using BusinessInternationalLicenses;
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
    public partial class frmShowDriverLicenseHistory : Form
    {
        clsPerson Person = new clsPerson();
        DataTable dtLocalLicenses = new DataTable();
        DataTable dtInternationalLicenses = new DataTable();
        public frmShowDriverLicenseHistory()
        {
            InitializeComponent();
        }
        public frmShowDriverLicenseHistory(string NationalNumber)
        {
            InitializeComponent();
            Person = clsPerson.FindPersonByNationalNumber(NationalNumber);
        }
        private void frmShowDriverLicenseHistory_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            btnFind.Enabled = false;

            if(Person != null && Person.ID != -1)
                _LoadFormInfo();
        }
        private void _LoadFormInfo()
        {
            _InitializePersonInfoControl();
            _IntializeDataGridsInfo();
            groupBoxFilter.Enabled = false;
        }
        private void _ResizedDataGridLocalLicenseTable()
        {
            dataGridViewLocalLicenses.Columns[0].Width = 100;
            dataGridViewLocalLicenses.Columns[1].Width = 100;
            dataGridViewLocalLicenses.Columns[2].Width = 200;
            dataGridViewLocalLicenses.Columns[3].Width = 200;
            dataGridViewLocalLicenses.Columns[4].Width = 100;
        }
        private void _ResizeDataGridInternationalLicenseTable()
        {
            dataGridViewIntenationalLicenses.Columns[0].Width = 100;
            dataGridViewIntenationalLicenses.Columns[1].Width = 100;
            dataGridViewIntenationalLicenses.Columns[2].Width = 250;
            dataGridViewIntenationalLicenses.Columns[3].Width = 200;
            dataGridViewIntenationalLicenses.Columns[4].Width = 100;
        }
        private void _IntializeDataGridsInfo()
        {
          
            dtLocalLicenses = clsLicense.GetPersonLicenses(Person.ID);
            dataGridViewLocalLicenses.DataSource = dtLocalLicenses;
            

            dtInternationalLicenses = clsInternationalLicense.GetPersonLicenses(Person.ID);
            dataGridViewIntenationalLicenses.DataSource = dtInternationalLicenses;
            
            
            //_ResizedDataGridLocalLicenseTable();
            //_ResizeDataGridInternationalLicenseTable();
        }
        private void _InitializePersonInfoControl()
        {
            ctrlPersonInfo1.LoadControlComponents(Person.ID);
        }
       
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = txtBoxFilter.Text.Length > 0;
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void _ShowMessage()
        {
            if (Person == null || Person.ID == -1)
                MessageBox.Show("Person Is Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            Person = comboBoxFilter.SelectedIndex == 0 ? clsPerson.FindPersonByNationalNumber(txtBoxFilter.Text) :
                clsPerson.FindPersonByID(Convert.ToInt32(txtBoxFilter.Text));
            _InitializePersonInfoControl();
            _IntializeDataGridsInfo();
            _ShowMessage();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson Addperson = new frmAddEditPerson(-1);
            Addperson.ShowDialog();
        }
        private void _ShowLocalLicenseInfo()
        {
            string ClassName = (string)dataGridViewLocalLicenses.CurrentRow.Cells[2].Value;
            int ApplicationID = (int)dataGridViewLocalLicenses.CurrentRow.Cells[1].Value;
            string NationalNo = clsPerson.GetPersonNationalNumberByAppID(ApplicationID);
            frmShowLicenseInfo License = new frmShowLicenseInfo(ApplicationID, ClassName, NationalNo);
            License.ShowDialog();
        }
        private void _ShowInternationalLicense()
        {
            int InternationalLicenseID = (int)dataGridViewIntenationalLicenses.CurrentRow.Cells[0].Value;
            int AppID = (int)dataGridViewIntenationalLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsPerson.GetPersonID(clsPerson.GetPersonNationalNumberByAppID(AppID));
            frmShowInternationalLicenseInfo InernationalLicense = new frmShowInternationalLicenseInfo(InternationalLicenseID, PersonID);
            InernationalLicense.ShowDialog();
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlLicenses.SelectedIndex == 0)
                _ShowLocalLicenseInfo();
            else
                _ShowInternationalLicense();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
