using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataAccess;
using PeopleBusiness;

namespace UserBusiness
{
    public class clsUser
    {
        enum enMode { Add, Update };
        enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsPerson Person = new clsPerson();
        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            _Mode = enMode.Add;
            this.Person = new clsPerson();
        }
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this._Mode = enMode.Update;
            this.Person = clsPerson.FindPersonByID(PersonID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetUsers();
        }
        public static bool IsUserExistsByUserID(int userID)
        {
            return clsUserDataAccess.IsUserExist(userID);
        }
        public static bool IsUserExistsByPersonID(int PersonID)
        {
            return  clsUserDataAccess.IsUserExistsByPersonID(PersonID);
        }
        public static bool IsUserExistsByUserName(string UserName, ref string ErrorMessage)
        {
            bool IsExists = clsUserDataAccess.IsUserExist(UserName);
            ErrorMessage = IsExists ? string.Empty : "User Name Not Valid";
            return IsExists;
        }
        public static bool CheckUserPassword(string UserName, string Password, ref string ErrorMessage)
        {
            string UserPassword = clsUserDataAccess.GetUserPassword(UserName);
            bool IsRightPassword = (UserPassword != string.Empty && UserPassword == Password);
            ErrorMessage = IsRightPassword ? string.Empty : "Wrong Password";
            return IsRightPassword;
        }
        public static bool IsUserExists(string NationalNumber)
        {
            return clsUserDataAccess.IsUserExists(NationalNumber);
        }
        public static clsUser FindUserById(int UserID)
        {
            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            if (clsUserDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUser FindUserByUserName(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;
            if (clsUserDataAccess.GetUserInfoByUserName(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUser FindUserByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;
            bool IsActive = false;
            if (clsUserDataAccess.GetUserInfoByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
                    IsSaved = (this.UserID != -1);
                    _Mode = enMode.Update;
                    break;
                case enMode.Update:
                    IsSaved = clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
                    break;
            }
            return IsSaved;
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }
        public static bool IsUserActive(int UserID)
        {
            clsUser User = clsUser.FindUserById(UserID);
            return (User != null && User.IsActive) ? true : false;
        }
        public static bool IsUserActive(string UserName, ref string ErrorMessage)
        {
            clsUser User = clsUser.FindUserByUserName(UserName);
            bool IsActive = (User != null && User.IsActive);
            ErrorMessage = IsActive ? string.Empty : "User Is Not Active";
            return IsActive;
        }
        public static string GetUserName(int UserID)
        {
            return clsUserDataAccess.GetUserName(UserID);
        }

    }
}
