namespace DVLD
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridViewTestsTypes = new DataGridView();
            contextMenuStripTestType = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            lblRecordNumbers = new Label();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestsTypes).BeginInit();
            contextMenuStripTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 1;
            label1.Text = "Manage Tests Types";
            // 
            // dataGridViewTestsTypes
            // 
            dataGridViewTestsTypes.AllowUserToAddRows = false;
            dataGridViewTestsTypes.AllowUserToDeleteRows = false;
            dataGridViewTestsTypes.AllowUserToOrderColumns = true;
            dataGridViewTestsTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTestsTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTestsTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewTestsTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTestsTypes.ContextMenuStrip = contextMenuStripTestType;
            dataGridViewTestsTypes.Location = new Point(14, 176);
            dataGridViewTestsTypes.Name = "dataGridViewTestsTypes";
            dataGridViewTestsTypes.ReadOnly = true;
            dataGridViewTestsTypes.RowHeadersWidth = 51;
            dataGridViewTestsTypes.RowTemplate.Height = 50;
            dataGridViewTestsTypes.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridViewTestsTypes.Size = new Size(951, 120);
            dataGridViewTestsTypes.TabIndex = 2;
            // 
            // contextMenuStripTestType
            // 
            contextMenuStripTestType.ImageScalingSize = new Size(30, 30);
            contextMenuStripTestType.Items.AddRange(new ToolStripItem[] { editTestTypeToolStripMenuItem });
            contextMenuStripTestType.Name = "contextMenuStripTestType";
            contextMenuStripTestType.Size = new Size(184, 40);
            // 
            // editTestTypeToolStripMenuItem
            // 
            editTestTypeToolStripMenuItem.Image = (Image)resources.GetObject("editTestTypeToolStripMenuItem.Image");
            editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            editTestTypeToolStripMenuItem.Size = new Size(183, 36);
            editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            editTestTypeToolStripMenuItem.Click += editTestTypeToolStripMenuItem_Click;
            // 
            // lblRecordNumbers
            // 
            lblRecordNumbers.AutoSize = true;
            lblRecordNumbers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordNumbers.Location = new Point(16, 388);
            lblRecordNumbers.Name = "lblRecordNumbers";
            lblRecordNumbers.Size = new Size(0, 20);
            lblRecordNumbers.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(836, 302);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(842, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 351);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(lblRecordNumbers);
            Controls.Add(dataGridViewTestsTypes);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmManageTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Test Types";
            Load += frmManageTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTestsTypes).EndInit();
            contextMenuStripTestType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridViewTestsTypes;
        private Label lblRecordNumbers;
        private Button btnClose;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStripTestType;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}