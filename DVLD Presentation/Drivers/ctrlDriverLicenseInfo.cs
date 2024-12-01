using DVLD.Properties;
using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public string LicenseClassName { get; set; }
        public int PersonID { get; set; }
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
            ApplicationID = -1;
            DriverID = -1;
            LicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;
            LicenseClassName = string.Empty;
            PersonID = -1; ;
        }
        private void _InitializeProperties(int ApplicationID, int LicenseID, int DriverID, DateTime IssueDate, DateTime ExpirationDate,
            string IsActive, int CreatedByUserID, string ClassName, string DriverNationalNo)
        {
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseID = LicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = (IsActive == "Yes");
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassName = ClassName;
            this.PersonID = clsPerson.GetPersonID(DriverNationalNo);
        }
        public void ChangeActiveStatus()
        {
            lblActiveStatus.Text = lblActiveStatus.Text == "Yes" ? "No" : "Yes";
        }
        public void ChangeDetainStatus()
        {
            lblIsDetained.Text = lblIsDetained.Text == "Yes" ? "No" : "Yes";
        }
        public void InitializeComponents()
        {
            foreach (Control L in this.Controls)
            {
                if (L.Name.StartsWith("lbl"))
                    L.Text = "[???]";
            }
            picBoxDriverPhoto.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png";

        }
        public void InitializeComponents(int ApplicationID, string ClassName, string DriverName, int LicenseID, string DriverNationalNo,
            string Gender, DateTime IssueDate, string IssueReason, string Notes, string IsActive, DateTime DateOfBirth,
            int DriverID, DateTime ExpirationDate, string IsDetained, string ImagePath, int CreatedByUserID)
        {
            _InitializeProperties(ApplicationID, LicenseID, DriverID, IssueDate, ExpirationDate, IsActive, CreatedByUserID,
                ClassName, DriverNationalNo);
            lblLicenseClassName.Text = ClassName;
            lblDriverFullName.Text = DriverName;
            lblLicenseID.Text = LicenseID.ToString();
            lblNationalNo.Text = DriverNationalNo;
            lblGender.Text = Gender;
            lblActiveStatus.Text = IsActive;
            lblDateOfBirth.Text = DateOfBirth.ToShortDateString();
            lblDriverID.Text = DriverID.ToString();
            lblExpirationDate.Text = ExpirationDate.ToShortDateString();
            lblIsDetained.Text = IsDetained;
            lblIssueDate.Text = IssueDate.ToShortDateString();
            lblIssueReson.Text = IssueReason;
            lblNotes.Text = Notes;
            picBoxDriverPhoto.ImageLocation = (ImagePath != string.Empty && File.Exists(ImagePath)) ? ImagePath :
                Gender == "Male" ? "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png" :
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Female.png";
        }

       
    }
}
