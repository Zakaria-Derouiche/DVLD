using System.Data;
using PeopleBusiness;
using System.IO;
using UserBusiness;
using DriversBusiness;
using ApplicationsBusiness;

namespace DVLD
{
    public partial class frmPeopleInfo : Form
    {
        enum enMode { Add, Update };
        DataTable PeopleDataTable = new DataTable();
        public frmPeopleInfo()
        {
            InitializeComponent();
        }
        private void _ResizeDataGridTable()
        {
            dataGridViewPeople.Columns[0].Width = 95;
            dataGridViewPeople.Columns[1].Width = 95;
            dataGridViewPeople.Columns[2].Width = 95;
            dataGridViewPeople.Columns[3].Width = 100;
            dataGridViewPeople.Columns[4].Width = 95;
            dataGridViewPeople.Columns[5].Width = 95;
            dataGridViewPeople.Columns[6].Width = 95;
            dataGridViewPeople.Columns[7].Width = 95;
            dataGridViewPeople.Columns[8].Width = 170;
            dataGridViewPeople.Columns[9].Width = 180;
            dataGridViewPeople.Columns[10].Width = 100;
        }
        private void frmPeopleInfo_Load(object sender, EventArgs e)
        {
            _LoadPeopleInformations();
            _InitializeFormInfo();
        }
        private void _InitializeFormInfo()
        {
            this.Text = "People Informations";
            ComboBoxFilter.SelectedIndex = 0;
        }
        private void _LoadPeopleInformations()
        {
            PeopleDataTable = clsPerson.GetPeople();
            dataGridViewPeople.DataSource = PeopleDataTable;
            _ResizeDataGridTable();
            lblRecordsNumber.Text = PeopleDataTable.Rows.Count.ToString() + " " + "Record(s)";
        }    
        private void _RadioButton_Visibility()
        {
            radioButtonAll.Visible = ComboBoxFilter.SelectedIndex == 8;
            radioButtonMale.Visible = ComboBoxFilter.SelectedIndex == 8;
            radioButtonFemale.Visible = ComboBoxFilter.SelectedIndex == 8;
            pictureBoxRBMale.Visible = ComboBoxFilter.SelectedIndex == 8;
            pictureBoxRBFemale.Visible = ComboBoxFilter.SelectedIndex == 8;
        }        
        private void _txtBoxFilter_Visiblity()
        {
            txtBoxFilter.Visible = ComboBoxFilter.SelectedIndex != 0 && ComboBoxFilter.SelectedIndex != 8;
        }
        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Text = string.Empty;
            _RadioButton_Visibility();
            _txtBoxFilter_Visiblity();
        }
        private void dataGridView_FilterResult()
        {
            DataTable dt = clsPerson.GetPeople();
            dt.DefaultView.RowFilter = ComboBoxFilter.Text + "='" + txtBoxFilter.Text + "'";
            dt = dt.DefaultView.ToTable();
            dataGridViewPeople.DataSource = dt;
        }
        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPeople.DataSource = PeopleDataTable;
            if (txtBoxFilter.Text != string.Empty)
                dataGridView_FilterResult();
            lblRecordsNumber.Text = dataGridViewPeople.Rows.Count.ToString() + " Record(s)";
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxFilter.SelectedIndex == 1)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else if (ComboBoxFilter.SelectedIndex == 2)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else if (ComboBoxFilter.SelectedIndex == 9)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '+' &&
                    !txtBoxFilter.Text.Contains('+'));
            else if(ComboBoxFilter.SelectedIndex == 10)
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.' &&
                    !txtBoxFilter.Text.Contains('.')) && !(e.KeyChar == '@' &&  !txtBoxFilter.Text.Contains('@'));
            else
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void RadioButton_Checked(object sender, MouseEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            DataTable dt = clsPerson.GetPeople();
            if (rb.Text != "All" && rb.Checked)
            {
                dt.DefaultView.RowFilter = ComboBoxFilter.Text + "='" + rb.Text + "'";
                dt = dt.DefaultView.ToTable();
                dataGridViewPeople.DataSource = dt;
            }
            lblRecordsNumber.Text = dataGridViewPeople.Rows.Count.ToString() + " Records";
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            frmAddEditPerson AddEditPerson = new frmAddEditPerson(PersonID);
            AddEditPerson.DataBack += frmAddEditPerson_DataBack;
            AddEditPerson.ShowDialog();
        }
        private string _GetErrorMessage(string ErrorMessage)
        {
            return ErrorMessage.Contains("Users") ? "Denied Opersation, Because This person Is A User" :
                ErrorMessage.Contains("Drivers") ? "Denied Opersation, Because This person Is A Driver" :
                ErrorMessage.Contains("Drivers") ? "Denied Opersation, Because This person Has An Application"
                : "Unknown Error";
        }
        private void _DisplayResult(bool IsDeleted, string ErrorMessage)
        {
            string Message = IsDeleted ? "Successfull Operation" :  _GetErrorMessage(ErrorMessage);
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ( IsDeleted)
                _LoadPeopleInformations();
        }
        private void _DeletePerson()
        {
            int PersonID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            string ErrorMessage = string.Empty;
            bool IsDeleted = clsPerson.DeletePerson(PersonID, ref ErrorMessage);
            _DisplayResult(IsDeleted, ErrorMessage);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _DeletePerson();
        }
        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson AddEditPerson = new frmAddEditPerson(-1);
            AddEditPerson.DataBack += frmAddEditPerson_DataBack;
            AddEditPerson.ShowDialog();
        }
        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            frmDisplayPersonInfo DisplayInfo = new frmDisplayPersonInfo(PersonID);
            DisplayInfo.DataBack += frmDisplayForm_DataBack;
            DisplayInfo.ShowDialog();
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Service Is Unavilable Right Now", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Service Is Unavilable Right Now", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmDisplayForm_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                _LoadPeopleInformations();
        }
        private void frmAddEditPerson_DataBack(object sender, bool IsSaved, int PersonID)
        {
            if (IsSaved)
                _LoadPeopleInformations();
        }
        private void btnAddNewPerson_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson AddEditPerson = new frmAddEditPerson(-1);
            AddEditPerson.DataBack += frmAddEditPerson_DataBack;
            AddEditPerson.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
