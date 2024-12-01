using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using Microsoft.SqlServer.Server;

namespace CountriesDataAccess
{
    public class clsCountriesAccess
    {
        public static string[] GetAllCountries()
        {
            string[] Countries = new string[178];
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT CountryID, CountryName FROM Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string CountryName;
                int Index;
                while (reader.Read())

                {
                    CountryName = (string)reader["CountryName"];
                    Index = (int)reader["CountryID"];
                    Countries[Index - 1] = CountryName;
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
            return Countries;
        }
        public static string GetCountryDialingCode(string CountryName)
        {
            string DialingCode = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT Code FROM Countries WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DialingCode = (string)reader["Code"];
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
            return DialingCode;
        }
    }
}
