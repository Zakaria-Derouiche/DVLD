using ApplicationsBusiness;
using LicensesBusiness;
using LocalApplicationsBusiness;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        DataTable dtLocalApplication = new DataTable();
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewLocalApplications.Columns[0].Width = 100;
            dataGridViewLocalApplications.Columns[1].Width = 150;
            dataGridViewLocalApplications.Columns[2].Width = 100;
            dataGridViewLocalApplications.Columns[3].Width = 250;
            dataGridViewLocalApplications.Columns[4].Width = 100;
            dataGridViewLocalApplications.Columns[5].Width = 100;
            dataGridViewLocalApplications.Columns[6].Width = 100;
        }
        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadDataGridInfo();
            this.Text = "Local Driving License Applications";
            comboBoxFilter.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
        }
        private void _LoadDataGridInfo(bool IsSaved = true)
        {
            dtLocalApplication = clsLocalApplications.GetLocalApplications();
            dataGridViewLocalApplications.DataSource = dtLocalApplication;
            _ResizeDataGridTable();
            lblRecordNumber.Text = dataGridViewLocalApplications.Rows.Count.ToString() + " Records";
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Visible = (comboBoxFilter.SelectedIndex != 0 && comboBoxFilter.SelectedIndex != 4);
            comboBoxStatus.Visible = (comboBoxFilter.SelectedIndex == 4);
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (comboBoxFilter.SelectedIndex)
            {
                case 1:
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                    break;
                case 2:
                    e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                    break;
                case 3:
                    e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
                    break;
            }
        }
        private void _FilterDataGridViewResultsByTextBoxFilterText()
        {
            DataTable dt = clsLocalApplications.GetLocalApplications();
            dt.DefaultView.RowFilter = comboBoxFilter.SelectedIndex == 1 ?
                string.Format("[{0}] = {1}", comboBoxFilter.Text, txtBoxFilter.Text.Trim()) :
                string.Format("[{0}] Like '{1}%'", comboBoxFilter.Text, txtBoxFilter.Text.Trim());
            dt = dt.DefaultView.ToTable();
            dataGridViewLocalApplications.DataSource = dt;
            lblRecordNumber.Text = dt.Rows.Count.ToString() + " Records";
        }
        private void _FilterDataGridViewResultsByComboBoxStatus()
        {
            DataTable dt = clsLocalApplications.GetLocalApplications();
            dt.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", comboBoxFilter.Text, comboBoxStatus.Text.Trim());
            dt = dt.DefaultView.ToTable();
            dataGridViewLocalApplications.DataSource = dt;
            lblRecordNumber.Text = dt.Rows.Count.ToString() + " Records";
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewLocalApplications.DataSource = dtLocalApplication;
            if (txtBoxFilter.Text != string.Empty)
                _FilterDataGridViewResultsByTextBoxFilterText();
        }
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewLocalApplications.DataSource = dtLocalApplication;
            if (comboBoxFilter.SelectedIndex == 4 && comboBoxStatus.SelectedIndex != 0)
                _FilterDataGridViewResultsByComboBoxStatus();
        }
        private void frmDrivingLicenseApplication_DataBack(object sender, bool IsAdded)
        {
            if (IsAdded)
                _LoadDataGridInfo();
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            int ApplicationID = clsLocalApplications.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseID);
            bool IsDeleted = (clsLocalApplications.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseID)
                && clsApplication.DeleteApplication(ApplicationID));
            MessageBox_Show(IsDeleted);
            _LoadDataGridInfo(IsDeleted);
        }
        private void MessageBox_Show(bool IsTrue)
        {
            string Message = IsTrue ? "Successfull Operation" : "Failed Operation";
            MessageBoxIcon icon = IsTrue ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, icon);
        }
        private int _GetApplicationID(int LocalApplicationID)
        {
            return clsLocalApplications.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalApplicationID);
        }
        private bool _IsLicenseIssued(int ApplicationID)
        {
            return clsLicense.IsLicenseExists(ApplicationID);
        }
        private void _DisableContextMenuStripViewItems()
        {
            foreach (ToolStripItem Item in contextMenuStripLocalApplications.Items)
                Item.Enabled = false;
        }
        private void _NewApplicationContextMenuStripView(int ApplicationID, int PassedTests)
        {
            bool IsIssued = _IsLicenseIssued(ApplicationID);
            for (Byte i = 0; i < contextMenuStripLocalApplications.Items.Count; i++)
            {
                if (i == 4)
                    contextMenuStripLocalApplications.Items[i].Enabled = PassedTests == 3  && !IsIssued;
                else if (i == 5)
                    contextMenuStripLocalApplications.Items[i].Enabled = IsIssued;
                else
                    contextMenuStripLocalApplications.Items[i].Enabled = true;
            }
        }
        private void _CompletedApplicationConytextMenuStripView(int ApplicationID)
        {
            for (Byte i = 0; i < contextMenuStripLocalApplications.Items.Count; i++)
            {
                if (i == 0 || i == 6)
                    contextMenuStripLocalApplications.Items[i].Enabled = true;
                else if (i == 4)
                    contextMenuStripLocalApplications.Items[i].Enabled = !_IsLicenseIssued(ApplicationID);
                else if (i == 5)
                    contextMenuStripLocalApplications.Items[i].Enabled = _IsLicenseIssued(ApplicationID);
                else
                    contextMenuStripLocalApplications.Items[i].Enabled = false;
            }
        }
        private void contextMenuStripLocalApplications_Opened(object sender, EventArgs e)
        {
            string ApplicationStatus = (string)dataGridViewLocalApplications.CurrentRow.Cells[6].Value;
            int ApplicationID = _GetApplicationID((int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value);
            int PassedTests = (int)dataGridViewLocalApplications.CurrentRow.Cells[5].Value;
            switch (ApplicationStatus)
            {
                case "Canceled":
                    _DisableContextMenuStripViewItems();
                    break;
                case "New":
                    _NewApplicationContextMenuStripView(ApplicationID, PassedTests);
                    break;
                case "Completed":
                    _CompletedApplicationConytextMenuStripView(ApplicationID);
                    break;
            }
        }
        private void _ScheduleTestDropDownList(int PassedTests)
        {
            for (byte i = 0; i < sechduleTestsToolStripMenuItem.DropDownItems.Count; i++)
                sechduleTestsToolStripMenuItem.DropDownItems[i].Enabled = i == PassedTests;
        }
        private void sechduleTestsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            int TestPassed = (int)dataGridViewLocalApplications.CurrentRow.Cells[5].Value;
            _ScheduleTestDropDownList(TestPassed);
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            int ApplicationID = clsLocalApplications.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseID);
            bool IsCanceled = clsApplication.CancelApplication(ApplicationID);
            MessageBox_Show(IsCanceled);
            _LoadDataGridInfo(IsCanceled);
        }
        private void _PrepareAppointment(frmAppointment.enAppointementTestType TestType)
        {
            int LocalDrivingLicenseApplicationID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            string ClassName = (string)dataGridViewLocalApplications.CurrentRow.Cells[1].Value;
            string ApplicantFullName = (string)dataGridViewLocalApplications.CurrentRow.Cells[3].Value;
            DateTime ApplicationDate = (DateTime)dataGridViewLocalApplications.CurrentRow.Cells[4].Value;
            int PassedTests = (int)dataGridViewLocalApplications.CurrentRow.Cells[5].Value;
            string Status = (string)dataGridViewLocalApplications.CurrentRow.Cells[6].Value;
            _ShowAppointmentForm(TestType, LocalDrivingLicenseApplicationID, ClassName,  ApplicantFullName, ApplicationDate, 
                PassedTests, Status);
        }
        private void _ShowAppointmentForm(frmAppointment.enAppointementTestType TestType, int LocalDrivingLicenseApplicationID,
            string ClassName, string ApplicantFullName, DateTime ApplicationDate, int PassedTests, string Status)
        {
            frmAppointment VisionAppointement = new frmAppointment(TestType,LocalDrivingLicenseApplicationID, ClassName,
                ApplicantFullName, ApplicationDate, PassedTests, Status);
            VisionAppointement.DataBack += frmAppointment_DataBack;
            VisionAppointement.ShowDialog();
        }
        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _PrepareAppointment(frmAppointment.enAppointementTestType.Vision);
        }
        private void writtingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _PrepareAppointment(frmAppointment.enAppointementTestType.Written);
        }
        private void drivingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _PrepareAppointment(frmAppointment.enAppointementTestType.Street);
        }
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            string ClassName = (string)dataGridViewLocalApplications.CurrentRow.Cells[1].Value;
            string ApplicantFullName = (string)dataGridViewLocalApplications.CurrentRow.Cells[3].Value;
            DateTime ApplicationDate = (DateTime)dataGridViewLocalApplications.CurrentRow.Cells[4].Value;
            int PassedTests = (int)dataGridViewLocalApplications.CurrentRow.Cells[5].Value;
            string Status = (string)dataGridViewLocalApplications.CurrentRow.Cells[6].Value;
            frmShowApplicationDetails ApplicationDetails = new frmShowApplicationDetails(LocalDrivingLicenseApplicationID, ClassName, 
                ApplicantFullName, ApplicationDate, PassedTests, Status);
            ApplicationDetails.ShowDialog();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivinLicesnApplication = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            int ApplicationID = clsLocalApplications.GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivinLicesnApplication);
            string DrivingClass = (string)dataGridViewLocalApplications.CurrentRow.Cells[1].Value;
            string NationalNumber = (string)dataGridViewLocalApplications.CurrentRow.Cells[2].Value;
            frmShowLicenseInfo License = new frmShowLicenseInfo(ApplicationID, DrivingClass, NationalNumber);
            License.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dataGridViewLocalApplications.CurrentRow.Cells[2].Value;
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(NationalNumber);
            History.ShowDialog();
        }
        private void _IssuingDrivingLicense()
        {
            int PassedTests = (int)dataGridViewLocalApplications.CurrentRow.Cells[5].Value;
            int LocalDrivingLicenseApplicationID = (int)dataGridViewLocalApplications.CurrentRow.Cells[0].Value;
            string ClassName = (string)dataGridViewLocalApplications.CurrentRow.Cells[1].Value;
            string ApplicantFullName = (string)dataGridViewLocalApplications.CurrentRow.Cells[3].Value;
            DateTime ApplicationDate = (DateTime)dataGridViewLocalApplications.CurrentRow.Cells[4].Value;
            string Status = (string)dataGridViewLocalApplications.CurrentRow.Cells[6].Value;
            _ShowIssuingDrivingLicenseForm(LocalDrivingLicenseApplicationID, ClassName, ApplicantFullName, ApplicationDate,
                PassedTests, Status);
        }
        private void _ShowIssuingDrivingLicenseForm(int LocalDrivingLicenseApplicationID,string ClassName, string ApplicantFullName,
            DateTime ApplicationDate, int PassedTests, string Status)
        {
            frmIssueDrivingLicense NewDrivingLicense = new frmIssueDrivingLicense(LocalDrivingLicenseApplicationID, ClassName,
                ApplicantFullName, ApplicationDate, PassedTests, Status);
            NewDrivingLicense.DataBack += frmIssueDrivingLicense_DataBack;
            NewDrivingLicense.ShowDialog();
        }
        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IssuingDrivingLicense();
        }
        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseApplication newApplication =
                new frmDrivingLicenseApplication(frmDrivingLicenseApplication.enApplicationType.NewLocalDL);
            newApplication.DataBack += frmDrivingLicenseApplication_DataBack;
            newApplication.ShowDialog();
        }
        private void frmAppointment_DataBack(object sender, bool IsPassTest)
        {
            if (IsPassTest)
                _LoadDataGridInfo();
        }
        private void frmIssueDrivingLicense_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                _LoadDataGridInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
