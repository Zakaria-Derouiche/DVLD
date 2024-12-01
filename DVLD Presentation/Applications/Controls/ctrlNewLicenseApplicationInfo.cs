using ApplicationsBusiness;
using DVLD.Global;
using LicenseClassesBusiness;
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
    public partial class ctrlNewLicenseApplicationInfo : UserControl
    {
        public string Notes { get { return textBoxNotes.Text; } }
        public ctrlNewLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        private void ctrlNewLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsProjectSettings.CurrentUser.UserName;
            lblApplicationFees.Text = clsApplicationTypes.GetApplicationTypeFees(2).ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
        }
        public void ReloadInfo(int OldLicenseID, int LicenseClassID)
        {
            lblOldLicenceID.Text = OldLicenseID.ToString();
            decimal LicenseClassFees = clsLicenseClass.GetLicenseClassFees(LicenseClassID);
            byte LicenseValidityLength = clsLicenseClass.GetLicenseDefaultValidityLength(LicenseClassID);
            lblExpirationDate.Text = (DateTime.Now + new TimeSpan((LicenseValidityLength) * 365, 0, 0, 0)).ToShortDateString();
            lblLicenceFees.Text = LicenseClassFees.ToString();
            lblTotalFees.Text = (LicenseClassFees + Convert.ToDecimal(lblApplicationFees.Text)).ToString();
        }
        public void LoadLicenseInfo(int DrivingLicenseApplicationID, int NewLicenseID)
        {
            lblRenewLLicenseAppID.Text = DrivingLicenseApplicationID.ToString();
            lblNewLicenceID.Text = NewLicenseID.ToString();
        }
    }
}
