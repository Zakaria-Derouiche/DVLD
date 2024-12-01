namespace DVLD
{
    partial class frmLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenseApplications));
            btnAddApplication = new Button();
            dataGridViewLocalApplications = new DataGridView();
            contextMenuStripLocalApplications = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            sechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            visionTestToolStripMenuItem = new ToolStripMenuItem();
            writtingTestToolStripMenuItem = new ToolStripMenuItem();
            drivingTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            txtBoxFilter = new TextBox();
            pictureBox1 = new PictureBox();
            lblRecordNumber = new Label();
            comboBoxStatus = new ComboBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalApplications).BeginInit();
            contextMenuStripLocalApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddApplication
            // 
            btnAddApplication.BackgroundImage = (Image)resources.GetObject("btnAddApplication.BackgroundImage");
            btnAddApplication.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddApplication.Location = new Point(890, 136);
            btnAddApplication.Name = "btnAddApplication";
            btnAddApplication.Size = new Size(130, 38);
            btnAddApplication.TabIndex = 0;
            btnAddApplication.UseVisualStyleBackColor = true;
            btnAddApplication.Click += btnAddApplication_Click;
            // 
            // dataGridViewLocalApplications
            // 
            dataGridViewLocalApplications.AllowUserToAddRows = false;
            dataGridViewLocalApplications.AllowUserToDeleteRows = false;
            dataGridViewLocalApplications.AllowUserToOrderColumns = true;
            dataGridViewLocalApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLocalApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLocalApplications.BackgroundColor = SystemColors.ControlLight;
            dataGridViewLocalApplications.ColumnHeadersHeight = 29;
            dataGridViewLocalApplications.ContextMenuStrip = contextMenuStripLocalApplications;
            dataGridViewLocalApplications.GridColor = SystemColors.Menu;
            dataGridViewLocalApplications.Location = new Point(13, 190);
            dataGridViewLocalApplications.MultiSelect = false;
            dataGridViewLocalApplications.Name = "dataGridViewLocalApplications";
            dataGridViewLocalApplications.ReadOnly = true;
            dataGridViewLocalApplications.RowHeadersWidth = 51;
            dataGridViewLocalApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLocalApplications.Size = new Size(1007, 197);
            dataGridViewLocalApplications.TabIndex = 1;
            // 
            // contextMenuStripLocalApplications
            // 
            contextMenuStripLocalApplications.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            contextMenuStripLocalApplications.ImageScalingSize = new Size(30, 30);
            contextMenuStripLocalApplications.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem, sechduleTestsToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStripLocalApplications.LayoutStyle = ToolStripLayoutStyle.Table;
            contextMenuStripLocalApplications.Name = "contextMenuStrip1";
            contextMenuStripLocalApplications.Size = new Size(326, 256);
            contextMenuStripLocalApplications.Opened += contextMenuStripLocalApplications_Opened;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showApplicationDetailsToolStripMenuItem.Image");
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(325, 36);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = (Image)resources.GetObject("deleteApplicationToolStripMenuItem.Image");
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(325, 36);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Image = (Image)resources.GetObject("cancelApplicationToolStripMenuItem.Image");
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(325, 36);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // sechduleTestsToolStripMenuItem
            // 
            sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visionTestToolStripMenuItem, writtingTestToolStripMenuItem, drivingTestToolStripMenuItem });
            sechduleTestsToolStripMenuItem.Image = (Image)resources.GetObject("sechduleTestsToolStripMenuItem.Image");
            sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            sechduleTestsToolStripMenuItem.Size = new Size(325, 36);
            sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            sechduleTestsToolStripMenuItem.DropDownOpened += sechduleTestsToolStripMenuItem_DropDownOpened;
            // 
            // visionTestToolStripMenuItem
            // 
            visionTestToolStripMenuItem.Image = (Image)resources.GetObject("visionTestToolStripMenuItem.Image");
            visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            visionTestToolStripMenuItem.Size = new Size(197, 36);
            visionTestToolStripMenuItem.Text = "Vision Test";
            visionTestToolStripMenuItem.Click += visionTestToolStripMenuItem_Click;
            // 
            // writtingTestToolStripMenuItem
            // 
            writtingTestToolStripMenuItem.Image = (Image)resources.GetObject("writtingTestToolStripMenuItem.Image");
            writtingTestToolStripMenuItem.Name = "writtingTestToolStripMenuItem";
            writtingTestToolStripMenuItem.Size = new Size(197, 36);
            writtingTestToolStripMenuItem.Text = "Writting Test";
            writtingTestToolStripMenuItem.Click += writtingTestToolStripMenuItem_Click;
            // 
            // drivingTestToolStripMenuItem
            // 
            drivingTestToolStripMenuItem.Image = (Image)resources.GetObject("drivingTestToolStripMenuItem.Image");
            drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem";
            drivingTestToolStripMenuItem.Size = new Size(197, 36);
            drivingTestToolStripMenuItem.Text = "Driving Test";
            drivingTestToolStripMenuItem.Click += drivingTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = (Image)resources.GetObject("issueDrivingLicenseFirstTimeToolStripMenuItem.Image");
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(325, 36);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License(First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseToolStripMenuItem.Image");
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(325, 36);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(325, 36);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(325, 113);
            label1.Name = "label1";
            label1.Size = new Size(383, 31);
            label1.TabIndex = 2;
            label1.Text = "Local Driving License Applications";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "None", "L.B.L.AppID", "National No", "Full Name", "Status" });
            comboBoxFilter.Location = new Point(12, 145);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(191, 28);
            comboBoxFilter.TabIndex = 3;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(238, 146);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(191, 27);
            txtBoxFilter.TabIndex = 4;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblRecordNumber
            // 
            lblRecordNumber.AutoSize = true;
            lblRecordNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordNumber.Location = new Point(13, 398);
            lblRecordNumber.Name = "lblRecordNumber";
            lblRecordNumber.Size = new Size(0, 20);
            lblRecordNumber.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "All", "New", "Canceled", "Completed" });
            comboBoxStatus.Location = new Point(238, 146);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(191, 28);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(890, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 40);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(901, 398);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 444);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(comboBoxStatus);
            Controls.Add(lblRecordNumber);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxFilter);
            Controls.Add(comboBoxFilter);
            Controls.Add(label1);
            Controls.Add(dataGridViewLocalApplications);
            Controls.Add(btnAddApplication);
            Name = "frmLocalDrivingLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Applications";
            Load += frmLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalApplications).EndInit();
            contextMenuStripLocalApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddApplication;
        private DataGridView dataGridViewLocalApplications;
        private Label label1;
        private ComboBox comboBoxFilter;
        private TextBox txtBoxFilter;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStripLocalApplications;
        private Label lblRecordNumber;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ComboBox comboBoxStatus;
        private ToolStripMenuItem visionTestToolStripMenuItem;
        private ToolStripMenuItem writtingTestToolStripMenuItem;
        private ToolStripMenuItem drivingTestToolStripMenuItem;
        private Button btnClose;
        private PictureBox pictureBox2;
    }
}