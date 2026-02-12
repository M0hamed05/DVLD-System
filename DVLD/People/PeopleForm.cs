using System;
using System.Data;
using System.Windows.Forms;
using DVLDBussinessLayer;

namespace DVLD
{
    public partial class PeopleForm : Form
    {
        private DataTable dt;


        public PeopleForm()
        {
            InitializeComponent();
        }

        public void refersh_all()
        {
            dt = DVLD_BL.People.get_all_people();
            people_dgv.DataSource = dt;
            if (people_dgv.Rows.Count > 0)
            {
                recordsLabel.Text = $"Records: {dt.Rows.Count}";
                people_dgv.Columns["PersonID"].HeaderText = "Person ID";
                people_dgv.Columns["NationalNo"].HeaderText = "National No";
                people_dgv.Columns["FirstName"].HeaderText = "First Name";
                people_dgv.Columns["SecondName"].HeaderText = "Second Name";
                people_dgv.Columns["ThirdName"].HeaderText = "Third Name";
                people_dgv.Columns["LastName"].HeaderText = "Last Name";
                people_dgv.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            }
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            refersh_all();

            foreach (DataGridViewColumn column in people_dgv.Columns)
            {
                filterComboBox.Items.Add(column.Name.ToString());//should be name here
            }
            filterComboBox.Items.Remove("DateOfBirth");
            if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditPersonForm addform = new AddEditPersonForm();
            addform.ShowDialog();
        }

        private void filter_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filter_txtbox.Text))
            {
                dt.DefaultView.RowFilter = "";
                recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
                return;
            }

            if (filterComboBox.SelectedIndex == 0)
            {
                if (int.TryParse(filter_txtbox.Text, out int value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[0]},'System.String') LIKE '{value}%'";

            }
            else dt.DefaultView.RowFilter = $"{filterComboBox.Text} LIKE '{filter_txtbox.Text}%'";
            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPersonForm addform = new AddEditPersonForm();
            addform.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPersonForm frm = new AddEditPersonForm((int)people_dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)people_dgv.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Delete Person With ID = {id}?", "Confrim Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DVLD_BL.People.delete_person(id))
                {
                    MessageBox.Show("Person Deleted Successfully");
                    refersh_all();
                }
                else
                {
                    MessageBox.Show("Person can't be deleted becuase it has data linked to it","Delete Denied",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void showDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetailsForm frm = new PersonDetailsForm((int)people_dgv.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will be Added","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Will be Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

