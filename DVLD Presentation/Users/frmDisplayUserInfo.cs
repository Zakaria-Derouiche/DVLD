using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusiness;
using Encryption;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD
{
    public partial class frmDisplayUserInfo : Form
    {

        public delegate void DataBackHandler(object sender, bool IsChanged);
        public event DataBackHandler DataBack = delegate { };
        private clsUser User = new clsUser();
        private bool _IsChanged;
        public enum enMode { DisplayInfo, ChangePassword };
        enMode _Mode;
        public frmDisplayUserInfo(int UserID, enMode Mode)
        {
            InitializeComponent();
            User = clsUser.FindUserById(UserID);
            _IsChanged = false;
            _Mode = Mode;
            _InitilizeComponentsValues(Mode);
        }
        private void _HideUserInfo()
        {
            ctrlChangePassword1.Visible = false;
            btnSave.Visible = false;
            pictureBox1.Visible = false;
            btnClose.Location = new Point(btnClose.Location.X, btnClose.Location.Y - ctrlChangePassword1.Height);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - ctrlChangePassword1.Height);
            Height -= ctrlChangePassword1.Height;
        }
        private void _Refresh()
        {
            User = clsUser.FindUserByPersonID(User.PersonID);
            _InitilizeComponentsValues(_Mode);
        }
        private void _FillUserInfo()
        {
            lblUserID.Text = User.UserID.ToString();
            lblUserName.Text = User.UserName.ToString();
            lblIsActive.Text = (User.IsActive == true) ? "Yes" : "No";
        }
        private void _InitilizeComponentsValues(enMode Mode)
        {
            ctrlPersonInfo1.LoadControlComponents(User.PersonID);
            _FillUserInfo();
            if (Mode == enMode.DisplayInfo)
                _HideUserInfo();
        }
        private void frmDisplayUserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, _IsChanged);
        }
        private bool CheckInputs()
        {
            return clsEncryption.GetHashValue( ctrlChangePassword1.OldPassword) == User.Password && !string.IsNullOrEmpty(ctrlChangePassword1.NewPassword)
                && !string.IsNullOrEmpty(ctrlChangePassword1.ConfirmedPassword)
                && ctrlChangePassword1.NewPassword == ctrlChangePassword1.ConfirmedPassword;
        }
        private void _UpdateUserInfo()
        {
            User.Password = clsEncryption.GetHashValue(ctrlChangePassword1.NewPassword);
            bool IsSaved = User.Save();
            if (IsSaved)
                MessageBox.Show("Seccessful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
                _UpdateUserInfo();
            else
                MessageBox.Show("Wrong Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
