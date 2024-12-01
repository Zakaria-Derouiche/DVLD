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
using static DVLD.frmAppointment;
using DriversBusiness;
using LicensesBusiness;
using LicenseClassesBusiness;
using LocalApplicationsBusiness;
using DVLD.Global;

namespace DVLD
{
    public partial class frmIssueDrivingLicense : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        clsApplication Application = new clsApplication();
        clsLicense License = new clsLicense();
        public frmIssueDrivingLicense(int LocalDrivingLicenseApplicationID, string ClassName, string ApplicantFullName,
            DateTime ApplicationDate, int PassedTests, string Status)
        {
            InitializeComponent();
            _InitializeInfo(LocalDrivingLicenseApplicationID, ClassName, ApplicantFullName, ApplicationDate, PassedTests, Status);
        }
        private void _InitializeInfo(int LocalDrivingLicenseApplicationID, string ClassName, string ApplicantFullName,
            DateTime ApplicationDate, int PassedTests, string Status)
        {
            ctrlDrivingLicenseApplicationInfo1.InitializePropertiesValues(LocalDrivingLicenseApplicationID, ClassName, PassedTests);
            ctrlDrivingLicenseApplicationInfo1.LoadControlInfo();
            int ApplicationID = clsLocalApplicationsDataAccess.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            Application = clsApplication.FindApplication(ApplicationID);
            ctrlApplicationInfo1.InitializeApplicationInfoControlProprties(Application.ApplicationID, Application.ApplicantPersonID,
                Application.ApplicantFullName, Application.ApplicationTypeTitle, Application.ApplicationDate,
                Application.ApplicationFees, Application.AppliactionStatus, Application.LastStatusDate,
                Application.CreatedByUserUserName);
            ctrlApplicationInfo1.LoadControlInfo();
        }
        private void _ShowResultMessage(bool IsUpdated, string Message = "")
        {
            Message = Message != string.Empty ? Message : IsUpdated ?  "Successful Operation" : "Failed Operation";
            MessageBoxIcon icon = IsUpdated ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, icon);
        }
        private void _SetChangements()
        {
            Application.LastStatusDate = DateTime.Now;
            Application.AppliactionStatus = "Completed";
            btnIssue.Enabled = false;
            ctrlDrivingLicenseApplicationInfo1.ShowLinkLabelLicenseInfo(License.DriverID);
            bool IsApplicationSaved = Application.Save();
            btnIssue.Enabled = !IsApplicationSaved;
            DataBack?.Invoke(this, IsApplicationSaved);
        }
        private void _CreateLicense(int DriverID)
        {
            clsLicenseClass LicenseClass = clsLicenseClass.GetLicenseClassInfo(ctrlDrivingLicenseApplicationInfo1.LicenseClassName);
            MessageBox.Show(LicenseClass.DefaultValidityLength.ToString());
            License = new clsLicense(Application.ApplicationID, DriverID, LicenseClass.LicenseClassID,
                DateTime.Now, DateTime.Now + new TimeSpan(LicenseClass.DefaultValidityLength * 365, 0, 0, 0), LicenseClass.ClassFees,
                txtBoxNotes.Text, true, Application.ApplicationTypeID, clsProjectSettings.CurrentUser.UserID);
            bool IsLicenseSaved = License.Save();
            _ShowResultMessage(IsLicenseSaved);
            if (IsLicenseSaved)
                _SetChangements();
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            int DriverID = (!clsDriver.IsExistsDriver(Application.ApplicantPersonID)) ?
                clsDriver.AddDriver(Application.ApplicantPersonID, clsProjectSettings.CurrentUser.UserID, DateTime.Now) :
                clsDriver.GetDriverID(Application.ApplicantPersonID);
            if (!clsLicense.IsLicenseExists(Application.ApplicationID))
                _CreateLicense(DriverID);
            else
                _ShowResultMessage(false, "This Person Already Has A License");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
