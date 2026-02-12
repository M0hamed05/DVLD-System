using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ChangePasswordForm : Form
    {
        bool saved = false;
        int personID = -1;
        int userID = -1;
        public ChangePasswordForm(int personID, int userID)
        {
            InitializeComponent();
            this.personID = personID;
            this.userID = userID;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            userInfoUserControl1.load_all_data(personID, userID);
        }

        private void oldPasswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (DVLDShared.currentUser.password != oldpasswordTxtBox.Text)
            {
                errorProvider.SetError(oldpasswordTxtBox, "Password Should Match the old password");
            }
            else errorProvider.Clear();
        }

        private void passowrdTxtBox_Leave(object sender, EventArgs e)
        {
            if (DVLDShared.currentUser.password == passowrdTxtBox.Text) errorProvider.SetError(passowrdTxtBox, "New Password Should be different");
            else errorProvider.Clear();
        }

        private void confrimPasswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (confrimPasswordTxtBox.Text != passowrdTxtBox.Text) errorProvider.SetError(passowrdTxtBox, "Passwords should be matches");
            else errorProvider.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                MessageBox.Show("Close and open again for a new action", "Changes already made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            if (!change_happend())
            {
                MessageBox.Show("No change made to be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Control ctrl in loginInfoPanel.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(ctrl)))
                {
                    MessageBox.Show("Error, Please Fix the red Errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(passowrdTxtBox.Text) || string.IsNullOrEmpty(oldpasswordTxtBox.Text))
            {
                MessageBox.Show("No Username and password to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
            }

            if (DVLD_BL.Users.update_user_password(DVLDShared.currentUser.userID, passowrdTxtBox.Text))
            {
                MessageBox.Show("User Password Updated Successfully!", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = Application.OpenForms["UsersForm"];
                if (frm != null)
                    ((UsersForm)frm).refersh_all();
                saved = true;
                DVLDShared.currentUser = DVLD_BL.Users.get_user_data(DVLDShared.currentUser.userID);
            }
            else
            {
                MessageBox.Show("Error updateing the user password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Nothing Saved, Are you Sure to Close?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
            }
            else
                this.Close();
        }

        private bool change_happend()
        {
            if (DVLDShared.currentUser.password != passowrdTxtBox.Text) return true;
            return false;
        }

    }
}
