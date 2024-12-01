namespace DVLD
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStripMainMenu = new MenuStrip();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensesServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationlLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicemseToolStripMenuItem = new ToolStripMenuItem();
            replaceForLostOrDamagedLicneseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            desActivateLicenseToolStripMenuItem = new ToolStripMenuItem();
            activeteLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            releaseLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            menuStripMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.AutoSize = false;
            menuStripMainMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStripMainMenu.ImageScalingSize = new Size(40, 40);
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { applicationsToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(1032, 70);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStripMainMenu";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.AutoSize = false;
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, detainLicenseToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            applicationsToolStripMenuItem.Image = (Image)resources.GetObject("applicationsToolStripMenuItem.Image");
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(152, 50);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            drivingLicensesServicesToolStripMenuItem.AutoSize = false;
            drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicemseToolStripMenuItem, replaceForLostOrDamagedLicneseToolStripMenuItem, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem, desActivateLicenseToolStripMenuItem, activeteLicenseToolStripMenuItem });
            drivingLicensesServicesToolStripMenuItem.Image = (Image)resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image");
            drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            drivingLicensesServicesToolStripMenuItem.Size = new Size(260, 40);
            drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationlLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = (Image)resources.GetObject("newDrivingLicenseToolStripMenuItem.Image");
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(379, 46);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = (Image)resources.GetObject("localLicenseToolStripMenuItem.Image");
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(254, 46);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationlLicenseToolStripMenuItem
            // 
            internationlLicenseToolStripMenuItem.Image = (Image)resources.GetObject("internationlLicenseToolStripMenuItem.Image");
            internationlLicenseToolStripMenuItem.Name = "internationlLicenseToolStripMenuItem";
            internationlLicenseToolStripMenuItem.Size = new Size(254, 46);
            internationlLicenseToolStripMenuItem.Text = "Internationl License";
            internationlLicenseToolStripMenuItem.Click += internationlLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicemseToolStripMenuItem
            // 
            renewDrivingLicemseToolStripMenuItem.Image = (Image)resources.GetObject("renewDrivingLicemseToolStripMenuItem.Image");
            renewDrivingLicemseToolStripMenuItem.Name = "renewDrivingLicemseToolStripMenuItem";
            renewDrivingLicemseToolStripMenuItem.Size = new Size(379, 46);
            renewDrivingLicemseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicemseToolStripMenuItem.Click += renewDrivingLicemseToolStripMenuItem_Click;
            // 
            // replaceForLostOrDamagedLicneseToolStripMenuItem
            // 
            replaceForLostOrDamagedLicneseToolStripMenuItem.Image = (Image)resources.GetObject("replaceForLostOrDamagedLicneseToolStripMenuItem.Image");
            replaceForLostOrDamagedLicneseToolStripMenuItem.Name = "replaceForLostOrDamagedLicneseToolStripMenuItem";
            replaceForLostOrDamagedLicneseToolStripMenuItem.Size = new Size(379, 46);
            replaceForLostOrDamagedLicneseToolStripMenuItem.Text = "Replace For Lost Or Damaged Licnese";
            replaceForLostOrDamagedLicneseToolStripMenuItem.Click += replaceForLostOrDamagedLicneseToolStripMenuItem_Click;
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainedDrivingLicenseToolStripMenuItem.Image");
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(379, 46);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            releaseDetainedDrivingLicenseToolStripMenuItem.Click += releaseDetainedDrivingLicenseToolStripMenuItem_Click;
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = (Image)resources.GetObject("retakeTestToolStripMenuItem.Image");
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(379, 46);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // desActivateLicenseToolStripMenuItem
            // 
            desActivateLicenseToolStripMenuItem.Image = (Image)resources.GetObject("desActivateLicenseToolStripMenuItem.Image");
            desActivateLicenseToolStripMenuItem.Name = "desActivateLicenseToolStripMenuItem";
            desActivateLicenseToolStripMenuItem.Size = new Size(379, 46);
            desActivateLicenseToolStripMenuItem.Text = "DesActivate A License";
            desActivateLicenseToolStripMenuItem.Click += desActivateLicenseToolStripMenuItem_Click;
            // 
            // activeteLicenseToolStripMenuItem
            // 
            activeteLicenseToolStripMenuItem.Image = (Image)resources.GetObject("activeteLicenseToolStripMenuItem.Image");
            activeteLicenseToolStripMenuItem.Name = "activeteLicenseToolStripMenuItem";
            activeteLicenseToolStripMenuItem.Size = new Size(379, 46);
            activeteLicenseToolStripMenuItem.Text = "Activate A License";
            activeteLicenseToolStripMenuItem.Click += activeteLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.AutoSize = false;
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationsToolStripMenuItem, internationalDrivingLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationsToolStripMenuItem.Image");
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(260, 40);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            localDrivingLicenseApplicationsToolStripMenuItem.Image = (Image)resources.GetObject("localDrivingLicenseApplicationsToolStripMenuItem.Image");
            localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            localDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(415, 46);
            localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationsToolStripMenuItem.Click += localDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            internationalDrivingLicenseApplicationsToolStripMenuItem.Image = (Image)resources.GetObject("internationalDrivingLicenseApplicationsToolStripMenuItem.Image");
            internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(415, 46);
            internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License Applications";
            internationalDrivingLicenseApplicationsToolStripMenuItem.Click += internationalDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.AutoSize = false;
            detainLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicensesToolStripMenuItem, detainLicenseToolStripMenuItem1, releaseLicenseToolStripMenuItem });
            detainLicenseToolStripMenuItem.Image = (Image)resources.GetObject("detainLicenseToolStripMenuItem.Image");
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(260, 40);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            manageDetainedLicensesToolStripMenuItem.Image = (Image)resources.GetObject("manageDetainedLicensesToolStripMenuItem.Image");
            manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            manageDetainedLicensesToolStripMenuItem.Size = new Size(301, 46);
            manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            manageDetainedLicensesToolStripMenuItem.Click += manageDetainedLicensesToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem1
            // 
            detainLicenseToolStripMenuItem1.Image = (Image)resources.GetObject("detainLicenseToolStripMenuItem1.Image");
            detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            detainLicenseToolStripMenuItem1.Size = new Size(301, 46);
            detainLicenseToolStripMenuItem1.Text = "Detain License";
            detainLicenseToolStripMenuItem1.Click += detainLicenseToolStripMenuItem1_Click;
            // 
            // releaseLicenseToolStripMenuItem
            // 
            releaseLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseLicenseToolStripMenuItem.Image");
            releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            releaseLicenseToolStripMenuItem.Size = new Size(301, 46);
            releaseLicenseToolStripMenuItem.Text = "Release License";
            releaseLicenseToolStripMenuItem.Click += releaseLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.AutoSize = false;
            manageApplicationTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageApplicationTypesToolStripMenuItem.Image");
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(260, 40);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.AutoSize = false;
            manageTestTypesToolStripMenuItem.Image = (Image)resources.GetObject("manageTestTypesToolStripMenuItem.Image");
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(260, 40);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.AutoSize = false;
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(152, 50);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.AutoSize = false;
            driversToolStripMenuItem.Image = (Image)resources.GetObject("driversToolStripMenuItem.Image");
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(170, 50);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.AutoSize = false;
            usersToolStripMenuItem.Image = (Image)resources.GetObject("usersToolStripMenuItem.Image");
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(170, 50);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.AutoSize = false;
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            accountSettingsToolStripMenuItem.Image = (Image)resources.GetObject("accountSettingsToolStripMenuItem.Image");
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(170, 50);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.AutoSize = false;
            currentUserInfoToolStripMenuItem.Image = (Image)resources.GetObject("currentUserInfoToolStripMenuItem.Image");
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(224, 40);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.AutoSize = false;
            changePasswordToolStripMenuItem.Image = (Image)resources.GetObject("changePasswordToolStripMenuItem.Image");
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(224, 40);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.AutoSize = false;
            signOutToolStripMenuItem.Image = (Image)resources.GetObject("signOutToolStripMenuItem.Image");
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(224, 40);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 503);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            FormClosing += frmMenu_FormClosing;
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationlLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicemseToolStripMenuItem;
        private ToolStripMenuItem replaceForLostOrDamagedLicneseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem desActivateLicenseToolStripMenuItem;
        private ToolStripMenuItem activeteLicenseToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}