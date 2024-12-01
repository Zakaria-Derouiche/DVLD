using DVLD.Global;
using LicenseClassesBusiness;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    public partial class frmMenu : Form
    {
        public delegate void DataBackHandler(object sender, string UserName);
        public event DataBackHandler DataBack = delegate { };
        frmLogin _Login = new frmLogin();
        public frmMenu(string UserName, frmLogin Login)
        {
            InitializeComponent();
            _Login = Login;
            clsProjectSettings.CurrentUser = clsUser.FindUserByUserName(UserName);
            clsUser.FindUserByUserName(UserName);
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUsers Users = new frmShowUsers();
            Users.ShowDialog();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleInfo People = new frmPeopleInfo();
            People.ShowDialog();
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers manageDrivers = new frmManageDrivers();
            manageDrivers.ShowDialog();
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, clsProjectSettings.CurrentUser.UserName);
            clsProjectSettings.CurrentUser = new clsUser();
            _Login.Show();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayUserInfo CurrentUserInfo = new frmDisplayUserInfo(clsProjectSettings.CurrentUser.UserID,
                frmDisplayUserInfo.enMode.ChangePassword);
            CurrentUserInfo.ShowDialog();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayUserInfo CurrentUserInfo = new frmDisplayUserInfo(clsProjectSettings.CurrentUser.UserID,
                frmDisplayUserInfo.enMode.DisplayInfo);
            CurrentUserInfo.ShowDialog();
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes MangeApplications = new frmManageApplicationTypes();
            MangeApplications.ShowDialog();
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes ManageTestsTypes = new frmManageTestTypes();
            ManageTestsTypes.ShowDialog();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseApplication newApplication =
                new frmDrivingLicenseApplication(frmDrivingLicenseApplication.enApplicationType.NewLocalDL);
            newApplication.ShowDialog();
        }
        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplications LocalApplications = new frmLocalDrivingLicenseApplications();
            LocalApplications.ShowDialog();
        }
        private void internationlLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenceApplication application = new frmAddInternationalLicenceApplication();
            application.ShowDialog();
        }
        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplications InternationalLicesneApplications = new frmInternationalLicenseApplications();
            InternationalLicesneApplications.ShowDialog();
        }
        private void renewDrivingLicemseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReNewLicenseApplication Application = new frmReNewLicenseApplication();
            Application.ShowDialog();
        }
        private void replaceForLostOrDamagedLicneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceDamagedOrLostLicense Application = new frmReplaceDamagedOrLostLicense();
            Application.ShowDialog();
        }
        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplications applications = new frmLocalDrivingLicenseApplications();
            applications.ShowDialog();
        }
        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdetainedLicensesList DetainedLicensesList = new frmdetainedLicensesList();
            DetainedLicensesList.ShowDialog();
        }
        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
        }
        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
        }
        private void desActivateLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivateDesactivateLicense Desactivate = new frmActivateDesactivateLicense(frmActivateDesactivateLicense.enMode.Desactivate);
            Desactivate.ShowDialog();
        }
        private void activeteLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivateDesactivateLicense Activate = new frmActivateDesactivateLicense(frmActivateDesactivateLicense.enMode.Activate);
            Activate.ShowDialog();
        }
        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense License = new frmReleaseLicense();
            License.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
