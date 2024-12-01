using PeopleBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using System.Runtime.CompilerServices;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;


namespace DVLD
{
    public partial class ctrlPersonInfo : UserControl
    {
        public delegate void DataBackHandler(object sender, bool IsChanged);
        public event DataBackHandler DataBack = delegate { };
        private clsPerson Person = new clsPerson();
        public int PersonID { get; set; }
        public bool IsChanged { set; get; }
        public ctrlPersonInfo()
        {
            InitializeComponent();
            IsChanged = false;
        }
        private void _FillControlWithEmptyPerson()
        {
            lblNationalNumber.Text = "[???]";
            lblPersonID.Text = "[???]";
            lblFullName.Text = "[???]";
            lblCountry.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblEmail.Text = "[???]";
            lblPhone.Text = "[???]";
            lblAddress.Text = "[???]";
            lblGender.Text = "[???]";
            picBoxGender.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Gender.jpg";
            picBoxPersonImage.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png";
        }
        public void LoadControlComponents(int PersonID)
        {
            this.PersonID = PersonID;
            Person = clsPerson.FindPersonByID(PersonID);
            if (Person != null)
                _FillControlWithExistPerson();
            else
                _FillControlWithEmptyPerson();
        }
        private void _FillControlWithExistPerson()
        {
            lblNationalNumber.Text = Person.NationalNumber;
            lblPersonID.Text = Person.ID.ToString();
            lblFullName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            lblCountry.Text = Person.CountryName();
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lblEmail.Text = Person.Email;
            lblPhone.Text = Person.Phone;
            lblAddress.Text = Person.Address;
            lblGender.Text = (Person.Gender == 0) ? "Male" : "Female";
            picBoxGender.ImageLocation = (Person.Gender == 0) ? "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png"
                : "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png";
            picBoxPersonImage.ImageLocation = Person.ImagePath != string.Empty && File.Exists(Person.ImagePath) ?
                Person.ImagePath : picBoxGender.ImageLocation;
        }
        private void frmAddEditPerson_DataBack(object sender, bool IsSaved, int PersonID)
        {
            if (IsSaved)
            {
                IsChanged = true;
                LoadControlComponents(Person.ID);
                DataBack?.Invoke(this, IsSaved);
            }  
        }
        private void linklblEditPersomInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson EditPerson = new frmAddEditPerson(Person.ID);
            EditPerson.DataBack += frmAddEditPerson_DataBack;
            EditPerson.ShowDialog();
        }
    }
}
