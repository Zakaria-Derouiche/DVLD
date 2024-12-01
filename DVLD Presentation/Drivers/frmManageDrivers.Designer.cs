namespace DVLD
{
    partial class frmManageDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDrivers));
            dataGridViewDrivers = new DataGridView();
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            comboBoxFilterType = new ComboBox();
            txtBoxFilter = new TextBox();
            lblRecordNumbers = new Label();
            pictureBox2 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.AllowUserToAddRows = false;
            dataGridViewDrivers.AllowUserToDeleteRows = false;
            dataGridViewDrivers.AllowUserToOrderColumns = true;
            dataGridViewDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDrivers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDrivers.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.ContextMenuStrip = contextMenuStrip1;
            dataGridViewDrivers.GridColor = SystemColors.InactiveBorder;
            dataGridViewDrivers.Location = new Point(12, 238);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.ReadOnly = true;
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.Size = new Size(889, 188);
            dataGridViewDrivers.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(781, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(342, 141);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 2;
            label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Filter By:";
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No" });
            comboBoxFilterType.Location = new Point(87, 193);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(151, 28);
            comboBoxFilterType.TabIndex = 5;
            comboBoxFilterType.SelectedIndexChanged += comboBoxFilterType_SelectedIndexChanged;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(268, 194);
            txtBoxFilter.MaxLength = 30;
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(151, 27);
            txtBoxFilter.TabIndex = 6;
            txtBoxFilter.Visible = false;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // lblRecordNumbers
            // 
            lblRecordNumbers.AutoSize = true;
            lblRecordNumbers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordNumbers.Location = new Point(12, 447);
            lblRecordNumbers.Name = "lblRecordNumbers";
            lblRecordNumbers.Size = new Size(0, 20);
            lblRecordNumbers.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(790, 447);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonInfoToolStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(228, 52);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            showPersonInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            showPersonInfoToolStripMenuItem.Size = new Size(227, 24);
            showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            showPersonInfoToolStripMenuItem.Click += showPersonInfoToolStripMenuItem_Click;
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(227, 24);
            showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // frmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 484);
            Controls.Add(pictureBox2);
            Controls.Add(lblRecordNumbers);
            Controls.Add(txtBoxFilter);
            Controls.Add(comboBoxFilterType);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(dataGridViewDrivers);
            Name = "frmManageDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Drivers";
            Load += frmManageDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDrivers;
        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox comboBoxFilterType;
        private TextBox txtBoxFilter;
        private Label lblRecordNumbers;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}