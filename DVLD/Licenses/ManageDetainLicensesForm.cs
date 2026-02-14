using DVLD.Applications;
using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class ManageDetainLicensesForm : Form
    {
        public ManageDetainLicensesForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void ManageDetainLicensesForm_Load(object sender, EventArgs e)
        {
            refersh_all();

            foreach (DataGridViewColumn Column in detainLicense_dgv.Columns)
            {
                filterComboBox.Items.Add(Column.HeaderText);
            }
            filterComboBox.Items.RemoveAt(2);
            filterComboBox.Items.RemoveAt(2);
            filterComboBox.Items.RemoveAt(3);

            if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
        }

        public void refersh_all()
        {
            dt = DVLD_BL.Licenses.get_all_detainLicense(); ;
            detainLicense_dgv.DataSource = dt;
            recordsLabel.Text = $"Recordrs : {detainLicense_dgv.RowCount}";
        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm frm = new ReleaseDetainedLicenseForm();
            frm.ShowDialog();
        }

        private void detainButton_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm frm = new ReleaseDetainedLicenseForm();
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

            dt.DefaultView.RowFilter = string.Format($"Convert([{filterComboBox.Text}], 'System.String') LIKE '{filter_txtbox.Text}%'");//optimized than last ways

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 1 || filterComboBox.SelectedIndex == 5)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void showPersonDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetailsForm frm = new PersonDetailsForm(DVLD_BL.People.get_personID_by_NationaltyNO(detainLicense_dgv.CurrentRow.Cells[6].Value.ToString()));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(Convert.ToInt32(detainLicense_dgv.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(DVLD_BL.People.get_personID_by_NationaltyNO(detainLicense_dgv.CurrentRow.Cells[6].Value.ToString()));
            frm.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm frm = new ReleaseDetainedLicenseForm();
            frm.set_comboBoxID(Convert.ToInt32(detainLicense_dgv.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void optionsContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToBoolean(detainLicense_dgv.CurrentRow.Cells[3].Value)) releaseDetainLicenseToolStripMenuItem.Enabled = false;
            else releaseDetainLicenseToolStripMenuItem.Enabled = true;
        }
    }
}
