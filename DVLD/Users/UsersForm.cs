using System;
using System.Data;
using System.Windows.Forms;
using DVLD_Shared;
using DVLDBussinessLayer;

namespace DVLD
{
    public partial class UsersForm : Form
    {
        DataTable dt;
        public void refersh_all()
        {
            dt = DVLD_BL.Users.get_all_users();
            users_dgv.DataSource = dt;
            recordsLabel.Text = $"Records : {dt.Rows.Count}";
            if (dt.Rows.Count > 0)
            {
                users_dgv.Columns["UserID"].HeaderText = "User ID";
                users_dgv.Columns["PersonID"].HeaderText = "Person ID";
                users_dgv.Columns["UserName"].HeaderText = "Username";
                users_dgv.Columns["IsActive"].HeaderText = "Is Active";
            }
        }

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            refersh_all();
            foreach (DataGridViewColumn coloumns in users_dgv.Columns)
            {
                filterComboBox.Items.Add(coloumns.Name.ToString());
            }
            if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditUserForm frm = new AddEditUserForm();
            frm.ShowDialog();
        }

        private void filter_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filter_txtbox.Text))
            {
                dt.DefaultView.RowFilter = "";
                recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
                return;
            }

            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 1)
            {
                if (int.TryParse(filter_txtbox.Text, out int value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns["UserID"]}, 'System.String') LIKE '{value}%'"; // so i can be searched like a string
            }
            else dt.DefaultView.RowFilter = $"{filterComboBox.Text} LIKE '{filter_txtbox.Text}%'";

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 1) 
                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will be Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will be Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUserForm frm = new AddEditUserForm();
            frm.ShowDialog();
        }

        private void deleteUserStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)users_dgv.CurrentRow.Cells[0].Value;

            if(users_dgv.Rows.Count == 1)
            {
                MessageBox.Show("There should be one user at least", "delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id == DVLDShared.currentUser.userID)
            {
                MessageBox.Show("User can't be deleted becuase it is the current user", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete User With ID = {id}?", "Confrim Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DVLD_BL.Users.delete_user(id))
                {
                    MessageBox.Show("User Deleted Successfully");
                    refersh_all();
                }
                else
                {
                    MessageBox.Show("User can't be deleted becuase it has data linked to it", "Delete Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm frm = new UserInfoForm((int)users_dgv.CurrentRow.Cells[1].Value, (int)users_dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedIndex == (filterComboBox.Items.Count-1))
            {
                activeCasesComboBox.Visible = true;
                activeCasesComboBox.SelectedIndex = 0;
                filter_txtbox.Visible = false;
            }
            else
            {
                activeCasesComboBox.Visible = false;
                filter_txtbox.Visible = true;
                dt.DefaultView.RowFilter = "";
            }
        }

        private void activeCasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeCasesComboBox.SelectedIndex == 2)
                dt.DefaultView.RowFilter = $"[{filterComboBox.Text}] = 1";
            else if (activeCasesComboBox.SelectedIndex == 1)
                dt.DefaultView.RowFilter = $"[{filterComboBox.Text}] = 0";
            else
                dt.DefaultView.RowFilter = "";

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUserForm frm = new AddEditUserForm((int)users_dgv.CurrentRow.Cells[1].Value, (int)users_dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm((int)users_dgv.CurrentRow.Cells[1].Value, (int)users_dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
