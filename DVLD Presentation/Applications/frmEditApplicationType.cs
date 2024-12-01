using ApplicationsBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmEditApplicationType : Form
    {
        public delegate void DataBackHandler(object sender, bool IsSaved);
        public event DataBackHandler DataBack = delegate { };
        public frmEditApplicationType(int AppTypeID, string AppTypeName, decimal AppTypeFees)
        {
            InitializeComponent();
            _InitializeComponentsValues(AppTypeID, AppTypeName, AppTypeFees);
        }
        private void _InitializeComponentsValues(int AppTypeID, string AppTypeName, decimal AppTypeFees)
        {
            lblApplicationTypeID.Text = AppTypeID.ToString();
            txtBoxAppTypeName.Text = AppTypeName;
            txtBoxAppTypeFees.Text = AppTypeFees.ToString();
        }
        private void txtBoxAppTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.' &&
                !txtBoxAppTypeFees.Text.Contains('.'));
        }
        private void txtBoxAppTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar));
        }
        private void txtBoxAppTypeFees_TextChanged(object sender, EventArgs e)
        {
            txtBoxAppTypeFees.Text = txtBoxAppTypeFees.Text.Length == 1 && txtBoxAppTypeFees.Text[0] == '.' ?
                "0." : txtBoxAppTypeFees.Text;
            txtBoxAppTypeFees.SelectionStart = txtBoxAppTypeFees.TextLength;
        }
        private bool _CheckInputs()
        {
            return (!string.IsNullOrEmpty(txtBoxAppTypeName.Text) && !string.IsNullOrEmpty(txtBoxAppTypeFees.Text)) ;
        }
        private void _ShowResultMessage(bool IsUpdated, string Message = "")
        {
            Message = (Message != "") ? Message : IsUpdated ? "Successful Operation" : "Failed Operation";
            MessageBoxIcon icon = IsUpdated ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, icon);
        }
        private void _UpadteApplicationType(int AppTypeID, decimal AppTypeFees)
        {
            clsApplicationTypes AppType = new clsApplicationTypes(AppTypeID, txtBoxAppTypeName.Text.Trim(),
                AppTypeFees);
            bool IsUpdated = AppType.UpdateApplicationType();
            _ShowResultMessage(IsUpdated);
            DataBack?.Invoke(this, true);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckInputs() && int.TryParse(lblApplicationTypeID.Text, out int AppTypeID)
                && decimal.TryParse(txtBoxAppTypeFees.Text.Trim(), out decimal AppTypeFees))
                _UpadteApplicationType(AppTypeID, AppTypeFees);
            else
                _ShowResultMessage(false, "Invalid Inputs");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
