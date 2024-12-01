using ApplicationsBusiness;
using DetainedLicensesBusiness;
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
    public partial class ctrlReleaseInfo : UserControl
    {
        
        public ctrlReleaseInfo()
        {
            InitializeComponent();
        }
        private void _ReloadControl()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name.StartsWith("lbl"))
                {
                    control.Text = "[???]";
                }
            }
        }
        public void InitializeComponents(int LicenseID = -1)
        {
            _ReloadControl();
        }
        public void InitializeComponents(int LicenseID, int DetainID, DateTime DetainDate, decimal FineFees, int CreatedByUserID )
        {
            lblLicenseID.Text = LicenseID.ToString();
            decimal ApplicationFees = clsApplicationTypes.GetApplicationTypeFees(5);
            string CreatedBy = clsUser.GetUserName(CreatedByUserID);
            lblDetainID.Text = DetainID.ToString();
            lblApplicationFees.Text = ApplicationFees.ToString();
            lblFineFees.Text = FineFees.ToString();
            lblDetainDate.Text = DetainDate.ToShortDateString();
            lblTotalFees.Text = (ApplicationFees + FineFees).ToString();
            lblCreatedBy.Text = CreatedBy;
        }
        public void SetApplicationID(int ApplicationID)
        {
            lblReleaseAppID.Text = ApplicationID.ToString();
        }
    }
}
