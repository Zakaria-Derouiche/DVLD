using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
namespace ApplicationsTypeDataAccess
{
    public static class clsApplicationTypeDataAccess
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable ApplicationTypes = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM ApplicationTypes";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ApplicationTypes.Load(reader);
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
            return ApplicationTypes;
        }
        
        public static bool GetApplicationTypeInfo(int ApplicationTypeID, ref string ApplicationTypeTitle, 
            ref decimal ApplicationTypeFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM ApplicationTypes WHERE APPlicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
                    ApplicationTypeFees = (decimal)Reader["ApplicationFees"];
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
        public static bool UpdateApllicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE  ApplicationTypes
                            SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                ApplicationFees = @ApplicationTypeFees
                            WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("ApplicationTypeFees", ApplicationTypeFees);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static bool GetApplicationTypeFees(int ApplicationTypeID, ref decimal ApplicationTypeFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeFees = (decimal)Reader["ApplicationFees"];
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
        public static bool GetApplicationTypeTitle(int ApplicationTypeID, ref string ApplicationTypeTitle)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE APPlicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
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
