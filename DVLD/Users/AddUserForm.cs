using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddEditUserForm : Form
    {
        public AddEditUserForm()
        {
            InitializeComponent();
        }

        public AddEditUserForm(int personID,int UserID)
        {
            InitializeComponent();
            headerLabel.Text = "Update User";
            load_user_data_for_edit(personID, UserID);
            this.personID = personID;
            this.userID = UserID;
        }

        bool next_clicked = false;
        bool editmode = false;
        bool saved = false;
        int personID = -1;
        int userID = -1;

        DVLDShared.stUser user;

        List<string> all_nationalty = DVLD_BL.People.get_all_nationlityID_for_user_adding();

        List<int> all_personID = DVLD_BL.People.get_all_personID_for_user_adding();

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            filterComboBox.Items.Add("NationalNo");
            filterComboBox.Items.Add("PersonID");
            filterComboBox.SelectedIndex = 0;
            allUsersComboBox.DataSource = all_nationalty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0)
            {
                personID = DVLD_BL.People.get_personID_by_NationaltyNO(allUsersComboBox.Text.ToString());
                if (personID != -1)
                    personInfoUserControl1.load_person_data(personID);
            }
            else
            {
                personInfoUserControl1.load_person_data(Convert.ToInt32(allUsersComboBox.Text));

            }
            nxtBtn.Enabled = true;
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            if (!next_clicked)
            {
                loginInfoPanel.Visible = true;
                next_clicked = true;
                saveBtn.Enabled = true;
                nxtBtn.Text = "Prev";
            }
            else
            {
                loginInfoPanel.Visible = false;
                next_clicked = false;
                saveBtn.Enabled = false;
                nxtBtn.Text = "Next";
            }
        }

        private void usernameTxtBox_Leave(object sender, EventArgs e)
        {
            if (DVLD_BL.Users.is_repeated_user_id(usernameTxtBox.Text.ToString()))
                errorProvider.SetError(usernameTxtBox, "There is a username with this id");
            else if (string.IsNullOrWhiteSpace(usernameTxtBox.Text)) errorProvider.SetError(usernameTxtBox, "This is requried field");
            else errorProvider.Clear();
        }

        private void confrimPasswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passowrdTxtBox.Text != confrimPasswordTxtBox.Text)
                errorProvider.SetError(confrimPasswordTxtBox, "Passwords should be matched");

            else errorProvider.Clear();
        }

        private void passowrdTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passowrdTxtBox.Text)) errorProvider.SetError(passowrdTxtBox, "This is requried field");
            else if (passowrdTxtBox.Text == confrimPasswordTxtBox.Text) errorProvider.Clear();
            else errorProvider.Clear();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                MessageBox.Show("Close and open again for a new action", "Changes already made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

            if (!editmode)
            {
                int userID = DVLD_BL.Users.add_new_user(save_user_to_struct());
                if (userID != -1)
                {
                    MessageBox.Show($"User Added Successfully With User ID :{userID}", "Operation Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    saved = true;

                    Form frm = Application.OpenForms["UsersForm"];
                    if (frm != null)
                        ((UsersForm)frm).refersh_all();
                }
                else
                {
                    MessageBox.Show($"Error Adding the user", "Operation Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!change_happend())
                {
                    MessageBox.Show("No change made to save", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                is_in_rememberme(personID);

                if(DVLD_BL.Users.update_user(save_user_to_struct()))
                {
                    MessageBox.Show("User Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form frm = Application.OpenForms["UsersForm"];
                    if (frm != null)
                        ((UsersForm)frm).refersh_all();
                    saved = true;
                }
                else
                {
                    MessageBox.Show("Error updateing the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    saved = false;
                }


            }

        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddEditPersonForm frm = new AddEditPersonForm();
            frm.ShowDialog();
            if (frm.is_saved())
            {
                all_nationalty = DVLD_BL.People.get_all_nationlityID_for_user_adding();
                all_personID = DVLD_BL.People.get_all_personID_for_user_adding();
                allUsersComboBox.DataSource = all_nationalty;
            }
        }

        private DVLDShared.stUser save_user_to_struct()
        {
            DVLDShared.stUser user = new DVLDShared.stUser();
            user.username = usernameTxtBox.Text;
            user.password = passowrdTxtBox.Text;
            user.personID = personID;
            user.userID = userID;
            user.isActive = isActiveCheckButton.Checked;
            return user;
        }

        private void load_user_data_for_edit(int personID, int UserID)
        {
            filterPanel.Visible = false;
            nextBtnPanel.Visible = false;
            loginInfoPanel.Visible = true;
            saveBtn.Enabled = true;
            this.Size = new System.Drawing.Size(1125, 690);
            editmode = true;

            personInfoUserControl1.load_person_data(personID);

            user = DVLD_BL.Users.get_user_data(UserID);
            usernameTxtBox.Text = user.username.ToString();
            passowrdTxtBox.Text = user.password.ToString();
            confrimPasswordTxtBox.Text = passowrdTxtBox.Text;

            if (user.isActive == true)
                isActiveCheckButton.Checked = true;
            else isActiveCheckButton.Checked = false;

        }
    
        private bool change_happend()
        {
            if (this.user.username != usernameTxtBox.Text) return true;
            if (this.user.password != passowrdTxtBox.Text) return true;
            if (this.user.isActive == true && isActiveCheckButton.Checked == false) return true;
            if (this.user.isActive == false && isActiveCheckButton.Checked == true) return true;
            return false;
        }

        private bool is_in_rememberme(int personID)
        {
            if (personID == (int)Properties.Settings.Default.SavedID)
            {
                Properties.Settings.Default.SavedID = 0;
                Properties.Settings.Default.Save();
                return true;
            }
            return false;
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filterComboBox.SelectedIndex == 0)
            {
                allUsersComboBox.DataSource = all_nationalty;
            }
            else
            {
                allUsersComboBox.DataSource = all_personID;
            }
        }
    }
}
