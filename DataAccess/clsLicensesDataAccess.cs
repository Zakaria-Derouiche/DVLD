using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace LicensesDataAccess
{
    public static class clsLicensesDataAccess
    {
        public static bool IsLicenseExists(int ApplicationID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT Found = 1 FROM Licenses WHERE ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
               SqlDataReader reader = Command.ExecuteReader();
               IsFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally{
                Connection.Close();
            }
            return IsFound;
        }
        public static bool AddNewLicense(ref int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, 
            DateTime ExpirationDate, decimal PaidFees,  string Notes, bool IsActive, int ApplicationTypeID, int CreatedByUserID)
        {
            bool IsAdded = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"INSERT INTO Licenses VALUES (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate,
                            @Notes, @PaidFees, @IsActive, @ApplicationTypeID, @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            if(Notes == string.Empty)
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out LicenseID))
                {
                    IsAdded = true;
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
            return IsAdded;
        } 
      
        public static DataTable GetPersonLicenses(int PersonID)
        {
            DataTable dtLicenses = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT 'Lic.ID' = Licenses.LicenseID,
                                    'App.ID' = Licenses.ApplicationID, 
	                                'Driving Class' = LicenseClasses.ClassName,
	                                'Issue Date' = Licenses.IssueDate,
	                                'Is Active' = Licenses.IsActive
                             FROM Licenses
                             INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                             INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                             WHERE Drivers.PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                dtLicenses.Load(Reader);
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
            return  dtLicenses;
        }
        public static bool GetLicenseInfo(int LicenseID, ref int applicationID, ref int driverID, ref int licenseClassID,
            ref DateTime issueDate,  ref DateTime expirationDate, ref decimal paidFees, ref string Notes, ref bool isActive,
            ref byte applicationTypeID, ref int createdByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT *
                            FROM Licenses
                            WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    licenseClassID = (int)reader["LicenseClass"];
                    driverID = (int)reader["DriverID"];
                    applicationID = (int)reader["ApplicationID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    applicationTypeID = (byte)reader["IssueReason"];
                    Notes = (reader["Notes"] == System.DBNull.Value) ? "No Notes" : (string)reader["Notes"];
                    isActive = (bool)reader["IsActive"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    IsFound = true;
                }
                reader.Close();
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
        public static bool GetLicenseInfo(int ApplicationID, ref int licenseID, ref int applicationID, 
            ref int driverID, ref int licenseClassID,  ref DateTime issueDate, ref DateTime expirationDate, ref decimal paidFees, 
            ref string Notes, ref bool isActive, ref byte applicationTypeID, ref int createdByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT  * FROM Licenses WHERE ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    licenseID = (int)reader["LicenseID"];
                    licenseClassID = (int)reader["LicenseClass"];
                    driverID = (int)reader["DriverID"];
                    applicationID = (int)reader["ApplicationID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    applicationTypeID = (byte)reader["IssueReason"];
                    Notes = (reader["Notes"] == System.DBNull.Value) ? "No Notes" : (string)reader["Notes"];
                    isActive = (bool)reader["IsActive"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    IsFound = true;
                }
                reader.Close();
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
        public static bool UpdateLicenceInfo(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
            DateTime ExpirationDate, decimal PaidFees, string Notes, bool IsActive, int ApplicationTypeID, int CreatedByUserID)
        {
            bool IsChanged = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"Update Licenses
                             SET ApplicationID = @ApplicationID,  DriverID = @DriverID, LicenseClass = @LicenseClassID,
                             IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Notes = @Notes, PaidFees = @PaidFees,
                             IsActive = @IsActive,  IssueReason = @ApplicationTypeID,CreatedByUserID =  @CreatedByUserID
                             WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            if (Notes == string.Empty)
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsChanged = RowsAffected > 0;
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsChanged;
        }
        public static int GetLicenseClassID(int  LicenseID)
        {
            int LicenseClassID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT LicenseClass FROM Licenses 
                             WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                object ob = Command.ExecuteScalar();
                if (ob != null && int.TryParse(ob.ToString(), out int licenseClassID))
                    LicenseClassID = licenseClassID;

            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return LicenseClassID;
        }
        public static int GetLicenseApplication(int LicenseID)
        {
            int ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT ApplicationID FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                object ob = Command.ExecuteScalar();
                if (ob != null && int.TryParse(ob.ToString(), out int AppID))
                    ApplicationID = AppID;
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return ApplicationID;
        }
        public static bool ChangeLicenseStatus(int LicenseID, bool IsActive)
        {
            bool IsSaved = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"Update Licenses SET  IsActive = @isActive WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            if(IsActive)
                Command.Parameters.AddWithValue("@isActive", "1");
            else
                Command.Parameters.AddWithValue("@isActive", "0");
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsSaved = RowsAffected > 0;
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsSaved;
        }
        public static bool IsActiveLicense(int LicenseID)
        {
            bool IsActive = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT IsActive FROM Licenses  WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read()) 
                    IsActive = (bool)Reader["IsActive"];
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
            return IsActive;
        }
        public static bool IsLicenseRecreated(int DriverID, int IssueReason)
        {
            bool IsRenewed = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT * FROM Licenses  WHERE DriverID = @DriverID AND IssueReason = @IssueReason";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                    IsRenewed = (bool)Reader["IsActive"];
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
            return IsRenewed;
        }
       
    }
}
