using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class LocalDrivingLicenseApplicationsForm : Form
    {
        public LocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        public void refersh_all()
        {
            dt = DVLD_BL.Applications.get_all_applications();
            applications_dgv.DataSource = dt;
            if (applications_dgv.Rows.Count > 0)
            {
                applications_dgv.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L AppID";
                applications_dgv.Columns["ClassName"].HeaderText = "Driving Class";
                applications_dgv.Columns["NationalNo"].HeaderText = "National No";
                applications_dgv.Columns["FullName"].HeaderText = "Full Name";
                applications_dgv.Columns["FullName"].FillWeight = 250;
                applications_dgv.Columns["ApplicationDate"].HeaderText = "Application Date";
                applications_dgv.Columns["PassedTestCount"].HeaderText = "Passed Tests";
            }
            recordsLabel.Text = $"Records : {dt.Rows.Count}";
        }

        private void LocalDrivingLicenseApplicationsForm_Load(object sender, EventArgs e)
        {
            refersh_all();
            if (applications_dgv.Rows.Count > 0)
                foreach (DataGridViewColumn column in applications_dgv.Columns)
                {
                    filterComboBox.Items.Add(column.HeaderText.ToString());
                }

            if (filterComboBox.Items.Count > 0) filterComboBox.SelectedIndex = 0;
        }

        private void filter_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 0 || filterComboBox.SelectedIndex == 5)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
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
            else if(filterComboBox.SelectedIndex == 5)
            {
                if (int.TryParse(filter_txtbox.Text, out value))
                    dt.DefaultView.RowFilter = $"Convert({dt.Columns[5]},'System.String') LIKE '{value}%'";
            }
            else dt.DefaultView.RowFilter = $"[{dt.Columns[filterComboBox.SelectedIndex]}] LIKE '{filter_txtbox.Text}%'";

            recordsLabel.Text = $"Records: {dt.DefaultView.Count}";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddLocalDrivingLicenseApplicationForm frm = new AddLocalDrivingLicenseApplicationForm();
            frm.ShowDialog();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applications_dgv.CurrentRow.Cells["Status"].Value.ToString() == "Cancelled")
            {
                MessageBox.Show("Application Aleardy Cancelled", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show("Are you Sure to cancel this Application?", "Confrim",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DVLD_BL.Applications.canacel_applicationID((Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value))))
                {
                    MessageBox.Show("Application Cancelled Successfully", "Operation Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refersh_all();
                }
                else
                {
                    MessageBox.Show("Error Cancelling the Application", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showApplicationDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApplicationDetailsForm frm = new ShowApplicationDetailsForm(
                Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value), applications_dgv.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value),
                Convert.ToString(applications_dgv.CurrentRow.Cells[6].Value) == "Completed");
            frm.ShowDialog();
        }

        private void optionsContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (ToolStripItem item in optionsContextMenuStrip.Items)
            {
                item.Enabled = true;
            }

            if (Convert.ToString(applications_dgv.CurrentRow.Cells[6].Value) == "Completed")
            {
                editToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechToolStripMenuItem.Enabled = false;
                issueDrirvingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                return;
            }

            if (Convert.ToString(applications_dgv.CurrentRow.Cells[6].Value) == "Cancelled")
            {
                editToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechToolStripMenuItem.Enabled = false;
                issueDrirvingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                return;
            }

            if (Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value) == 0)
            {
                issueDrirvingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                sechduleStreetTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;

                return;
            }

            if (Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value) == 1)
            {
                issueDrirvingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                sechduleStreetTestToolStripMenuItem.Enabled = false;
                sechduleVisionTestToolStripMenuItem.Enabled = false;

                sechduleWrittenTestToolStripMenuItem.Enabled = true;

                editToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                return;
            }
            if (Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value) == 2)
            {
                issueDrirvingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                sechduleWrittenTestToolStripMenuItem.Enabled = false;
                sechduleVisionTestToolStripMenuItem.Enabled = false;

                sechduleStreetTestToolStripMenuItem.Enabled = true;

                editToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                return;
            }
            if (Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value) == 3)
            {
                sechToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                editToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                return;
            }
        }

        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionTestForm frm = new VisionTestForm(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value), applications_dgv.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value), 1);
            frm.ShowDialog();
        }

        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionTestForm frm = new VisionTestForm(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value), applications_dgv.CurrentRow.Cells[1].Value.ToString(),
            Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value), 2);
            frm.ShowDialog();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisionTestForm frm = new VisionTestForm(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value), applications_dgv.CurrentRow.Cells[1].Value.ToString(),
            Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value), 3);
            frm.ShowDialog();
        }

        private void issueDrirvingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicenseApplicaionForm frm = new IssueDrivingLicenseApplicaionForm(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value), applications_dgv.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToByte(applications_dgv.CurrentRow.Cells[5].Value));
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(DVLD_BL.Applications.get_applicationID_by_LDLA(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value)));
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Application", "Confrim Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                if (DVLD_BL.Applications.delete_localDrivingLicenseApplication(Convert.ToInt32(applications_dgv.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Application Deleted SuccessFully", "Deletion Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refersh_all();
                }
                else
                {
                    MessageBox.Show("Unexpected Error Deleting the Application", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(
                DVLD_BL.People.get_personID_by_NationaltyNO(Convert.ToString(applications_dgv.CurrentRow.Cells[2].Value)));
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature could be added in the future","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}