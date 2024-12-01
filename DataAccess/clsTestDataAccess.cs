using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using Microsoft.SqlServer.Server;

namespace TestsDataAccess
{
    public static  class clsTestDataAccess
    {
        public static bool AddNewTest(ref int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            bool IsInserted = false;
            SqlConnection Connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string Query = @"INSERT INTO Tests 
                             Values (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            if(Notes == string.Empty)
                Command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out TestID))
                {
                    IsInserted = (TestID != -1);
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
            return IsInserted;
        }
    }
}
