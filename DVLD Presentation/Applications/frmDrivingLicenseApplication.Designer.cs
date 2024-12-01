namespace DVLD
{
    partial class frmDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivingLicenseApplication));
            btnSave = new Button();
            lblTitle = new Label();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabControlAddApplication = new TabControl();
            tabPagePersonalInfo = new TabPage();
            pictureBox3 = new PictureBox();
            btnNext = new Button();
            groupBoxFilter = new GroupBox();
            btnAdd = new Button();
            txtBoxFilter = new TextBox();
            btnFind = new Button();
            comboBoxFilter = new ComboBox();
            label1 = new Label();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            tabPageApplicationInfo = new TabPage();
            lblApplicationCreatedBy = new Label();
            lblApplicationFees = new Label();
            lblApplicationDate = new Label();
            lblDrivingLicenseApplicationID = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBoxLicenseClasses = new ComboBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            errorProviderInput = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControlAddApplication.SuspendLayout();
            tabPagePersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBoxFilter.SuspendLayout();
            tabPageApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInput).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(468, 518);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(171, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(447, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(637, 518);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(480, 523);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(646, 523);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // tabControlAddApplication
            // 
            tabControlAddApplication.Controls.Add(tabPagePersonalInfo);
            tabControlAddApplication.Controls.Add(tabPageApplicationInfo);
            tabControlAddApplication.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlAddApplication.Location = new Point(12, 64);
            tabControlAddApplication.Name = "tabControlAddApplication";
            tabControlAddApplication.SelectedIndex = 0;
            tabControlAddApplication.Size = new Size(764, 452);
            tabControlAddApplication.TabIndex = 6;
            tabControlAddApplication.SelectedIndexChanged += tabControlAddApplication_SelectedIndexChanged;
            tabControlAddApplication.Selected += tabControlAddApplication_Selected;
            // 
            // tabPagePersonalInfo
            // 
            tabPagePersonalInfo.Controls.Add(pictureBox3);
            tabPagePersonalInfo.Controls.Add(btnNext);
            tabPagePersonalInfo.Controls.Add(groupBoxFilter);
            tabPagePersonalInfo.Controls.Add(ctrlPersonInfo1);
            tabPagePersonalInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPagePersonalInfo.Location = new Point(4, 29);
            tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            tabPagePersonalInfo.Padding = new Padding(3);
            tabPagePersonalInfo.Size = new Size(756, 419);
            tabPagePersonalInfo.TabIndex = 0;
            tabPagePersonalInfo.Text = "Personal Info";
            tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(620, 378);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(609, 373);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(135, 40);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnAdd);
            groupBoxFilter.Controls.Add(txtBoxFilter);
            groupBoxFilter.Controls.Add(btnFind);
            groupBoxFilter.Controls.Add(comboBoxFilter);
            groupBoxFilter.Controls.Add(label1);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(15, 20);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(700, 60);
            groupBoxFilter.TabIndex = 1;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Fliter";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(596, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 35);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(316, 23);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(186, 27);
            txtBoxFilter.TabIndex = 1;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            txtBoxFilter.Validating += txtBoxFilter_Validating;
            // 
            // btnFind
            // 
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(508, 19);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(82, 35);
            btnFind.TabIndex = 2;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Person ID", "National No" });
            comboBoxFilter.Location = new Point(109, 23);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(186, 28);
            comboBoxFilter.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.IsChanged = false;
            ctrlPersonInfo1.Location = new Point(13, 87);
            ctrlPersonInfo1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.PersonID = 0;
            ctrlPersonInfo1.Size = new Size(731, 271);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // tabPageApplicationInfo
            // 
            tabPageApplicationInfo.Controls.Add(lblApplicationCreatedBy);
            tabPageApplicationInfo.Controls.Add(lblApplicationFees);
            tabPageApplicationInfo.Controls.Add(lblApplicationDate);
            tabPageApplicationInfo.Controls.Add(lblDrivingLicenseApplicationID);
            tabPageApplicationInfo.Controls.Add(pictureBox8);
            tabPageApplicationInfo.Controls.Add(pictureBox7);
            tabPageApplicationInfo.Controls.Add(pictureBox6);
            tabPageApplicationInfo.Controls.Add(pictureBox5);
            tabPageApplicationInfo.Controls.Add(label6);
            tabPageApplicationInfo.Controls.Add(label5);
            tabPageApplicationInfo.Controls.Add(label4);
            tabPageApplicationInfo.Controls.Add(label3);
            tabPageApplicationInfo.Controls.Add(comboBoxLicenseClasses);
            tabPageApplicationInfo.Controls.Add(pictureBox4);
            tabPageApplicationInfo.Controls.Add(label2);
            tabPageApplicationInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPageApplicationInfo.Location = new Point(4, 29);
            tabPageApplicationInfo.Name = "tabPageApplicationInfo";
            tabPageApplicationInfo.Padding = new Padding(3);
            tabPageApplicationInfo.Size = new Size(756, 419);
            tabPageApplicationInfo.TabIndex = 1;
            tabPageApplicationInfo.Text = "Application Info";
            tabPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lblApplicationCreatedBy
            // 
            lblApplicationCreatedBy.AutoSize = true;
            lblApplicationCreatedBy.Location = new Point(281, 320);
            lblApplicationCreatedBy.Name = "lblApplicationCreatedBy";
            lblApplicationCreatedBy.Size = new Size(42, 20);
            lblApplicationCreatedBy.TabIndex = 15;
            lblApplicationCreatedBy.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Location = new Point(281, 259);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(42, 20);
            lblApplicationFees.TabIndex = 14;
            lblApplicationFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Location = new Point(281, 137);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(42, 20);
            lblApplicationDate.TabIndex = 12;
            lblApplicationDate.Text = "[???]";
            // 
            // lblDrivingLicenseApplicationID
            // 
            lblDrivingLicenseApplicationID.AutoSize = true;
            lblDrivingLicenseApplicationID.Location = new Point(281, 76);
            lblDrivingLicenseApplicationID.Name = "lblDrivingLicenseApplicationID";
            lblDrivingLicenseApplicationID.Size = new Size(42, 20);
            lblDrivingLicenseApplicationID.TabIndex = 11;
            lblDrivingLicenseApplicationID.Text = "[???]";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(198, 317);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(198, 248);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(198, 189);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(198, 130);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 320);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 6;
            label6.Text = "Created By:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 259);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 5;
            label5.Text = "Application Fees:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 198);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "License Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 137);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Application Date:";
            // 
            // comboBoxLicenseClasses
            // 
            comboBoxLicenseClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLicenseClasses.FormattingEnabled = true;
            comboBoxLicenseClasses.Location = new Point(281, 191);
            comboBoxLicenseClasses.Name = "comboBoxLicenseClasses";
            comboBoxLicenseClasses.Size = new Size(298, 28);
            comboBoxLicenseClasses.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(198, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 76);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 0;
            label2.Text = "D L Application ID:";
            // 
            // errorProviderInput
            // 
            errorProviderInput.ContainerControl = this;
            // 
            // frmDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 565);
            Controls.Add(tabControlAddApplication);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Name = "frmDrivingLicenseApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Local Driving License Application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControlAddApplication.ResumeLayout(false);
            tabPagePersonalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            tabPageApplicationInfo.ResumeLayout(false);
            tabPageApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label lblTitle;
        private Button btnClose;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TabControl tabControlAddApplication;
        private TabPage tabPagePersonalInfo;
        private TabPage tabPageApplicationInfo;
        private ctrlPersonInfo ctrlPersonInfo1;
        private GroupBox groupBoxFilter;
        private Button btnAdd;
        private TextBox txtBoxFilter;
        private Button btnFind;
        private ComboBox comboBoxFilter;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnNext;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxLicenseClasses;
        private PictureBox pictureBox4;
        private Label label2;
        private Label lblApplicationCreatedBy;
        private Label lblApplicationFees;
        private Label lblApplicationDate;
        private Label lblDrivingLicenseApplicationID;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label6;
        private Label label5;
        private ErrorProvider errorProviderInput;
    }
}