using DVLDBussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class PersonLicenseHistoryForm : Form
    {
        DataTable dtLocal = new DataTable();
        DataTable dtInternational = new DataTable();
        public PersonLicenseHistoryForm(int personID)
        {
            InitializeComponent();
            personInfoUserControl1.load_person_data(personID);
            dtLocal = DVLD_BL.Licenses.get_Driver_local_license(DVLD_BL.Drivers.get_DriverID_by_PerosnID(personInfoUserControl1.get_personID()));
            dtInternational = DVLD_BL.Licenses.get_Driver_international_license(DVLD_BL.Drivers.get_DriverID_by_PerosnID(personInfoUserControl1.get_personID()));
        }

        private void PersonLicenseHistoryForm_Load(object sender, EventArgs e)
        {
            refersh_table(true);
        }

        public void refersh_table(bool local)
        {
            if (local)
            {
                DriverLicense_dgv.DataSource = dtLocal;
                if (DriverLicense_dgv.Rows.Count > 0)
                {
                    dtLocal.DefaultView.Sort = "IssueDate DESC";
                    DriverLicense_dgv.Columns[0].HeaderText = "Lic ID";
                    DriverLicense_dgv.Columns[1].HeaderText = "App ID";
                    DriverLicense_dgv.Columns[2].HeaderText = "Class Name";
                    DriverLicense_dgv.Columns[2].FillWeight = 200;
                    DriverLicense_dgv.Columns[3].HeaderText = "Issue Date";
                    DriverLicense_dgv.Columns[4].HeaderText = "Expiation Date";
                    DriverLicense_dgv.Columns[5].HeaderText = "Is Active";

                    DriverLicense_dgv.Columns[3].DefaultCellStyle.Format = "d";
                    DriverLicense_dgv.Columns[4].DefaultCellStyle.Format = "d";
                }
            }
            else
            {
                DriverLicense_dgv.DataSource = dtInternational;
                if (DriverLicense_dgv.Rows.Count > 0)
                {
                    dtLocal.DefaultView.Sort = "IssueDate DESC";
                    DriverLicense_dgv.Columns[0].HeaderText = "Int License ID";
                    DriverLicense_dgv.Columns[1].HeaderText = "App ID";
                    DriverLicense_dgv.Columns[2].HeaderText = "L. Licese ID";
                    DriverLicense_dgv.Columns[3].HeaderText = "Issue Date";
                    DriverLicense_dgv.Columns[4].HeaderText = "Expiation Date";
                    DriverLicense_dgv.Columns[5].HeaderText = "Is Active";

                    DriverLicense_dgv.Columns[3].DefaultCellStyle.Format = "d";
                    DriverLicense_dgv.Columns[4].DefaultCellStyle.Format = "d";
                }
            }
            recordsLabel.Text = $"Records: {DriverLicense_dgv.RowCount}";
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refersh_table(true);
        }

        private void internationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refersh_table(false);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(Convert.ToInt32(DriverLicense_dgv.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }
    }
}
