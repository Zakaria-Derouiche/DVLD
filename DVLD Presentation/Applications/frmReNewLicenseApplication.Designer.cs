namespace DVLD
{
    partial class frmReNewLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReNewLicenseApplication));
            btnRenew = new Button();
            label1 = new Label();
            linkLabelShowLicenseHistory = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            linkLabelShowLicense = new LinkLabel();
            groupBox1 = new GroupBox();
            btnFindLicense = new Button();
            textBoxLicenseID = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            groupBox3 = new GroupBox();
            ctrlNewLicenseApplicationInfo1 = new ctrlNewLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRenew
            // 
            btnRenew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRenew.Location = new Point(695, 749);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(131, 40);
            btnRenew.TabIndex = 0;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(271, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 31);
            label1.TabIndex = 1;
            label1.Text = "ReNew License Application";
            // 
            // linkLabelShowLicenseHistory
            // 
            linkLabelShowLicenseHistory.AutoSize = true;
            linkLabelShowLicenseHistory.Location = new Point(11, 758);
            linkLabelShowLicenseHistory.Name = "linkLabelShowLicenseHistory";
            linkLabelShowLicenseHistory.Size = new Size(148, 20);
            linkLabelShowLicenseHistory.TabIndex = 2;
            linkLabelShowLicenseHistory.TabStop = true;
            linkLabelShowLicenseHistory.Text = "Show License History";
            linkLabelShowLicenseHistory.LinkClicked += linkLabelShowLicenseHistory_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(706, 757);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 757);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(541, 749);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // linkLabelShowLicense
            // 
            linkLabelShowLicense.AutoSize = true;
            linkLabelShowLicense.Location = new Point(168, 758);
            linkLabelShowLicense.Name = "linkLabelShowLicense";
            linkLabelShowLicense.Size = new Size(162, 20);
            linkLabelShowLicense.TabIndex = 8;
            linkLabelShowLicense.TabStop = true;
            linkLabelShowLicense.Text = "Show Renewed License";
            linkLabelShowLicense.LinkClicked += linkLabelShowLicense_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFindLicense);
            groupBox1.Controls.Add(textBoxLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(131, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 71);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(815, 291);
            groupBox2.TabIndex = 11;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrlNewLicenseApplicationInfo1);
            groupBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(11, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(815, 308);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "New License Application Info";
            // 
            // ctrlNewLicenseApplicationInfo1
            // 
            ctrlNewLicenseApplicationInfo1.Location = new Point(17, 24);
            ctrlNewLicenseApplicationInfo1.Name = "ctrlNewLicenseApplicationInfo1";
            ctrlNewLicenseApplicationInfo1.Size = new Size(781, 269);
            ctrlNewLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmReNewLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 814);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(linkLabelShowLicense);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabelShowLicenseHistory);
            Controls.Add(label1);
            Controls.Add(btnRenew);
            Name = "frmReNewLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReNew License Application";
            Load += frmReNewLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRenew;
        private Label label1;
        private LinkLabel linkLabelShowLicenseHistory;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnClose;
        private LinkLabel linkLabelShowLicense;
        private GroupBox groupBox1;
        private Button btnFindLicense;
        private TextBox textBoxLicenseID;
        private Label label2;
        private GroupBox groupBox2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox groupBox3;
        private ctrlNewLicenseApplicationInfo ctrlNewLicenseApplicationInfo1;
    }
}