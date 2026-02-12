using DVLD.Applications;
using DVLD.Licenses;
using DVLD.Resources;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        public MainForm(int personID)
        {
            DVLDShared.currentPerson = DVLD_BL.People.get_person_data_for_edit(personID);
            DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLD_BL.Users.get_user_id(personID));
            DVLD_BL.get_all_countries();
            InitializeComponent();
        }

        public void update_user_info(int personID)
        {
            DVLDShared.currentPerson = DVLD_BL.People.get_person_data_for_edit(personID);
            DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLD_BL.Users.get_user_id(personID));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void open_child_form(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType()) return;//null here because dont get value of null
            // name is محجوز if (ActiveForm != null) ActiveForm.Close();//if there an opend form close it
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            
            }

            activeForm = childForm;

            childForm.TopLevel = false;//make it a form in it
            childForm.Dock = DockStyle.Fill;

            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;//shows/saves info of current form
            childForm.BringToFront();//حطها في الاول فوق اي حاجه
            childForm.Show();
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

            Form frm = Application.OpenForms["Form1"];
            
            if(frm != null)
            {
                frm.Show();
            }
            else
            {
                loginForm frm2 = new loginForm();
                frm2.Show();
            }
            
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm frm = new UserInfoForm(DVLDShared.currentPerson.personID,DVLDShared.currentUser.userID);
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
            ChangePasswordForm frm = new ChangePasswordForm(DVLDShared.currentPerson.personID,DVLDShared.currentUser.userID);
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
    }
}
