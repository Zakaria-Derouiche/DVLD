using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlApplicationInfo : UserControl
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public string ApplicantFullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal ApplicationFees { get; set; }
        public string CreatedByUserUserName { get; set; }
        public string ApplicationStatus { get; set; }
        public ctrlApplicationInfo()
        {
            InitializeComponent();
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicantFullName = string.Empty;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeTitle = string.Empty;
            LastStatusDate = DateTime.MinValue;
            ApplicationFees = 0;
            CreatedByUserUserName = string.Empty;
            ApplicationStatus = string.Empty;
        }
        public void InitializeApplicationInfoControlProprties(int ApplicationID, int ApplicantPersonID, string ApplicantFullName, 
            string ApplicationTypeTitle,  DateTime ApplicationDate, decimal ApplicationFees, string AppliactionStatus,
            DateTime LastStatusDate, string CreatedByUserUserName)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicantFullName = ApplicantFullName;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationFees = ApplicationFees;
            this.ApplicationStatus = AppliactionStatus;
            this.LastStatusDate = LastStatusDate;
            this.CreatedByUserUserName = CreatedByUserUserName;
        }
        public void LoadControlInfo()
        {
            lblAppID.Text = ApplicationID.ToString();
            lblAppStatus.Text = ApplicationStatus;
            lblAppFees.Text = ApplicationFees.ToString();
            lblCreatedBy.Text = CreatedByUserUserName;
            lblAppType.Text = ApplicationTypeTitle;
            lblApplicantFullName.Text = ApplicantFullName;
            lblAppDate.Text = ApplicationDate.ToShortDateString();
            lblAppStatusDate.Text = LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = CreatedByUserUserName;
        }
        private void linklblPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDisplayPersonInfo ApplicantInfoCard = new frmDisplayPersonInfo(ApplicantPersonID);
            ApplicantInfoCard.ShowDialog();
        }
    }
}
