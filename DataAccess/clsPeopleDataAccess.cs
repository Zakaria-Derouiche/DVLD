using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseSetting;
using System.Net;

namespace PeopleDataAccess
{
    public static class clsPeopleDataAccess
    {
        public static bool GetPersonInfoByID(int ID, ref string NationalNumber, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address,
        ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    NationalNumber = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool GetPersonInfoByNationalNumber(ref int ID, string NationalNumber, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address,
            ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int) reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = (reader["ImagePath"] != DBNull.Value)? ImagePath = (string)reader["ImagePath"]: string.Empty;
                    isFound = true;
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

        public static int AddNewPerson(string NationalNumber, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                                                Address, Phone, Email,  NationalityCountryID,ImagePath)
                          VALUES (@NationalNumber, @FirstName,@SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender,
                                                @Address, @Phone, @Email,  @NationalityCountryID, @ImagePath);
                          SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception Ex)
            {
                clsSettingAccess.AddEventLog(Ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
        public static bool UpdatePerson(int PersonID, string NationalNumber, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address,
            string Phone, string Email, int NationalCountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);

            string query = @"Update  People  
                         set NationalNo = @NationalNumber,
                             FirstName = @FirstName,
                             SecondName = @SecondName,
                             ThirdName = @ThirdName,
                             LastName = @LastName, 
                             DateOfBirth = @DateOfBirth,
                             Gendor = @Gender,
                             Address = @Address,
                             Phone = @Phone, 
                             Email = @Email,
                             NationalityCountryID = @NationalCountryID,
                             ImagePath =@ImagePath
                             where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsSettingAccess.AddEventLog(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetPeople()
        {
            DataTable People = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT People.personID, People.NationalNo, People.FirstName, People.SecondName,
                          People.ThirdName, People.LastName,
                          Gender = CASE WHEN People.Gendor = 0 THEN 'Male' WHEN People.Gendor = 1 THEN 'Female' end,
                          People.DateOfBirth, People.Phone, People.Email, Nationality =  Countries.CountryName FROM People
                          inner join Countries 
                          on People.NationalityCountryID = Countries.CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    People.Load(reader);
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
            return People;
        }
        public static bool DeletePerson(int PersonID, ref string ErrorMessage)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"Delete People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);

        }
        public static bool IsPersonExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
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
        public static bool IsPersonExist(string NationalNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNumber";

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
        public static string GetPersonCountry(int PersonID)
        {
            string PersonCountryName = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT CountryName FROM Countries WHERE CountryID =
                          (Select NationalityCountryID From People Where PersonID =  @PersonID)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonCountryName = (string)reader["CountryName"];
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
            return PersonCountryName;
        }
        public static int GetPersonID(string NationalNumber)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT PersonID From People Where NationalNo =  @NationalNumber;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
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
            return PersonID;
        }
        public static bool GetPersonInfoByDriverID(int DriverID, ref int ID, ref string NationalNumber, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address,
        ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT People.* From People
                             INNER JOIN Drivers ON People.PersonID = Drivers.PersonID
                             WHERE Drivers.DriverID = @DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["PersonID"];
                    NationalNumber = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageError = ex.ToString();
                clsSettingAccess.AddEventLog(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static string GetPersonNationalNumber(int DriverID)
        {
            string PersonNationalNo = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT People.NationalNo From People
                             INNER JOIN Drivers ON People.PersonID = Drivers.PersonID
                             WHERE Drivers.DriverID =  @DriverID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonNationalNo = (string)reader["NationalNo"];
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
            return PersonNationalNo;
        }
        public static int GetPersonID(int DriverID)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT People.PersonID From People
                             INNER JOIN Drivers ON People.PersonID = Drivers.PersonID
                             WHERE Drivers.DriverID =  @DriverID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
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
            return PersonID;
        }
        public static string GetPersonNationalNumberByAppID(int ApplicationID)
        {
            string NationalNumber = string.Empty;
            SqlConnection connection = new SqlConnection(clsSettingAccess.ConnectionString);
            string query = @"SELECT People.NationalNo From People
                             INNER JOIN Applications ON People.PersonID = Applications.ApplicantPersonID
                             WHERE  Applications.ApplicationID =  @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NationalNumber = (string)reader["NationalNo"];
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
            return NationalNumber;
        }
    }
}
