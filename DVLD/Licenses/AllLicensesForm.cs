using DVLD.Applications;
using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class AllLicensesForm : Form
    {
        public AllLicensesForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        public void refersh_all()
        {
            dt.Columns.Clear();
            AllLicenses_dgv.DataSource = dt;
            filterComboBox.Items.Clear();
            if (LocalradioButton.Checked)
            {
                dt = DVLD_BL.Licenses.get_all_local_licenses();
                AllLicenses_dgv.DataSource = dt;
                if (AllLicenses_dgv.Rows.Count > 0)
                {
                    AllLicenses_dgv.Columns[0].FillWeight = 60;
                    AllLicenses_dgv.Columns[1].FillWeight = 60;
                    AllLicenses_dgv.Columns[2].FillWeight = 80;
                    AllLicenses_dgv.Columns[3].FillWeight = 250;
                    AllLicenses_dgv.Columns[4].FillWeight = 250;
                    AllLicenses_dgv.Columns[5].FillWeight = 80;
                    AllLicenses_dgv.Columns[6].FillWeight = 60;
                }

                foreach (DataGridViewColumn column in AllLicenses_dgv.Columns)
                {
                    filterComboBox.Items.Add(column.HeaderText.ToString());
                }

                filterComboBox.Items.Remove(AllLicenses_dgv.Columns[5].HeaderText);
                if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
                recordsLabel.Text = $"Records : {AllLicenses_dgv.Rows.Count}";
                isActiveFilterComboBox.SelectedIndex = 0;
            }
            else
            {
                dt = DVLD_BL.Licenses.get_all_international_licenses();
                AllLicenses_dgv.DataSource = dt;
                if (AllLicenses_dgv.Rows.Count > 0)
                {
                    AllLicenses_dgv.Columns[0].FillWeight = 50;
                    AllLicenses_dgv.Columns[1].FillWeight = 50;
                    AllLicenses_dgv.Columns[2].FillWeight = 60;
                    AllLicenses_dgv.Columns[3].FillWeight = 250;
                    AllLicenses_dgv.Columns[4].FillWeight = 60;
                    AllLicenses_dgv.Columns[5].FillWeight = 60;
                }

                foreach (DataGridViewColumn column in AllLicenses_dgv.Columns)
                {
                    filterComboBox.Items.Add(column.HeaderText.ToString());
                }

                filterComboBox.Items.Remove(AllLicenses_dgv.Columns[4].HeaderText);
                if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
                recordsLabel.Text = $"Records : {AllLicenses_dgv.Rows.Count}";
                isActiveFilterComboBox.SelectedIndex = 0;
            }
        }

        private void AllLicensesForm_Load(object sender, EventArgs e)
        {
            refersh_all();
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
                dt.DefaultView.RowFilter = $"Convert([{filterComboBox.Text}], 'System.String') LIKE '{filter_txtbox.Text}%'";
            else
                dt.DefaultView.RowFilter = $"[{filterComboBox.Text}] LIKE '{filter_txtbox.Text}%'";//best mothed to filter

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 1)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filterComboBox.SelectedIndex == (filterComboBox.Items.Count -1))
            {
                filter_txtbox.Visible = false;
                isActiveFilterComboBox.Visible = true;
            }
            else
            {
                filter_txtbox.Visible = true;
                isActiveFilterComboBox.Visible = false;
            dt.DefaultView.RowFilter = "";
            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
            }

        }

        private void isActiveFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isActiveFilterComboBox.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = $"[Is Active] = 1";
            }
            else if(isActiveFilterComboBox.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = $"[Is Active] = 0";
            }
            else
            {
                dt.DefaultView.RowFilter = "";
            }
            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocalradioButton.Checked)
            {
                ShowLicenseInfo frm = new ShowLicenseInfo((int)AllLicenses_dgv.CurrentRow.Cells[0].Value, true);
                frm.ShowDialog();
            }
            else
            {
                ShowInternationalLicenseForm frm = new ShowInternationalLicenseForm((int)AllLicenses_dgv.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            }
        }

        private void showDriverHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocalradioButton.Checked)
            {
                PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(DVLD_BL.People.get_personID_by_NationaltyNO(((string)AllLicenses_dgv.CurrentRow.Cells[2].Value)));
                frm.ShowDialog();
            }
            else
            {
                PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(DVLD_BL.People.get_personID_by_NationaltyNO(((string)AllLicenses_dgv.CurrentRow.Cells[2].Value)));
                frm.ShowDialog();
            }
        }

        private void InternationalradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalradioButton.Checked)
                refersh_all();

        }

        private void LocalradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InternationalradioButton.Checked)
                refersh_all();
        }
    }
}
