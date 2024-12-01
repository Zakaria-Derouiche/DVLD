namespace DVLD
{
    partial class frmReleaseLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseLicense));
            groupBox2 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            groupBoxFilter = new GroupBox();
            btnFindLicense = new Button();
            textBoxLicenseID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            linkLabelShowLicense = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            linkLabelShowLicenseHistory = new LinkLabel();
            btnRelease = new Button();
            groupBox3 = new GroupBox();
            ctrlReleaseInfo1 = new ctrlReleaseInfo();
            groupBox2.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(7, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(815, 291);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Driver License Info";
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.ApplicationID = 0;
            ctrlDriverLicenseInfo1.CreatedByUserID = 0;
            ctrlDriverLicenseInfo1.DriverID = 0;
            ctrlDriverLicenseInfo1.ExpirationDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlDriverLicenseInfo1.IsActive = false;
            ctrlDriverLicenseInfo1.IssueDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.LicenseClassName = null;
            ctrlDriverLicenseInfo1.LicenseID = 0;
            ctrlDriverLicenseInfo1.Location = new Point(18, 22);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.PersonID = 0;
            ctrlDriverLicenseInfo1.Size = new Size(779, 252);
            ctrlDriverLicenseInfo1.TabIndex = 10;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnFindLicense);
            groupBoxFilter.Controls.Add(textBoxLicenseID);
            groupBoxFilter.Controls.Add(label2);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(127, 54);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(575, 71);
            groupBoxFilter.TabIndex = 16;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filter";
            // 
            // btnFindLicense
            // 
            btnFindLicense.BackgroundImage = (Image)resources.GetObject("btnFindLicense.BackgroundImage");
            btnFindLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnFindLicense.Location = new Point(406, 18);
            btnFindLicense.Name = "btnFindLicense";
            btnFindLicense.Size = new Size(120, 40);
            btnFindLicense.TabIndex = 2;
            btnFindLicense.UseVisualStyleBackColor = true;
            btnFindLicense.Click += btnFindLicense_Click;
            // 
            // textBoxLicenseID
            // 
            textBoxLicenseID.Location = new Point(162, 25);
            textBoxLicenseID.MaxLength = 30;
            textBoxLicenseID.Name = "textBoxLicenseID";
            textBoxLicenseID.Size = new Size(186, 27);
            textBoxLicenseID.TabIndex = 1;
            textBoxLicenseID.TextChanged += textBoxLicenseID_TextChanged;
            textBoxLicenseID.KeyPress += textBoxLicenseID_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 28);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "Licence ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 15;
            label1.Text = "Release License";
            // 
            // linkLabelShowLicense
            // 
            linkLabelShowLicense.AutoSize = true;
            linkLabelShowLicense.Location = new Point(181, 635);
            linkLabelShowLicense.Name = "linkLabelShowLicense";
            linkLabelShowLicense.Size = new Size(97, 20);
            linkLabelShowLicense.TabIndex = 26;
            linkLabelShowLicense.TabStop = true;
            linkLabelShowLicense.Text = "Show License";
            linkLabelShowLicense.LinkClicked += linkLabelShowLicense_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 634);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(537, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 40);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(702, 634);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // linkLabelShowLicenseHistory
            // 
            linkLabelShowLicenseHistory.AutoSize = true;
            linkLabelShowLicenseHistory.Location = new Point(7, 635);
            linkLabelShowLicenseHistory.Name = "linkLabelShowLicenseHistory";
            linkLabelShowLicenseHistory.Size = new Size(148, 20);
            linkLabelShowLicenseHistory.TabIndex = 22;
            linkLabelShowLicenseHistory.TabStop = true;
            linkLabelShowLicenseHistory.Text = "Show License History";
            linkLabelShowLicenseHistory.LinkClicked += linkLabelShowLicenseHistory_LinkClicked;
            // 
            // btnRelease
            // 
            btnRelease.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.Location = new Point(691, 626);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(131, 40);
            btnRelease.TabIndex = 21;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrlReleaseInfo1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(7, 437);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(815, 183);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detain Info";
            // 
            // ctrlReleaseInfo1
            // 
            ctrlReleaseInfo1.Location = new Point(12, 17);
            ctrlReleaseInfo1.Name = "ctrlReleaseInfo1";
            ctrlReleaseInfo1.Size = new Size(790, 151);
            ctrlReleaseInfo1.TabIndex = 0;
            // 
            // frmReleaseLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 671);
            Controls.Add(groupBox3);
            Controls.Add(linkLabelShowLicense);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabelShowLicenseHistory);
            Controls.Add(btnRelease);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxFilter);
            Controls.Add(label1);
            Name = "frmReleaseLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release License";
            groupBox2.ResumeLayout(false);
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox groupBoxFilter;
        private Button btnFindLicense;
        private TextBox textBoxLicenseID;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabelShowLicense;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelShowLicenseHistory;
        private Button btnRelease;
        private GroupBox groupBox3;
        private ctrlReleaseInfo ctrlReleaseInfo1;
    }
}