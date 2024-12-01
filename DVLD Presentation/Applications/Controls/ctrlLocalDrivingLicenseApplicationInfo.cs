using ApplicationsBusiness;
using DriversBusiness;
using LicensesBusiness;
using LocalApplicationsBusiness;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLocalDrivingLicenseApplicationInfo : UserControl
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string LicenseClassName { get; set; }
        public int PassedTests { get; set; }
        int ApplicationID;
       
        public ctrlLocalDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassName = string.Empty;
            PassedTests = 0;
        }
        public void InitializePropertiesValues(int LocalDrivingLicenseApplicationID, string LicenseClassName, int PassedTests)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassName = LicenseClassName;
            this.PassedTests = PassedTests;
        }
        public void LoadControlInfo()
        {
            lblDrivingLicenseApplicationID.Text = LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = LicenseClassName;
            lblPassedTests.Text = PassedTests.ToString() + "/3";
            ApplicationID = clsLocalApplications.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            bool IsLicenseExists = clsLicense.IsLicenseExists(ApplicationID);
            linkLabelShowLicenseInfo.Enabled = IsLicenseExists;
            picBoxShowLicenseInfo.Enabled = IsLicenseExists;
        }
        public void ShowLinkLabelLicenseInfo(int DriverID)
        {
            linkLabelShowLicenseInfo.Enabled = true;
        }
        private void linkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string NationalNo = clsPerson.GetPersonNationalNumberByAppID(ApplicationID);
            frmShowLicenseInfo License = new frmShowLicenseInfo(ApplicationID, LicenseClassName, NationalNo);
            License.ShowDialog();
        }
    }
}
