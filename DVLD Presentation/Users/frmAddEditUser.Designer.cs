namespace DVLD
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            tabControlPersonInfo = new TabControl();
            tabPage1 = new TabPage();
            groupBoxPersonInfo = new GroupBox();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            groupBoxFilter = new GroupBox();
            btnAdd = new Button();
            txtBoxFilter = new TextBox();
            btnFind = new Button();
            comboBoxFilter = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            ctrlUserLoginInfo1 = new ctrlUserLoginInfo();
            btnClose = new Button();
            btnSave = new Button();
            picBoxSave = new PictureBox();
            picBoxClose = new PictureBox();
            lblTitle = new Label();
            errorProviderFindBy = new ErrorProvider(components);
            tabControlPersonInfo.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxFilter.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFindBy).BeginInit();
            SuspendLayout();
            // 
            // tabControlPersonInfo
            // 
            tabControlPersonInfo.Controls.Add(tabPage1);
            tabControlPersonInfo.Controls.Add(tabPage2);
            tabControlPersonInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabControlPersonInfo.Location = new Point(17, 79);
            tabControlPersonInfo.Name = "tabControlPersonInfo";
            tabControlPersonInfo.SelectedIndex = 0;
            tabControlPersonInfo.Size = new Size(807, 532);
            tabControlPersonInfo.TabIndex = 0;
            tabControlPersonInfo.Click += tabControlPersonInfo_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxPersonInfo);
            tabPage1.Controls.Add(groupBoxFilter);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxPersonInfo
            // 
            groupBoxPersonInfo.Controls.Add(ctrlPersonInfo1);
            groupBoxPersonInfo.Controls.Add(pictureBox1);
            groupBoxPersonInfo.Controls.Add(btnNext);
            groupBoxPersonInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxPersonInfo.Location = new Point(24, 72);
            groupBoxPersonInfo.Name = "groupBoxPersonInfo";
            groupBoxPersonInfo.Size = new Size(750, 414);
            groupBoxPersonInfo.TabIndex = 1;
            groupBoxPersonInfo.TabStop = false;
            groupBoxPersonInfo.Text = "Person Info";
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.IsChanged = false;
            ctrlPersonInfo1.Location = new Point(20, 27);
            ctrlPersonInfo1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.PersonID = 0;
            ctrlPersonInfo1.Size = new Size(711, 325);
            ctrlPersonInfo1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.right;
            pictureBox1.Location = new Point(598, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(589, 369);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 35);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Controls.Add(btnAdd);
            groupBoxFilter.Controls.Add(txtBoxFilter);
            groupBoxFilter.Controls.Add(btnFind);
            groupBoxFilter.Controls.Add(comboBoxFilter);
            groupBoxFilter.Controls.Add(label1);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxFilter.Location = new Point(23, 6);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(750, 65);
            groupBoxFilter.TabIndex = 0;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Fliter";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(630, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 43);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(300, 23);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.Size = new Size(186, 27);
            txtBoxFilter.TabIndex = 3;
            txtBoxFilter.KeyPress += txtBoxFilter_KeyPress;
            // 
            // btnFind
            // 
            btnFind.BackgroundImage = (Image)resources.GetObject("btnFind.BackgroundImage");
            btnFind.BackgroundImageLayout = ImageLayout.Zoom;
            btnFind.Location = new Point(515, 15);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(99, 43);
            btnFind.TabIndex = 2;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "National No", "Person ID" });
            comboBoxFilter.Location = new Point(87, 23);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(186, 28);
            comboBoxFilter.TabIndex = 1;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ctrlUserLoginInfo1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 67);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrlUserLoginInfo1
            // 
            ctrlUserLoginInfo1.IsActive = false;
            ctrlUserLoginInfo1.Location = new Point(11, 6);
            ctrlUserLoginInfo1.Name = "ctrlUserLoginInfo1";
            ctrlUserLoginInfo1.Password = "";
            ctrlUserLoginInfo1.Size = new Size(772, 451);
            ctrlUserLoginInfo1.TabIndex = 0;
            ctrlUserLoginInfo1.UserID = -1;
            ctrlUserLoginInfo1.UserName = "";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(513, 617);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.TopLeft;
            btnSave.Location = new Point(681, 617);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // picBoxSave
            // 
            picBoxSave.Image = Properties.Resources.Save;
            picBoxSave.Location = new Point(697, 622);
            picBoxSave.Name = "picBoxSave";
            picBoxSave.Size = new Size(30, 30);
            picBoxSave.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxSave.TabIndex = 2;
            picBoxSave.TabStop = false;
            // 
            // picBoxClose
            // 
            picBoxClose.Image = Properties.Resources.close;
            picBoxClose.Location = new Point(528, 622);
            picBoxClose.Name = "picBoxClose";
            picBoxClose.Size = new Size(30, 30);
            picBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxClose.TabIndex = 3;
            picBoxClose.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(366, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 23);
            lblTitle.TabIndex = 4;
            // 
            // errorProviderFindBy
            // 
            errorProviderFindBy.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 663);
            Controls.Add(lblTitle);
            Controls.Add(picBoxClose);
            Controls.Add(picBoxSave);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tabControlPersonInfo);
            Name = "frmAddEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            FormClosing += frmAddEditUser_FormClosing;
            tabControlPersonInfo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxPersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFindBy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlPersonInfo;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnClose;
        private Button btnSave;
        private PictureBox picBoxSave;
        private PictureBox picBoxClose;
        private GroupBox groupBoxPersonInfo;
        private GroupBox groupBoxFilter;
        private Button btnAdd;
        private TextBox txtBoxFilter;
        private Button btnFind;
        private ComboBox comboBoxFilter;
        private Label label1;
        private ctrlUserLoginInfo ctrlUserLoginInfo1;
        private Button btnNext;
        private PictureBox pictureBox1;
        private ctrlPersonInfo ctrlPersonInfo1;
        private Label lblTitle;
        private ErrorProvider errorProviderFindBy;
    }
}