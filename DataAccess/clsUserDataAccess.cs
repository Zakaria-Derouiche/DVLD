using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using Microsoft.SqlServer.Server;

namespace UserDataAccess
{
    public class clsUserDataAccess
    {
        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    isFound = false;
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
        public static bool GetUserInfoByUserName(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    isFound = false;
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

        public static bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    isFound = false;
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
        public static bool IsUserExists(string NationalNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Found = 1 FROM Users  INNER JOIN People ON Users.PersonID = People.PersonID
                            WHERE NationalNo = @NationalNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
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
        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {

            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)
                             VALUES (@PersonID, @UserName, @Password, @IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            if (IsActive)
                command.Parameters.AddWithValue("@IsActive", 1);
            else
                command.Parameters.AddWithValue("@IsActive", 0);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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
            return UserID;
        }
        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"UPDATE  Users 
                            SET UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                             WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            if (IsActive)
                command.Parameters.AddWithValue("@IsActive", 1);
            else
                command.Parameters.AddWithValue("@IsActive", 0);
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
        public static DataTable GetUsers()
        {
            DataTable Users = new DataTable();
            Users.Columns.Add("User ID", typeof(int));
            Users.Columns.Add("Person ID", typeof(int));
            Users.Columns.Add("Full Name", typeof(string));
            Users.Columns.Add("User Name", typeof(string));
            Users.Columns.Add("Is Active", typeof(bool));
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Users.UserID, Users.PersonID, 
                            'Full Name' = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName,
                            Users.UserName, Users.IsActive
                            FROM Users INNER JOIN People ON Users.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int UserID = (int)reader["UserID"];
                    int PersonID = (int)reader["PersonID"];
                    string FullName = (string)reader["Full Name"];
                    string UserName = (string)reader["UserName"];
                    bool IsActive = (bool)reader["IsActive"];
                    Users.Rows.Add(UserID, PersonID, FullName, UserName, IsActive);
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
            return Users;
        }
        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"DELETE Users
                                WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
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
        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM Users WHERE UserName COLLATE Latin1_General_CS_AS = 
                             @UserName COLLATE Latin1_General_CS_AS";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
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
        public static bool IsUserExistsByPersonID(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
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
        public static string GetUserPassword(string UserName)
        {
            string Password = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT Password FROM Users WHERE UserName COLLATE Latin1_General_CS_AS = 
                             @UserName COLLATE Latin1_General_CS_AS";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    Password = (string)reader["Password"];
                reader.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return Password;
        }
        public static string GetUserName(int UserID)
        {
            string UserName = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT UserName FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    UserName = (string)reader["UserName"];
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
            return UserName;
        }

    }
}
