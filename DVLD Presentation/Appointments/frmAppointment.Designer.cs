namespace DVLD
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            groupBox = new GroupBox();
            ctrlDrivingLicenseApplicationInfo1 = new ctrlLocalDrivingLicenseApplicationInfo();
            dataGridViewTestApointements = new DataGridView();
            contextMenuStripAppointments = new ContextMenuStrip(components);
            editTestToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ctrlApplicationInfo1 = new ctrlApplicationInfo();
            lblAppointmentsNumber = new Label();
            picBoxFromType = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            lblFormTitle = new Label();
            btnAddAppointement = new Button();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestApointements).BeginInit();
            contextMenuStripAppointments.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFromType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            groupBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(15, 176);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(872, 151);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Driving License Application Info";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.LicenseClassName = "";
            ctrlDrivingLicenseApplicationInfo1.LocalDrivingLicenseApplicationID = -1;
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(11, 22);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(850, 113);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // dataGridViewTestApointements
            // 
            dataGridViewTestApointements.AllowUserToAddRows = false;
            dataGridViewTestApointements.AllowUserToDeleteRows = false;
            dataGridViewTestApointements.AllowUserToOrderColumns = true;
            dataGridViewTestApointements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTestApointements.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTestApointements.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTestApointements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTestApointements.ContextMenuStrip = contextMenuStripAppointments;
            dataGridViewTestApointements.Location = new Point(15, 656);
            dataGridViewTestApointements.Name = "dataGridViewTestApointements";
            dataGridViewTestApointements.ReadOnly = true;
            dataGridViewTestApointements.RowHeadersWidth = 51;
            dataGridViewTestApointements.Size = new Size(872, 117);
            dataGridViewTestApointements.TabIndex = 2;
            // 
            // contextMenuStripAppointments
            // 
            contextMenuStripAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStripAppointments.ImageScalingSize = new Size(20, 20);
            contextMenuStripAppointments.Items.AddRange(new ToolStripItem[] { editTestToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStripAppointments.Name = "contextMenuStripAppointments";
            contextMenuStripAppointments.Size = new Size(148, 56);
            // 
            // editTestToolStripMenuItem
            // 
            editTestToolStripMenuItem.Image = (Image)resources.GetObject("editTestToolStripMenuItem.Image");
            editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            editTestToolStripMenuItem.Size = new Size(147, 26);
            editTestToolStripMenuItem.Text = "Edit Test";
            editTestToolStripMenuItem.Click += editTestToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = (Image)resources.GetObject("takeTestToolStripMenuItem.Image");
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(147, 26);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 622);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "Appointements";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlApplicationInfo1);
            groupBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(872, 252);
            groupBox2.TabIndex = 5;
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
            ctrlApplicationInfo1.Location = new Point(9, 22);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(855, 205);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // lblAppointmentsNumber
            // 
            lblAppointmentsNumber.AutoSize = true;
            lblAppointmentsNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppointmentsNumber.Location = new Point(24, 784);
            lblAppointmentsNumber.Name = "lblAppointmentsNumber";
            lblAppointmentsNumber.Size = new Size(0, 20);
            lblAppointmentsNumber.TabIndex = 6;
            // 
            // picBoxFromType
            // 
            picBoxFromType.BorderStyle = BorderStyle.FixedSingle;
            picBoxFromType.Location = new Point(315, 12);
            picBoxFromType.Name = "picBoxFromType";
            picBoxFromType.Size = new Size(273, 101);
            picBoxFromType.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxFromType.TabIndex = 7;
            picBoxFromType.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(751, 779);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(136, 40);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(763, 784);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.IndianRed;
            lblFormTitle.Location = new Point(451, 128);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(0, 23);
            lblFormTitle.TabIndex = 9;
            // 
            // btnAddAppointement
            // 
            btnAddAppointement.BackgroundImage = (Image)resources.GetObject("btnAddAppointement.BackgroundImage");
            btnAddAppointement.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddAppointement.Location = new Point(797, 615);
            btnAddAppointement.Name = "btnAddAppointement";
            btnAddAppointement.Size = new Size(90, 35);
            btnAddAppointement.TabIndex = 11;
            btnAddAppointement.UseVisualStyleBackColor = true;
            btnAddAppointement.Click += btnAddAppointement_Click;
            // 
            // frmAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 827);
            Controls.Add(btnAddAppointement);
            Controls.Add(lblFormTitle);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(picBoxFromType);
            Controls.Add(lblAppointmentsNumber);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dataGridViewTestApointements);
            Controls.Add(groupBox);
            Name = "frmAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointements";
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestApointements).EndInit();
            contextMenuStripAppointments.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxFromType).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private DataGridView dataGridViewTestApointements;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblAppointmentsNumber;
        private PictureBox picBoxFromType;
        private Button btnClose;
        private PictureBox pictureBox2;
        private ctrlLocalDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private ctrlApplicationInfo ctrlApplicationInfo1;
        private Label lblFormTitle;
        private Button btnAddAppointement;
        private ContextMenuStrip contextMenuStripAppointments;
        private ToolStripMenuItem editTestToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}