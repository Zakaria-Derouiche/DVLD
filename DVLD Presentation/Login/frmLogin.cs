using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;
using DatabaseSetting;
using Encryption;
namespace DVLD
{
    public partial class frmLogin : Form
    {
        private string _UserName = string.Empty;
        private string _Password = string.Empty;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login";
        }
        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtBoxUserName.Focus();
        }
        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar));
        }
        //private void _FillLastLoginInfoFromFile()
        //{
        //    string file = @"C:\Users\THINK15-G4\source\repos\DVLD\Login.txt";
        //    if (File.Exists(file))
        //    {
        //        string LoginText = File.ReadAllText(file);
        //        if (LoginText != string.Empty)
        //        {
        //            string[] Login;
        //            Login = LoginText.Split("//##//", 3);
        //            txtBoxUserName.Text = Login[0];
        //            txtBoxPassword.Text = Login[1];
        //            checkBoxRememberMe.Checked = (Login[2] == "1") ? true : false;
        //        }
        //    }
        //}
        private void _FillLastLoginInfoFromRegistry(string UserName)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            try
            {
                string Password = Registry.GetValue(KeyPath, UserName, null) as string;
                if (Password != null)
                {
                    txtBoxUserName.Text = UserName;
                    txtBoxPassword.Text = Password;
                   _CleanLoginInfoFromRegistry(UserName);
                }
                else
                {
                    _EmptyLoginFormCredientials();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void _SaveLoginInfoToRegistry()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            try
            {
                string Password = Registry.GetValue(KeyPath, _UserName, null) as string;
                if (Password == null) {
                    try
                    {
                        Registry.SetValue(KeyPath, _UserName, _Password, RegistryValueKind.String);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        //private void _SaveLoginCredientialOnFile()
        //{

        //    string file = @"C:\Users\THINK15-G4\source\repos\DVLD\Login.txt";
        //    if (File.Exists(file))
        //    {
        //        string LoginText = _UserName + "//##//" + _Password;
        //        LoginText += (checkBoxRememberMe.Checked) ? "//##//1" : "//##//0";
        //        File.WriteAllText(file, LoginText);
        //    }
        //}
        //private void _CleanLoginCredientialFromFile()
        //{

        //    string file = @"C:\Users\THINK15-G4\source\repos\DVLD\Login.txt";
        //    if (File.Exists(file))
        //        File.WriteAllText(file, string.Empty);
        //}
        private void _CleanLoginInfoFromRegistry(string UserName)
        {
            string KeyPath = @"Software\DVLD";
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(KeyPath, true))
            {
                if (Key != null)
                {
                    Key.DeleteValue(UserName);
                }
                else
                {
                    MessageBox.Show("Key Is Not Exist");
                }
            }
        }
        private bool _CheckInputsValidity(ref string ErrorMessage)
        {
            bool IsValid = !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_Password);
            ErrorMessage = IsValid ? string.Empty : "Invalid Inputs";
            return IsValid;
        }
        private void _ReadUserInputs()
        {
            _UserName = txtBoxUserName.Text.Trim();
            _Password = clsEncryption.GetHashValue(txtBoxPassword.Text.Trim());
        }
        private bool _CheckLoginPermission(ref string ErrorMessage)
        {
            return clsUser.IsUserExistsByUserName(_UserName, ref ErrorMessage) &&
                clsUser.CheckUserPassword(_UserName, _Password, ref ErrorMessage) && clsUser.IsUserActive(_UserName, ref ErrorMessage);
        }
        private void _OpenUserSession()
        {
            _SaveLoginInfo();
            clsSettingAccess.AddUserLoginEventLog($"User With UserID '{clsUser.FindUserByUserName(_UserName).UserID.ToString()}" +
                $"' User Name '{_UserName}' Logged In");
            frmMenu Menu = new frmMenu(_UserName, this);
            this.Hide();
            Menu.DataBack += frmMenu_DataBack;
            Menu.Show();
        }
        private void _SaveLoginInfo()
        {
            if (checkBoxRememberMe.Checked)
                _SaveLoginInfoToRegistry();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            _ReadUserInputs();
            if (_CheckInputsValidity(ref ErrorMessage) && _CheckLoginPermission(ref ErrorMessage))
                _OpenUserSession();
            else
                MessageBox.Show(ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frmMenu_DataBack(object sender, string UserName)
        {
            _FillLastLoginInfoFromRegistry(UserName);
        }
        private void _EmptyLoginFormCredientials()
        {
            txtBoxUserName.Text = string.Empty;
            txtBoxPassword.Text = string.Empty;
            checkBoxRememberMe.Checked = false;
            txtBoxUserName.Focus();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_CleanLoginInfoFromRegistry();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
