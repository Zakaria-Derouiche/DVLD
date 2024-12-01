namespace DVLD
{
    partial class frmEditApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicationType));
            label1 = new Label();
            txtBoxAppTypeName = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblApplicationTypeID = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxAppTypeFees = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnSave = new Button();
            btnClose = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(171, 20);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 0;
            label1.Text = "Update Application Type";
            // 
            // txtBoxAppTypeName
            // 
            txtBoxAppTypeName.Location = new Point(218, 126);
            txtBoxAppTypeName.Name = "txtBoxAppTypeName";
            txtBoxAppTypeName.Size = new Size(261, 27);
            txtBoxAppTypeName.TabIndex = 1;
            txtBoxAppTypeName.KeyPress += txtBoxAppTypeName_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(96, 74);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblApplicationTypeID.Location = new Point(227, 74);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(0, 20);
            lblApplicationTypeID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(96, 128);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(96, 182);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 6;
            label5.Text = "Fees";
            // 
            // txtBoxAppTypeFees
            // 
            txtBoxAppTypeFees.Location = new Point(218, 179);
            txtBoxAppTypeFees.Name = "txtBoxAppTypeFees";
            txtBoxAppTypeFees.Size = new Size(261, 27);
            txtBoxAppTypeFees.TabIndex = 7;
            txtBoxAppTypeFees.TextChanged += txtBoxAppTypeFees_TextChanged;
            txtBoxAppTypeFees.KeyPress += txtBoxAppTypeFees_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(152, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(152, 177);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(218, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(369, 229);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 43);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(227, 235);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(377, 235);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // frmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 284);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtBoxAppTypeFees);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxAppTypeName);
            Controls.Add(label1);
            Name = "frmEditApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Application Type";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxAppTypeName;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblApplicationTypeID;
        private Label label4;
        private Label label5;
        private TextBox txtBoxAppTypeFees;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnSave;
        private Button btnClose;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}