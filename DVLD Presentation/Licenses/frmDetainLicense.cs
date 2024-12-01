using ApplicationsBusiness;
using DetainedLicensesBusiness;
using DVLD.Global;
using LicenseClassesBusiness;
using LicensesBusiness;
using LocalApplicationsBusiness;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDetainLicense : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        private clsLicense _License = new clsLicense();
        clsPerson Person = new clsPerson();
        bool IsDetainedLicense = false;
        public frmDetainLicense()
        {
            InitializeComponent();
            _InitializeComponents();
        }
        private void textBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void _btnDetain_EnableStatus()
        {
            btnDetain.Enabled = (_License == null || _License.LicenseID == -1) ? false :
                _License.IsActive && !clsDetainedLicense.IsDetainedLicence(_License.LicenseID);
        }
        private void _InitializeComponents()
        {
            _ChangeLinkLableStatus();
            _btnDetain_EnableStatus();
            btnFindLicense.Enabled = false;
        }
        private bool _GetLicense(int LicenseID)
        {
            _License = clsLicense.FindLicenseByLicenseID(LicenseID);
            return _License != null && _License.LicenseID != -1;
        }
        private void textBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = textBoxLicenseID.Text.Trim().Length > 0;
        }
        private void _ChangeLinkLableStatus()
        {
            linkLabelShowLicense.Enabled = (_License == null || _License.LicenseID == -1) ? false : true;
            linkLabelShowLicenseHistory.Enabled = (_License == null || _License.LicenseID == -1) ? false : true;
        }
        private void _SetFormInfo(string Gender, string IssueReason, string LicenseClass, string IsActive, string IsDetained)
        {
            ctrlDriverLicenseInfo1.InitializeComponents(_License.ApplicationID, LicenseClass, Person.FullName,
                  _License.LicenseID, Person.NationalNumber, Gender, _License.IssueDate, IssueReason,
                  _License.Notes, IsActive, DateTime.Now, _License.DriverID, _License.ExpirationDate, IsDetained,
                  Person.ImagePath, _License.CreatedByUserID);
            ctrlDetainInfo1.InitializeComponents(_License.LicenseID);
        }
        private void _InitializeInfo()
        {
            Person = clsPerson.FindPersonByDriverID(_License.DriverID);
            string Gender = Person.Gender == 0 ? "Male" : "Female";
            string IssueReason = clsApplicationTypes.GetApplicationTitle(_License.ApplicationTypeID);
            string LicenseClass = clsLicenseClass.GetLicenseName(_License.LicenseClassID);
            string IsActive = _License.IsActive ? "Yes" : "No";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(_License.LicenseID) ? "Yes" : "No";
            IsDetainedLicense = IsDetained == "Yes";
            _SetFormInfo(Gender, IssueReason, LicenseClass, IsActive, IsDetained);
        }
        private void _ChangeDetainInfoControlEnableStatus()
        {
            ctrlDetainInfo1.Enabled = _License != null && _License.LicenseID != -1 && _License.IsActive;
        }
        private void _ReloadForm()
        {
            ctrlDetainInfo1.InitializeComponents();
            ctrlDriverLicenseInfo1.InitializeComponents();
        }
        private void _ShowErrorMessage()
        {
            if (_License == null || _License.LicenseID == -1)
                MessageBox.Show("License Is Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!_License.IsActive)
                MessageBox.Show("Desactivated License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsDetainedLicense)
                MessageBox.Show("License Is Allready Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLicenseID.Text, out int LicenseID) && _GetLicense(LicenseID))
                _InitializeInfo();
            else
                _ReloadForm();
            _ShowErrorMessage();
            _ChangeLinkLableStatus();
            _btnDetain_EnableStatus();
            _ChangeDetainInfoControlEnableStatus();
        }
        private void linkLabelShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string NationalNumber = clsPerson.GetPersonNationalNumber(_License.DriverID);
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(NationalNumber);
            History.ShowDialog();
        }
        private void linkLabelShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = clsLicense.GetLicenseApplicationID(_License.LicenseID);
            string LicenseClass = clsLicenseClass.GetLicenseName(_License.LicenseClassID);
            string NationalNumber = clsPerson.GetPersonNationalNumber(_License.DriverID);
            frmShowLicenseInfo LicenseInfo = new frmShowLicenseInfo(ApplicationID, LicenseClass, NationalNumber);
            LicenseInfo.ShowDialog();
        }
        private void _ChangeLicenseDetainStatus()
        {
            _License.IsActive = false;
            _License.Save();
        }
        private void _ChangeFormInfo(int DetainID)
        {
            ctrlDetainInfo1.ChangeDetainID(DetainID);
            ctrlDriverLicenseInfo1.ChangeDetainStatus();
            ctrlDetainInfo1.Enabled = false;
            btnDetain.Enabled = false;
            DataBack?.Invoke(this, true);
            MessageBox.Show("Successful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _Save(int DetainID)
        {
            _ChangeLicenseDetainStatus();
            _ChangeFormInfo(DetainID);
        }
        private void _DetainLicense()
        {
            clsDetainedLicense DetainLicense = new clsDetainedLicense(_License.LicenseID, DateTime.Now, ctrlDetainInfo1.FineFees,
                   clsProjectSettings.CurrentUser.UserID);
            if (DetainLicense.Save())
                _Save(DetainLicense.DetainID);
            else
                MessageBox.Show("Failed Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (ctrlDetainInfo1.FineFees == 0)
                ctrlDetainInfo1.SetError();
            else
                _DetainLicense();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
