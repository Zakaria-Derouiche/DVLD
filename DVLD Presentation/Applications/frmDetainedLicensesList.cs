using ApplicationsBusiness;
using DetainedLicensesBusiness;
using DriversBusiness;
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

namespace DVLD
{
    public partial class frmdetainedLicensesList : Form
    {
        DataTable dtDetainedLicenses = new DataTable();
        public frmdetainedLicensesList()
        {
            InitializeComponent();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewDetainedLicenses.Columns[0].Width = 80;
            dataGridViewDetainedLicenses.Columns[1].Width = 80;
            dataGridViewDetainedLicenses.Columns[2].Width = 80;
            dataGridViewDetainedLicenses.Columns[3].Width = 80;
            dataGridViewDetainedLicenses.Columns[4].Width = 80;
            dataGridViewDetainedLicenses.Columns[5].Width = 80;
            dataGridViewDetainedLicenses.Columns[6].Width = 80;
            dataGridViewDetainedLicenses.Columns[7].Width = 200;
            dataGridViewDetainedLicenses.Columns[8].Width = 80;
        }
        private void _LoadDataGridListInfo()
        {
            dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicense();
            dataGridViewDetainedLicenses.DataSource = dtDetainedLicenses;
            _ResizeDataGridTable();
            lblRecordsNumber.Text = dtDetainedLicenses.Rows.Count.ToString() + " Record(s)";
        }
        private void frmdetainedLicensesList_Load(object sender, EventArgs e)
        {
            _LoadDataGridListInfo();
            comboBoxFilter.SelectedIndex = 0;
        }     
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            int SelectedIndex = comboBoxFilter.SelectedIndex;
            e.Handled = SelectedIndex == 4 ? !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                : (SelectedIndex == 1 || SelectedIndex == 4) ? !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) :
                !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void TextBoxRadioButtonVisibility(bool TextBoxVisibility, bool RadioButtonsVisibility)
        {
            txtBoxFilter.Visible = TextBoxVisibility;
            rbYes.Visible = rbNo.Visible = RadioButtonsVisibility;
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Text = string.Empty;
            if (comboBoxFilter.SelectedIndex == 0)
                TextBoxRadioButtonVisibility(false, false);
            else if (comboBoxFilter.SelectedIndex == 2)
                TextBoxRadioButtonVisibility(false, true);
            else
                TextBoxRadioButtonVisibility(true, false);
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDetainedLicenses.DataSource = dtDetainedLicenses;
            if (!string.IsNullOrEmpty(txtBoxFilter.Text))
            {
                DataTable dt = clsDetainedLicense.GetAllDetainedLicense();
                dt.DefaultView.RowFilter = "[" + comboBoxFilter.Text + "]='" + txtBoxFilter.Text + "'";
                dt = dt.DefaultView.ToTable();
                dataGridViewDetainedLicenses.DataSource = dt;
            }
            lblRecordsNumber.Text = dataGridViewDetainedLicenses.Rows.Count.ToString() + " Record(s)";
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            bool IsReleased = rb.Text == "Yes";
            if (rb.Checked)
            {
                DataTable dt = dtDetainedLicenses;
                dt.DefaultView.RowFilter = "[" + comboBoxFilter.Text + "] = '" + IsReleased + "'";
                dt = dt.DefaultView.ToTable();
                dataGridViewDetainedLicenses.DataSource = dt;
            }
            lblRecordsNumber.Text = dataGridViewDetainedLicenses.Rows.Count.ToString() + " Record(s)";
        }
        private void frmDetainLicense_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                _LoadDataGridListInfo();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.DataBack += frmDetainLicense_DataBack;
            DetainLicense.ShowDialog();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense();
            ReleaseLicense.DataBack += frmReleaseLicense_DataBack;
            ReleaseLicense.ShowDialog();
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dataGridViewDetainedLicenses.CurrentRow.Cells[6].Value;
            frmDisplayPersonInfo PersonInfo = new frmDisplayPersonInfo(NationalNumber);
            PersonInfo.ShowDialog();
        }
        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dataGridViewDetainedLicenses.CurrentRow.Cells[6].Value;
            int LicenseID = (int)dataGridViewDetainedLicenses.CurrentRow.Cells[1].Value;
            int LicenseClassID = clsLicense.GetLicenseClassID(LicenseID);
            string ClassName = clsLicenseClass.GetLicenseName(LicenseClassID);
            int ApplicationID = clsLicense.GetLicenseApplicationID(LicenseID);
            frmShowLicenseInfo LicenseInfo = new frmShowLicenseInfo(ApplicationID, ClassName, NationalNumber);
            LicenseInfo.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dataGridViewDetainedLicenses.CurrentRow.Cells[6].Value;
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(NationalNumber);
            History.ShowDialog();
        }
        private void frmReleaseLicense_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                _LoadDataGridListInfo();
        }
        private void releaseDetainedLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dataGridViewDetainedLicenses.CurrentRow.Cells[1].Value;
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense(LicenseID);
            ReleaseLicense.DataBack += frmReleaseLicense_DataBack;
            ReleaseLicense.ShowDialog();
        }
        private void contextMenuStripList_Opened(object sender, EventArgs e)
        {
            bool IsReleased = (bool)dataGridViewDetainedLicenses.CurrentRow.Cells[3].Value;
            contextMenuStripList.Items[3].Enabled = !IsReleased;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
