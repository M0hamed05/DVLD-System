using DVLD.Applications;
using DVLD.Licenses;
using DVLD.Login_and_main;
using DVLD.Resources;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        private Form loginForm = null;

        public MainForm(int personID,Form loginForm)
        {
            DVLDShared.currentPerson = DVLD_BL.People.get_person_data_for_edit(personID);
            DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLD_BL.Users.get_user_id_by_PersonID(personID));
            this.loginForm = loginForm;
            DVLD_BL.get_all_countries();
            InitializeComponent();
        }

        public MainForm(int personID)
        {
            DVLDShared.currentPerson = DVLD_BL.People.get_person_data_for_edit(personID);
            DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLD_BL.Users.get_user_id_by_PersonID(personID));
            DVLD_BL.get_all_countries();
            InitializeComponent();
        }

        public void update_user_info(int personID)
        {
            DVLDShared.currentPerson = DVLD_BL.People.get_person_data_for_edit(personID);
            DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLD_BL.Users.get_user_id_by_PersonID(personID));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            show_image();
        }

        public void show_image()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackgorundImage) &&
                File.Exists(Properties.Settings.Default.BackgorundImage))
            {
                mainPanel.BackgroundImage = Image.FromFile(Properties.Settings.Default.BackgorundImage);//should be form file here
                mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void open_child_form(Form childForm)
        {
            if (activeForm?.GetType() == childForm.GetType()) return;//null here because dont get value of null
                                                                     // name is محجوز if (ActiveForm != null) ActiveForm.Close();//if there an opend form close it
            Form LastForm = activeForm;
            activeForm = childForm;


           mainPanel.SuspendLayout();//wait a second please till the second form appear

            childForm.TopLevel = false;//make it a form in it
            childForm.Dock = DockStyle.Fill;
            childForm.Size = mainPanel.ClientSize;//takes panel size then display it so didn't show pop screen

            this.mainPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.BringToFront();

            if (LastForm != null)
            {
                LastForm.Close();
                LastForm.Dispose();
            }

            mainPanel.ResumeLayout();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new PeopleForm());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Properties.Settings.Default.SavedID = 0;
            Properties.Settings.Default.Save();
            DVLD_BL.Users.Save_username_and_password_to_registry("", "");
            DVLDShared.currentPerson = null;
            DVLDShared.currentUser = null;
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                loginForm frm = new loginForm();
                frm.Show();
            }
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm frm = new UserInfoForm(DVLDShared.currentPerson.personID);
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new UsersForm());
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm(DVLDShared.currentPerson.personID);
            frm.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            open_child_form(new ManageApplicationTypesForm());
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new ManageTestTypeForm());
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocalDrivingLicenseApplicationForm frm = new AddLocalDrivingLicenseApplicationForm();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new LocalDrivingLicenseApplicationsForm());
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new ManageDriversForm());

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseApplicationForm frm = new IssueInternationalLicenseApplicationForm();
            frm.ShowDialog();
        }

        private void internationalLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new internationalLicenseApplicationForm());
            
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseApplicationForm frm = new RenewLicenseApplicationForm();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamageedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForLostOrDamagedForm frm = new ReplacementForLostOrDamagedForm();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetainLicenseForm frm = new DetainLicenseForm();
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm frm = new ReleaseDetainedLicenseForm();
            frm.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new ManageDetainLicensesForm());     
        }

        private void realseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm frm = new ReleaseDetainedLicenseForm();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new LocalDrivingLicenseApplicationsForm());
        }

        private void changeBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBackgroundImageForm frm = new ChangeBackgroundImageForm();
            frm.ShowDialog();
        }

        private void MainMenutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }
        }

        public void remove_image()
        {
            if (mainPanel.BackgroundImage != null)
            {
                mainPanel.BackgroundImage.Dispose();
                mainPanel.BackgroundImage = null;
            }
        }

        private void licensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_child_form(new AllLicensesForm());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D2)
            {
                peopleToolStripMenuItem.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D3)
            {
                driversToolStripMenuItem.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D4)
            {
                licensesToolStripMenuItem.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D5)
            {
                usersToolStripMenuItem.PerformClick();
            }
        }
    }
}
