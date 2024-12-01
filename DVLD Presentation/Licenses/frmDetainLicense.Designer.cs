namespace DVLD
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            groupBox2 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            groupBox1 = new GroupBox();
            btnFindLicense = new Button();
            textBoxLicenseID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            linkLabelShowLicense = new LinkLabel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            linkLabelShowLicenseHistory = new LinkLabel();
            btnDetain = new Button();
            groupBox3 = new GroupBox();
            ctrlDetainInfo1 = new ctrlDetainInfo();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(815, 291);
            groupBox2.TabIndex = 14;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFindLicense);
            groupBox1.Controls.Add(textBoxLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(132, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 71);
            groupBox1.TabIndex = 13;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(334, 23);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 12;
            label1.Text = "Detain License";
            // 
            // linkLabelShowLicense
            // 
            linkLabelShowLicense.AutoSize = true;
            linkLabelShowLicense.Location = new Point(206, 656);
            linkLabelShowLicense.Name = "linkLabelShowLicense";
            linkLabelShowLicense.Size = new Size(97, 20);
            linkLabelShowLicense.TabIndex = 20;
            linkLabelShowLicense.TabStop = true;
            linkLabelShowLicense.Text = "Show License";
            linkLabelShowLicense.LinkClicked += linkLabelShowLicense_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(545, 655);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(535, 647);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(695, 655);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // linkLabelShowLicenseHistory
            // 
            linkLabelShowLicenseHistory.AutoSize = true;
            linkLabelShowLicenseHistory.Location = new Point(13, 656);
            linkLabelShowLicenseHistory.Name = "linkLabelShowLicenseHistory";
            linkLabelShowLicenseHistory.Size = new Size(148, 20);
            linkLabelShowLicenseHistory.TabIndex = 16;
            linkLabelShowLicenseHistory.TabStop = true;
            linkLabelShowLicenseHistory.Text = "Show License History";
            linkLabelShowLicenseHistory.LinkClicked += linkLabelShowLicenseHistory_LinkClicked;
            // 
            // btnDetain
            // 
            btnDetain.Enabled = false;
            btnDetain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.Location = new Point(685, 647);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(140, 40);
            btnDetain.TabIndex = 15;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrlDetainInfo1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(13, 465);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(812, 173);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detain Info";
            // 
            // ctrlDetainInfo1
            // 
            ctrlDetainInfo1.Location = new Point(17, 17);
            ctrlDetainInfo1.Name = "ctrlDetainInfo1";
            ctrlDetainInfo1.Size = new Size(779, 140);
            ctrlDetainInfo1.TabIndex = 0;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 695);
            Controls.Add(groupBox3);
            Controls.Add(linkLabelShowLicense);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabelShowLicenseHistory);
            Controls.Add(btnDetain);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmDetainLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detain License";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox groupBox1;
        private Button btnFindLicense;
        private TextBox textBoxLicenseID;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabelShowLicense;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelShowLicenseHistory;
        private Button btnDetain;
        private GroupBox groupBox3;
        private ctrlDetainInfo ctrlDetainInfo1;
    }
}