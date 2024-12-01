using BusinessInternationalLicenses;
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
    public partial class frmInternationalLicenseApplications : Form
    {
        DataTable dtInternationalLicenses = new DataTable();
        public frmInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewInternationalLicenseApplications.Columns[0].Width = 200;
            dataGridViewInternationalLicenseApplications.Columns[1].Width = 80;
            dataGridViewInternationalLicenseApplications.Columns[2].Width = 80;
            dataGridViewInternationalLicenseApplications.Columns[3].Width = 80;
            dataGridViewInternationalLicenseApplications.Columns[4].Width = 140;
            dataGridViewInternationalLicenseApplications.Columns[5].Width = 140;
            dataGridViewInternationalLicenseApplications.Columns[6].Width = 80;
        }
        private void frmInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            dtInternationalLicenses = clsInternationalLicense.GetAllLicenses();
            dataGridViewInternationalLicenseApplications.DataSource = dtInternationalLicenses;
            lblRecordsNumber.Text = dtInternationalLicenses.Rows.Count.ToString() + " Record(s)";
            _ResizeDataGridTable();
            comboBoxFiter.SelectedIndex = 0;
        }
        private void comboBoxFiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Visible = (comboBoxFiter.SelectedIndex != 0);
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void _DataGrindView_Filter()
        {
            DataTable dt = clsInternationalLicense.GetAllLicenses();
            dt.DefaultView.RowFilter = comboBoxFiter.Text + " = '" + txtBoxFilter.Text + "'";
            dt = dt.DefaultView.ToTable();
            dataGridViewInternationalLicenseApplications.DataSource = dt;
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewInternationalLicenseApplications.DataSource = dtInternationalLicenses;
            if (txtBoxFilter.Text != string.Empty)
                _DataGrindView_Filter();
            lblRecordsNumber.Text = dataGridViewInternationalLicenseApplications.Rows.Count.ToString() + " Record(s)";
        }
        private void frmAddInternationalLicenceApplication_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                frmInternationalLicenseApplications_Load(null, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenceApplication InternationalLicense = new frmAddInternationalLicenceApplication();
            InternationalLicense.DataBack += frmAddInternationalLicenceApplication_DataBack;
            InternationalLicense.ShowDialog();
        }
        private void showDriverDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dataGridViewInternationalLicenseApplications.CurrentRow.Cells[2].Value;
            clsPerson Person = clsPerson.FindPersonByDriverID(DriverID);
            frmDisplayPersonInfo PersonInfo = new frmDisplayPersonInfo(Person.ID);
            PersonInfo.ShowDialog();
        }
        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dataGridViewInternationalLicenseApplications.CurrentRow.Cells[2].Value;
            clsPerson Person = clsPerson.FindPersonByDriverID(DriverID);
            int InternationalLicenseID = (int)dataGridViewInternationalLicenseApplications.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo License = new frmShowInternationalLicenseInfo(InternationalLicenseID, Person.ID);
            License.ShowDialog();
        }
        private void showPersonDrivingLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dataGridViewInternationalLicenseApplications.CurrentRow.Cells[2].Value;
            clsPerson Person = clsPerson.FindPersonByDriverID(DriverID);
            frmShowDriverLicenseHistory History = new frmShowDriverLicenseHistory(Person.NationalNumber);
            History.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
