using ApplicationsBusiness;
using DVLD.Global;
using LicenseClassesBusiness;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmDrivingLicenseApplication : Form
    {
        public delegate void DataBackHandler(object sender, bool IsAdded);
        public event DataBackHandler DataBack = delegate { };
        clsPerson Person = new clsPerson();
        public enum enApplicationType
        {
            NewLocalDL = 1, ReNewDL = 2, ReplaceLostDL = 3, ReplaceDamagedDL = 4,
            ReleaseDetainedDL = 5, NewInternationalDL = 6
        };
        clsApplicationTypes _ApplicationType = new clsApplicationTypes();
        public frmDrivingLicenseApplication(enApplicationType AppType = enApplicationType.NewLocalDL)
        {
            InitializeComponent();
            _ApplicationType = clsApplicationTypes.GetApplictionTypeInfoByType((int)AppType);
            _InitializeComponentsValues();
        }
        private void _InitializeComponentsValues()
        {
            comboBoxFilter.SelectedIndex = 0;
            _InitializeApplicationInfoTabPage();
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = comboBoxFilter.SelectedIndex == 0 ? (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) :
                (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void txtBoxFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxFilter.Text.Trim()))
            {
                errorProviderInput.SetError(txtBoxFilter, "Empty Field is Denied");
                txtBoxFilter.Focus();
            }
            else
            {
                errorProviderInput.Clear();
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            Person = comboBoxFilter.SelectedIndex == 0 ? clsPerson.FindPersonByID(Convert.ToInt32(txtBoxFilter.Text.Trim())) :
                 clsPerson.FindPersonByNationalNumber(txtBoxFilter.Text.Trim());
            if (Person != null && Person.ID != 0)
                ctrlPersonInfo1.LoadControlComponents(Person.ID);
            else
            {
                MessageBox.Show("Person With This " + comboBoxFilter.Text + " is Not Exists", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ctrlPersonInfo1.LoadControlComponents(-1);
                _InitializeApplicationInfoTabPage();
            }
        }
        private void tabControlAddApplication_Selected(object sender, TabControlEventArgs e)
        {
            
        }
        private void tabControlAddApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Person == null || Person.ID == -1)
                tabControlAddApplication.SelectedIndex = 0;
        }
        private void _InitializeApplicationInfoTabPage()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            comboBoxLicenseClasses.Items.AddRange(clsLicenseClass.GetAllClassesName());
            comboBoxLicenseClasses.SelectedIndex = 2;
            lblApplicationCreatedBy.Text = clsProjectSettings.CurrentUser.UserName;
            lblApplicationFees.Text = _ApplicationType.ApplicationTypeFees.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Person != null && Person.ID != -1)
                tabControlAddApplication.SelectedIndex = 1;
        }
        private void _RelaodPersonInfo(int PersonID)
        {
            Person = clsPerson.FindPersonByID(PersonID);
            ctrlPersonInfo1.LoadControlComponents(PersonID);
        }
        private void frmAddEditPerson_DataBack(object sender, bool IsSaved, int PersonID)
        {
            if (IsSaved)
                _RelaodPersonInfo(PersonID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson newPerson = new frmAddEditPerson(-1);
            newPerson.DataBack += frmAddEditPerson_DataBack;
            newPerson.ShowDialog();
        }
        private void _ShowSuccessfullApplication(int LocalDrivingLicenseID)
        {
            MessageBox.Show("Successfull Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDrivingLicenseApplicationID.Text = LocalDrivingLicenseID.ToString();
            DataBack?.Invoke(this, true);
        }
        private void _CreateLocalApplication(int ApplicationID)
        {
            clsLocalApplications LocalApplication = new clsLocalApplications(ApplicationID,
                    comboBoxLicenseClasses.SelectedIndex + 1);
            if (LocalApplication.SaveLocalApplication())
                _ShowSuccessfullApplication(LocalApplication.LocalDrivingLicenseID);
            else
                MessageBox.Show("Failed Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _CreateApplication()
        {
            clsApplication application = new clsApplication(Person.ID, DateTime.Now, _ApplicationType.ApplcationTypeID, DateTime.Now,
                 (decimal)20.00, clsProjectSettings.CurrentUser.UserID);
            if (application.Save())
                _CreateLocalApplication(application.ApplicationID);
            else
                MessageBox.Show("Failed Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsApplication.IsPersonHasCompletedApplication(Person.ID, comboBoxLicenseClasses.SelectedIndex + 1)
                || clsApplication.IsPersonHasNewApplication(Person.ID, comboBoxLicenseClasses.SelectedIndex + 1))
                MessageBox.Show("Exist Or Completed Application", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                _CreateApplication();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
