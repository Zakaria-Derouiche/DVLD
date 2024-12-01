using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;

namespace DVLD
{
    public partial class ctrlUserLoginInfo : UserControl
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public ctrlUserLoginInfo()
        {
            InitializeComponent();
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
        }
        public void InitializeComponentsValues()
        {
            lblUserID.Text = UserID == -1 ? "N/A" : UserID.ToString();
            txtBoxUserName.Text = UserName;
            txtBoxPassword.Text = "";
            txtBoxConfirmedPassword.Text = "";
            checkBoxActiveStatus.Checked = IsActive;
        }
        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar));
        }
        private void _SetError(CancelEventArgs e)
        {
            e.Cancel = true;
            txtBoxConfirmedPassword.Focus();
            errorProvider1.SetError(txtBoxConfirmedPassword, "Empty or Does Not Match");
        }
        private void _CancelError(CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(txtBoxConfirmedPassword, "");
        }
        private void txtBoxConfirmedPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxConfirmedPassword.Text) || txtBoxConfirmedPassword.Text != txtBoxPassword.Text)
                _SetError(e);
            else
                _CancelError(e);
        }
        public void GetControlInfo()
        {
            UserID = lblUserID.Text == "[???]" ? -1 : Convert.ToInt32(lblUserID.Text);
            UserName = txtBoxUserName.Text;
            Password = txtBoxPassword.Text;
            IsActive = checkBoxActiveStatus.Checked;
        }
        public bool CheckInputs(frmAddEditUser.enMode Mode)
        {
            string ErrorMessage = string.Empty;
            if(Mode == frmAddEditUser.enMode.Add)
            {
                return !string.IsNullOrEmpty(txtBoxUserName.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text)
                && !string.IsNullOrEmpty(txtBoxConfirmedPassword.Text) && txtBoxPassword.Text == txtBoxConfirmedPassword.Text &&
                !clsUser.IsUserExistsByUserName(txtBoxUserName.Text.Trim(), ref ErrorMessage);
            }
            return !string.IsNullOrEmpty(txtBoxUserName.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text)
                && !string.IsNullOrEmpty(txtBoxConfirmedPassword.Text) && txtBoxPassword.Text == txtBoxConfirmedPassword.Text;
        }
    }
}
