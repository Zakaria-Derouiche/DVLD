namespace DVLD
{
    partial class ctrlUserLoginInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlUserLoginInfo));
            label1 = new Label();
            txtBoxUserName = new TextBox();
            pictureBox1 = new PictureBox();
            checkBoxActiveStatus = new CheckBox();
            txtBoxPassword = new TextBox();
            txtBoxConfirmedPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblUserID = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 126);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(233, 123);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(190, 27);
            txtBoxUserName.TabIndex = 1;
            txtBoxUserName.KeyPress += txtBoxUserName_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // checkBoxActiveStatus
            // 
            checkBoxActiveStatus.AutoSize = true;
            checkBoxActiveStatus.Location = new Point(217, 322);
            checkBoxActiveStatus.Name = "checkBoxActiveStatus";
            checkBoxActiveStatus.Size = new Size(86, 24);
            checkBoxActiveStatus.TabIndex = 3;
            checkBoxActiveStatus.Text = "Is Active";
            checkBoxActiveStatus.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(233, 192);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '.';
            txtBoxPassword.Size = new Size(190, 27);
            txtBoxPassword.TabIndex = 4;
            // 
            // txtBoxConfirmedPassword
            // 
            txtBoxConfirmedPassword.Location = new Point(233, 261);
            txtBoxConfirmedPassword.Name = "txtBoxConfirmedPassword";
            txtBoxConfirmedPassword.PasswordChar = '.';
            txtBoxConfirmedPassword.Size = new Size(190, 27);
            txtBoxConfirmedPassword.TabIndex = 5;
            txtBoxConfirmedPassword.Validating += txtBoxConfirmedPassword_Validating_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 195);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 264);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 57);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "User ID";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(246, 57);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(40, 20);
            lblUserID.TabIndex = 9;
            lblUserID.Text = "[???]";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(161, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(161, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(161, 254);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlUserLoginInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblUserID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxConfirmedPassword);
            Controls.Add(txtBoxPassword);
            Controls.Add(checkBoxActiveStatus);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxUserName);
            Controls.Add(label1);
            Name = "ctrlUserLoginInfo";
            Size = new Size(521, 364);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxUserName;
        private PictureBox pictureBox1;
        private CheckBox checkBoxActiveStatus;
        private TextBox txtBoxPassword;
        private TextBox txtBoxConfirmedPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblUserID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ErrorProvider errorProvider1;
    }
}
