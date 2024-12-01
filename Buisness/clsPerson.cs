using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using PeopleDataAccess;
namespace PeopleBusiness
{
    public class clsPerson
    {
        enum enMode { Add, Update };
        enMode _Mode;
        public int ID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public clsPerson()
        {
            ID = -1;
            NationalNumber = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = new DateTime();
            Gender = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = 0;
            ImagePath = "";
            _Mode = enMode.Add;
        }
        private clsPerson(int iD, string nationalNumber, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email,
            int nationalityCountryID, string imagePath)
        {
            this.ID = iD;
            this.NationalNumber = nationalNumber;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            _Mode = enMode.Update;
        }
        public static DataTable GetPeople()
        {
            return clsPeopleDataAccess.GetPeople();
            
        }
        public static clsPerson FindPersonByID(int ID)
        {
            string NationalNumber = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (clsPeopleDataAccess.GetPersonInfoByID(ID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID,
                ref ImagePath))
            {
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson FindPersonByNationalNumber(string NationalNumber)
        {
            int ID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (clsPeopleDataAccess.GetPersonInfoByNationalNumber(ref ID, NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID,
                ref ImagePath))
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public bool Save()
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    this.ID = clsPeopleDataAccess.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName,
                           this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                           this.NationalityCountryID, this.ImagePath);
                    this._Mode = enMode.Update;
                    IsSaved = (this.ID != -1);
                    break;
                case enMode.Update:
                    IsSaved = clsPeopleDataAccess.UpdatePerson(this.ID, this.NationalNumber, this.FirstName, this.SecondName,
                                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone,
                                this.Email, this.NationalityCountryID, this.ImagePath);
                    break;
            }
            return IsSaved;
        }
        
        public static bool IsPersonExists(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExist(PersonID);
        }
        public static bool IsPersonExists(string NationalNumber)
        {
            return clsPeopleDataAccess.IsPersonExist(NationalNumber);
        }
        public string CountryName()
        {
            return clsPeopleDataAccess.GetPersonCountry(this.ID);
        }
        public static bool DeletePerson(int PersonID, ref string ErrorMessage)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID, ref ErrorMessage);
        }
        public static int GetPersonID(string nationalNumber)
        {
            return clsPeopleDataAccess.GetPersonID(nationalNumber);
        }
        public static clsPerson FindPersonByDriverID(int DriverID)
        {
            int ID = -1;
            string NationalNumber = string.Empty;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gender = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePath = "";
            if (clsPeopleDataAccess.GetPersonInfoByDriverID(DriverID, ref ID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID,
                ref ImagePath))
            {
                return new clsPerson(ID, NationalNumber, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static string GetPersonNationalNumber(int DriverID)
        {
            return clsPeopleDataAccess.GetPersonNationalNumber(DriverID);
        }

        public static int GetPersonID(int DriverID)
        {
            return clsPeopleDataAccess.GetPersonID(DriverID);
        }
        public static string GetPersonNationalNumberByAppID(int ApplicationID)
        {
            return clsPeopleDataAccess.GetPersonNationalNumberByAppID(ApplicationID);
        }
    }
}
