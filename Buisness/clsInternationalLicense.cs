using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalLicensesDataAccess;
using static System.Net.Mime.MediaTypeNames;
using LicenseClassesBusiness;
namespace BusinessInternationalLicenses
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int LocalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID {  get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID {  get; set; } 
        public clsInternationalLicense() {
            InternationalLicenseID = -1;
            LocalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = IssueDate + new TimeSpan((clsLicenseClass.GetLicenseDefaultValidityLength(3)) * 365, 0, 0, 0);
            IsActive = false;
            CreatedByUserID = -1;
        }
        private clsInternationalLicense(int internationalLicenseID, int localLicenseID, int applicationID, int driverID,
            DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.LocalLicenseID = localLicenseID;
            this.ApplicationID = applicationID;
            DriverID = driverID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }
        public static DataTable GetPersonLicenses(int PersonID)
        {
            return clsInternationalLicenseDataAccess.GetPersonInternationalLicenses(PersonID);
        }
        public static bool IsExistsLicense(int LocalLicenseID)
        {
            return clsInternationalLicenseDataAccess.IsLicesneExists(LocalLicenseID);
        }
        public static  clsInternationalLicense FindInternationalLicense(int LocalLicenseID)
        {
            int internationalLicenseID = -1;
            int applicationID = -1;
            int driverID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int createdByUserID = -1;
            if (clsInternationalLicenseDataAccess.GetInternationalLicenseInfo(LocalLicenseID, ref internationalLicenseID,
                ref applicationID, ref driverID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
                return new clsInternationalLicense(internationalLicenseID, LocalLicenseID, applicationID, driverID, issueDate,
                    expirationDate, isActive, createdByUserID);
            else
                return null;
        }
        public static clsInternationalLicense FindInternationalLicenseByInternationalLoicenseID(int InternationalLicenseID)
        {
            int localLicenseID = -1;
            int applicationID = -1;
            int driverID = -1;
            DateTime issueDate = DateTime.Now;
            DateTime expirationDate = DateTime.Now;
            bool isActive = false;
            int createdByUserID = -1;
            if (clsInternationalLicenseDataAccess.GetInternationalLicenseInfoByInternationalLicenseID(InternationalLicenseID,
                ref applicationID, ref localLicenseID, ref driverID, ref issueDate, ref expirationDate, ref isActive,
                ref createdByUserID))
                return new clsInternationalLicense(InternationalLicenseID, localLicenseID, applicationID, driverID, issueDate,
                    expirationDate, isActive, createdByUserID);
            else
                return null;
        }
        public static bool AddNewLicense(ref int InternationalLicenseID, int ApplicationID, int DriverID, int LocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            return clsInternationalLicenseDataAccess.AddInternationalLicense(ref InternationalLicenseID, ApplicationID, DriverID, LocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);
        }
        public static DataTable GetAllLicenses()
        {
            return clsInternationalLicenseDataAccess.GetInternationalLicenses();
        }
    }
}
