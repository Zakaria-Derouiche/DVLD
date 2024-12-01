namespace DVLD
{
    partial class frmShowLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLicenseInfo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(302, 115);
            label1.Name = "label1";
            label1.Size = new Size(214, 31);
            label1.TabIndex = 0;
            label1.Text = "Driver License Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ctrlDriverLicenseInfo1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 335);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver License Info";
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
            ctrlDriverLicenseInfo1.Location = new Point(21, 26);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.PersonID = 0;
            ctrlDriverLicenseInfo1.Size = new Size(744, 295);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(688, 502);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 35);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(693, 507);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // frmShowLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 548);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmShowLicenseInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show License Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
    }
}