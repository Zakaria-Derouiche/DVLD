using BusinessInternationalLicenses;
using PeopleBusiness;
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
    public partial class ctrlInternationalDriverInfo : UserControl
    {
        clsPerson Person = new clsPerson();
        clsInternationalLicense InternationalLicense = new clsInternationalLicense();
        public ctrlInternationalDriverInfo()
        {
            InitializeComponent(); 
        }
        public void InitializeComponents(int InternationalLicenseID, int PersonID)
        {
            Person = clsPerson.FindPersonByID(PersonID);
            InternationalLicense = clsInternationalLicense.FindInternationalLicenseByInternationalLoicenseID(InternationalLicenseID);
            _LoadInfo();
        }
        private void _LoadInfo()
        {
            lblDriverFullName.Text = Person.FullName;
            lblDriverID.Text = InternationalLicense.DriverID.ToString();
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lblGender.Text = Person.Gender == 0 ? "Male" : "Female";
            lblIApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            lblIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
            lblNationalNo.Text = Person.NationalNumber;
            lblLocalLicenseID.Text = InternationalLicense.LocalLicenseID.ToString();
            lblActiveStatus.Text = (InternationalLicense.IsActive) ? "Yes" : "No";
            picBoxDriverPhoto.ImageLocation = File.Exists(Person.ImagePath) ? Person.ImagePath : Person.Gender == 0 ?
             "C:\\Users\\THINK15-G4\\source\repos\\DVLD\\ProjectImages\\Male.png" :
            "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Female.png";
        }
    }
}
