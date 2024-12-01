using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmDisplayPersonInfo : Form
    {
        public delegate void DataBackEventHandler(object sender, bool IsSaved);
        public event DataBackEventHandler DataBack = delegate { };
        public frmDisplayPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadControlComponents(PersonID);
        }
        public frmDisplayPersonInfo(string NationalNumber) { 
            InitializeComponent();
            int PersonID = clsPerson.GetPersonID(NationalNumber);
            ctrlPersonInfo1.LoadControlComponents(PersonID);
        }

        private void ctrlPersonInfo_DataBack(object sender, bool IsSaved)
        {
            if (IsSaved)
                DataBack?.Invoke(this, IsSaved);
        }
        private void frmDispaly_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, ctrlPersonInfo1.IsChanged);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
