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
using ApplicationsTypes;
using ApplicationsBusiness;
using BusinessInternationalLicenses;
using static System.Net.Mime.MediaTypeNames;
using TestsTypesBusiness;
using DVLD.Global;

namespace DVLD
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ApplicationDate {  get; set; }
        public decimal Fees { get; set; }
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
            _InitializeProperties();
            _InitializeComponents();
        }
        private void _InitializeProperties()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = IssueDate + new TimeSpan((clsLicenseClass.GetLicenseDefaultValidityLength(3)) * 365, 0, 0, 0);
            Fees = clsApplicationTypes.GetApplicationTypeFees(6);
        }
        public void ReLoad()
        {
            _InitializeProperties();
            _InitializeComponents();
        }
         public void InitailizeValues(int InternationalLicenseID,int ApplicationID, int DriverID, int  LocalLicenseID,
                DateTime IssueDate, DateTime ExpirationDate, bool IsActive)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LocalLicenseID = LocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            _InitializeComponents();
        }
        private void _InitializeComponents()
        {
            lblApplicationDate.Text = IssueDate.ToShortDateString();
            lblIssueDate.Text = IssueDate.ToShortDateString();
            lblExpirationDate.Text = ExpirationDate.ToShortDateString();
            lblFees.Text = Fees.ToString();
            lblInternationalApplicationLicenceID.Text = (ApplicationID != -1) ? ApplicationID.ToString() : "[???]";
            lblInternationalLicenceID.Text = (InternationalLicenseID != -1) ? InternationalLicenseID.ToString() : "[???]";
            lblLocalLicenseID.Text = (LocalLicenseID != -1) ? LocalLicenseID.ToString() : "[???]";
            lblCreatedBy.Text = clsProjectSettings.CurrentUser.UserName;
        }

    }
}
