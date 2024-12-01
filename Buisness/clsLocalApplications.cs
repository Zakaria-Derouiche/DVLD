using ApplicationsTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocalApplicationsBusiness
{
    public class clsLocalApplications
    {
        public int LocalDrivingLicenseID {  get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID {  get; set; }
        public clsLocalApplications(int ApplicationID, int LicenseClassID)
        {
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }
        public static DataTable GetLocalApplications()
        {
            return clsLocalApplicationsDataAccess.GetAllLocalApplications();
        }
        public bool  SaveLocalApplication()
        {
            LocalDrivingLicenseID = clsLocalApplicationsDataAccess.AddNewLocalDrivingLicenseApplication(ApplicationID,
                LicenseClassID);
            return (LocalDrivingLicenseID != -1); 
        }
        public static int GetApplicationIDByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalApplicationsDataAccess.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalApplicationsDataAccess.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }
        public static int GetLocalApplicationID(int ApplicationID)
        {
            return clsLocalApplicationsDataAccess.GetLocalApplicationID(ApplicationID);
        }
        

       
    }
}
