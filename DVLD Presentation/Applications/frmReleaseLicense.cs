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
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmReleaseLicense : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        clsLicense _License = new clsLicense();
        clsPerson Person = new clsPerson();
        clsDetainedLicense DetainLicense = new clsDetainedLicense();
        public frmReleaseLicense()
        {
            InitializeComponent();
            _InitializeComponents();
        }
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _License = clsLicense.FindLicenseByLicenseID(LicenseID);
            Person = clsPerson.FindPersonByDriverID(_License.DriverID);
            _LoadFormInfo();
            groupBoxFilter.Enabled = false;
        }
        private void _InitializeComponents()
        {
            btnRelease.Enabled = false;
            linkLabelShowLicense.Enabled = false;
            linkLabelShowLicenseHistory.Enabled = false;
            btnFindLicense.Enabled = false;
            ctrlDriverLicenseInfo1.InitializeComponents();
        }
        private void _LoadFormInfo()
        {
            _LoadDriverLicenseControlInfo();
            _LoadReleaseControlInfo();
            ChangeStatus();
        }
        private void _LoadDriverLicenseControlInfo()
        {
            string ClassName = clsLicenseClass.GetLicenseName(_License.LicenseClassID);
            string Gender = Person.Gender == 0 ? "Male" : "Female";
            string IssueReason = clsApplicationTypes.GetApplicationTitle(_License.ApplicationTypeID);
            string IsActive = _License.IsActive ? "Yes" : "No";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(_License.LicenseID) ? "Yes" : "No";
            ctrlDriverLicenseInfo1.InitializeComponents(_License.ApplicationID, ClassName, Person.FullName, _License.LicenseID,
                Person.NationalNumber, Gender, _License.IssueDate, IssueReason, _License.Notes, IsActive, Person.DateOfBirth,
                _License.DriverID, _License.ExpirationDate, IsDetained, Person.ImagePath, _License.CreatedByUserID);
        }
        private void _LoadReleaseControlInfo()
        {
            DetainLicense = clsDetainedLicense.FindDetainedLicense(_License.LicenseID);
            if (DetainLicense != null)
                ctrlReleaseInfo1.InitializeComponents(_License.LicenseID, DetainLicense.DetainID, DetainLicense.DetainDate,
                    DetainLicense.FineFees, DetainLicense.CreatedByUserID);
        }
        private void textBoxLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void ChangeStatus()
        {
            linkLabelShowLicense.Enabled = !(_License == null || _License.LicenseID == -1);
            linkLabelShowLicenseHistory.Enabled = !(_License == null || _License.LicenseID == -1);
            btnRelease.Enabled = !(_License == null || _License.LicenseID == -1);
        }
        private void textBoxLicenseID_TextChanged(object sender, EventArgs e)
        {
            btnFindLicense.Enabled = textBoxLicenseID.Text.Trim().Length > 0;
        }
        private void _DisplayInfo()
        {
            Person = clsPerson.FindPersonByDriverID(_License.DriverID);
            if (!clsDetainedLicense.IsDetainedLicence(_License.LicenseID))
                MessageBox.Show("This License Is Not Detained", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            _LoadFormInfo();  
        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            _License = new clsLicense();
            _License= clsLicense.FindLicenseByLicenseID(Convert.ToInt32(textBoxLicenseID.Text));
            if(_License != null && _License.LicenseID != -1 && !clsDetainedLicense.IsDetainedLicence(_License.LicenseID))
            {
                MessageBox.Show("This License Is Not Detained", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_License != null && _License.LicenseID != -1 && clsDetainedLicense.IsDetainedLicence(_License.LicenseID))
                _DisplayInfo();
            else
                { 
                MessageBox.Show("This License Is Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InitializeComponents();
            }        
        }
        private void _SaveApplication(decimal PaidFees)
        {
            clsApplication Application = new clsApplication(Person.ID, DateTime.Now, 5, DateTime.Now, PaidFees,
                clsProjectSettings.CurrentUser.UserID);
            if (Application.Save())
                _ReleaseDetainedLicense(Application.ApplicationID);
            else
                MessageBox.Show("Application Is Not Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _UpdateReleaseControlOnfo()
        {
            _License.IsActive = true;
            _License.Save();
            ctrlReleaseInfo1.SetApplicationID(DetainLicense.ReleaseApplicationID);
            ctrlDriverLicenseInfo1.ChangeActiveStatus();
            ctrlDriverLicenseInfo1.ChangeDetainStatus();
        }
        private void _UpdateFormInfo()
        {
            MessageBox.Show("Seccessful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _UpdateReleaseControlOnfo();
            btnRelease.Enabled = false;
            DataBack?.Invoke(this, true);
        }
        private void _ReleaseDetainedLicense(int ApplicationID)
        {
            DetainLicense.ReleaseApplicationID = ApplicationID;
            DetainLicense.ReleasedByUserID = clsProjectSettings.CurrentUser.UserID;
            DetainLicense.ReleaseDate = DateTime.Now;
            DetainLicense.IsReleased = true;
            if (DetainLicense.Save())
                _UpdateFormInfo();
            else
                MessageBox.Show("Failed Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);          
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            decimal PaidFees = clsApplicationTypes.GetApplicationTypeFees(5);
            _SaveApplication(PaidFees);
        }
        private void linkLabelShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ApplicationID = clsLicense.GetLicenseApplicationID(_License.LicenseID);
            string LicenseClass = clsLicenseClass.GetLicenseName(_License.LicenseClassID);
            frmShowLicenseInfo LicenseInfo = new frmShowLicenseInfo(ApplicationID, LicenseClass, Person.NationalNumber);
            LicenseInfo.ShowDialog();
        }
        private void linkLabelShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(Person.NationalNumber);
            History.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
