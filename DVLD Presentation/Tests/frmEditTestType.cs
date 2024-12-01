using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsTypesBusiness;

namespace DVLD
{
    public partial class frmEditTestType : Form
    {
        public delegate void DataBackHandler(object sender, bool IsChnaged);
        public event DataBackHandler DataBack = delegate { };
        public frmEditTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            InitializeComponent();
            _InitializeComponentsValues(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
        private void _InitializeComponentsValues(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            lblTestTypeID.Text = TestTypeID.ToString();
            txtBoxTestTypeName.Text = TestTypeTitle.ToString();
            txtBoxTestTypedescription.Text = TestTypeDescription.ToString();
            txtBoxTestTypeFees.Text = TestTypeFees.ToString();
        }
        private void txtBoxTestTypeFees_TextChanged(object sender, EventArgs e)
        {
            txtBoxTestTypeFees.Text = txtBoxTestTypeFees.TextLength == 1 && txtBoxTestTypeFees.Text[0] == '.' ? "0." :
                txtBoxTestTypeFees.Text;
            txtBoxTestTypeFees.SelectionStart = txtBoxTestTypeFees.Text.Length;
        }
        private void txtBoxTestTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar));
        }
        private void txtBoxTestTypedescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar));
        }
        private void txtBoxTestTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' &&
                !txtBoxTestTypeFees.Text.Contains('.'));
        }
        private bool CheckInputs()
        {
            return (!string.IsNullOrEmpty(txtBoxTestTypeName.Text.Trim()) &&
                !string.IsNullOrEmpty(txtBoxTestTypedescription.Text.Trim())
                && !string.IsNullOrEmpty(txtBoxTestTypeFees.Text.Trim()));
        }
        private void _ShowResultMessage(bool IsUpdated, string Message = "")
        {
            Message = (Message != "") ? Message : IsUpdated ? "Successful Operation" : "Failed Operation";
            MessageBoxIcon icon = IsUpdated ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, icon);
        }
        private void _UpdateTestInfo(int TestTypeID, decimal TestTypeFees)
        {
            clsTestType TestType = new clsTestType(TestTypeID, txtBoxTestTypeName.Text,
                   txtBoxTestTypedescription.Text, TestTypeFees);
            bool IsUpdated = TestType.UpdateTestTypeInfo();
            _ShowResultMessage(IsUpdated);
            DataBack?.Invoke(this, IsUpdated);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInputs() && int.TryParse(lblTestTypeID.Text, out int TestTypeID) &&
                decimal.TryParse(txtBoxTestTypeFees.Text.Trim(), out decimal TestTypeFees))
                _UpdateTestInfo(TestTypeID, TestTypeFees);
            else
                _ShowResultMessage(false, "Invalid Inputs");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
