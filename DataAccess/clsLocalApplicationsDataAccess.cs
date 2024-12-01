using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace ApplicationsTypes
{
    public static class clsLocalApplicationsDataAccess
    {
        public static DataTable GetAllLocalApplications()
        {
            DataTable dtLocalApplications = new DataTable();
            dtLocalApplications.Columns.Add("L.B.L.AppID", typeof(int));
            dtLocalApplications.Columns.Add("Driving Class", typeof(string));
            dtLocalApplications.Columns.Add("National No", typeof(string));
            dtLocalApplications.Columns.Add("Full Name", typeof(string));
            dtLocalApplications.Columns.Add("Application Date", typeof(DateTime));
            dtLocalApplications.Columns.Add("Passed Tests", typeof(int));
            dtLocalApplications.Columns.Add("Status", typeof(string));
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"Select  A.LocalDrivingLicenseApplicationID, A.ClassName, A.NationalNo, A.FullName, A.ApplicationDate,
                                    B.PassedTests, A.Status
	                         From (SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                                           LicenseClasses.ClassName, People.NationalNo,
	                                       FullName = People.FirstName + ' ' + People.SecondName+ ' ' + People.ThirdName + ' ' + People.LastName,
	                                       Applications.ApplicationDate,
	                                       Status = Case Applications.ApplicationStatus
	                                                   when 1 then 'New'
				                                       when 2 then 'Canceled'
				                                       when 3 then 'Completed'
				                                    end
                                    From LocalDrivingLicenseApplications
                                    INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                                    INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                                    INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID)A
                             FULL JOIN (SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
                                                     PassedTests = count(TestAppointments.LocalDrivingLicenseApplicationID) 
                                          FROM LocalDrivingLicenseApplications 
								          FULL OUTER JOIN TestAppointments ON
								          LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =
                                          TestAppointments.LocalDrivingLicenseApplicationID
                                          FULL OUTER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
								          WHERE Tests.TestResult = 1
					                      GROUP BY LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID)B
                              ON A.LocalDrivingLicenseApplicationID = B.LocalDrivingLicenseApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    string ClassName = (string)reader["ClassName"];
                    string NationalNo = (string)reader["NationalNo"];
                    string FullName = (string)reader["FullName"];
                    DateTime ApplicationDate = (DateTime)reader["ApplicationDate"];
                    int PassedTests = 0;
                    if (reader["PassedTests"] == System.DBNull.Value)
                        PassedTests = 0;
                    else
                        PassedTests = (int)reader["PassedTests"];
                    string Status = (string)reader["Status"];
                    dtLocalApplications.Rows.Add(LocalDrivingLicenseApplicationID, ClassName, NationalNo, FullName,
                        ApplicationDate, PassedTests, Status );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message); ;
            }
            finally
            {
                connection.Close();
            }
            return dtLocalApplications;
        }
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications(ApplicationID, LicenseClassID)
                             Values (@ApplicationID, @LicenseClassID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int InsertedLocalDLApp))
                {
                    LocalDrivingLicenseApplicationID = InsertedLocalDLApp;
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
            return LocalDrivingLicenseApplicationID;
        }
        public static bool IsLocalApplicationsHasLicense(int LocalDrivingLicenseID )
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT M = 1 FROM Applications INNER JOIN LocalDrivingLicenseApplications
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             INNER JOIN Licenses on Applications.ApplicationID = Licenses.ApplicationID 
                             WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    isFound = true;
                }
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
        public static int GetApplicationIDByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"DELETE FROM  LocalDrivingLicenseApplications WHERE 
                             LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
        public static int GetLocalApplicationID(int ApplicationID)
        {
            int LocalApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            String Query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                             FROM LocalDrivingLicenseApplications 
                             WHERE LocalDrivingLicenseApplications.ApplicationID = @ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                object ob = Command.ExecuteScalar();
                if (ob != null && int.TryParse(ob.ToString(), out int AppID))
                    LocalApplicationID = AppID;

            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return LocalApplicationID;
        }
        
       
    }
}
