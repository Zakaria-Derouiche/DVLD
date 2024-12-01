using Encryption;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;

namespace DVLD
{
    public partial class frmAddEditUser : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        public enum enMode { Add, Edit };
        enMode _Mode;
        clsUser User = new clsUser();
        private bool _IsChanged;
        public frmAddEditUser(int PersonID)
        {
            InitializeComponent();
            bool IsUserExists = clsPerson.IsPersonExists(PersonID) && clsUser.IsUserExistsByPersonID(PersonID);
            User = IsUserExists ? clsUser.FindUserByPersonID(PersonID) : new clsUser();
            _Mode = IsUserExists ? enMode.Edit : enMode.Add;
            _IntializeComponentsValues();
        }
        private void _Refresh()
        {
            User = clsUser.FindUserByPersonID(User.PersonID);
            _IntializeComponentsValues();
        }
        private void _SendUserInfoToLoginControl()
        {
            ctrlUserLoginInfo1.UserID = User.UserID;
            ctrlUserLoginInfo1.UserName = User.UserName;
            ctrlUserLoginInfo1.Password = User.Password;
            ctrlUserLoginInfo1.IsActive = User.IsActive;
        }
        private void _InitializeUserForm()
        {
            _SendUserInfoToLoginControl();
            ctrlUserLoginInfo1.InitializeComponentsValues();
        }
        private void _IntializeComponentsValues()
        {
            comboBoxFilter.SelectedIndex = 0;
            this.Text = (_Mode == enMode.Add) ? "Add New User" : "Update User";
            lblTitle.Text = (_Mode == enMode.Add) ? "Add New User" : "Update User";
            ctrlPersonInfo1.LoadControlComponents(User.PersonID);
            groupBoxFilter.Enabled = _Mode == enMode.Add;
            if (_Mode == enMode.Edit)
                _InitializeUserForm();
        }
        private bool PersonIsUser()
        {
            return clsUser.IsUserExistsByPersonID(ctrlPersonInfo1.PersonID);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControlPersonInfo.SelectedIndex = _Mode == enMode.Add ? (User.Person.ID == -1 || PersonIsUser()) ? 0 : 1 : 1;
            if (PersonIsUser() && _Mode == enMode.Add)
                MessageBox.Show("Sorry, This User Is Already Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (comboBoxFilter.SelectedIndex == 0) ? (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) :
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }
        private void _SetError()
        {
            if (string.IsNullOrEmpty(txtBoxFilter.Text))
            {
                errorProviderFindBy.SetError(txtBoxFilter, "Empty");
                txtBoxFilter.Focus();
            }
            else
            {
                errorProviderFindBy.Clear();
            }
        }
        private bool _IsExistPerson()
        {
            return comboBoxFilter.SelectedIndex == 0 ? clsPerson.IsPersonExists(txtBoxFilter.Text) :
                clsPerson.IsPersonExists(Convert.ToInt32(txtBoxFilter.Text));
        }
        private void _GetPerson()
        {
            User.Person = _IsExistPerson() ? comboBoxFilter.SelectedIndex == 0 ? clsPerson.FindPersonByNationalNumber(txtBoxFilter.Text)
                : clsPerson.FindPersonByID(Convert.ToInt32(txtBoxFilter.Text)) : new clsPerson();
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilter.Text = string.Empty;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            txtBoxFilter.Text = txtBoxFilter.Text.Trim();
            _SetError();
            _GetPerson();
            ctrlPersonInfo1.LoadControlComponents(User.Person.ID);
            if (User.Person.ID == -1)
                MessageBox.Show("Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson Person = new frmAddEditPerson(-1);
            Person.DataBack += frmAddEditPerson_DataBack;
            Person.ShowDialog();
        }
        private void frmAddEditPerson_DataBack(object sender, bool IsSaved, int PersonID)
        {
            if (IsSaved)
                ctrlPersonInfo1.LoadControlComponents(User.PersonID);
        }
        private void _FillUserClassInfo()
        {
            User.PersonID = _Mode == enMode.Add ? ctrlPersonInfo1.PersonID : User.Person.ID;
            User.Person = _Mode == enMode.Add ? clsPerson.FindPersonByID(User.PersonID) : User.Person;
            User.UserName = ctrlUserLoginInfo1.UserName;
            User.Password = clsEncryption.GetHashValue(ctrlUserLoginInfo1.Password);
            User.IsActive = ctrlUserLoginInfo1.IsActive;
        }
        private void tabControlPersonInfo_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add && tabControlPersonInfo.SelectedIndex == 1 && clsUser.IsUserExistsByPersonID(User.Person.ID))
            {
                tabControlPersonInfo.SelectedIndex = 0;
                MessageBox.Show("User Is Already Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _DisplaySaveOperationResult(bool IsSaved)
        {
            if(!IsSaved)
            {
                MessageBox.Show("Failed Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("User " + _Mode.ToString() + "ed Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlUserLoginInfo1.UserID = User.UserID;
            ctrlUserLoginInfo1.InitializeComponentsValues();
            DataBack?.Invoke(this, IsSaved);
            _Mode = enMode.Edit;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlUserLoginInfo1.CheckInputs(_Mode))
            {
                ctrlUserLoginInfo1.GetControlInfo();
                _FillUserClassInfo();
                bool IsSaved = User.Save();
                _DisplaySaveOperationResult(IsSaved);
                ctrlUserLoginInfo1.InitializeComponentsValues();
            }
            else
            {
                MessageBox.Show("User Name Allready Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, _IsChanged);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
