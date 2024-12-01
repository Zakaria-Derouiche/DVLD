using BusinessInternationalLicenses;
using LicensesBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseClassesBusiness;
using ApplicationsBusiness;
using DetainedLicensesBusiness;
using PeopleBusiness;
using System.Security;
using System.Runtime.InteropServices.Marshalling;
using DVLD.Global;

namespace DVLD
{
    public partial class frmAddInternationalLicenceApplication : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        clsLicense License = new clsLicense();
        clsPerson Person = new clsPerson();
        clsInternationalLicense InternationalLicense = new clsInternationalLicense();
        public frmAddInternationalLicenceApplication()
        {
            InitializeComponent();
            _InitializeComponents();
        }
        private void txtBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void txtBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = txtBoxLicenseID.Text.Trim().Length > 0;
        }
        private void _SetInternationalDrivingLicenseInfo()
        {
            InternationalLicense = clsInternationalLicense.FindInternationalLicense(License.LicenseID);
            ctrlInternationalLicenseInfo1.InitailizeValues(InternationalLicense.InternationalLicenseID,
                InternationalLicense.ApplicationID, InternationalLicense.DriverID, InternationalLicense.LocalLicenseID,
                InternationalLicense.IssueDate, InternationalLicense.ExpirationDate, InternationalLicense.IsActive);
        }
        private void _SetLocalDrivingLicenseInfo()
        {
            string Gender = (Person.Gender == 0) ? "Male" : "Female";
            string IssueReason = clsApplicationTypes.GetApplicationTitle(License.ApplicationTypeID);
            string IsActive = (License.IsActive) ? "Yes" : "No";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(License.LicenseID) ? "Yes" : "No";
            string LicenseClass = clsLicenseClass.GetLicenseName(License.LicenseClassID);
            ctrlDriverLicenseInfo1.InitializeComponents(License.ApplicationID, LicenseClass, Person.FullName, License.LicenseID,
                Person.NationalNumber, Gender, License.IssueDate, IssueReason, License.Notes, IsActive, Person.DateOfBirth, License.DriverID,
                License.ExpirationDate, IsDetained, Person.ImagePath, License.CreatedByUserID);
        }
        private void _ShowError(string ErrorMessage)
        {
            if (ErrorMessage != string.Empty)
                MessageBox.Show(ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private string _GetErrorMessage(bool IsExistsInternationalLicense)
        {
            return IsExistsInternationalLicense ?
                "This Person Already Has An International LicenseID" : !License.IsActive ?
                "License is Desactivated, Reactivate It First" : License.LicenseClassID != 3 ?
                "Only Ordinary driving license Is Allowed" : string.Empty;
        }
        private void _FillFormInfo()
        {
            Person = clsPerson.FindPersonByDriverID(License.DriverID);
            _SetLocalDrivingLicenseInfo();
            _ShowRelatedInfo();
        }     
        private void _SetChangements(string ErrorMessage, bool IsExistsInternationalLicense)
        {
            _ShowError(ErrorMessage);
            if (IsExistsInternationalLicense)
            {
                _SetInternationalDrivingLicenseInfo();
                linkLabelShowLicenseInfo.Enabled = true;
            }
        }
        private void _ShowRelatedInfo()
        {
            linkLabelLicenseHistory.Enabled = true;
            bool IsExistsInternationalLicense = clsInternationalLicense.IsExistsLicense(License.LicenseID);
            string ErrorMessage = _GetErrorMessage(IsExistsInternationalLicense);
            btnIssue.Enabled = (ErrorMessage == string.Empty);
            if (IsExistsInternationalLicense)
                _SetChangements(ErrorMessage, IsExistsInternationalLicense);
            else if (!License.IsActive || License.LicenseClassID != 3)
                _SetChangements(ErrorMessage, IsExistsInternationalLicense);
            else
                ctrlInternationalLicenseInfo1.InitailizeValues(-1, -1, -1, License.LicenseID, DateTime.Now,
                    DateTime.Now + new TimeSpan(10 * 365, 0, 0, 0), false);
        }
        private void _Reload()
        {
            ctrlDriverLicenseInfo1.InitializeComponents();
            ctrlInternationalLicenseInfo1.ReLoad();
            _InitializeComponents();
        } 
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            _Reload();
            int LicenseID = Convert.ToInt32(txtBoxLicenseID.Text);
            License = clsLicense.FindLicenseByLicenseID(LicenseID);
            if (License != null && License.LicenseID != -1)
                _FillFormInfo();
            else
            {
                MessageBox.Show("License Does Not Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlDriverLicenseInfo1.InitializeComponents();
            }
                
        }
        private void _InitializeComponents()
        {
            linkLabelShowLicenseInfo.Enabled = false;
            linkLabelLicenseHistory.Enabled = false;
            btnIssue.Enabled = false;
            btnFindLicense.Enabled = false;
        }
        private clsApplication _CreateApplication()
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = Person.ID;
            Application.ApplicationTypeID = 6; ;
            Application.ApplicationFees = clsApplicationTypes.GetApplicationTypeFees(6);
            Application.CreatedByUserID = clsProjectSettings.CurrentUser.UserID;
            Application.ApplicationDate = DateTime.Now;
            return Application;
        }
        private bool _AddInternationalLicense(ref int InternationalLicenseID, int ApplicationID)
        {
            bool IsInternationalLicenseAdded = clsInternationalLicense.AddNewLicense(ref InternationalLicenseID, ApplicationID,
                       License.DriverID, License.LicenseID, DateTime.Now,
                       DateTime.Now + new TimeSpan(clsLicenseClass.GetLicenseDefaultValidityLength(License.LicenseClassID) *
                       365, 0, 0, 0), License.IsActive, clsProjectSettings.CurrentUser.UserID);
            return IsInternationalLicenseAdded;
        }
        private void _DisplayInternationalLicenseInfo(int InternationalLicenseID, bool IsInternational)
        {
            InternationalLicense = IsInternational ?
                clsInternationalLicense.FindInternationalLicenseByInternationalLoicenseID(InternationalLicenseID) :
                 clsInternationalLicense.FindInternationalLicense(License.LicenseID);
            ctrlInternationalLicenseInfo1.InitailizeValues(InternationalLicense.InternationalLicenseID,
                InternationalLicense.ApplicationID, InternationalLicense.DriverID, InternationalLicense.LocalLicenseID,
                InternationalLicense.IssueDate, InternationalLicense.ExpirationDate, InternationalLicense.IsActive);
            linkLabelShowLicenseInfo.Enabled = true;
            btnIssue.Enabled = false;
        }
        private void _SetAddionalOperations(int InternationalLicenseID)
        {
            _DisplayInternationalLicenseInfo(InternationalLicenseID, true);
            MessageBox.Show("Successful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataBack?.Invoke(this, true);
        }
        private string _GetErrorMessage(bool IsAppAdded, bool IsLicenseAdded)
        {
            string ErrorMessage = !IsAppAdded ? "Application Is Not Saved" : string.Empty;
            ErrorMessage += !IsLicenseAdded ? ErrorMessage == string.Empty ? "International License Is Not Saved" :
                ", International License Is Not Saved" : string.Empty;
            return ErrorMessage;
        }
        private void _ProcessOperation()
        {
            clsApplication Application = _CreateApplication();
            bool IsApplicationSaved = Application.Save();
            int InternationalLicenseID = -1;
            bool IsInternationalLicenseAdded = _AddInternationalLicense(ref InternationalLicenseID, Application.ApplicationID);
            string ErrorMessage = _GetErrorMessage(IsApplicationSaved, IsInternationalLicenseAdded);
            if (IsApplicationSaved && IsInternationalLicenseAdded)
                _SetAddionalOperations(InternationalLicenseID);
            else
                MessageBox.Show(ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!clsInternationalLicense.IsExistsLicense(License.LicenseID))
                _ProcessOperation();
            else
                _DisplayInternationalLicenseInfo(License.LicenseID, false);
        }
        private void linkLabelLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(Person.NationalNumber);
            History.ShowDialog();
        }
        private void linkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo InterenationalLicense = new frmShowInternationalLicenseInfo(
                InternationalLicense.InternationalLicenseID, Person.ID);
            InterenationalLicense.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
