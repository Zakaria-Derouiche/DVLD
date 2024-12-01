using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Global;

namespace DVLD
{
    public partial class ctrlDetainInfo : UserControl
    {
        public decimal FineFees
        {
            get
            {
                return (string.IsNullOrEmpty(txtBoxFineFees.Text) ? 0 : Convert.ToDecimal(txtBoxFineFees.Text));
            }
        }
        public ctrlDetainInfo()
        {
            InitializeComponent();
        }
        private void ctrlDetainInfo_Load(object sender, EventArgs e)
        {
            lblCreatedBy.Text = clsProjectSettings.CurrentUser.UserName;
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
        }
        public void InitializeComponents(int LicenseID = -1)
        {
            lblLicenseID.Text = LicenseID == -1 ? "[???]" : LicenseID.ToString();
        }
        public void ChangeDetainID(int DetainID)
        {
            lblDeatinID.Text = DetainID.ToString();
        }
        private void txtBoxFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        public void SetError()
        {
            errorProviderFineFees.SetError(txtBoxFineFees, "Requred Field");
            txtBoxFineFees.Focus();
        }
        private void txtBoxFineFees_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxFineFees.Text))
            {
                errorProviderFineFees.SetError(txtBoxFineFees, "Requred Field");
                txtBoxFineFees.Focus();
            }
            else
            {
                errorProviderFineFees.Clear();
            }
        }

       
    }
}
