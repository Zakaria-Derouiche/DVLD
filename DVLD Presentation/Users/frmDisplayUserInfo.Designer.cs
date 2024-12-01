namespace DVLD
{
    partial class frmDisplayUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplayUserInfo));
            ctrlPersonInfo1 = new ctrlPersonInfo();
            groupBoxLoginInfo = new GroupBox();
            lblIsActive = new Label();
            label5 = new Label();
            lblUserName = new Label();
            label3 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            groupBoxPersonalInfo = new GroupBox();
            btnSave = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            ctrlChangePassword1 = new ctrlChangePassword();
            pictureBox2 = new PictureBox();
            groupBoxLoginInfo.SuspendLayout();
            groupBoxPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.IsChanged = false;
            ctrlPersonInfo1.Location = new Point(10, 22);
            ctrlPersonInfo1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.PersonID = -1;
            ctrlPersonInfo1.Size = new Size(778, 305);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // groupBoxLoginInfo
            // 
            groupBoxLoginInfo.Controls.Add(lblIsActive);
            groupBoxLoginInfo.Controls.Add(label5);
            groupBoxLoginInfo.Controls.Add(lblUserName);
            groupBoxLoginInfo.Controls.Add(label3);
            groupBoxLoginInfo.Controls.Add(lblUserID);
            groupBoxLoginInfo.Controls.Add(label1);
            groupBoxLoginInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxLoginInfo.Location = new Point(12, 376);
            groupBoxLoginInfo.Name = "groupBoxLoginInfo";
            groupBoxLoginInfo.Size = new Size(799, 80);
            groupBoxLoginInfo.TabIndex = 1;
            groupBoxLoginInfo.TabStop = false;
            groupBoxLoginInfo.Text = "Login Info";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblIsActive.Location = new Point(628, 38);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(0, 20);
            lblIsActive.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(545, 38);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Is Active:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblUserName.Location = new Point(353, 38);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 20);
            lblUserName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(257, 38);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "UserName:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblUserID.Location = new Point(156, 38);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(0, 20);
            lblUserID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID:";
            // 
            // groupBoxPersonalInfo
            // 
            groupBoxPersonalInfo.Controls.Add(ctrlPersonInfo1);
            groupBoxPersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPersonalInfo.Location = new Point(12, 12);
            groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            groupBoxPersonalInfo.Size = new Size(799, 349);
            groupBoxPersonalInfo.TabIndex = 2;
            groupBoxPersonalInfo.TabStop = false;
            groupBoxPersonalInfo.Text = "Personal Info";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(536, 617);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(681, 617);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 622);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ctrlChangePassword1
            // 
            ctrlChangePassword1.Location = new Point(15, 462);
            ctrlChangePassword1.Name = "ctrlChangePassword1";
            ctrlChangePassword1.Size = new Size(792, 149);
            ctrlChangePassword1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(688, 622);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // frmDisplayUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 664);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlChangePassword1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(groupBoxPersonalInfo);
            Controls.Add(groupBoxLoginInfo);
            Name = "frmDisplayUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display User Info";
            FormClosing += frmDisplayUserInfo_FormClosing;
            groupBoxLoginInfo.ResumeLayout(false);
            groupBoxLoginInfo.PerformLayout();
            groupBoxPersonalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private GroupBox groupBoxLoginInfo;
        private Label lblIsActive;
        private Label label5;
        private Label lblUserName;
        private Label label3;
        private Label lblUserID;
        private Label label1;
        private GroupBox groupBoxPersonalInfo;
        private Button btnSave;
        private Button btnClose;
        private PictureBox pictureBox1;
        private ctrlChangePassword ctrlChangePassword1;
        private PictureBox pictureBox2;
    }
}