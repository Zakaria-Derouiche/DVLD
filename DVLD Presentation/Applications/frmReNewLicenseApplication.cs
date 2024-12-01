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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReNewLicenseApplication : Form
    {
        private clsLicense License = new clsLicense();
        private clsLicense NewLicense = new clsLicense();
        private clsApplication Application = new clsApplication();
        clsPerson Person = new clsPerson();
        public frmReNewLicenseApplication()
        {
            InitializeComponent();
        }
        private void frmReNewLicenseApplication_Load(object sender, EventArgs e)
        {
            linkLabelShowLicense.Enabled = false;
            linkLabelShowLicenseHistory.Enabled = false;
            btnRenew.Enabled = false;
            ctrlNewLicenseApplicationInfo1.Enabled = false;
            btnFindLicense.Enabled = false;
        }
        private void textBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = textBoxLicenseID.Text.Trim().Length > 0;
        }
        private void _LoadDriverLicenseControlInfo()
        {
           
            string ClassName = clsLicenseClass.GetLicenseName(License.LicenseClassID);
            string IssueReason = clsApplicationTypes.GetApplicationTitle(License.ApplicationTypeID);
            string IsActive = License.IsActive ? "Yes" : "No";
            string Gender = (Person.Gender == 0) ? "Male" : "Female";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(License.LicenseID) ? "Yes" : "No";
            ctrlDriverLicenseInfo1.InitializeComponents(License.ApplicationID, ClassName, Person.FirstName, License.LicenseID,
                Person.NationalNumber, Gender, License.IssueDate, IssueReason, License.Notes, IsActive, Person.DateOfBirth,
                License.DriverID, License.ExpirationDate,
                IsDetained, Person.ImagePath, License.CreatedByUserID);
        }
        private void _SetFromChangements()
        {
            bool IsLicenseExpired = _CheckLicenseExpirationDate();
            btnRenew.Enabled = License!= null && License.LicenseID != -1 ? IsLicenseExpired : false;
            linkLabelShowLicense.Enabled = License != null && License.LicenseID != -1 ? IsLicenseExpired : false;
            linkLabelShowLicenseHistory.Enabled = License != null && License.LicenseID != -1;
            ctrlNewLicenseApplicationInfo1.Enabled = License != null && License.LicenseID != -1 ? IsLicenseExpired : false;
            if (!IsLicenseExpired)
                MessageBox.Show("License Date Is Not Expired", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool _CheckLicenseExpirationDate()
        {
            return  DateTime.Now > License.ExpirationDate;
        }
        private void _LoadFormInfo()
        {
            Person = clsPerson.FindPersonByDriverID(License.DriverID);
            _LoadDriverLicenseControlInfo();
            ctrlNewLicenseApplicationInfo1.ReloadInfo(License.LicenseID, License.LicenseClassID);
            _SetFromChangements();
        }
        private void _RefreshForm()
        {
            ctrlDriverLicenseInfo1.InitializeComponents();
            linkLabelShowLicense.Enabled = false;
            linkLabelShowLicenseHistory.Enabled = false;
            btnRenew.Enabled = false;
        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(textBoxLicenseID.Text.Trim());
            License = clsLicense.FindLicenseByLicenseID(LicenseID);
            if (License != null && License.LicenseID != -1)
                _LoadFormInfo();
            else
            {
                _RefreshForm();
                MessageBox.Show("License Is Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }
        private void _DesActivateOldLicense()
        {
            if (License.IsActive)
            {
                License.IsActive = false;
                License.Save();
            }
        }
        private bool _AddApplication()
        {
            int PersonID = clsPerson.GetPersonID(License.DriverID);
            decimal AppFees = clsApplicationTypes.GetApplicationTypeFees(2);
            Application = new clsApplication(PersonID, DateTime.Now, 2, DateTime.Now,
                AppFees, clsProjectSettings.CurrentUser.UserID);
            return Application.Save();
        }
        private void _ShowOperationResult()
        {
            MessageBox.Show("License Renewed Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlNewLicenseApplicationInfo1.LoadLicenseInfo(NewLicense.ApplicationID, NewLicense.LicenseID);
            ctrlNewLicenseApplicationInfo1.Enabled = false;
            btnRenew.Enabled = false;
            linkLabelShowLicense.Enabled = true;
        }
        private bool _AddNewLicense()
        {
            decimal LicenseFees = clsLicenseClass.GetLicenseClassFees(License.LicenseClassID);
            byte DefaultLicenseLength = clsLicenseClass.GetLicenseDefaultValidityLength(License.LicenseClassID);
            NewLicense = new clsLicense(Application.ApplicationID, License.DriverID, License.LicenseClassID,
                DateTime.Now, DateTime.Now + new TimeSpan((DefaultLicenseLength) * 365, 0, 0, 0), LicenseFees,
                ctrlNewLicenseApplicationInfo1.Notes, true, Application.ApplicationTypeID, clsProjectSettings.CurrentUser.UserID);
            return  NewLicense.Save();
        }
        private void _CreateNewLicense()
        {
            if (_AddApplication() && _AddNewLicense())
                _ShowOperationResult();
            else
                MessageBox.Show("Operation Failed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _ProccessOperation()
        {
            _DesActivateOldLicense();
            _CreateNewLicense();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (License.ExpirationDate >  DateTime.Now)
                MessageBox.Show("License Date Is Not Expired", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            else if(clsDetainedLicense.IsDetainedLicence(License.LicenseID))
                MessageBox.Show("License Is Detained Pay Your Fine Fess First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!License.IsActive)
                MessageBox.Show("desactivated License", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _ProccessOperation();
        }
        private void linkLabelShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string PersonNationalNumber = clsPerson.GetPersonNationalNumber(License.DriverID);
            string LicenseClass = clsLicenseClass.GetLicenseName(License.LicenseClassID);
            int ApplicationID = clsLicense.GetLicenseApplicationID(NewLicense.LicenseID);
            frmShowLicenseInfo Licesne = new frmShowLicenseInfo(ApplicationID, LicenseClass, PersonNationalNumber);
            Licesne.ShowDialog();
        }
        private void linkLabelShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string PersonNationalNumber = clsPerson.GetPersonNationalNumber(License.DriverID);
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(PersonNationalNumber);
            History.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
