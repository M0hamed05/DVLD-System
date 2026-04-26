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
        bool add_clicked = false;
        int personID = -1;
        int userID = -1;

        DVLDShared.clsUser user;

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
            add_clicked = true;
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            if (!next_clicked)
            {
                loginInfoPanel.Visible = true;
                next_clicked = true;
                saveBtn.Enabled = true;
                nxtBtn.Text = "Prev";
                if (!add_clicked)
                {
                    addBtn.PerformClick();
                }
                filterPanel.Enabled = false;
            }
            else
            {
                loginInfoPanel.Visible = false;
                next_clicked = false;
                saveBtn.Enabled = false;
                nxtBtn.Text = "Next";
                filterPanel.Enabled = true;
            }
            
        }

        private void usernameTxtBox_Leave(object sender, EventArgs e)
        {
            if (editmode)
            {
                if (DVLD_BL.Users.is_repeated_user_id_but_personal(usernameTxtBox.Text.ToString(), userID))
                    errorProvider.SetError(usernameTxtBox, "There is a username with this id");
                else if (string.IsNullOrWhiteSpace(usernameTxtBox.Text)) errorProvider.SetError(usernameTxtBox, "This is requried field");
                else errorProvider.Clear();
            }
            else
            {
                if (DVLD_BL.Users.is_repeated_user_id(usernameTxtBox.Text.ToString()))
                    errorProvider.SetError(usernameTxtBox, "There is a username with this id");
                else if (string.IsNullOrWhiteSpace(usernameTxtBox.Text)) errorProvider.SetError(usernameTxtBox, "This is requried field");
                else errorProvider.Clear();
            }
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

            if(string.IsNullOrWhiteSpace(usernameTxtBox.Text))
            {
                MessageBox.Show("Error, Please Fill all the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!editmode)
            {
                foreach (Control ctrl in loginInfoPanel.Controls)
                {
                    if (string.IsNullOrEmpty(errorProvider.GetError(ctrl)))
                    {
                        MessageBox.Show("Error, Please Fix the red Errors or Fill all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                int userID = DVLD_BL.Users.add_new_user(save_user_to_class());
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

                if (DVLD_BL.Users.update_user(save_user_to_class()))
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

            personID = -1;
            userID = -1;
            all_nationalty = DVLD_BL.People.get_all_nationlityID_for_user_adding();
            all_personID = DVLD_BL.People.get_all_personID_for_user_adding();
            filterComboBox.SelectedIndex = 0;
            allUsersComboBox.DataSource = all_nationalty;

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

        private DVLDShared.clsUser save_user_to_class()
        {
            DVLDShared.clsUser user = new DVLDShared.clsUser();
            user.username = usernameTxtBox.Text;
            user.password = DVLD_BL.Users.ComputeHash(passowrdTxtBox.Text);
            user.personID = personID;
            user.userID = userID;
            user.isActive = isActiveCheckButton.Checked;
            return user;
        }

        private void load_user_data_for_edit(int personID, int UserID)
        {
            passowrdTxtBox.Enabled = false;
            confrimPasswordTxtBox.Enabled = false;
            filterPanel.Visible = false;
            nextBtnPanel.Visible = false;
            loginInfoPanel.Visible = true;
            saveBtn.Enabled = true;
            this.Size = new System.Drawing.Size(1125, 690);
            editmode = true;

            personInfoUserControl1.load_person_data(personID);

            user = DVLD_BL.Users.get_user_data(UserID);
            usernameTxtBox.Text = user.username.ToString();

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
            add_clicked = false;
        }

        private void isActiveCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isActiveCheckButton.Checked)
            {
                if(DVLDShared.currentUser.personID == personInfoUserControl1.get_personID())
                {
                    MessageBox.Show("User can't be unactive because it is the current user", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isActiveCheckButton.Checked = true;
                }
            }
        }

        private void allUsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_clicked = false;
        }

        private void AddEditUserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (!saved)
                {
                    if (MessageBox.Show("Nothing Saved, Are you Sure to Close?", "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
                }
                else
                    this.Close();
            }
        }
    }
}
