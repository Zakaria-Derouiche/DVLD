using ApplicationsBusiness;
using DetainedLicensesBusiness;
using LicenseClassesBusiness;
using LicensesBusiness;
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
using UserBusiness;

namespace DVLD
{
    public partial class frmActivateDesactivateLicense : Form
    {
        clsLicense License = new clsLicense();
        clsPerson Person = new clsPerson();
        public enum enMode { Activate, Desactivate };
        private enMode _Mode;
        public frmActivateDesactivateLicense(enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;
            _InitializeComponents();
        }
        private void _InitializeComponents()
        {
            this.Text = _Mode == enMode.Activate ? "Activate License" : "Desactivate License";
            lblTitle.Text = _Mode.ToString() + " A License";
            btnFindLicense.Enabled = false;
            btnActivateDesactivate.Text = _Mode.ToString();
            _ChangeFormStatus();
        }
        private void _DisplayLicenseControlInfo()
        {
            string ClassName = clsLicenseClass.GetLicenseName(License.LicenseClassID);
            string IssueReason = clsApplicationTypes.GetApplicationTitle(License.ApplicationTypeID);
            string IsActive = (License.IsActive) ? "Yes" : "No";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(License.LicenseID) ? "Yes" : "No";
            string Gender = Person.Gender == 0 ? "Male" : "Female";
            string CreatedBy = clsUser.GetUserName(License.CreatedByUserID);
            ctrlDriverLicenseInfo1.InitializeComponents(License.ApplicationID, ClassName, Person.FullName, License.LicenseID,
                Person.NationalNumber, Gender, License.IssueDate, IssueReason, License.Notes, IsActive, Person.DateOfBirth,
                License.DriverID, License.ExpirationDate, IsDetained, Person.ImagePath, License.CreatedByUserID);
        }
        private void _LoadLicenseInfo()
        {
            License = clsLicense.FindLicenseByLicenseID(Convert.ToInt32(textBoxLicenseID.Text));
            Person = clsPerson.FindPersonByDriverID(License.DriverID);
            _DisplayLicenseControlInfo();
            _ChangeFormStatus();
        }
        private void textBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void _InitializeLicenseControl()
        {
            License = new clsLicense();
            ctrlDriverLicenseInfo1.InitializeComponents();
            _ChangeFormStatus();
        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            License = clsLicense.FindLicenseByLicenseID(Convert.ToInt32(textBoxLicenseID.Text.Trim()));
            if (_IsNullOrEmptyLicenseObject())
            {
                MessageBox.Show("Not Existed License", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InitializeLicenseControl();
                return;
            }
            _LoadLicenseInfo();
        }
        private bool _IsNullOrEmptyLicenseObject()
        {
            return (License == null || License.LicenseID == -1);
        }
        private void _ChangeFormStatus()
        {
            btnActivateDesactivate.Enabled = !_IsNullOrEmptyLicenseObject();
        }
        private void textBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = textBoxLicenseID.Text.Trim().Length > 0;
        }
        private void btnActivateDesactivate_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Activate && !License.IsActive)
            {
                clsLicense.ChangeLicenseStatus(License.LicenseID, true);
                MessageBox.Show("Successful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadLicenseInfo();
            }
            else if (_Mode == enMode.Desactivate && License.IsActive)
            {
                clsLicense.ChangeLicenseStatus(License.LicenseID, false);
                MessageBox.Show("Successful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadLicenseInfo();
            }
            else
            {
                MessageBox.Show("License Allready " + _Mode.ToString() + "d", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
