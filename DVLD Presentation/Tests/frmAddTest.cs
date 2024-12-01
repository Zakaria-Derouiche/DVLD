using LocalApplicationsBusiness;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using TestAppointementsBusiness;
using TestsBusiness;
using TestsTypesBusiness;
using static DVLD.frmAddTest;

namespace DVLD
{
    public partial class frmAddTest : Form
    {
        public delegate void DataBackHandler(object sender, bool isSaved);
        public event DataBackHandler DataBack = delegate { };
        public enum enTestMode { Take, Retake };
        private enTestMode _TestMode;
        private int _TestTypeID;
        private int _CreatedByUserID;
        private int _LocalApplicationID;
        clsAppointment TestAppointment = new clsAppointment();
        public frmAddTest(int TestAppointmentID, frmAppointment.enAppointementTestType TestType, enTestMode TestMode,
            int LocalDrivinApplicationID, string LicenseClass, string ApplicantFullName, byte TrialNumber,
            int CreatedByUserID, bool IsLocked)
        {
            InitializeComponent();
            _InitializeValues(TestAppointmentID, TestType, TestMode, CreatedByUserID);
            _InitializeComponentsValues(TestType, LocalDrivinApplicationID, LicenseClass, ApplicantFullName, TrialNumber, IsLocked);

        }
        private void _InitializeValues(int TestAppointmentID, frmAppointment.enAppointementTestType TestType, enTestMode TestMode,
            int CreatedByUserID)
        {
            TestAppointment = (TestAppointmentID != -1) ? clsAppointment.FindAppointment(TestAppointmentID) : new clsAppointment();
            _TestMode = TestMode;
            _TestTypeID = (int)TestType;
            _CreatedByUserID = CreatedByUserID;
            dateTimePickerTestDate.MinDate = DateTime.Now + new TimeSpan(1, 0, 0, 0);
        }
        private void _InitializeComponentsValues(frmAppointment.enAppointementTestType TestType, int LocalDrivinApplicationID,
            string LicenseClass, string ApplicantFullName, byte TrialNumber, bool IsLocked)
        {
            _LocalApplicationID = LocalDrivinApplicationID;
            groupBoxTestType.Enabled = !IsLocked;
            lblTitle.Text = (_TestMode == enTestMode.Take) ? "Take Test" : "Reatke Test";
            lblTitle.Location = (_TestMode == enTestMode.Take) ?  new Point(295, 112) : new Point(285, 112);
            groupBoxRetakeTestInfo.Enabled = (_TestMode == enTestMode.Take) ? false : true;
            lblLocalDLAppID.Text = LocalDrivinApplicationID.ToString();
            lblDrivingLicenseClass.Text = LicenseClass.ToString();
            lblApplicantName.Text = ApplicantFullName.ToString();
            lblTrialNumber.Text = TrialNumber.ToString();
            lblTestFees.Text = clsTestType.GetTestTypeFees((int)TestType).ToString();
            dateTimePickerTestDate.MinDate = DateTime.Now;
            picBoxFormImage_LoadImage(TestType);
            _InititializeRetakeGroupBox();
        }
        private void picBoxFormImage_LoadImage(frmAppointment.enAppointementTestType TestType)
        {
            picBoxFormImage.ImageLocation = TestType == frmAppointment.enAppointementTestType.Vision ?
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\TestEye.png" :
                TestType == frmAppointment.enAppointementTestType.Written ?
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\essay (1).png" :
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\DrivingTest.png";
        }
        private void _InitializeTest()
        {
            TestAppointment.LocalDrivingLicenseApplicationID = Convert.ToInt32(lblLocalDLAppID.Text);
            TestAppointment.PaidFees = clsTestType.GetTestTypeFees(_TestTypeID);
            TestAppointment.TestTypeID = _TestTypeID;
            TestAppointment.IsLocked = false;
            TestAppointment.CreatedByUserID = _CreatedByUserID;
        }
        private void _SetSaveChangements()
        {
            btnSave.Enabled = false;
            DataBack?.Invoke(this, true);
            MessageBox.Show("Test Appointment Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _ShowSaveResult()
        {
            bool IsSaved = TestAppointment.Save();
            if (IsSaved)
                _SetSaveChangements(); 
            else
                MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _SaveTest()
        {
            if (_CheckTest())
                _ShowSaveResult();
            else
                MessageBox.Show("Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }              
        private bool _CheckTest()
        {
            return !clsAppointment.IsExistsOrPassedTestAppoitment(_LocalApplicationID, _TestTypeID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TestAppointment.AppointmentID == -1)
                _InitializeTest();
            TestAppointment.AppointmentDate = dateTimePickerTestDate.Value;
           _SaveTest();
        }
        private void _InititializeRetakeGroupBox()
        {
            lblTotalFees.Text = _TestMode == enTestMode.Take ? lblTestFees.Text :
                (Convert.ToDecimal(lblTestFees.Text) + 5).ToString();
            lblRetakeAppFees.Text = _TestMode == enTestMode.Take ? "0" : "5";
            lblRetakeTestAppID.Text = "N/A";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
