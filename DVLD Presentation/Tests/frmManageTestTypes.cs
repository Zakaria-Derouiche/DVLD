using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsTypesBusiness;

namespace DVLD
{
    public partial class frmManageTestTypes : Form
    {
        DataTable dtTestsTypesInfo = new DataTable();
        public frmManageTestTypes()
        {
            InitializeComponent();
        } 
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestsTypes();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewTestsTypes.Columns[0].Width = 90;
            dataGridViewTestsTypes.Columns[1].Width = 170;
            dataGridViewTestsTypes.Columns[2].Width = 530;
            dataGridViewTestsTypes.Columns[3].Width = 100;
        }
        private void _LoadTestsTypes()
        {
            dtTestsTypesInfo = clsTestType.GetAllTestsTypeInfo();
            dataGridViewTestsTypes.DataSource = dtTestsTypesInfo;
            _ResizeDataGridTable();
            lblRecordNumbers.Text = dtTestsTypesInfo.Rows.Count.ToString() + " Records";
        }
        private void frmEditTestType_DataBack(object sender, bool IsChanged)
        {
            if (IsChanged)
                _LoadTestsTypes();
        }
        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dataGridViewTestsTypes.CurrentRow.Cells[0].Value;
            string TestTypeTitle = (string)dataGridViewTestsTypes.CurrentRow.Cells[1].Value;
            string TestTypeDescription = (string)dataGridViewTestsTypes.CurrentRow.Cells[2].Value;
            decimal TestTypeFees = (decimal)dataGridViewTestsTypes.CurrentRow.Cells[3].Value;
            frmEditTestType TestType = new frmEditTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            TestType.DataBack += frmEditTestType_DataBack;
            TestType.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}