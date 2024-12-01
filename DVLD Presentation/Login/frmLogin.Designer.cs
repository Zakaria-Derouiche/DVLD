namespace DVLD
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            errorProviderInputs = new ErrorProvider(components);
            checkBoxRememberMe = new CheckBox();
            label2 = new Label();
            picBoxPassword = new PictureBox();
            txtBoxPassword = new TextBox();
            picBoxUserName = new PictureBox();
            txtBoxUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClose = new Button();
            picBoxLogin = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // errorProviderInputs
            // 
            errorProviderInputs.ContainerControl = this;
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxRememberMe.Location = new Point(232, 386);
            checkBoxRememberMe.Margin = new Padding(3, 4, 3, 4);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.Size = new Size(130, 20);
            //checkBoxRememberMe.TabIndex = 4;
            checkBoxRememberMe.Text = "Remember Me";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 318);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            //label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // picBoxPassword
            // 
            picBoxPassword.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxPassword.Image = (Image)resources.GetObject("picBoxPassword.Image");
            picBoxPassword.Location = new Point(145, 312);
            picBoxPassword.Margin = new Padding(3, 4, 3, 4);
            picBoxPassword.Name = "picBoxPassword";
            picBoxPassword.Size = new Size(30, 35);
            picBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            //picBoxPassword.TabIndex = 13;
            picBoxPassword.TabStop = false;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtBoxPassword.Location = new Point(221, 314);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(252, 28);
            txtBoxPassword.TabIndex = 0;
            // 
            // picBoxUserName
            // 
            picBoxUserName.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxUserName.Image = (Image)resources.GetObject("picBoxUserName.Image");
            picBoxUserName.Location = new Point(145, 238);
            picBoxUserName.Margin = new Padding(3, 4, 3, 4);
            picBoxUserName.Name = "picBoxUserName";
            picBoxUserName.Size = new Size(30, 35);
            picBoxUserName.SizeMode = PictureBoxSizeMode.Zoom;
            //picBoxUserName.TabIndex = 7;
            picBoxUserName.TabStop = false;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtBoxUserName.Location = new Point(221, 241);
            txtBoxUserName.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(252, 28);
            //txtBoxUserName.TabIndex = 0;
            txtBoxUserName.KeyPress += txtBoxUserName_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 244);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            //label1.TabIndex = 10;
            label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 68);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(107, 21);
            label3.Name = "label3";
            label3.Size = new Size(320, 32);
            //label3.TabIndex = 9;
            label3.Text = "Login To Your Account";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(picBoxLogin);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(txtBoxUserName);
            splitContainer1.Panel2.Controls.Add(picBoxUserName);
            splitContainer1.Panel2.Controls.Add(txtBoxPassword);
            splitContainer1.Panel2.Controls.Add(picBoxPassword);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(checkBoxRememberMe);
            splitContainer1.Size = new Size(858, 515);
            splitContainer1.SplitterDistance = 327;
           // splitContainer1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.LightSalmon;
            label8.Location = new Point(94, 396);
            label8.Name = "label8";
            label8.Size = new Size(144, 29);
            //label8.TabIndex = 9;
            label8.Text = "Version 1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.LightSalmon;
            label6.Location = new Point(92, 238);
            label6.Name = "label6";
            label6.Size = new Size(148, 29);
            //label6.TabIndex = 7;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.LightSalmon;
            label7.Location = new Point(117, 317);
            label7.Name = "label7";
            label7.Size = new Size(98, 29);
            //label7.TabIndex = 8;
            label7.Text = "System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.LightSalmon;
            label4.Location = new Point(102, 80);
            label4.Name = "label4";
            label4.Size = new Size(129, 29);
            //label4.TabIndex = 5;
            label4.Text = "Welcome ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.LightSalmon;
            label5.Location = new Point(16, 159);
            label5.Name = "label5";
            label5.Size = new Size(301, 29);
            //label5.TabIndex = 6;
            label5.Text = "Driving & Vehicle License ";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(485, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // picBoxLogin
            // 
            picBoxLogin.BackgroundImageLayout = ImageLayout.Zoom;
            picBoxLogin.Image = (Image)resources.GetObject("picBoxLogin.Image");
            picBoxLogin.Location = new Point(154, 435);
            picBoxLogin.Margin = new Padding(3, 4, 3, 4);
            picBoxLogin.Name = "picBoxLogin";
            picBoxLogin.Size = new Size(40, 40);
            picBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            //picBoxLogin.TabIndex = 12;
            picBoxLogin.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(140, 428);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(252, 55);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(868, 525);
            ControlBox = false;
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Activated += frmLogin_Activated;
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderInputs).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProviderInputs;
        private SplitContainer splitContainer1;
        private Button btnLogin;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBoxUserName;
        private PictureBox picBoxUserName;
        private TextBox txtBoxPassword;
        private PictureBox picBoxPassword;
        private Label label2;
        private CheckBox checkBoxRememberMe;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label8;
        private PictureBox picBoxLogin;
        private Button btnClose;
    }
}