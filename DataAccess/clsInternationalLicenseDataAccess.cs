using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;

namespace InternationalLicensesDataAccess
{
    public class clsInternationalLicenseDataAccess
    {
        public static DataTable GetPersonInternationalLicenses(int PersonID)
        {
            DataTable dtLicenses = new DataTable();
            
            dtLicenses.Columns.Add("InterNational.Lic.ID", typeof(int));
            dtLicenses.Columns.Add("App.ID", typeof(int));
            dtLicenses.Columns.Add("Driving Class", typeof(string));
            dtLicenses.Columns.Add("Issue Date", typeof(DateTime));
            dtLicenses.Columns.Add("IsActive", typeof(bool));
            string Query = @"SELECT InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, 
	                                LicenseClasses.ClassName, InternationalLicenses.IssueDate,InternationalLicenses.IsActive
                             FROM InternationalLicenses
							 INNER JOIN Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID
                             INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                             INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                             WHERE Drivers.PersonID = @PersonID";
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    int InternationalLicID = (int)Reader["InternationalLicenseID"];
                    int InternationalAppID = (int)Reader["ApplicationID"];
                    string DrivingClass = (string)Reader["ClassName"];
                    DateTime IssueDate = (DateTime)Reader["IssueDate"];
                    bool IsActive =(bool )Reader["IsActive"];
                    dtLicenses.Rows.Add(InternationalLicID, InternationalAppID, DrivingClass, IssueDate, IsActive);
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
            return dtLicenses;
        }
        public static bool AddInternationalLicense(ref int InternationalLicenseID, int ApplicationID, int DriverID,
            int LocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            bool IsSaved = true;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"INSERT INTO InternationalLicenses VALUES
                            (@ApplicationID, @DriverID, @LocalLicenseID, @IssueDate, @ExpirationDate, @IsActive,
                            @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out InternationalLicenseID))
                {
                    IsSaved =true;
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
            return IsSaved;
        }
        public static bool IsLicesneExists(int LocalLicenseID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT * FROM InternationalLicenses
                             WHERE IssuedUsingLocalLicenseID = @LocalLicenseID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                IsFound = Reader.HasRows;
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
        public static bool GetInternationalLicenseInfo(int LocalLicenseID, ref int internationalLicenseID, ref int applicationID,
            ref int driverID, ref  DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT * FROM InternationalLicenses
                             WHERE IssuedUsingLocalLicenseID = @LocalLicenseID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    internationalLicenseID = (int)Reader["InternationalLicenseID"];
                    applicationID = (int)Reader["ApplicationID"];
                    driverID = (int)Reader["DriverID"];
                    issueDate = (DateTime)Reader["IssueDate"];
                    expirationDate = (DateTime)Reader["ExpirationDate"];
                    isActive = (bool)Reader["IsActive"];
                    createdByUserID = (int)Reader["CreatedByUserID"];
                    IsFound = true;
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

        public static bool GetInternationalLicenseInfoByInternationalLicenseID(int internationalLicenseID, ref int applicationID,
            ref int localLicenseID,  ref int driverID, ref DateTime issueDate, ref DateTime expirationDate,
            ref bool isActive, ref int createdByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT * FROM InternationalLicenses
                             WHERE InternationalLicenseID = @internationalLicenseID";
            SqlCommand command = new SqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@internationalLicenseID", internationalLicenseID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    applicationID = (int)Reader["ApplicationID"];
                    driverID = (int)Reader["DriverID"];
                    issueDate = (DateTime)Reader["IssueDate"];
                    localLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    expirationDate = (DateTime)Reader["ExpirationDate"];
                    isActive = (bool)Reader["IsActive"];
                    createdByUserID = (int)Reader["CreatedByUserID"];
                    IsFound = true;
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

        public static DataTable GetInternationalLicenses()
        {
            DataTable dtLicenses = new DataTable();
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"SELECT 'InterNational.Lic.ID' = InternationalLicenseID,
                                    'App.ID' = ApplicationID,
                                    'Driver.ID' = DriverID,
                                    'Local.Lic.ID' = IssuedUsingLocalLicenseID,
	                                'Issue Date' = InternationalLicenses.IssueDate,
                                    'Expiration Date' = ExpirationDate,
	                                'Is Active' = InternationalLicenses.IsActive
                             FROM InternationalLicenses";
            SqlCommand command = new SqlCommand(Query, Connection);
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
            return dtLicenses;
        }
    }
}
