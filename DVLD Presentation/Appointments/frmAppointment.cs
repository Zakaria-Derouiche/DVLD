using ApplicationsBusiness;
using ApplicationsTypes;
using DVLD.Global;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppointementsBusiness;
using TestsTypesBusiness;
using static DVLD.frmAppointment;
namespace DVLD
{
    public partial class frmAppointment : Form
    {
        public delegate void DataBackHandler(object sender, bool IsPassTest);
        public event DataBackHandler DataBack = delegate { };
        bool _IsPassTest = false;
        clsApplication Application = new clsApplication();
        DataTable dtTestAppointenments = new DataTable();
        public enum enAppointementTestType { Vision = 1, Written = 2, Street = 3 };
        enAppointementTestType _AppointementTestType;
        private string _DrivingLicenseClass = string.Empty;
        public frmAppointment(enAppointementTestType AppointementTestType, int LocalDrivingLicenseApplicationID, string ClassName,
            string ApplicantFullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            InitializeComponent();
            _LoadFromInfo(AppointementTestType, LocalDrivingLicenseApplicationID, ClassName,  ApplicantFullName, ApplicationDate,
                PassedTests, Status);
        }
        private void _LoadDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID, string ClassName, int PassedTests)
        {
            ctrlDrivingLicenseApplicationInfo1.InitializePropertiesValues(LocalDrivingLicenseApplicationID, ClassName, PassedTests);
            ctrlDrivingLicenseApplicationInfo1.LoadControlInfo();
        }
        private void _LoadApplicationInfo()
        {
            ctrlApplicationInfo1.InitializeApplicationInfoControlProprties(Application.ApplicationID, Application.ApplicantPersonID,
               Application.ApplicantFullName, Application.ApplicationTypeTitle, Application.ApplicationDate,
               Application.ApplicationFees, Application.AppliactionStatus, Application.LastStatusDate,
               Application.CreatedByUserUserName);
            ctrlApplicationInfo1.LoadControlInfo();
        }
        private void _GetApplication(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = clsLocalApplicationsDataAccess.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            Application = clsApplication.FindApplication(ApplicationID);
        }
        private void _InitializeValues(enAppointementTestType AppointementTestType, string ClassName)
        {
            _AppointementTestType = AppointementTestType;
            _DrivingLicenseClass = ClassName;
        }
        private void _LoadFromInfo(enAppointementTestType AppointementTestType, int LocalDrivingLicenseApplicationID, string ClassName,
            string ApplicantFullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            _InitializeValues(AppointementTestType, ClassName);
            _SetFormTitle();
            _LoadDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID, ClassName, PassedTests);
            _GetApplication(LocalDrivingLicenseApplicationID);
            _LoadApplicationInfo();
            _LoadTestAppointements();
            PicBoxFormTitle_Load();
        }
        private void PicBoxFormTitle_Load()
        {
            picBoxFromType.ImageLocation = (_AppointementTestType == enAppointementTestType.Vision) ?
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\TestEye.png" :
                (_AppointementTestType == enAppointementTestType.Written) ?
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\essay (1).png" :
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\car.png";
        }
        private void _SetFormTitle()
        {
            lblFormTitle.Text = _AppointementTestType.ToString() + " Test Appointement";
            lblFormTitle.Location = _AppointementTestType == enAppointementTestType.Vision ? new Point(350, 135) :
                _AppointementTestType == enAppointementTestType.Written ? new Point(344, 135) : new Point(351, 135);
        }
        private void _LoadTestAppointements()
        {
            dtTestAppointenments = (_AppointementTestType == enAppointementTestType.Vision) ?
                clsAppointment.GetTestAppointments(1, Application.ApplicantPersonID, _DrivingLicenseClass)
                : (_AppointementTestType == enAppointementTestType.Written) ?
                clsAppointment.GetTestAppointments(2, Application.ApplicantPersonID, _DrivingLicenseClass) :
                 clsAppointment.GetTestAppointments(3, Application.ApplicantPersonID, _DrivingLicenseClass);
            dataGridViewTestApointements.DataSource = dtTestAppointenments;
            lblAppointmentsNumber.Text = dtTestAppointenments.Rows.Count.ToString() + " Resord(s)";
        }
        private bool IsListAppointmentsEmpty()
        {
            return dtTestAppointenments.Rows.Count == 0;
        }
        private bool CheckUnlockedTestAppointment()
        {
            for (int i = 0; i < dtTestAppointenments.Rows.Count; i++)
            {
                if ((bool)dtTestAppointenments.Rows[i][3] == false)
                    return true;
            }
            return false;
        }
        private bool CheckPassedTestAppointment()
        {
            for (int i = 0; i < dtTestAppointenments.Rows.Count; i++)
            {
                if (clsAppointment.IsTestAppointmentPassed((int)dtTestAppointenments.Rows[i][0]))
                    return true;
            }
            return false;
        }
        private void frmAddTest_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
            {
                _LoadTestAppointements();
                ctrlDrivingLicenseApplicationInfo1.PassedTests += 1;
                ctrlDrivingLicenseApplicationInfo1.LoadControlInfo();
            }
        }
        private void frmScheduleTest_DataBack(object sender, bool IsInserted)
        {
            if (IsInserted)
            {
                _LoadTestAppointements();
                DataBack.Invoke(this, IsInserted);
            }
        }
        private void _AddTest(int TestAppointmentID = -1, frmAddTest.enTestMode TestMode = frmAddTest.enTestMode.Take)
        {
            frmAddTest Test = new frmAddTest(TestAppointmentID, _AppointementTestType, TestMode,
                ctrlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID,
                ctrlDrivingLicenseApplicationInfo1.LicenseClassName, Application.ApplicantFullName,
                (byte)dtTestAppointenments.Rows.Count, clsProjectSettings.CurrentUser.UserID, false);
            Test.DataBack += frmAddTest_DataBack;
            Test.ShowDialog();
            
        }
        private void btnAddAppointement_Click(object sender, EventArgs e)
        {
            frmAddTest.enTestMode TestMode = IsListAppointmentsEmpty() ? frmAddTest.enTestMode.Take : frmAddTest.enTestMode.Retake;
            bool TakeRetake = (IsListAppointmentsEmpty() || !CheckPassedTestAppointment() && !CheckUnlockedTestAppointment());
            if (TakeRetake)
                _AddTest(-1, TestMode);
            else
                MessageBox.Show("Unfinished Or Passsed Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dataGridViewTestApointements.CurrentRow.Cells[0].Value;
            bool IsLocked = (bool)dataGridViewTestApointements.CurrentRow.Cells[3].Value;
            if (!IsLocked)
                _AddTest(TestAppointmentID);
            else
                MessageBox.Show("This Test Is Already Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void _ScheduleTest(int TestAppointmentID)
        {
            frmScheduleTest scheduleTest = new frmScheduleTest(TestAppointmentID, _AppointementTestType,
                ctrlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID,
                ctrlDrivingLicenseApplicationInfo1.LicenseClassName,Application.ApplicantFullName,
                Application.ApplicationDate, clsTestType.GetTestTypeFees((int)_AppointementTestType), dtTestAppointenments.Rows.Count);
            scheduleTest.DataBack += frmScheduleTest_DataBack;
            scheduleTest.ShowDialog();
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dataGridViewTestApointements.CurrentRow.Cells[0].Value;
            bool IsLocked = (bool)dataGridViewTestApointements.CurrentRow.Cells[3].Value;
            if (!IsLocked)
                _ScheduleTest(TestAppointmentID);
            else
                MessageBox.Show("This Test Is Already Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
