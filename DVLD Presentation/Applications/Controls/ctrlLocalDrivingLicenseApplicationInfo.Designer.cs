namespace DVLD
{
    partial class ctrlLocalDrivingLicenseApplicationInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlLocalDrivingLicenseApplicationInfo));
            label1 = new Label();
            lblDrivingLicenseApplicationID = new Label();
            label3 = new Label();
            lblLicenseClass = new Label();
            label6 = new Label();
            lblPassedTests = new Label();
            picBoxLicenseName = new PictureBox();
            picBoxDLAppID = new PictureBox();
            picBoxPassedTests = new PictureBox();
            picBoxShowLicenseInfo = new PictureBox();
            linkLabelShowLicenseInfo = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picBoxLicenseName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDLAppID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassedTests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShowLicenseInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "D.L.App ID";
            // 
            // lblDrivingLicenseApplicationID
            // 
            lblDrivingLicenseApplicationID.AutoSize = true;
            lblDrivingLicenseApplicationID.Location = new Point(157, 25);
            lblDrivingLicenseApplicationID.Name = "lblDrivingLicenseApplicationID";
            lblDrivingLicenseApplicationID.Size = new Size(0, 20);
            lblDrivingLicenseApplicationID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 25);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 2;
            label3.Text = "Applied For Licence";
            // 
            // lblLicenseClass
            // 
            lblLicenseClass.AutoSize = true;
            lblLicenseClass.Location = new Point(510, 25);
            lblLicenseClass.Name = "lblLicenseClass";
            lblLicenseClass.Size = new Size(0, 20);
            lblLicenseClass.TabIndex = 3;
            lblLicenseClass.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 73);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Passed Tests";
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Location = new Point(510, 73);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(0, 20);
            lblPassedTests.TabIndex = 6;
            // 
            // picBoxLicenseName
            // 
            picBoxLicenseName.Image = (Image)resources.GetObject("picBoxLicenseName.Image");
            picBoxLicenseName.Location = new Point(452, 20);
            picBoxLicenseName.Name = "picBoxLicenseName";
            picBoxLicenseName.Size = new Size(30, 30);
            picBoxLicenseName.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLicenseName.TabIndex = 7;
            picBoxLicenseName.TabStop = false;
            // 
            // picBoxDLAppID
            // 
            picBoxDLAppID.Image = (Image)resources.GetObject("picBoxDLAppID.Image");
            picBoxDLAppID.Location = new Point(112, 20);
            picBoxDLAppID.Name = "picBoxDLAppID";
            picBoxDLAppID.Size = new Size(30, 30);
            picBoxDLAppID.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxDLAppID.TabIndex = 8;
            picBoxDLAppID.TabStop = false;
            // 
            // picBoxPassedTests
            // 
            picBoxPassedTests.Image = (Image)resources.GetObject("picBoxPassedTests.Image");
            picBoxPassedTests.Location = new Point(452, 68);
            picBoxPassedTests.Name = "picBoxPassedTests";
            picBoxPassedTests.Size = new Size(30, 30);
            picBoxPassedTests.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxPassedTests.TabIndex = 9;
            picBoxPassedTests.TabStop = false;
            // 
            // picBoxShowLicenseInfo
            // 
            picBoxShowLicenseInfo.Image = (Image)resources.GetObject("picBoxShowLicenseInfo.Image");
            picBoxShowLicenseInfo.Location = new Point(112, 68);
            picBoxShowLicenseInfo.Name = "picBoxShowLicenseInfo";
            picBoxShowLicenseInfo.Size = new Size(30, 30);
            picBoxShowLicenseInfo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxShowLicenseInfo.TabIndex = 10;
            picBoxShowLicenseInfo.TabStop = false;
            // 
            // linkLabelShowLicenseInfo
            // 
            linkLabelShowLicenseInfo.AutoSize = true;
            linkLabelShowLicenseInfo.Location = new Point(166, 73);
            linkLabelShowLicenseInfo.Name = "linkLabelShowLicenseInfo";
            linkLabelShowLicenseInfo.Size = new Size(127, 20);
            linkLabelShowLicenseInfo.TabIndex = 11;
            linkLabelShowLicenseInfo.TabStop = true;
            linkLabelShowLicenseInfo.Text = "Show License Info";
            linkLabelShowLicenseInfo.LinkClicked += linkLabelShowLicenseInfo_LinkClicked;
            // 
            // ctrlLocalDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabelShowLicenseInfo);
            Controls.Add(picBoxShowLicenseInfo);
            Controls.Add(picBoxPassedTests);
            Controls.Add(picBoxDLAppID);
            Controls.Add(picBoxLicenseName);
            Controls.Add(lblPassedTests);
            Controls.Add(label6);
            Controls.Add(lblLicenseClass);
            Controls.Add(label3);
            Controls.Add(lblDrivingLicenseApplicationID);
            Controls.Add(label1);
            Name = "ctrlLocalDrivingLicenseApplicationInfo";
            Size = new Size(727, 127);
            ((System.ComponentModel.ISupportInitialize)picBoxLicenseName).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDLAppID).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassedTests).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShowLicenseInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDrivingLicenseApplicationID;
        private Label label3;
        private Label lblLicenseClass;
        private Label label6;
        private Label lblPassedTests;
        private PictureBox picBoxLicenseName;
        private PictureBox picBoxDLAppID;
        private PictureBox picBoxPassedTests;
        private PictureBox picBoxShowLicenseInfo;
        private LinkLabel linkLabelShowLicenseInfo;
    }
}
