using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class ctrlChangePassword : UserControl
    {
        public string OldPassword { get { return txtBoxCurrentPassword.Text.Trim(); } }
        public string NewPassword { get { { return txtBoxNewPassword.Text.Trim(); } } }
        public string ConfirmedPassword { get { { return txtBoxConfirmedPassword.Text.Trim(); } } }
        public ctrlChangePassword()
        {
            InitializeComponent();
        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox txtBox = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrEmpty(txtBox.Text.Trim()))
            {
                errorProviderInputs.SetError(txtBox, "Required Field");
                txtBox.Focus();
            }
            else
            {
                errorProviderInputs.Clear();
            }
        }
        private void txtBoxConfirmedPassword_TextChanged(object sender, EventArgs e)
        {
             if (txtBoxConfirmedPassword.Text != txtBoxNewPassword.Text)
            {
                errorProviderInputs.SetError(txtBoxConfirmedPassword, "New And Confirmed Password Are Not The Same");
                txtBoxConfirmedPassword.Focus();
            }
            else
            {
                errorProviderInputs.Clear();
            }
        }
    }
}
