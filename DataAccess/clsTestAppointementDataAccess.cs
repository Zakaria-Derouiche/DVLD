using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
namespace TestApointementsDataAccess
{
    public static class clsTestAppointementDataAccess
    {
        public static DataTable GetTestAppointments(int TestTypeID, int ApplicantPersonID, string ClassName)
        {
            DataTable dtTestAppointments = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT TestAppointmentID, AppointmentDate, TestAppointments.PaidFees ,
                             IsLocked FROM TestAppointments INNER JOIN LocalDrivingLicenseApplications 
                             ON TestAppointments.LocalDrivingLicenseApplicationID = 
                             LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                             INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID =
                             Applications.ApplicationID
                             INNER JOIN LicenseClasses on LocalDrivingLicenseApplications.LicenseClassID = 
                             LicenseClasses.LicenseClassID
                             WHERE TestAppointments.TestTypeID = @TestTypeID AND
                             Applications.ApplicantPersonID = @ApplicantPersonID AND
                             LicenseClasses.ClassName = @ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtTestAppointments.Load(reader);
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
            return dtTestAppointments;
        }
        public static bool AddNewTestAppointement(ref int InsertedAppointmentID,int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            bool IsAdded = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"INSERT INTO TestAppointments VALUES (
                             @TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, 
                             @IsLocked);
                             SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out InsertedAppointmentID))
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
                connection.Close();
            }
            return IsAdded;
        }
        public static bool UpdateTestAppintementInfo(int TestAppointmentID, DateTime AppointmentDate)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE TestAppointments 
                            SET AppointmentDate = @AppointmentDate
                            WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                IsUpdated = (RowsAffected > 0);
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }
        public static bool GetTestAppointment(int AppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
            ref DateTime AppointementDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @AppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointementDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];
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
                connection.Close();
            }
            return IsFound;
        }
        public static bool IsTestAppointmentsPassed(int TestAppointmentID)
        {
            bool IsPassed = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Tests.TestResult FROM Tests 
                             WHERE Tests.TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsPassed = ((bool)Reader["TestResult"]);
                }
                Reader.Close ();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsPassed;
        }
        public static bool IsAppointmentExists(int TestAppointmentID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT TestAppointmentID FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointemetID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = (int)Reader["TestAppointmentID"] == TestAppointmentID;
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
        public static  bool LockTestAppointment(int TestAppointmentID)
        {
            bool IsLocked = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE TestAppointments 
                            SET IsLocked = 1
                            WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                IsLocked = (RowsAffected > 0);
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsLocked;
        }
        public static bool IsExistsOrPassedTestAppointment(int LocalApplicationID, int TestTypeID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM TestAppointments 
                            INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalApplicationID 
                            AND TestAppointments.TestTypeID = @TestTypeID AND 
                            (TestAppointments.IsLocked = 0 OR Tests.TestResult = 1);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                IsFound = Reader.HasRows;
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
