namespace DVLD
{
    partial class frmShowUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUsers));
            comboBoxFilter = new ComboBox();
            dataGridViewUsers = new DataGridView();
            contextMenuStripUser = new ContextMenuStrip(components);
            showUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            picBoxForm = new PictureBox();
            label1 = new Label();
            lblRecordsCount = new Label();
            btnAddUser = new Button();
            btnClose = new Button();
            txtBoxFilter = new TextBox();
            picBoxBtnClose = new PictureBox();
            comboBoxActiveStatus = new ComboBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            contextMenuStripUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBtnClose).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.AccessibleRole = AccessibleRole.None;
            comboBoxFilter.AllowDrop = true;
            comboBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "All", "User ID", "Person ID", "Full Name", "User Name", "Is Active" });
            comboBoxFilter.Location = new Point(95, 167);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(154, 28);
            comboBoxFilter.TabIndex = 6;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.ContextMenuStrip = contextMenuStripUser;
            dataGridViewUsers.Location = new Point(29, 200);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(958, 257);
            dataGridViewUsers.TabIndex = 0;
            // 
            // contextMenuStripUser
            // 
            contextMenuStripUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStripUser.ImageScalingSize = new Size(20, 20);
            contextMenuStripUser.Items.AddRange(new ToolStripItem[] { showUserDetailsToolStripMenuItem, addNewUserToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, phoneCallToolStripMenuItem, sendEmailToolStripMenuItem });
            contextMenuStripUser.Name = "contextMenuStripUser";
            contextMenuStripUser.Size = new Size(209, 186);
            // 
            // showUserDetailsToolStripMenuItem
            // 
            showUserDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showUserDetailsToolStripMenuItem.Image");
            showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            showUserDetailsToolStripMenuItem.Size = new Size(208, 26);
            showUserDetailsToolStripMenuItem.Text = "Show User Details";
            showUserDetailsToolStripMenuItem.Click += showUserDetailsToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = (Image)resources.GetObject("addNewUserToolStripMenuItem.Image");
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(208, 26);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(208, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(208, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(208, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = (Image)resources.GetObject("phoneCallToolStripMenuItem.Image");
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(208, 26);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = (Image)resources.GetObject("sendEmailToolStripMenuItem.Image");
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(208, 26);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // picBoxForm
            // 
            picBoxForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxForm.Image = (Image)resources.GetObject("picBoxForm.Image");
            picBoxForm.Location = new Point(328, 12);
            picBoxForm.Name = "picBoxForm";
            picBoxForm.Size = new Size(339, 98);
            picBoxForm.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxForm.TabIndex = 1;
            picBoxForm.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 167);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 2;
            label1.Text = "Filter";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecordsCount.Location = new Point(29, 475);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(0, 20);
            lblRecordsCount.TabIndex = 3;
            // 
            // btnAddUser
            // 
            btnAddUser.BackgroundImage = (Image)resources.GetObject("btnAddUser.BackgroundImage");
            btnAddUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddUser.Location = new Point(872, 159);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(115, 35);
            btnAddUser.TabIndex = 4;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.TopLeft;
            btnClose.Location = new Point(837, 460);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFilter.Location = new Point(270, 167);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(164, 27);
            txtBoxFilter.TabIndex = 7;
            txtBoxFilter.Visible = false;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // picBoxBtnClose
            // 
            picBoxBtnClose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picBoxBtnClose.Image = (Image)resources.GetObject("picBoxBtnClose.Image");
            picBoxBtnClose.Location = new Point(848, 465);
            picBoxBtnClose.Name = "picBoxBtnClose";
            picBoxBtnClose.Size = new Size(31, 30);
            picBoxBtnClose.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxBtnClose.TabIndex = 8;
            picBoxBtnClose.TabStop = false;
            // 
            // comboBoxActiveStatus
            // 
            comboBoxActiveStatus.AccessibleRole = AccessibleRole.None;
            comboBoxActiveStatus.AllowDrop = true;
            comboBoxActiveStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxActiveStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActiveStatus.FormattingEnabled = true;
            comboBoxActiveStatus.Items.AddRange(new object[] { "All", "Active", "Unactive" });
            comboBoxActiveStatus.Location = new Point(270, 167);
            comboBoxActiveStatus.Name = "comboBoxActiveStatus";
            comboBoxActiveStatus.Size = new Size(164, 28);
            comboBoxActiveStatus.TabIndex = 9;
            comboBoxActiveStatus.Visible = false;
            comboBoxActiveStatus.SelectedIndexChanged += comboBoxActiveStatus_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(414, 123);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 31);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Manage Users";
            // 
            // frmShowUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 512);
            Controls.Add(lblTitle);
            Controls.Add(comboBoxActiveStatus);
            Controls.Add(picBoxBtnClose);
            Controls.Add(txtBoxFilter);
            Controls.Add(comboBoxFilter);
            Controls.Add(btnClose);
            Controls.Add(btnAddUser);
            Controls.Add(lblRecordsCount);
            Controls.Add(label1);
            Controls.Add(picBoxForm);
            Controls.Add(dataGridViewUsers);
            Name = "frmShowUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Users";
            Load += frmShowUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            contextMenuStripUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBtnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private PictureBox picBoxForm;
        private Label label1;
        private Label lblRecordsCount;
        private Button btnAddUser;
        private Button btnClose;
        private ComboBox comboBoxFilter;
        private TextBox txtBoxFilter;
        private PictureBox picBoxBtnClose;
        private ComboBox comboBoxActiveStatus;
        private ContextMenuStrip contextMenuStripUser;
        private ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private Label lblTitle;
    }
}