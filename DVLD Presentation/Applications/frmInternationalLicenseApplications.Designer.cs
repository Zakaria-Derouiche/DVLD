namespace DVLD
{
    partial class frmInternationalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalLicenseApplications));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblRecordsNumber = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            dataGridViewInternationalLicenseApplications = new DataGridView();
            contextMenuStripLicenses = new ContextMenuStrip(components);
            showDriverDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonDrivingLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            comboBoxFiter = new ComboBox();
            txtBoxFilter = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInternationalLicenseApplications).BeginInit();
            contextMenuStripLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(294, 101);
            label1.Name = "label1";
            label1.Size = new Size(383, 31);
            label1.TabIndex = 0;
            label1.Text = "International License Applications";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 149);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Filter By";
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecordsNumber.Location = new Point(13, 416);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(0, 20);
            lblRecordsNumber.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(838, 408);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(850, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 39);
            btnAdd.TabIndex = 5;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewInternationalLicenseApplications
            // 
            dataGridViewInternationalLicenseApplications.AllowUserToAddRows = false;
            dataGridViewInternationalLicenseApplications.AllowUserToDeleteRows = false;
            dataGridViewInternationalLicenseApplications.AllowUserToOrderColumns = true;
            dataGridViewInternationalLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInternationalLicenseApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewInternationalLicenseApplications.BackgroundColor = SystemColors.Control;
            dataGridViewInternationalLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInternationalLicenseApplications.ContextMenuStrip = contextMenuStripLicenses;
            dataGridViewInternationalLicenseApplications.Location = new Point(13, 189);
            dataGridViewInternationalLicenseApplications.Name = "dataGridViewInternationalLicenseApplications";
            dataGridViewInternationalLicenseApplications.ReadOnly = true;
            dataGridViewInternationalLicenseApplications.RowHeadersWidth = 51;
            dataGridViewInternationalLicenseApplications.Size = new Size(945, 211);
            dataGridViewInternationalLicenseApplications.TabIndex = 6;
            // 
            // contextMenuStripLicenses
            // 
            contextMenuStripLicenses.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            contextMenuStripLicenses.ImageScalingSize = new Size(20, 20);
            contextMenuStripLicenses.Items.AddRange(new ToolStripItem[] { showDriverDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonDrivingLicenseHistoryToolStripMenuItem });
            contextMenuStripLicenses.Name = "contextMenuStripLicenses";
            contextMenuStripLicenses.Size = new Size(342, 82);
            // 
            // showDriverDetailsToolStripMenuItem
            // 
            showDriverDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showDriverDetailsToolStripMenuItem.Image");
            showDriverDetailsToolStripMenuItem.Name = "showDriverDetailsToolStripMenuItem";
            showDriverDetailsToolStripMenuItem.Size = new Size(341, 26);
            showDriverDetailsToolStripMenuItem.Text = "Show Person Details";
            showDriverDetailsToolStripMenuItem.Click += showDriverDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(341, 26);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonDrivingLicenseHistoryToolStripMenuItem
            // 
            showPersonDrivingLicenseHistoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            showPersonDrivingLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDrivingLicenseHistoryToolStripMenuItem.Image");
            showPersonDrivingLicenseHistoryToolStripMenuItem.Name = "showPersonDrivingLicenseHistoryToolStripMenuItem";
            showPersonDrivingLicenseHistoryToolStripMenuItem.Size = new Size(341, 26);
            showPersonDrivingLicenseHistoryToolStripMenuItem.Text = "Show Person Driving License History";
            showPersonDrivingLicenseHistoryToolStripMenuItem.Click += showPersonDrivingLicenseHistoryToolStripMenuItem_Click;
            // 
            // comboBoxFiter
            // 
            comboBoxFiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiter.FormattingEnabled = true;
            comboBoxFiter.Items.AddRange(new object[] { "None", "InterNational.Lic.ID", "Driver.ID", "Local.Lic.ID", "App.ID" });
            comboBoxFiter.Location = new Point(90, 146);
            comboBoxFiter.Name = "comboBoxFiter";
            comboBoxFiter.Size = new Size(160, 28);
            comboBoxFiter.TabIndex = 7;
            comboBoxFiter.SelectedIndexChanged += comboBoxFiter_SelectedIndexChanged;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(273, 146);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(164, 27);
            txtBoxFilter.TabIndex = 8;
            txtBoxFilter.Visible = false;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(849, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // frmInternationalLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 458);
            Controls.Add(pictureBox2);
            Controls.Add(txtBoxFilter);
            Controls.Add(comboBoxFiter);
            Controls.Add(dataGridViewInternationalLicenseApplications);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsNumber);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmInternationalLicenseApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "International License Applications";
            Load += frmInternationalLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInternationalLicenseApplications).EndInit();
            contextMenuStripLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblRecordsNumber;
        private Button btnClose;
        private Button btnAdd;
        private DataGridView dataGridViewInternationalLicenseApplications;
        private ComboBox comboBoxFiter;
        private TextBox txtBoxFilter;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStripLicenses;
        private ToolStripMenuItem showDriverDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonDrivingLicenseHistoryToolStripMenuItem;
    }
}