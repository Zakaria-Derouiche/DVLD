using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDataAccess;
namespace ApplicationsBusiness
{
    public class clsApplication
    {
        enum enMode { Add, Edit};
        enMode _Mode;
        public int ApplicationID {  get; set; }
        public string ApplicantFullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal ApplicationFees {  get; set; }
        public decimal PaidFees {  get; set; }
        public string CreatedByUserUserName { get; set; }
        public string AppliactionStatus { get; set; }
        public int ApplicationTypeID {  get; set; }
        public int ApplicantPersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0;
            LastStatusDate = DateTime.Now;
            ApplicationFees = 0;
            CreatedByUserID = -1;
            _Mode = enMode.Add;
        }

        public clsApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, DateTime LastStatusDate,
            decimal PaidFees, int CreatedUserID)
        {
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedUserID;
        }
        private clsApplication(int ApplicationID, int ApplicantPersonID, string ApplicantFullName, DateTime ApplicationDate,
            int ApplicationTypeID, string ApplicationTypeTitle,
            string ApplicationStatus, DateTime LastStatusDate, decimal ApplicationFees, string CreatedByUserUserName )
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicantFullName = ApplicantFullName;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.AppliactionStatus = ApplicationStatus;
            this.LastStatusDate= LastStatusDate;
            this.ApplicationFees = ApplicationFees;
            this.CreatedByUserUserName = CreatedByUserUserName;
            this.ApplicationTypeID= ApplicationTypeID;
            _Mode = enMode.Edit;
        }
        public static clsApplication FindApplication(int ApplicationID)
        {
            int ApplicantPerID = -1;
            string ApplicantFullName = string.Empty;
            DateTime AppDate = DateTime.Now;
            string AppTypeTitle = string.Empty;
            string AppStatus = string.Empty;
            int ApplicationTypeID = 0;
            decimal AppFees = 0;
            DateTime LDStatus = DateTime.Now;
            string CreatedByUserName = string.Empty;
            bool IsFound = clsApplicationDataAccess.GetApplicationInfo(ApplicationID, ref ApplicantPerID, ref ApplicantFullName, 
                ref AppDate, ref AppTypeTitle, ref ApplicationTypeID, ref AppStatus, ref AppFees, ref LDStatus, ref CreatedByUserName);
            if (IsFound)
                return new clsApplication(ApplicationID, ApplicantPerID, ApplicantFullName, AppDate, ApplicationTypeID,
                     AppTypeTitle, AppStatus, LDStatus, AppFees, CreatedByUserName);
            else
                return null;
        }
        public bool Save()
        {
            bool IsSaved = false;
            switch(_Mode)
            {
                case enMode.Add:
                    ApplicationID = clsApplicationDataAccess.AddNewApplication(ApplicantPersonID, ApplicationDate,
                        ApplicationTypeID, PaidFees, CreatedByUserID);
                    IsSaved = (ApplicationID != -1);
                    _Mode = (IsSaved)? enMode.Edit : enMode.Add; 
                    break;
                case enMode.Edit:
                    IsSaved = clsApplicationDataAccess.UpdateApplication(ApplicationID, ApplicationTypeID, _GetApplicationStatus(),
                        LastStatusDate, PaidFees);
                    break;
            }
            return IsSaved ;
        }
        public static bool IsPersonHasNewApplication(int PersonID, int LicenseClassID)
        {
            return clsApplicationDataAccess.IsPersonHasNewApplication (PersonID, LicenseClassID);
        }
        public static bool IsPersonHasCanceledApplication(int PersonID, int LicenseClassID)
        {
            return clsApplicationDataAccess.IsPersonHasCanceledApplication (PersonID, LicenseClassID);
        }
        public static bool IsPersonHasCompletedApplication(int PersonID, int LicenseClassID)
        {
            return clsApplicationDataAccess.IsPersonHasCompletedApplication (PersonID, LicenseClassID);
        }
        public static bool CancelApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.CancelApplication(ApplicationID);
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplication(ApplicationID);
        }
        private int _GetApplicationStatus()
        {
            return (AppliactionStatus == "New") ? 1 : (AppliactionStatus == "Canceled") ? 2 : 3;
        }
        public static int GetApplicationTypeID(int ApplicationID)
        {
            int ApplicationTypeID = -1;
            return (clsApplicationDataAccess.GetApplicationTypeID(ApplicationID, ref ApplicationTypeID))? ApplicationTypeID : -1;
        }
        
    }
}
