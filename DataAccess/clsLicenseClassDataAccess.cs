using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;

namespace LicenseClassesDataAccess
{
    public static class clsLicenseClassDataAccess
    {
        public static string[] GetAllLicenseClassesNames()
        {
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = "SELECT ClassName FROM LicenseClasses";
            SqlCommand Command = new SqlCommand(Query, Connection);
            string[] ClassesNames = new string[7];
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                byte i = 0;
                while (Reader.Read())
                {
                    ClassesNames[i] = (string)Reader["ClassName"];
                    i++;
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
            return ClassesNames;
        }
       
        
        public static bool GetLicenseInfo(string LicenseClassName, ref int LicenseClassID, ref string ClassDecription, 
            ref decimal LicenseClassFees, ref byte MinimumAllowedAge, ref byte DefaultValidityLength)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = "SELECT * FROM LicenseClasses WHERE ClassName = @LicenseClassName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassName", LicenseClassName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    LicenseClassID = (int)Reader["LicenseClassID"];
                    ClassDecription = (string)Reader["ClassDescription"];
                    MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
                    LicenseClassFees = (decimal)Reader["ClassFees"];
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
        public static bool GetLicenseValidityLength(int LicenseClassID, ref byte DefaultValidityLength)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = "SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
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
        public static bool GetLicenseName(int LicenseClassID, ref string ClassName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    ClassName = (string)Reader["ClassName"];
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
        public static decimal GetLicenseClassFees(int LicenseClassID)
        {
            decimal Fees = 0;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Fees = (decimal)Reader["ClassFees"];
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
            return Fees;
        }
    }
}
