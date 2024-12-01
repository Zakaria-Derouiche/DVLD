using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
namespace DriversDataAccess
{
    public static class clsDriverDataAccess
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dtDrivers = new DataTable();
            dtDrivers.Columns.Add("Driver ID", typeof(int));
            dtDrivers.Columns.Add("Person ID", typeof(int));
            dtDrivers.Columns.Add("National No", typeof(string));
            dtDrivers.Columns.Add("Full Name", typeof(string));
            dtDrivers.Columns.Add("Creation Date", typeof(DateTime));
            dtDrivers.Columns.Add("Active Licenses", typeof(int));
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT A.DriverID, A.PersonID, A.NationalNo,
                             A.[Full Name],  A.CreatedDate, B.[Active Licenses] 
                            FROM (SELECT  Drivers.DriverID, People.PersonID,People.NationalNo,
	                                    'Full Name' = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
	                                     Drivers.CreatedDate
                                FROM Drivers
                                INNER JOIN People ON Drivers.PersonID = People.PersonID)A
                           JOIN (SELECT Licenses.DriverID,
                                       'Active Licenses' = COUNT(Licenses.LicenseID)
                                FROM Licenses GROUP BY Licenses.DriverID)B
                           ON A.[DriverID] = B.DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int DriverID = (int)Reader["DriverID"];
                    int PersonID = (int)Reader["PersonID"];
                    string NationalNumber = (string)Reader["NationalNo"];
                    string FullName = (string)Reader["Full Name"];
                    DateTime CreationDate = (DateTime)Reader["CreatedDate"];
                    int ActiveLicenses = (int)Reader["Active Licenses"];
                    dtDrivers.Rows.Add(DriverID, PersonID,  NationalNumber, FullName, CreationDate, ActiveLicenses);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dtDrivers;
        }
        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"INSERT INTO Drivers VALUES
                             (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result != null && int.TryParse(Result.ToString(), out int InsertedDriverID))
                {
                    DriverID = InsertedDriverID;
                }
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return DriverID;
        }
        public static bool IsDriverExists(int PersonID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT PersonID FROM Drivers WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = ((int)Reader["PersonID"] == PersonID);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }
        public static int GetDriverID(int PersonID)
        {
            int DriverID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    DriverID = (int)Reader["DriverID"];
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return DriverID;
        }  
    }
}
