﻿using BusinessInternationalLicenses;
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
    public partial class frmShowInternationalLicenseInfo : Form
    {
        public frmShowInternationalLicenseInfo(int InternationalLicenseID, int PersonID)
        {
            InitializeComponent();
            ctrlInternationalDriverInfo1.InitializeComponents(InternationalLicenseID, PersonID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
