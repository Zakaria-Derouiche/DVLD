namespace DVLD
{
    partial class frmIssueDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicense));
            groupBox = new GroupBox();
            ctrlDrivingLicenseApplicationInfo1 = new ctrlLocalDrivingLicenseApplicationInfo();
            groupBox2 = new GroupBox();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            txtBoxNotes = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnIssue = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(7, 98);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(891, 151);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Driving License Application Info";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.LicenseClassName = "";
            ctrlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(11, 26);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(861, 108);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlApplicationInfo1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(7, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(891, 282);
            groupBox2.TabIndex = 6;
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
            ctrlApplicationInfo1.Location = new Point(11, 26);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(861, 241);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // txtBoxNotes
            // 
            txtBoxNotes.Location = new Point(112, 543);
            txtBoxNotes.Multiline = true;
            txtBoxNotes.Name = "txtBoxNotes";
            txtBoxNotes.Size = new Size(525, 53);
            txtBoxNotes.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 546);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "Notes";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(634, 605);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 35);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 544);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(773, 605);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(128, 35);
            btnIssue.TabIndex = 10;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(643, 610);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(784, 610);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(334, 38);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 13;
            label2.Text = "Issue Driving License";
            // 
            // frmIssueDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 652);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnIssue);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtBoxNotes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Name = "frmIssueDrivingLicense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Driving License";
            groupBox.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private GroupBox groupBox2;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private TextBox txtBoxNotes;
        private Label label1;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnIssue;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
    }
}