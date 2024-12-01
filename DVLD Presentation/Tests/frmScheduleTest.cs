using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Global;
using TestAppointementsBusiness;
using TestsBusiness;

namespace DVLD
{
    public partial class frmScheduleTest : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        frmAppointment.enAppointementTestType _TestType;
        int _TestAppointmentID;
        public frmScheduleTest(int TestAppointmentID, frmAppointment.enAppointementTestType TestType, int LocalDrivingLicenseApplicationID, string LicenseClass,
            string ApplicantFullName, DateTime TestAppointmentDate, decimal TestFees, int Trial)
        {
            InitializeComponent();
            _TestType = TestType;
            _TestAppointmentID = TestAppointmentID;
            _InitializeComponenetsValues(TestAppointmentID, LocalDrivingLicenseApplicationID, LicenseClass, ApplicantFullName,
                TestAppointmentDate, TestFees, Trial);
        }
        private void _InitializeComponenetsValues(int TestAppointmentID, int LocalDrivingLicenseApplicationID, string LicenseClass,
            string ApplicantFullName, DateTime TestAppointmentDate, decimal TestFees, int Trial)
        {
            lblLocalDrivingLicenseApplicationID.Text = LocalDrivingLicenseApplicationID.ToString();
            lblDrivingLicenseClass.Text = LicenseClass.ToString();
            lblFullName.Text = ApplicantFullName.ToString();
            lblTrial.Text = Trial.ToString();
            lblTestDate.Text = TestAppointmentDate.ToString();
            lblTestFees.Text = TestFees.ToString();
            groupBoxTitle.Text = _TestType.ToString() + " Test";
        }
        private void txtBoxNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void InitializePicBoxTitleForm()
        {
            switch (_TestType)
            {
                case frmAppointment.enAppointementTestType.Vision:
                    picBoxTitleForm.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\eye.png";
                    break;
                case frmAppointment.enAppointementTestType.Written:
                    picBoxTitleForm.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\essay (1).png";
                    break;
                case frmAppointment.enAppointementTestType.Street:
                    picBoxTitleForm.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\DrivingTest.png";
                    break;
            }
        }
        private bool _CheckInputs()
        {
            return radioButtonPass.Checked || radioButtonFail.Checked;
        }

        private void _ShowSecheduleResult(bool IsTestAdded, bool IsTestLocked)
        {
            string Message = IsTestAdded ? "Test Sechduled Successefully" : "Test Is Not Secheduled";
            Message += !IsTestLocked ? ", Test Is Not Locked" : "";
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
        }
        private void _SecheduleTest(bool TestResult,string Notes,int TestID)
        {
            bool IsTestAdded = clsTest.AddTest(ref TestID, _TestAppointmentID, TestResult, Notes, clsProjectSettings.CurrentUser.UserID);
            bool IsTestLocked = clsAppointment.LockTestAppointment(_TestAppointmentID);
            btnSave.Enabled = !IsTestAdded;
            DataBack?.Invoke(this, IsTestAdded);
            _ShowSecheduleResult(IsTestAdded, IsTestLocked);
        }
        private void _AddTest()
        {
            bool TestResult = (radioButtonPass.Checked);
            string Notes = txtBoxNotes.Text.Trim();
            int TestID = -1;
            _SecheduleTest(TestResult, Notes,TestID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if(_CheckInputs())
                _AddTest();
           else
                MessageBox.Show("Put The Test Result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
