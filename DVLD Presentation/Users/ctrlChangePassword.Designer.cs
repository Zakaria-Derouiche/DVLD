namespace DVLD
{
    partial class ctrlChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlChangePassword));
            label1 = new Label();
            txtBoxCurrentPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBoxNewPassword = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            txtBoxConfirmedPassword = new TextBox();
            label3 = new Label();
            errorProviderInputs = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Current Password";
            // 
            // txtBoxCurrentPassword
            // 
            txtBoxCurrentPassword.Location = new Point(258, 21);
            txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            txtBoxCurrentPassword.PasswordChar = '*';
            txtBoxCurrentPassword.Size = new Size(230, 27);
            txtBoxCurrentPassword.TabIndex = 1;
            txtBoxCurrentPassword.Validating += TextBox_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtBoxNewPassword
            // 
            txtBoxNewPassword.Location = new Point(258, 61);
            txtBoxNewPassword.Name = "txtBoxNewPassword";
            txtBoxNewPassword.PasswordChar = '*';
            txtBoxNewPassword.Size = new Size(230, 27);
            txtBoxNewPassword.TabIndex = 4;
            txtBoxNewPassword.Validating += TextBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(13, 64);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 3;
            label2.Text = "New Password";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(190, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtBoxConfirmedPassword
            // 
            txtBoxConfirmedPassword.Location = new Point(258, 109);
            txtBoxConfirmedPassword.Name = "txtBoxConfirmedPassword";
            txtBoxConfirmedPassword.PasswordChar = '*';
            txtBoxConfirmedPassword.Size = new Size(230, 27);
            txtBoxConfirmedPassword.TabIndex = 7;
            txtBoxConfirmedPassword.TextChanged += txtBoxConfirmedPassword_TextChanged;
            txtBoxConfirmedPassword.Validating += TextBox_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 112);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm New Password";
            // 
            // errorProviderInputs
            // 
            errorProviderInputs.ContainerControl = this;
            // 
            // ctrlChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(txtBoxConfirmedPassword);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(txtBoxNewPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxCurrentPassword);
            Controls.Add(label1);
            Name = "ctrlChangePassword";
            Size = new Size(613, 149);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxCurrentPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtBoxNewPassword;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox txtBoxConfirmedPassword;
        private Label label3;
        private ErrorProvider errorProviderInputs;
    }
}
