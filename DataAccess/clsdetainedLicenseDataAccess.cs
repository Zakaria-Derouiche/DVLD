using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
namespace DetainedLicensesDataAccess
{
    public class clsdetainedLicenseDataAccess
    {
        public static DataTable GetAllDetainedLicenses()
        { 
            DataTable dtDetainedLicenses = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT 'Detain ID' = DetainedLicenses.DetainID, 'License ID' = DetainedLicenses.LicenseID,
	                                'Detain Date' = DetainedLicenses.DetainDate, 'Is Released' = DetainedLicenses.IsReleased,
                                    'Fine Fess' = DetainedLicenses.FineFees, 'Release Date' = DetainedLicenses.ReleaseDate,
                                    'National Number' = People.NationalNo,  'Full Name' = People.FirstName + ' ' + People.SecondName
                                    + ' ' + People.ThirdName + ' ' + People.LastName, 'Release App.ID' = DetainedLicenses.ReleaseApplicationID
                             From DetainedLicenses 
                             INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID
                             INNER JOIN Drivers On Licenses.DriverID = Drivers.DriverID
                             INNER JOIN People On Drivers.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                dtDetainedLicenses.Load(Reader);
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtDetainedLicenses;
        }
        public static bool IsDetainedLicesne(int LicenseID)
        {
            bool IsDetained = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                IsDetained = Reader.HasRows;
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
            return IsDetained;
        }
        public static bool AddDetainLicense(ref int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"INSERT INTO DetainedLicenses 
                             VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0, null, null, null);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if(Result != null && int.TryParse(Result.ToString(), out DetainID))
                    IsSaved = true;
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


        public static bool UpdateDetainedLicesne(int DetainID, DateTime ReleaseDate, int ReleasedByUserID,
            int ReleaseApplicationID)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE DetainedLicenses SET IsReleased = 1, ReleaseDate = @ReleaseDate, 
                             ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                IsSaved = (RowsAffected > 0);
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

        public static bool FindDetainLicenseInfo(int LicenseID, ref int DetainID , ref DateTime DetainDate, ref decimal FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, 
            ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];
                    ReleaseDate = Reader["ReleaseDate"] != System.DBNull.Value ? (DateTime)Reader["ReleaseDate"] : DateTime.MaxValue;
                    ReleasedByUserID = Reader["ReleasedByUserID"] != System.DBNull.Value ? (int)Reader["ReleasedByUserID"] : -1;
                    ReleaseApplicationID = Reader["ReleaseApplicationID"] != System.DBNull.Value ? (int)Reader["ReleaseApplicationID"] : -1;
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
