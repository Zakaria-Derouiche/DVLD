using ApplicationsBusiness;
using ApplicationsTypeDataAccess;
using DetainedLicensesBusiness;
using LicensesBusiness;
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
    public partial class frmShowLicenseInfo : Form
    {
        public frmShowLicenseInfo(int ApplicationID, string LicenseClass, string NationalNo)
        {
            InitializeComponent();
            _InitailizeLicenseControlComponents(ApplicationID, LicenseClass, NationalNo);
        }
        private void _InitailizeLicenseControlComponents(int ApplicationID, string LicenseClass, string NationalNo)
        {
            clsLicense License = clsLicense.FindLicenseByApplicationID(ApplicationID);
            clsPerson Person = clsPerson.FindPersonByNationalNumber(NationalNo);
            string Gender = (Person.Gender == 0) ? "Male" : "Female";
            string IssueReason = clsApplicationTypes.GetApplicationTitle(License.ApplicationTypeID);
            string IsActive = (License.IsActive) ? "Yes" : "No";
            string IsDetained = clsDetainedLicense.IsDetainedLicence(License.LicenseID) ? "Yes" : "No";
            ctrlDriverLicenseInfo1.InitializeComponents(License.ApplicationID, LicenseClass, Person.FullName, License.LicenseID,
                NationalNo, Gender, License.IssueDate, IssueReason, License.Notes, IsActive, Person.DateOfBirth, License.DriverID,
                License.ExpirationDate, IsDetained, Person.ImagePath, License.CreatedByUserID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
