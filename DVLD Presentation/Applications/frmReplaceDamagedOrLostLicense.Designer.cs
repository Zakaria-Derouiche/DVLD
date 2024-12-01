namespace DVLD
{
    partial class frmReplaceDamagedOrLostLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceDamagedOrLostLicense));
            lblTitle = new Label();
            groupBoxFilter = new GroupBox();
            btnFindLicense = new Button();
            textBoxLicenseID = new TextBox();
            label2 = new Label();
            groupBoxReplacementType = new GroupBox();
            radioButtonLost = new RadioButton();
            radioButtonDamged = new RadioButton();
            groupBox3 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            linkLabelShowLicense = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            linkLabelShowLicenseHistory = new LinkLabel();
            btnIssueReplacement = new Button();
            groupBox4 = new GroupBox();
            ctrlRepalcementApplicationInfo1 = new ctrlRepalcementApplicationInfo();
            groupBoxFilter.SuspendLayout();
            groupBoxReplacementType.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(274, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Repalcement For Damaged License";
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnFindLicense);
            groupBoxFilter.Controls.Add(textBoxLicenseID);
            groupBoxFilter.Controls.Add(label2);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(12, 66);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(575, 71);
            groupBoxFilter.TabIndex = 12;
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
            textBoxLicenseID.Location = new Point(177, 28);
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
            // groupBoxReplacementType
            // 
            groupBoxReplacementType.Controls.Add(radioButtonLost);
            groupBoxReplacementType.Controls.Add(radioButtonDamged);
            groupBoxReplacementType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxReplacementType.Location = new Point(613, 66);
            groupBoxReplacementType.Name = "groupBoxReplacementType";
            groupBoxReplacementType.Size = new Size(291, 95);
            groupBoxReplacementType.TabIndex = 13;
            groupBoxReplacementType.TabStop = false;
            groupBoxReplacementType.Text = "Replacement For";
            // 
            // radioButtonLost
            // 
            radioButtonLost.AutoSize = true;
            radioButtonLost.Location = new Point(15, 59);
            radioButtonLost.Name = "radioButtonLost";
            radioButtonLost.Size = new Size(115, 24);
            radioButtonLost.TabIndex = 1;
            radioButtonLost.TabStop = true;
            radioButtonLost.Text = "Lost License";
            radioButtonLost.UseVisualStyleBackColor = true;
            radioButtonLost.CheckedChanged += radioButtonLost_CheckedChanged;
            // 
            // radioButtonDamged
            // 
            radioButtonDamged.AutoSize = true;
            radioButtonDamged.Location = new Point(15, 29);
            radioButtonDamged.Name = "radioButtonDamged";
            radioButtonDamged.Size = new Size(152, 24);
            radioButtonDamged.TabIndex = 0;
            radioButtonDamged.TabStop = true;
            radioButtonDamged.Text = "Damaged License";
            radioButtonDamged.UseVisualStyleBackColor = true;
            radioButtonDamged.CheckedChanged += radioButtonDamged_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 167);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 342);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Driver License Info";
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.ApplicationID = 0;
            ctrlDriverLicenseInfo1.CreatedByUserID = 0;
            ctrlDriverLicenseInfo1.DriverID = 0;
            ctrlDriverLicenseInfo1.ExpirationDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlDriverLicenseInfo1.IsActive = false;
            ctrlDriverLicenseInfo1.IssueDate = new DateTime(0L);
            ctrlDriverLicenseInfo1.LicenseClassName = null;
            ctrlDriverLicenseInfo1.LicenseID = 0;
            ctrlDriverLicenseInfo1.Location = new Point(12, 26);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.PersonID = 0;
            ctrlDriverLicenseInfo1.Size = new Size(885, 296);
            ctrlDriverLicenseInfo1.TabIndex = 2;
            // 
            // linkLabelShowLicense
            // 
            linkLabelShowLicense.AutoSize = true;
            linkLabelShowLicense.Location = new Point(208, 737);
            linkLabelShowLicense.Name = "linkLabelShowLicense";
            linkLabelShowLicense.Size = new Size(131, 20);
            linkLabelShowLicense.TabIndex = 20;
            linkLabelShowLicense.TabStop = true;
            linkLabelShowLicense.Text = "Show New License";
            linkLabelShowLicense.LinkClicked += linkLabelShowLicense_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(550, 737);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(537, 729);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 40);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(700, 737);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // linkLabelShowLicenseHistory
            // 
            linkLabelShowLicenseHistory.AutoSize = true;
            linkLabelShowLicenseHistory.Location = new Point(15, 737);
            linkLabelShowLicenseHistory.Name = "linkLabelShowLicenseHistory";
            linkLabelShowLicenseHistory.Size = new Size(148, 20);
            linkLabelShowLicenseHistory.TabIndex = 16;
            linkLabelShowLicenseHistory.TabStop = true;
            linkLabelShowLicenseHistory.Text = "Show License History";
            linkLabelShowLicenseHistory.LinkClicked += linkLabelShowLicenseHistory_LinkClicked;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueReplacement.Location = new Point(685, 729);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(236, 40);
            btnIssueReplacement.TabIndex = 15;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.UseVisualStyleBackColor = true;
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ctrlRepalcementApplicationInfo1);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(15, 536);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(903, 187);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Application Info For License Repalcement";
            // 
            // ctrlRepalcementApplicationInfo1
            // 
            ctrlRepalcementApplicationInfo1.Location = new Point(19, 26);
            ctrlRepalcementApplicationInfo1.Name = "ctrlRepalcementApplicationInfo1";
            ctrlRepalcementApplicationInfo1.Size = new Size(864, 141);
            ctrlRepalcementApplicationInfo1.TabIndex = 22;
            // 
            // frmReplaceDamagedOrLostLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 772);
            Controls.Add(groupBox4);
            Controls.Add(linkLabelShowLicense);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabelShowLicenseHistory);
            Controls.Add(btnIssueReplacement);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxReplacementType);
            Controls.Add(groupBoxFilter);
            Controls.Add(lblTitle);
            Name = "frmReplaceDamagedOrLostLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Replace Damaged Or Lost License";
            Load += frmReplaceDamagedOrLostLicense_Load;
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            groupBoxReplacementType.ResumeLayout(false);
            groupBoxReplacementType.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBoxFilter;
        private Button btnFindLicense;
        private TextBox textBoxLicenseID;
        private Label label2;
        private GroupBox groupBoxReplacementType;
        private RadioButton radioButtonLost;
        private RadioButton radioButtonDamged;
        private GroupBox groupBox3;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private LinkLabel linkLabelShowLicense;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelShowLicenseHistory;
        private Button btnIssueReplacement;
        private GroupBox groupBox4;
        private ctrlRepalcementApplicationInfo ctrlRepalcementApplicationInfo1;
    }
}