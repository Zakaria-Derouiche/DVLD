using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicensesDataAccess;

namespace LicensesBusiness
{
    public class clsLicense
    {
        enum enMode { Add, Update};
        private enMode _Mode;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID{ get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int ApplicationTypeID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsLicense ()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            PaidFees = 0;
            Notes = string.Empty ;
            IsActive = false;
            ApplicationTypeID = -1;
            CreatedByUserID = -1;
            _Mode = enMode.Add;
        }
        public clsLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
            DateTime ExpirationDate, decimal PaidFees, string Notes, bool IsActive, int ApplicationTypeID, int CreatedByUserID)
        {
            this.LicenseID = -1;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.PaidFees = PaidFees;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.ApplicationTypeID = ApplicationTypeID;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Add;
        }
        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate,
            DateTime ExpirationDate, decimal PaidFees, string Notes, bool IsActive, int ApplicationTypeID, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.PaidFees = PaidFees;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.ApplicationTypeID = ApplicationTypeID;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Update;
        }
        public static bool IsLicenseExists(int ApplicationID)
        {
            return clsLicensesDataAccess.IsLicenseExists(ApplicationID);
        }
        public static clsLicense FindLicenseByLicenseID(int licenseID)
        {
            int appliactionID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            decimal paidFees = 0;
            string notes = string.Empty;
            bool isActive = false;
            byte applicationTypeID = 0;
            int createdByUserID = -1;
            return (clsLicensesDataAccess.GetLicenseInfo(licenseID, ref appliactionID, ref driverID, ref licenseClassID,
                ref issueDate, ref expirationDate, ref paidFees, ref notes, ref isActive,
                ref applicationTypeID, ref createdByUserID)) ? new clsLicense(licenseID, appliactionID, driverID, licenseClassID,
                issueDate, expirationDate, paidFees,  notes, isActive, applicationTypeID, createdByUserID) :
                null;
        }
        public static clsLicense FindLicenseByApplicationID(int ApplicationID)
        {
            int licenseID = -1;
            int appliactionID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            decimal paidFees = 0;
            string notes = string.Empty;
            bool isActive = false;
            byte applicationTypeID = 0;
            int createdByUserID = -1;
            if (clsLicensesDataAccess.GetLicenseInfo(ApplicationID, ref licenseID, ref appliactionID,
                ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref paidFees, ref notes,
                ref isActive, ref applicationTypeID, ref createdByUserID))
                return new clsLicense(licenseID, appliactionID, driverID, licenseClassID, issueDate, expirationDate, paidFees, notes,
                isActive, applicationTypeID, createdByUserID);
            else
                return null;
        }
        public bool Save()
        {
            bool IsSaved = false;
            int licenseID = -1;
            switch(_Mode)
            {
                case enMode.Add:
                    IsSaved = clsLicensesDataAccess.AddNewLicense(ref licenseID, ApplicationID, DriverID, LicenseClassID, IssueDate,
             ExpirationDate, PaidFees, Notes, IsActive, ApplicationTypeID, CreatedByUserID);
                    LicenseID = IsSaved ? licenseID : -1;
                    _Mode = IsSaved ? enMode.Update : enMode.Add;
                    break;
                case enMode.Update:
                    IsSaved = clsLicensesDataAccess.UpdateLicenceInfo(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate,
             ExpirationDate, PaidFees, Notes, IsActive, ApplicationTypeID, CreatedByUserID);
                    break;
            }
            return IsSaved;
        }
        public static DataTable GetPersonLicenses(int PersonID)
        {
            return clsLicensesDataAccess.GetPersonLicenses(PersonID);
        }
        public static int GetLicenseClassID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseClassID(LicenseID);
        }
        public static int GetLicenseApplicationID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseApplication(LicenseID);
        }
        public static bool ChangeLicenseStatus(int LicenseID, bool IsActive)
        {
            return clsLicensesDataAccess.ChangeLicenseStatus(LicenseID, IsActive);
        }
        public static bool IsActiveLicense(int LicenseID)
        {
            return clsLicensesDataAccess.IsActiveLicense(LicenseID);
        }
        public static bool IsRecreatedLicense(int LicenseID, int ApplicationTypeID)
        {
            return clsLicensesDataAccess.IsLicenseRecreated(LicenseID, ApplicationTypeID);
        }
       

    }
}
