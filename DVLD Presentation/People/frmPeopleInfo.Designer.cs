namespace DVLD
{
    partial class frmPeopleInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleInfo));
            ComboBoxFilter = new ComboBox();
            label1 = new Label();
            txtBoxFilter = new TextBox();
            lblRecordsNumber = new Label();
            dataGridViewPeople = new DataGridView();
            contextMenuStripPerson = new ContextMenuStrip(components);
            showToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            lblTableTitle = new Label();
            radioButtonAll = new RadioButton();
            btnClose = new Button();
            pictureBoxButtonClose = new PictureBox();
            pictureBoxRBFemale = new PictureBox();
            pictureBoxRBMale = new PictureBox();
            pictureBoxPeopleManagement = new PictureBox();
            btnAddNewPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).BeginInit();
            contextMenuStripPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBMale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPeopleManagement).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxFilter
            // 
            ComboBoxFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFilter.FormattingEnabled = true;
            ComboBoxFilter.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Nationality", "Gender", "Phone", "Email" });
            ComboBoxFilter.Location = new Point(97, 162);
            ComboBoxFilter.Margin = new Padding(3, 4, 3, 4);
            ComboBoxFilter.Name = "ComboBoxFilter";
            ComboBoxFilter.Size = new Size(154, 28);
            ComboBoxFilter.TabIndex = 1;
            ComboBoxFilter.SelectedIndexChanged += ComboBoxFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 172);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter By";
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFilter.Location = new Point(287, 162);
            txtBoxFilter.Margin = new Padding(3, 4, 3, 4);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(212, 27);
            txtBoxFilter.TabIndex = 3;
            txtBoxFilter.Visible = false;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // lblRecordsNumber
            // 
            lblRecordsNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecordsNumber.AutoSize = true;
            lblRecordsNumber.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsNumber.Location = new Point(15, 478);
            lblRecordsNumber.Name = "lblRecordsNumber";
            lblRecordsNumber.Size = new Size(0, 17);
            lblRecordsNumber.TabIndex = 5;
            // 
            // dataGridViewPeople
            // 
            dataGridViewPeople.AllowUserToAddRows = false;
            dataGridViewPeople.AllowUserToDeleteRows = false;
            dataGridViewPeople.AllowUserToOrderColumns = true;
            dataGridViewPeople.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeople.ContextMenuStrip = contextMenuStripPerson;
            dataGridViewPeople.Location = new Point(13, 198);
            dataGridViewPeople.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPeople.Name = "dataGridViewPeople";
            dataGridViewPeople.ReadOnly = true;
            dataGridViewPeople.RowHeadersWidth = 51;
            dataGridViewPeople.RowTemplate.Height = 24;
            dataGridViewPeople.Size = new Size(1262, 261);
            dataGridViewPeople.TabIndex = 0;
            // 
            // contextMenuStripPerson
            // 
            contextMenuStripPerson.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStripPerson.ImageScalingSize = new Size(20, 20);
            contextMenuStripPerson.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStripPerson.Name = "contextMenuStrip1";
            contextMenuStripPerson.Size = new Size(183, 160);
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Image = (Image)resources.GetObject("showToolStripMenuItem.Image");
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(182, 26);
            showToolStripMenuItem.Text = "Show Details";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click_1;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = (Image)resources.GetObject("addToolStripMenuItem.Image");
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(182, 26);
            addToolStripMenuItem.Text = "Add New Person";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click_1;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(182, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(182, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(182, 26);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(182, 26);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // radioButtonMale
            // 
            radioButtonMale.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMale.Location = new Point(261, 164);
            radioButtonMale.Margin = new Padding(3, 4, 3, 4);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(64, 24);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.Visible = false;
            radioButtonMale.MouseClick += RadioButton_Checked;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonFemale.Location = new Point(437, 164);
            radioButtonFemale.Margin = new Padding(3, 4, 3, 4);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(80, 24);
            radioButtonFemale.TabIndex = 8;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.Visible = false;
            radioButtonFemale.MouseClick += RadioButton_Checked;
            // 
            // lblTableTitle
            // 
            lblTableTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableTitle.ForeColor = Color.IndianRed;
            lblTableTitle.Location = new Point(556, 121);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(178, 31);
            lblTableTitle.TabIndex = 9;
            lblTableTitle.Text = "Manage People";
            // 
            // radioButtonAll
            // 
            radioButtonAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonAll.Location = new Point(706, 163);
            radioButtonAll.Margin = new Padding(3, 4, 3, 4);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(49, 24);
            radioButtonAll.TabIndex = 10;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.Visible = false;
            radioButtonAll.MouseClick += RadioButton_Checked;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(998, 467);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(277, 39);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBoxButtonClose
            // 
            pictureBoxButtonClose.Anchor = AnchorStyles.None;
            pictureBoxButtonClose.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxButtonClose.Image = (Image)resources.GetObject("pictureBoxButtonClose.Image");
            pictureBoxButtonClose.Location = new Point(1078, 471);
            pictureBoxButtonClose.Margin = new Padding(3, 4, 3, 4);
            pictureBoxButtonClose.Name = "pictureBoxButtonClose";
            pictureBoxButtonClose.Size = new Size(34, 30);
            pictureBoxButtonClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxButtonClose.TabIndex = 14;
            pictureBoxButtonClose.TabStop = false;
            // 
            // pictureBoxRBFemale
            // 
            pictureBoxRBFemale.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxRBFemale.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRBFemale.Image = (Image)resources.GetObject("pictureBoxRBFemale.Image");
            pictureBoxRBFemale.Location = new Point(523, 161);
            pictureBoxRBFemale.Margin = new Padding(3, 4, 3, 4);
            pictureBoxRBFemale.Name = "pictureBoxRBFemale";
            pictureBoxRBFemale.Size = new Size(147, 30);
            pictureBoxRBFemale.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRBFemale.TabIndex = 13;
            pictureBoxRBFemale.TabStop = false;
            pictureBoxRBFemale.Visible = false;
            // 
            // pictureBoxRBMale
            // 
            pictureBoxRBMale.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxRBMale.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRBMale.Image = (Image)resources.GetObject("pictureBoxRBMale.Image");
            pictureBoxRBMale.Location = new Point(331, 161);
            pictureBoxRBMale.Margin = new Padding(3, 4, 3, 4);
            pictureBoxRBMale.Name = "pictureBoxRBMale";
            pictureBoxRBMale.Size = new Size(90, 30);
            pictureBoxRBMale.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRBMale.TabIndex = 12;
            pictureBoxRBMale.TabStop = false;
            pictureBoxRBMale.Visible = false;
            // 
            // pictureBoxPeopleManagement
            // 
            pictureBoxPeopleManagement.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxPeopleManagement.Image = (Image)resources.GetObject("pictureBoxPeopleManagement.Image");
            pictureBoxPeopleManagement.Location = new Point(414, 7);
            pictureBoxPeopleManagement.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPeopleManagement.Name = "pictureBoxPeopleManagement";
            pictureBoxPeopleManagement.Size = new Size(463, 100);
            pictureBoxPeopleManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPeopleManagement.TabIndex = 11;
            pictureBoxPeopleManagement.TabStop = false;
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackgroundImage = (Image)resources.GetObject("btnAddNewPerson.BackgroundImage");
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.Location = new Point(1152, 147);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(123, 40);
            btnAddNewPerson.TabIndex = 15;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click_1;
            // 
            // frmPeopleInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 508);
            Controls.Add(btnAddNewPerson);
            Controls.Add(pictureBoxButtonClose);
            Controls.Add(pictureBoxRBFemale);
            Controls.Add(pictureBoxRBMale);
            Controls.Add(pictureBoxPeopleManagement);
            Controls.Add(radioButtonAll);
            Controls.Add(lblTableTitle);
            Controls.Add(radioButtonMale);
            Controls.Add(radioButtonFemale);
            Controls.Add(btnClose);
            Controls.Add(lblRecordsNumber);
            Controls.Add(txtBoxFilter);
            Controls.Add(label1);
            Controls.Add(ComboBoxFilter);
            Controls.Add(dataGridViewPeople);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPeopleInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "People Informations";
            Load += frmPeopleInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeople).EndInit();
            contextMenuStripPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxButtonClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRBMale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPeopleManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.PictureBox pictureBoxPeopleManagement;
        private System.Windows.Forms.PictureBox pictureBoxRBMale;
        private System.Windows.Forms.PictureBox pictureBoxRBFemale;
        private System.Windows.Forms.PictureBox pictureBoxButtonClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPerson;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private Button btnAddNewPerson;
    }
}
