using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationDataAccess
{
    public static class clsApplicationDataAccess
    {
        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate,int ApplicationTypeID,
            decimal PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"INSERT INTO Applications(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                             LastStatusDate, PaidFees, CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate,
                             @ApplicationTypeID, 1,@ApplicationDate, @PaidFees, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int InsertedApplicationID))
                {
                    ApplicationID = InsertedApplicationID;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static bool UpdateApplication(int ApplicationID,  int ApplicationTypeID, int ApplicationStatus,
            DateTime LastStatusDate, decimal PaidFees)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE Applications
                             SET ApplicationTypeID = @ApplicationTypeID,
                                 LastStatusDate = @LastStatusDate,
                                 ApplicationStatus = @ApplicationStatus,
                                 PaidFees = @PaidFees
                                 WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                IsSaved = RowsAffected > 0;
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsSaved;
        }
        public static bool IsPersonHasNewApplication(int PersonID, int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"Select Applications.ApplicantPersonID FROM Applications INNER JOIN  LocalDrivingLicenseApplications ON
                            Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                            WHERE Applications.ApplicantPersonID = @PersonID AND Applications.ApplicationStatus != 2 and 
                            LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = (int)reader["ApplicantPersonID"] == PersonID;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool IsPersonHasCanceledApplication(int PersonID, int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"Select Applications.ApplicantPersonID FROM Applications INNER JOIN  LocalDrivingLicenseApplications ON
                            Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                            WHERE Applications.ApplicantPersonID = @PersonID AND Applications.ApplicationStatus = 2 and 
                            LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = (int)reader["ApplicantPersonID"] == PersonID;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool IsPersonHasCompletedApplication(int PersonID, int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT LicenseClass From Licenses
                             INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                             WHERE Drivers.PersonID = @PersonID AND Licenses.LicenseID = @LicenseClassID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = (int)Reader["LicenseClass"] == LicenseClassID;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"DELETE FROM  Applications WHERE 
                             ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsDeleted = (RowsAffected > 0);
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsDeleted;
        }
        public static bool CancelApplication(int ApplicationID)
        {
            bool IsCanceled = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"UPDATE Applications 
                             SET ApplicationStatus = 2
                             WHERE ApplicationID = @ApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsCanceled = (RowsAffected > 0);
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return IsCanceled;
        }
        public static bool GetApplicationInfo(int ApplicationID, ref int ApplicantPersonID, ref string ApplicantFullName,
            ref DateTime ApplicationDate, ref string ApplicationTypeTitle, ref int ApplicationTypeID,  ref string ApplicationStatus, 
            ref decimal ApplicationFees,  ref DateTime LastStatusDate,  ref string CreatedByUserUserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Applications.ApplicationID, Applications.ApplicantPersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' +People.ThirdName + ' ' + People.LastName,
	                        ApplicationDate,
	                        ApplicationTypes.ApplicationTypeTitle,
                            Applications.ApplicationTypeID,
	                        Status = Case  when Applications.ApplicationStatus = 1 then 'New'
                                           when Applications.ApplicationStatus = 2 then 'Canceled'
                                           when Applications.ApplicationStatus = 3 then 'Completed'
                                           else 'Unknown'
                                      end,
	                        LastStatusDate,
		                    Users.UserName,
                            ApplicationTypes.ApplicationFees
		                    FROM Applications INNER JOIN People on Applications.ApplicantPersonID = People.PersonID
		                    INNER JOIN ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
		                    INNER JOIN Users on Applications.CreatedByUserID = Users.UserID
                            WHERE ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicantPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicantFullName = (string)Reader["FullName"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
                    ApplicationStatus = (string)Reader["Status"];
                    ApplicationFees = (decimal)Reader["ApplicationFees"];
                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    CreatedByUserUserName = (string)Reader["UserName"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool GetApplicationTypeID(int ApplicationID, ref int ApplicationTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Applications.ApplicationTypeID,
		                    FROM Applications 
                            WHERE ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
    }
}
