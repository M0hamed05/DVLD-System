using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ManageDriversForm : Form
    {
        public ManageDriversForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();


        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            refersh_all();

            foreach (DataGridViewColumn column in drivers_dgv.Columns)
            {
                filterComboBox.Items.Add(column.HeaderText.ToString());
                recordsLabel.Text = $"Records : {drivers_dgv.Rows.Count}";

            }
            filterComboBox.Items.RemoveAt(4);
            filterComboBox.SelectedIndex = 0;
        }

        public void refersh_all()
        {
            dt = DVLD_BL.Drivers.get_all_drivers();
            drivers_dgv.DataSource = dt;


            if (drivers_dgv.Rows.Count > 0)
            {
                drivers_dgv.Columns[0].HeaderText = "Driver ID";
                drivers_dgv.Columns[1].HeaderText = "Person ID";
                drivers_dgv.Columns[2].HeaderText = "National No";
                drivers_dgv.Columns[3].HeaderText = "Full Name";
                drivers_dgv.Columns[3].FillWeight = 250;
                drivers_dgv.Columns[4].HeaderText = "Date";
                drivers_dgv.Columns[4].HeaderText = "Active Licenses";
            }

        }

        private void filter_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filter_txtbox.Text))
            {
                dt.DefaultView.RowFilter = "";
                recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
                return;
            }

            if (filterComboBox.SelectedIndex == 4)
            {
                dt.DefaultView.RowFilter = $"{dt.Columns[5]} = {filter_txtbox.Text}";
            }
            else
            {
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[filterComboBox.SelectedIndex]},'System.String') LIKE '{filter_txtbox.Text}%'";
            }
            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 1)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void showDriverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(Convert.ToInt32(drivers_dgv.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetailsForm frm = new PersonDetailsForm(Convert.ToInt32(drivers_dgv.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseApplicationForm frm = new IssueInternationalLicenseApplicationForm();
            frm.ShowDialog();
        }
    }
}
