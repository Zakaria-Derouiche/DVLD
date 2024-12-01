namespace DVLD
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            dataGridViewApplicationTypes = new DataGridView();
            contextMenuStripAppTypes = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            lblFormTitle = new Label();
            picBoxForm = new PictureBox();
            lblRecordsNumber = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).BeginInit();
            contextMenuStripAppTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewApplicationTypes
            // 
            dataGridViewApplicationTypes.AllowUserToAddRows = false;
            dataGridViewApplicationTypes.AllowUserToDeleteRows = false;
            dataGridViewApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewApplicationTypes.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApplicationTypes.ContextMenuStrip = contextMenuStripAppTypes;
            dataGridViewApplicationTypes.Location = new Point(12, 176);
            dataGridViewApplicationTypes.MultiSelect = false;
            dataGridViewApplicationTypes.Name = "dataGridViewApplicationTypes";
            dataGridViewApplicationTypes.ReadOnly = true;
            dataGridViewApplicationTypes.RowHeadersWidth = 51;
            dataGridViewApplicationTypes.Size = new Size(801, 188);
            dataGridViewApplicationTypes.TabIndex = 0;
            // 
            // contextMenuStripAppTypes
            // 
            contextMenuStripAppTypes.ImageScalingSize = new Size(20, 20);
            contextMenuStripAppTypes.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            contextMenuStripAppTypes.Name = "contextMenuStripAppTypes";
            contextMenuStripAppTypes.Size = new Size(225, 30);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Image = (Image)resources.GetObject("editApplicationTypeToolStripMenuItem.Image");
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(224, 26);
            editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(661, 373);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.IndianRed;
            lblFormTitle.Location = new Point(261, 126);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(302, 31);
            lblFormTitle.TabIndex = 2;
            lblFormTitle.Text = "Manage Application Types";
            // 
            // picBoxForm
            // 
            picBoxForm.Image = (Image)resources.GetObject("picBoxForm.Image");
            picBoxForm.Location = new Point(290, 12);
            picBoxForm.Name = "picBoxForm";
            picBoxForm.Size = new Size(244, 96);
            picBoxForm.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxForm.TabIndex = 3;
            picBoxForm.TabStop = false;
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsNumber.Location = new Point(12, 389);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(0, 20);
            lblRecordsNumber.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 425);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecordsNumber);
            Controls.Add(picBoxForm);
            Controls.Add(lblFormTitle);
            Controls.Add(btnClose);
            Controls.Add(dataGridViewApplicationTypes);
            Name = "frmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Application Types";
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewApplicationTypes).EndInit();
            contextMenuStripAppTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewApplicationTypes;
        private Button btnClose;
        private Label lblFormTitle;
        private PictureBox picBoxForm;
        private Label lblRecordsNumber;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStripAppTypes;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}