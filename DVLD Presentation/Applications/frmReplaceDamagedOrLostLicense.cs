using ApplicationsBusiness;
using DetainedLicensesBusiness;
using DVLD.Global;
using LicenseClassesBusiness;
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
using UserBusiness;

namespace DVLD
{
    public partial class frmReplaceDamagedOrLostLicense : Form
    {
        clsLicense License = new clsLicense();
        clsLicense NewLicense = new clsLicense();
        clsPerson Person = new clsPerson();
        clsApplication Application = new clsApplication();
        public frmReplaceDamagedOrLostLicense()
        {
            InitializeComponent();

        }
        private void frmReplaceDamagedOrLostLicense_Load(object sender, EventArgs e)
        {
            _InitailizeComponents();
        }
        private void _InitailizeComponents()
        {
            radioButtonDamged.Checked = true;
            linkLabelShowLicense.Enabled = false;
            linkLabelShowLicenseHistory.Enabled = false;
            btnIssueReplacement.Enabled = false;
            btnFindLicense.Enabled = false;
        }
        private void textBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void textBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = textBoxLicenseID.TextLength > 0;
        }
        private void _LoadDriverLiceseControlInfo()
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
        private void _RefreshFormInfo()
        {
            _InitailizeComponents();
            ctrlDriverLicenseInfo1.InitializeComponents();
            ctrlRepalcementApplicationInfo1.InitializeComponents();
        }
        private void _SetFoundChangements()
        {
            linkLabelShowLicenseHistory.Enabled = true;
            btnIssueReplacement.Enabled = true;
        }
        private void _LoadFormInfo()
        {
            Person = clsPerson.FindPersonByDriverID(License.DriverID);
            _LoadDriverLiceseControlInfo();
            ctrlRepalcementApplicationInfo1.InitializeComponents(License.LicenseID);
            _SetFoundChangements();
        }
        private void _ShowNotFoundresult()
        {
            MessageBox.Show("License Does Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _RefreshFormInfo();
        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            License = new clsLicense();
            int LicenseID = Convert.ToInt32(textBoxLicenseID.Text.Trim());
            License = clsLicense.FindLicenseByLicenseID(LicenseID);
            if (License != null && LicenseID != -1)
                _LoadFormInfo();
            else
                _ShowNotFoundresult();
        }
        private void radioButtonDamged_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDamged.Checked)
            {
                lblTitle.Text = "Repalcement For Damaged License";
                ctrlRepalcementApplicationInfo1.ChangeApplicationFees();
            }
        }
        private void radioButtonLost_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLost.Checked)
            {
                lblTitle.Text = "Repalcement For Lost License";
                ctrlRepalcementApplicationInfo1.ChangeApplicationFees();
            }
        }
        private void linkLabelShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string NationalNumber = clsPerson.GetPersonNationalNumber(License.DriverID);
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(NationalNumber);
            History.ShowDialog();
        }
        private void linkLabelShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = clsLicense.GetLicenseApplicationID(NewLicense.LicenseID);
            string LicenseClass = clsLicenseClass.GetLicenseName(License.LicenseClassID);
            string NationalNumber = clsPerson.GetPersonNationalNumber(License.DriverID);
            frmShowLicenseInfo LicenseInfo = new frmShowLicenseInfo(ApplicationID, LicenseClass, NationalNumber);
            LicenseInfo.ShowDialog();
        }
        private void _DesativateOldLicense()
        {
            if(License.IsActive)
            {
                License.IsActive = false;
                License.Save();
            }
        }
        private bool _AddApplication()
        {
            int PersonID = clsPerson.GetPersonID(License.DriverID);
            int ApplicationTypeID = (radioButtonDamged.Checked ? 4 : 3);
            decimal ApplicationFees = clsApplicationTypes.GetApplicationTypeFees(License.ApplicationTypeID);
            Application = new clsApplication(PersonID, DateTime.Now, ApplicationTypeID, DateTime.Now,
                ApplicationFees, clsProjectSettings.CurrentUser.UserID);
            return Application.Save();
        }
        private bool _AddLicense()
        {
            decimal LicenseFees = clsLicenseClass.GetLicenseClassFees(License.LicenseClassID);
            NewLicense = new clsLicense(Application.ApplicationID, License.DriverID, License.LicenseClassID,
                License.IssueDate, License.ExpirationDate, LicenseFees, License.Notes, true,
                Application.ApplicationTypeID, clsProjectSettings.CurrentUser.UserID);
            return NewLicense.Save();
        }
        private void _ShowOperationResult()
        {
            ctrlRepalcementApplicationInfo1.InitializeComponents(Application.ApplicationID, NewLicense.LicenseID);
            linkLabelShowLicense.Enabled = true;
            btnIssueReplacement.Enabled = false;
            MessageBox.Show("Successful Operation", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBoxReplacementType.Enabled = false;
            groupBoxFilter.Enabled = false;
        }
        private void _CreateNewLicense()
        {
            if (_AddApplication() && _AddLicense())
                _ShowOperationResult();
            else
                MessageBox.Show("Failed Operation", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _ProccessOperation()
        {
            _DesativateOldLicense();
            _CreateNewLicense();
        }
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if(clsDetainedLicense.IsDetainedLicence(License.LicenseID))
                MessageBox.Show("Detained License, Pay Your Fine Fees First", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!License.IsActive)
                MessageBox.Show("Desactivated License", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _ProccessOperation();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
