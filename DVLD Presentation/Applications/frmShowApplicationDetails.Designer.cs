namespace DVLD
{
    partial class frmShowApplicationDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowApplicationDetails));
            lblFormTitle = new Label();
            picBoxFromType = new PictureBox();
            groupBox2 = new GroupBox();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            groupBox = new GroupBox();
            ctrlDrivingLicenseApplicationInfo1 = new ctrlLocalDrivingLicenseApplicationInfo();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxFromType).BeginInit();
            groupBox2.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.IndianRed;
            lblFormTitle.Location = new Point(384, 117);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(137, 23);
            lblFormTitle.TabIndex = 13;
            lblFormTitle.Text = "Application Info";
            // 
            // picBoxFromType
            // 
            picBoxFromType.BorderStyle = BorderStyle.FixedSingle;
            picBoxFromType.Image = (Image)resources.GetObject("picBoxFromType.Image");
            picBoxFromType.Location = new Point(316, 12);
            picBoxFromType.Name = "picBoxFromType";
            picBoxFromType.Size = new Size(273, 87);
            picBoxFromType.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxFromType.TabIndex = 12;
            picBoxFromType.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlApplicationInfo1);
            groupBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(872, 252);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Application Basic Info";
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.ApplicantFullName = "";
            ctrlApplicationInfo1.ApplicantPersonID = -1;
            ctrlApplicationInfo1.ApplicationDate = new DateTime(0L);
            ctrlApplicationInfo1.ApplicationFees = new decimal(new int[] { 0, 0, 0, 0 });
            ctrlApplicationInfo1.ApplicationID = -1;
            ctrlApplicationInfo1.ApplicationStatus = "";
            ctrlApplicationInfo1.ApplicationTypeTitle = "";
            ctrlApplicationInfo1.CreatedByUserUserName = "";
            ctrlApplicationInfo1.LastStatusDate = new DateTime(0L);
            ctrlApplicationInfo1.Location = new Point(9, 22);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(855, 205);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            groupBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(16, 143);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(872, 151);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = "Driving License Application Info";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.LicenseClassName = "";
            ctrlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(11, 22);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(850, 113);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(764, 577);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(752, 572);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 40);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowApplicationDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 624);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(lblFormTitle);
            Controls.Add(picBoxFromType);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Name = "frmShowApplicationDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Application Details";
            ((System.ComponentModel.ISupportInitialize)picBoxFromType).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private PictureBox picBoxFromType;
        private GroupBox groupBox2;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private GroupBox groupBox;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private PictureBox pictureBox2;
        private Button btnClose;
    }
}