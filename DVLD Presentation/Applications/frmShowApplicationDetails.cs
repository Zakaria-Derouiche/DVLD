using ApplicationsBusiness;
using ApplicationsTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppointementsBusiness;
using TestsTypesBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmShowApplicationDetails : Form
    {
        clsApplication Application = new clsApplication();
        public frmShowApplicationDetails(int LocalDrivingLicenseApplicationID, string ClassName,
            string ApplicantFullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            InitializeComponent();
            _LoadFromInfo(LocalDrivingLicenseApplicationID, ClassName, ApplicantFullName, ApplicationDate, PassedTests, Status);
        }
        private void _LoadFromInfo(int LocalDrivingLicenseApplicationID, string ClassName,
           string ApplicantFullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            _LoadDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID, ClassName, PassedTests);
            _LoadApplicationInfo(LocalDrivingLicenseApplicationID);
        }
        private void _LoadDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID, string ClassName, int PassedTests)
        {
            ctrlDrivingLicenseApplicationInfo1.InitializePropertiesValues(LocalDrivingLicenseApplicationID, ClassName, PassedTests);
            ctrlDrivingLicenseApplicationInfo1.LoadControlInfo();
        }
        private void _GetApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = clsLocalApplicationsDataAccess.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            Application = clsApplication.FindApplication(ApplicationID);
        }
        private void _LoadApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _GetApplication(LocalDrivingLicenseApplicationID);
            ctrlApplicationInfo1.InitializeApplicationInfoControlProprties(Application.ApplicationID, Application.ApplicantPersonID,
               Application.ApplicantFullName, Application.ApplicationTypeTitle, Application.ApplicationDate,
               Application.ApplicationFees, Application.AppliactionStatus, Application.LastStatusDate,
               Application.CreatedByUserUserName);
            ctrlApplicationInfo1.LoadControlInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
