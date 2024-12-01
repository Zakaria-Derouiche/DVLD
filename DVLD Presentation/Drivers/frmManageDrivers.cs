using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DriversBusiness;
using LocalApplicationsBusiness;


namespace DVLD
{
    public partial class frmManageDrivers : Form
    {
        private DataTable dtDrivers = new DataTable();
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewDrivers.Columns[0].Width = 80;
            dataGridViewDrivers.Columns[1].Width = 80;
            dataGridViewDrivers.Columns[2].Width = 80;
            dataGridViewDrivers.Columns[3].Width = 250;
            dataGridViewDrivers.Columns[4].Width = 100;
            dataGridViewDrivers.Columns[5].Width = 80;
        }
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _LoadDataToDataGridView();
            comboBoxFilterType.SelectedIndex = 0;
        }
        private void _LoadDataToDataGridView()
        {
            dtDrivers = clsDriver.GetAllDrivers();
            dataGridViewDrivers.DataSource = dtDrivers;
            _ResizeDataGridTable();
            lblRecordNumbers.Text = dtDrivers.Rows.Count.ToString() + " Record(s)";
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (comboBoxFilterType.SelectedIndex == 3) ? !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) :
                !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Text = string.Empty;
            txtBoxFilter.Visible = (comboBoxFilterType.SelectedIndex != 0);
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDrivers.DataSource = clsDriver.GetAllDrivers();
            if (txtBoxFilter.Text != string.Empty)
            {
                DataTable dt = dtDrivers;
                dt.DefaultView.RowFilter = "[" + comboBoxFilterType.Text + "]='" + txtBoxFilter.Text + "'";
                dt = dt.DefaultView.ToTable();
                dataGridViewDrivers.DataSource = dt;

                lblRecordNumbers.Text = dt.Rows.Count.ToString() + " Record(s)";
            }
            else
            {
                lblRecordNumbers.Text = dtDrivers.Rows.Count.ToString() + " Record(s)";
            }
        }
        private void frmDisplayPersonInfo_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                _LoadDataToDataGridView();
        }
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridViewDrivers.CurrentRow.Cells[1].Value;
            frmDisplayPersonInfo PersonInfo = new frmDisplayPersonInfo(PersonID);
            PersonInfo.DataBack += frmDisplayPersonInfo_DataBack;
            PersonInfo.ShowDialog();

        }
        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dataGridViewDrivers.CurrentRow.Cells[2].Value;
            frmShowDriverLicenseHistory history = new frmShowDriverLicenseHistory(NationalNumber);
            history.ShowDialog();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
