using ApplicationsBusiness;
using DVLD.Global;
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
    public partial class ctrlRepalcementApplicationInfo : UserControl
    {
        enum enReplacementType { Damage, Lost};
        enReplacementType Replacement;
        private decimal DamageFees;
        private decimal LostFees;
        public ctrlRepalcementApplicationInfo()
        {
            InitializeComponent();
            DamageFees = clsApplicationTypes.GetApplicationTypeFees(4);
            LostFees = clsApplicationTypes.GetApplicationTypeFees(3);
            Replacement = enReplacementType.Damage;
            _InitailzeComponents();
        }
        private void _InitailzeComponents()
        {
            lblApplocationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = clsProjectSettings.CurrentUser.UserName;
            lblApplicationFees.Text = DamageFees.ToString();
        }
        public void InitializeComponents(int LicenseID = -1)
        {
            lblOldAopplicationID.Text = (LicenseID == -1)? "[???]" :  lblOldAopplicationID.Text = LicenseID.ToString();
        }
        public void InitializeComponents(int NewApplicationID, int NewLicenseID)
        {
            lblLocalReplacementAppID.Text = NewApplicationID.ToString();
            lblReplacementLicenseID.Text = NewLicenseID.ToString();
        }
        private void _ChangeReplacementType()
        {
            Replacement = (Replacement == enReplacementType.Damage)? enReplacementType.Lost : enReplacementType.Damage;
        }
        public void ChangeApplicationFees()
        {
            lblApplicationFees.Text = (Replacement == enReplacementType.Damage) ? DamageFees.ToString() : LostFees.ToString();
            _ChangeReplacementType();
        }
    }
}
