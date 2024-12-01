namespace DVLD
{
    partial class frmdetainedLicensesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdetainedLicensesList));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnDetain = new Button();
            dataGridViewDetainedLicenses = new DataGridView();
            contextMenuStripList = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsNumber = new Label();
            btnRelease = new Button();
            btnClose = new Button();
            lblFilterBy = new Label();
            comboBoxFilter = new ComboBox();
            pictureBox2 = new PictureBox();
            txtBoxFilter = new TextBox();
            rbNo = new RadioButton();
            rbYes = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetainedLicenses).BeginInit();
            contextMenuStripList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(420, 110);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 0;
            label1.Text = "Detained Licenses List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnDetain
            // 
            btnDetain.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.Location = new Point(980, 155);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(150, 40);
            btnDetain.TabIndex = 2;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // dataGridViewDetainedLicenses
            // 
            dataGridViewDetainedLicenses.AllowUserToAddRows = false;
            dataGridViewDetainedLicenses.AllowUserToDeleteRows = false;
            dataGridViewDetainedLicenses.AllowUserToOrderColumns = true;
            dataGridViewDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetainedLicenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetainedLicenses.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetainedLicenses.ContextMenuStrip = contextMenuStripList;
            dataGridViewDetainedLicenses.Location = new Point(9, 204);
            dataGridViewDetainedLicenses.MultiSelect = false;
            dataGridViewDetainedLicenses.Name = "dataGridViewDetainedLicenses";
            dataGridViewDetainedLicenses.ReadOnly = true;
            dataGridViewDetainedLicenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewDetainedLicenses.ScrollBars = ScrollBars.None;
            dataGridViewDetainedLicenses.Size = new Size(1125, 188);
            dataGridViewDetainedLicenses.TabIndex = 3;
            // 
            // contextMenuStripList
            // 
            contextMenuStripList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStripList.ImageScalingSize = new Size(20, 20);
            contextMenuStripList.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, releaseDetainedLToolStripMenuItem });
            contextMenuStripList.Name = "contextMenuStripList";
            contextMenuStripList.Size = new Size(284, 108);
            contextMenuStripList.Opened += contextMenuStripList_Opened;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(283, 26);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(283, 26);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(283, 26);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // releaseDetainedLToolStripMenuItem
            // 
            releaseDetainedLToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainedLToolStripMenuItem.Image");
            releaseDetainedLToolStripMenuItem.Name = "releaseDetainedLToolStripMenuItem";
            releaseDetainedLToolStripMenuItem.Size = new Size(283, 26);
            releaseDetainedLToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLToolStripMenuItem.Click += releaseDetainedLToolStripMenuItem_Click;
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsNumber.Location = new Point(15, 414);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(0, 20);
            lblRecordsNumber.TabIndex = 4;
            // 
            // btnRelease
            // 
            btnRelease.BackgroundImageLayout = ImageLayout.Zoom;
            btnRelease.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.Location = new Point(787, 155);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(150, 40);
            btnRelease.TabIndex = 5;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1011, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterBy.Location = new Point(15, 162);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(67, 20);
            lblFilterBy.TabIndex = 7;
            lblFilterBy.Text = "Filter By";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National Number", "Full Name", "Release App.ID" });
            comboBoxFilter.Location = new Point(100, 162);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(183, 28);
            comboBoxFilter.TabIndex = 8;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1023, 414);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(300, 162);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(183, 27);
            txtBoxFilter.TabIndex = 10;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(366, 163);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(50, 24);
            rbNo.TabIndex = 11;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            rbNo.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Checked = true;
            rbYes.Location = new Point(300, 163);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(51, 24);
            rbYes.TabIndex = 12;
            rbYes.TabStop = true;
            rbYes.Text = "Yes";
            rbYes.UseVisualStyleBackColor = true;
            rbYes.CheckedChanged += radioButton_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(795, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(990, 164);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // frmdetainedLicensesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 456);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(rbYes);
            Controls.Add(rbNo);
            Controls.Add(txtBoxFilter);
            Controls.Add(pictureBox2);
            Controls.Add(comboBoxFilter);
            Controls.Add(lblFilterBy);
            Controls.Add(btnClose);
            Controls.Add(btnRelease);
            Controls.Add(lblRecordsNumber);
            Controls.Add(dataGridViewDetainedLicenses);
            Controls.Add(btnDetain);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmdetainedLicensesList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detained Licenses List";
            Load += frmdetainedLicensesList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetainedLicenses).EndInit();
            contextMenuStripList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnDetain;
        private DataGridView dataGridViewDetainedLicenses;
        private Label lblRecordsNumber;
        private Button btnRelease;
        private Button btnClose;
        private Label lblFilterBy;
        private ComboBox comboBoxFilter;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStripList;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLToolStripMenuItem;
        private TextBox txtBoxFilter;
        private RadioButton rbNo;
        private RadioButton rbYes;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}