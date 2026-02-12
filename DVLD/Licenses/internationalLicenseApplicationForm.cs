using DVLD.Applications;
using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class internationalLicenseApplicationForm : Form
    {
        public internationalLicenseApplicationForm()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void internationalLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            refersh_all();

            foreach (DataGridViewColumn column in applications_dgv.Columns)
            {
                filterComboBox.Items.Add(column.HeaderText.ToString());
            }
            filterComboBox.Items.Remove(applications_dgv.Columns[6].HeaderText);
            filterComboBox.Items.Remove(applications_dgv.Columns[5].HeaderText);
            filterComboBox.Items.Remove(applications_dgv.Columns[4].HeaderText);

            if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
            recordsLabel.Text = $"Records : {dt.Rows.Count}";
        }
        

        public void refersh_all()
        {
            dt = DVLD_BL.Licenses.get_all_international_licenses();
            applications_dgv.DataSource = dt;
            if (applications_dgv.Rows.Count > 0)
            {
                applications_dgv.Columns[0].HeaderText = "Int License ID";
                applications_dgv.Columns[1].HeaderText = "Application ID";
                applications_dgv.Columns[2].HeaderText = "Driver ID";
                applications_dgv.Columns[3].HeaderText = "L License ID";
                applications_dgv.Columns[4].HeaderText = "Issue Date";
                applications_dgv.Columns[5].HeaderText = "Expiration Date";
                applications_dgv.Columns[6].HeaderText = "Is Active";
            }
            applications_dgv.Columns[4].DefaultCellStyle.Format = "d";
            applications_dgv.Columns[5].DefaultCellStyle.Format = "d";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            IssueInternationalLicenseApplicationForm frm = new IssueInternationalLicenseApplicationForm();
            frm.ShowDialog();
        }

        int value;
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
                if (int.TryParse(filter_txtbox.Text, out value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[0]},'System.String') LIKE '{value}%'";

            }
            else if (filterComboBox.SelectedIndex == 1)
            {
                if (int.TryParse(filter_txtbox.Text, out value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[1]},'System.String') LIKE '{value}%'";
            }
            else if (filterComboBox.SelectedIndex == 2)
            {
                if (int.TryParse(filter_txtbox.Text, out value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[2]},'System.String') LIKE '{value}%'";
            }
            else if (filterComboBox.SelectedIndex == 3)
            {
                if (int.TryParse(filter_txtbox.Text, out value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[3]},'System.String') LIKE '{value}%'";
            }

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 2 || filterComboBox.SelectedIndex == 3)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void showPersonDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetailsForm frm = new PersonDetailsForm(DVLD_BL.Drivers.get_personID_FromDriverID(Convert.ToInt32(applications_dgv.CurrentRow.Cells[2].Value)));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseForm frm = new ShowInternationalLicenseForm(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(DVLD_BL.Drivers.get_personID_FromDriverID(Convert.ToInt32(applications_dgv.CurrentRow.Cells[2].Value)));
            frm.ShowDialog();
        }
    }
}
