namespace DVLD
{
    partial class frmAddInternationalLicenceApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInternationalLicenceApplication));
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnFindLicense = new Button();
            txtBoxLicenseID = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            ctrlInternationalLicenseInfo1 = new ctrlInternationalLicenseInfo();
            pictureBox4 = new PictureBox();
            btnIssue = new Button();
            linkLabelLicenseHistory = new LinkLabel();
            linkLabelShowLicenseInfo = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(560, 736);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(240, 99);
            label1.Name = "label1";
            label1.Size = new Size(374, 31);
            label1.TabIndex = 1;
            label1.Text = "International Licence Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFindLicense);
            groupBox1.Controls.Add(txtBoxLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(123, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 68);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // btnFindLicense
            // 
            btnFindLicense.BackgroundImage = (Image)resources.GetObject("btnFindLicense.BackgroundImage");
            btnFindLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnFindLicense.Location = new Point(455, 18);
            btnFindLicense.Name = "btnFindLicense";
            btnFindLicense.Size = new Size(120, 40);
            btnFindLicense.TabIndex = 2;
            btnFindLicense.UseVisualStyleBackColor = true;
            btnFindLicense.Click += btnFindLicense_Click;
            // 
            // txtBoxLicenseID
            // 
            txtBoxLicenseID.Location = new Point(162, 25);
            txtBoxLicenseID.MaxLength = 30;
            txtBoxLicenseID.Name = "txtBoxLicenseID";
            txtBoxLicenseID.Size = new Size(219, 27);
            txtBoxLicenseID.TabIndex = 1;
            txtBoxLicenseID.TextChanged += txtBoxLicenseID_TextChanged;
            txtBoxLicenseID.KeyPress += txtBoxLicenseID_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 28);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Licence ID";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(570, 744);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.ApplicationID = 0;
            ctrlDriverLicenseInfo1.CreatedByUserID = 0;
            ctrlDriverLicenseInfo1.DriverID = 0;
            ctrlDriverLicenseInfo1.ExpirationDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.IsActive = false;
            ctrlDriverLicenseInfo1.IssueDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.LicenseClassName = null;
            ctrlDriverLicenseInfo1.LicenseID = 0;
            ctrlDriverLicenseInfo1.Location = new Point(21, 223);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.PersonID = 0;
            ctrlDriverLicenseInfo1.Size = new Size(813, 288);
            ctrlDriverLicenseInfo1.TabIndex = 5;
            // 
            // ctrlInternationalLicenseInfo1
            // 
            ctrlInternationalLicenseInfo1.ApplicationDate = new DateTime(0L);
            ctrlInternationalLicenseInfo1.ApplicationID = -1;
            ctrlInternationalLicenseInfo1.DriverID = -1;
            ctrlInternationalLicenseInfo1.ExpirationDate = new DateTime(2034, 7, 29, 12, 19, 52, 383);
            ctrlInternationalLicenseInfo1.Fees = new decimal(new int[] { 500000, 0, 0, 262144 });
            ctrlInternationalLicenseInfo1.InternationalLicenseID = -1;
            ctrlInternationalLicenseInfo1.IsActive = false;
            ctrlInternationalLicenseInfo1.IssueDate = new DateTime(2024, 7, 31, 12, 19, 52, 383);
            ctrlInternationalLicenseInfo1.LocalLicenseID = -1;
            ctrlInternationalLicenseInfo1.Location = new Point(21, 534);
            ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
            ctrlInternationalLicenseInfo1.Size = new Size(813, 187);
            ctrlInternationalLicenseInfo1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(710, 744);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.Location = new Point(700, 736);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(145, 40);
            btnIssue.TabIndex = 7;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // linkLabelLicenseHistory
            // 
            linkLabelLicenseHistory.AutoSize = true;
            linkLabelLicenseHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLicenseHistory.Location = new Point(36, 749);
            linkLabelLicenseHistory.Name = "linkLabelLicenseHistory";
            linkLabelLicenseHistory.Size = new Size(158, 20);
            linkLabelLicenseHistory.TabIndex = 9;
            linkLabelLicenseHistory.TabStop = true;
            linkLabelLicenseHistory.Text = "Show License History";
            linkLabelLicenseHistory.LinkClicked += linkLabelLicenseHistory_LinkClicked;
            // 
            // linkLabelShowLicenseInfo
            // 
            linkLabelShowLicenseInfo.AutoSize = true;
            linkLabelShowLicenseInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelShowLicenseInfo.Location = new Point(198, 749);
            linkLabelShowLicenseInfo.Name = "linkLabelShowLicenseInfo";
            linkLabelShowLicenseInfo.Size = new Size(230, 20);
            linkLabelShowLicenseInfo.TabIndex = 10;
            linkLabelShowLicenseInfo.TabStop = true;
            linkLabelShowLicenseInfo.Text = "Show International License Info";
            linkLabelShowLicenseInfo.LinkClicked += linkLabelShowLicenseInfo_LinkClicked;
            // 
            // frmAddInternationalLicenceApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 785);
            Controls.Add(linkLabelShowLicenseInfo);
            Controls.Add(linkLabelLicenseHistory);
            Controls.Add(pictureBox4);
            Controls.Add(btnIssue);
            Controls.Add(ctrlInternationalLicenseInfo1);
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "frmAddInternationalLicenceApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "International Licence Application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnFindLicense;
        private TextBox txtBoxLicenseID;
        private Label label2;
        private PictureBox pictureBox2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
        private PictureBox pictureBox4;
        private Button btnIssue;
        private LinkLabel linkLabelLicenseHistory;
        private LinkLabel linkLabelShowLicenseInfo;
    }
}