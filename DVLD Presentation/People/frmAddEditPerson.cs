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
using PeopleBusiness;
using DVLD.Properties;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using CountriesBusiness;
using Microsoft.IdentityModel.Tokens;
using UserBusiness;
using DVLD.Global;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {
        bool _IsSaved = false;
        clsPerson Person = new clsPerson();
        enum enMode { Add, Update };
        enMode _Mode;
        public delegate void DataBackEventHandler(object sender, bool IsSaved, int PersonID);
        public event DataBackEventHandler DataBack = delegate { };
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = PersonID == -1 ? enMode.Add : enMode.Update;
            Person = PersonID == -1 ? new clsPerson() : clsPerson.FindPersonByID(PersonID);
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            InitializeComponentsValues();
        }
        private void _dtpDateOfBirth_SetMaxMinDate()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now - new TimeSpan(18 * 365, 0, 0, 0);
            dtpDateOfBirth.MinDate = DateTime.Now - new TimeSpan(150 * 365, 0, 0, 0);
        }
        private void _SetGender()
        {
            radioButtonMale.Checked = (Person.Gender == 0);
            radioButtonFemale.Checked = !radioButtonMale.Checked;
        }
        private void _picBoxPersonImage_SetImage()
        {
            pictureBoxPersonImage.ImageLocation = Person.ImagePath != string.Empty ? Person.ImagePath : Person.Gender == 0 ?
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png" :
                "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Female.png";
        }
        private void _InitializeFormInfo()
        {
            this.Text = _Mode == enMode.Add ? "Add Person" : "Edit Person Info";
            comboBoxCountry.SelectedIndex = (_Mode == enMode.Update) ? Person.NationalityCountryID - 1 : 2;
            txtBoxPhone.Text = (_Mode == enMode.Add)?  "+" + clsCountries.GetCountryDialingCode(comboBoxCountry.Text).Trim() + " " : Person.Phone;
            dtpDateOfBirth.Value = (_Mode == enMode.Update) ? Person.DateOfBirth : dtpDateOfBirth.MaxDate;
            txtBoxFirstName.Text = Person.FirstName;
            txtBoxSecondName.Text = Person.SecondName;
            txtBoxThirdName.Text = Person.ThirdName;
            txtBoxLastName.Text = Person.LastName;
            txtBoxNationalNumber.Text = Person.NationalNumber;
            txtBoxEmail.Text = Person.Email;
            txtBoxAdderss.Text = Person.Address;
            linkLabelSetImage.Text = pictureBoxPersonImage.ImageLocation.Contains("Users\\THINK15-G4\\source\\repos\\DVLD\\PeoplePics") ?
                "Change Image" : "Set Image";
            linkLabelRemoveImage.Visible =  linkLabelSetImage.Text == "Change Image";
            lblPersonID.Text = (_Mode == enMode.Add)? "N/A" : Person.ID.ToString();
        }
        private void InitializeComponentsValues()
        {
            _LoadCountriesInComboBox();
            _dtpDateOfBirth_SetMaxMinDate();
            _SetGender();
            _picBoxPersonImage_SetImage();
            _InitializeFormInfo();
        }
        private void _LoadCountriesInComboBox()
        {
            string[] CountriesNames = clsCountries.CountriesList();
            comboBoxCountry.Items.AddRange(CountriesNames);
        }
        private void TextBox_KeyPressNameValidation(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar));
        }
        private void TextBox_KeyPressPhoneValidation(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
        }
        private void TextBox_KeyPressEmailValidation(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@');
        }
        private void TextBox_KeyPressAddressValidation(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar));
        }
        private void TextBox_KeyPressNationlNumberValidation(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar));
        }
        private bool IsGenderSelected()
        {
            return (radioButtonMale.Checked || radioButtonFemale.Checked);
        }
        private bool IsTextBoxesValid()
        {
            return (!string.IsNullOrEmpty(txtBoxFirstName.Text) && !string.IsNullOrEmpty(txtBoxSecondName.Text)
                && !string.IsNullOrEmpty(txtBoxLastName.Text) && !string.IsNullOrEmpty(txtBoxNationalNumber.Text)
                && !string.IsNullOrEmpty(txtBoxPhone.Text) && !string.IsNullOrEmpty(txtBoxAdderss.Text));
        }
        private bool CheckInputs()
        {
            
            return (IsTextBoxesValid() && IsGenderSelected() && clsValidation.IsValideEamil(txtBoxEmail.Text.Trim()) 
                && clsValidation.IsValidePhoneNumber(txtBoxPhone.Text.Trim()));
        }
        private byte GetGender()
        {
            return (radioButtonMale.Checked) ? (byte)0 : (byte)1;
        }
        private string GetImagePath()
        {
            string DestinationPath = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\PeoplePics\\";
            return pictureBoxPersonImage.ImageLocation.Contains(DestinationPath)? pictureBoxPersonImage.ImageLocation : string.Empty;
        }
        private void FillInformationToPersonClass()
        {
            Person.FirstName = txtBoxFirstName.Text;
            Person.SecondName = txtBoxSecondName.Text;
            Person.ThirdName = txtBoxThirdName.Text;
            Person.LastName = txtBoxLastName.Text;
            Person.NationalNumber = txtBoxNationalNumber.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.Phone = txtBoxPhone.Text;
            Person.Email = txtBoxEmail.Text;
            Person.Address = txtBoxAdderss.Text;
            Person.Gender = GetGender();
            Person.NationalityCountryID = (byte)(comboBoxCountry.SelectedIndex + 1);
            Person.ImagePath = GetImagePath();
        }
        private void radioButtonMale_Click(object sender, EventArgs e)
        {
            if (pictureBoxPersonImage.ImageLocation == string.Empty)
                pictureBoxPersonImage.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png";
        }
        private void radioButtonFemale_Click(object sender, EventArgs e)
        {
            if (pictureBoxPersonImage.ImageLocation == string.Empty)
                pictureBoxPersonImage.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Female.png";
        }
        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                string DestinationPath = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\PeoplePics\\";
                if (_CheckImagePath())
                    File.Delete(pictureBoxPersonImage.ImageLocation);
                File.Copy(FileName, DestinationPath + openFileDialog1.SafeFileName);
                pictureBoxPersonImage.ImageLocation = DestinationPath + openFileDialog1.SafeFileName;
                _pictureBoxPersonImage_ImageChanged();
            }
        }
        private void _pictureBoxPersonImage_ImageChanged()
        {
            string DestinationPath = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\PeoplePics\\";
            bool IsPicFromDestinationPath = pictureBoxPersonImage.ImageLocation.Contains(DestinationPath);
            linkLabelRemoveImage.Visible = IsPicFromDestinationPath;
            linkLabelSetImage.Text = IsPicFromDestinationPath ? "Change Image" : "Set Image";
        }
        private bool _CheckImagePath()
        {
            string DestinationPath = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\PeoplePics\\";
            return pictureBoxPersonImage.ImageLocation.Contains(DestinationPath);
        }
        private void _ResetPersonImage()
        {
            pictureBoxPersonImage.ImageLocation = "C:\\Users\\THINK15-G4\\source\\repos\\DVLD\\ProjectImages\\Male.png";
            _pictureBoxPersonImage_ImageChanged();
        }
        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_CheckImagePath() && MessageBox.Show("Are You Sure", "???", MessageBoxButtons.OK) == DialogResult.OK)
            {
                File.Delete(pictureBoxPersonImage.ImageLocation);
                _ResetPersonImage();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Add && clsUser.IsUserExists(txtBoxNationalNumber.Text.Trim()))
            {
                MessageBox.Show("Natinal number Allready Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CheckInputs())
            {
                MessageBox.Show("Inputs are Invalide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FillInformationToPersonClass();
            _IsSaved = Person.Save();
            if (_IsSaved)
            {
                DataBack?.Invoke(this, _IsSaved, Person.ID);
                lblPersonID.Text = Person.ID.ToString();
                MessageBox.Show("Succesful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmAddEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lblPersonID.Text == "N/A" && _CheckImagePath())
                File.Delete(pictureBoxPersonImage.ImageLocation);
        }
        private void linkLabelSetImage_TextChanged(object sender, EventArgs e)
        {
            linkLabelSetImage.Location = linkLabelSetImage.Text == "Set Image" ? new Point(681, 349) : new Point(667, 349);
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DialingCode = clsCountries.GetCountryDialingCode(comboBoxCountry.Text);
            txtBoxPhone.Text = "+" + DialingCode.Trim() + " ";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
