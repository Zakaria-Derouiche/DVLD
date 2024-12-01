namespace DVLD
{
    partial class frmActivateDesactivateLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivateDesactivateLicense));
            groupBox3 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            groupBox1 = new GroupBox();
            btnFindLicense = new Button();
            textBoxLicenseID = new TextBox();
            label2 = new Label();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            btnActivateDesactivate = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(909, 342);
            groupBox3.TabIndex = 18;
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
            ctrlDriverLicenseInfo1.Location = new Point(7, 26);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.PersonID = 0;
            ctrlDriverLicenseInfo1.Size = new Size(885, 296);
            ctrlDriverLicenseInfo1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFindLicense);
            groupBox1.Controls.Add(textBoxLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(182, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 71);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // btnFindLicense
            // 
            btnFindLicense.BackgroundImage = (Image)resources.GetObject("btnFindLicense.BackgroundImage");
            btnFindLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnFindLicense.Location = new Point(406, 26);
            btnFindLicense.Name = "btnFindLicense";
            btnFindLicense.Size = new Size(111, 32);
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(365, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 31);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Activate A License";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 512);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(515, 504);
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
            pictureBox2.Location = new Point(705, 512);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // btnActivateDesactivate
            // 
            btnActivateDesactivate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivateDesactivate.Location = new Point(685, 504);
            btnActivateDesactivate.Name = "btnActivateDesactivate";
            btnActivateDesactivate.Size = new Size(236, 40);
            btnActivateDesactivate.TabIndex = 21;
            btnActivateDesactivate.Text = "Activate";
            btnActivateDesactivate.UseVisualStyleBackColor = true;
            btnActivateDesactivate.Click += btnActivateDesactivate_Click;
            // 
            // frmActivateDesactivateLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 559);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(btnActivateDesactivate);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "frmActivateDesactivateLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Activate License";
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox groupBox1;
        private Button btnFindLicense;
        private TextBox textBoxLicenseID;
        private Label label2;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Button btnActivateDesactivate;
    }
}