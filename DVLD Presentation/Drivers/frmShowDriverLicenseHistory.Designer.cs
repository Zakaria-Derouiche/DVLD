namespace DVLD
{
    partial class frmShowDriverLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDriverLicenseHistory));
            tabControlLicenses = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewLocalLicenses = new DataGridView();
            contextMenuStriplLicense = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            dataGridViewIntenationalLicenses = new DataGridView();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            groupBoxFilter = new GroupBox();
            btnAdd = new Button();
            txtBoxFilter = new TextBox();
            btnFind = new Button();
            comboBoxFilter = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            tabControlLicenses.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalLicenses).BeginInit();
            contextMenuStriplLicense.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIntenationalLicenses).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlLicenses
            // 
            tabControlLicenses.Controls.Add(tabPage1);
            tabControlLicenses.Controls.Add(tabPage2);
            tabControlLicenses.Location = new Point(11, 26);
            tabControlLicenses.Name = "tabControlLicenses";
            tabControlLicenses.SelectedIndex = 0;
            tabControlLicenses.Size = new Size(866, 217);
            tabControlLicenses.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewLocalLicenses);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(858, 187);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLocalLicenses
            // 
            dataGridViewLocalLicenses.AllowUserToAddRows = false;
            dataGridViewLocalLicenses.AllowUserToDeleteRows = false;
            dataGridViewLocalLicenses.AllowUserToOrderColumns = true;
            dataGridViewLocalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLocalLicenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLocalLicenses.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalLicenses.ContextMenuStrip = contextMenuStriplLicense;
            dataGridViewLocalLicenses.Location = new Point(16, 19);
            dataGridViewLocalLicenses.Name = "dataGridViewLocalLicenses";
            dataGridViewLocalLicenses.ReadOnly = true;
            dataGridViewLocalLicenses.RowHeadersWidth = 51;
            dataGridViewLocalLicenses.Size = new Size(827, 159);
            dataGridViewLocalLicenses.TabIndex = 1;
            // 
            // contextMenuStriplLicense
            // 
            contextMenuStriplLicense.ImageScalingSize = new Size(20, 20);
            contextMenuStriplLicense.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            contextMenuStriplLicense.Name = "contextMenuStriplLicense";
            contextMenuStriplLicense.Size = new Size(209, 30);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicenseInfoToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseInfoToolStripMenuItem.Image");
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(208, 26);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewIntenationalLicenses);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(858, 187);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Intenantional";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewIntenationalLicenses
            // 
            dataGridViewIntenationalLicenses.AllowUserToAddRows = false;
            dataGridViewIntenationalLicenses.AllowUserToDeleteRows = false;
            dataGridViewIntenationalLicenses.AllowUserToOrderColumns = true;
            dataGridViewIntenationalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIntenationalLicenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewIntenationalLicenses.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewIntenationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIntenationalLicenses.ContextMenuStrip = contextMenuStriplLicense;
            dataGridViewIntenationalLicenses.Location = new Point(17, 18);
            dataGridViewIntenationalLicenses.Name = "dataGridViewIntenationalLicenses";
            dataGridViewIntenationalLicenses.ReadOnly = true;
            dataGridViewIntenationalLicenses.RowHeadersWidth = 51;
            dataGridViewIntenationalLicenses.Size = new Size(824, 160);
            dataGridViewIntenationalLicenses.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControlLicenses);
            groupBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 454);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 269);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(780, 729);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnAdd);
            groupBoxFilter.Controls.Add(txtBoxFilter);
            groupBoxFilter.Controls.Add(btnFind);
            groupBoxFilter.Controls.Add(comboBoxFilter);
            groupBoxFilter.Controls.Add(label1);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(116, 60);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(680, 60);
            groupBoxFilter.TabIndex = 4;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Fliter";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(591, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 35);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(293, 19);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(186, 27);
            txtBoxFilter.TabIndex = 3;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // btnFind
            // 
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(494, 15);
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
            comboBoxFilter.Items.AddRange(new object[] { "National No", "Person ID" });
            comboBoxFilter.Location = new Point(92, 19);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(186, 28);
            comboBoxFilter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(349, 15);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 5;
            label2.Text = "License History";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(789, 737);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ctrlPersonInfo1);
            groupBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(885, 312);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Driver Info";
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.IsChanged = false;
            ctrlPersonInfo1.Location = new Point(37, 25);
            ctrlPersonInfo1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.PersonID = -1;
            ctrlPersonInfo1.Size = new Size(811, 280);
            ctrlPersonInfo1.TabIndex = 1;
            // 
            // frmShowDriverLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 777);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(groupBoxFilter);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "frmShowDriverLicenseHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show License History";
            Load += frmShowDriverLicenseHistory_Load;
            tabControlLicenses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalLicenses).EndInit();
            contextMenuStriplLicense.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIntenationalLicenses).EndInit();
            groupBox1.ResumeLayout(false);
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControlLicenses;
        private GroupBox groupBox1;
        private Button btnClose;
        private GroupBox groupBoxFilter;
        private Button btnAdd;
        private TextBox txtBoxFilter;
        private Button btnFind;
        private ComboBox comboBoxFilter;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private TabPage tabPage1;
        private DataGridView dataGridViewLocalLicenses;
        private TabPage tabPage2;
        private DataGridView dataGridViewIntenationalLicenses;
        private ContextMenuStrip contextMenuStriplLicense;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private GroupBox groupBox2;
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}