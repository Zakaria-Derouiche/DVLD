using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationsBusiness;

namespace DVLD
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable ApplicationTypes = new DataTable();
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _InitializeForm();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewApplicationTypes.Columns[0].Width = 150;
            dataGridViewApplicationTypes.Columns[1].Width = 500;
            dataGridViewApplicationTypes.Columns[2].Width = 150;
        }
        private void _InitializeForm()
        {
            ApplicationTypes = clsApplicationTypes.GetApplicationTypes();
            dataGridViewApplicationTypes.DataSource = ApplicationTypes;
            _ResizeDataGridTable();
            lblRecordsNumber.Text = ApplicationTypes.Rows.Count.ToString() + " Records";
        }
        private void frmEditApplicationType_DataBack(object sender, bool IsChanged)
        {
            if (IsChanged)
                _InitializeForm();
        }
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = (int)dataGridViewApplicationTypes.CurrentRow.Cells[0].Value;
            string ApplicationTypeName = (string)dataGridViewApplicationTypes.CurrentRow.Cells[1].Value;
            decimal Fees = (decimal)dataGridViewApplicationTypes.CurrentRow.Cells[2].Value;
            frmEditApplicationType AppType = new frmEditApplicationType(ApplicationTypeID, ApplicationTypeName, Fees);
            AppType.DataBack += frmEditApplicationType_DataBack;
            AppType.ShowDialog();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
