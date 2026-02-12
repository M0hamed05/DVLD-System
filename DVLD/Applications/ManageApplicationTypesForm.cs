using System;
using System.Windows.Forms;
using DVLDBussinessLayer;

namespace DVLD.Resources
{
    public partial class ManageApplicationTypesForm : Form
    {
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
        }

        public void refersh_all()
        {
            applicationsTypes_dgv.DataSource =  DVLD_BL.Applications.get_all_applicationsTypes();
            applicationsTypes_dgv.Columns["ApplicationTypeID"].HeaderText = "ID";
            applicationsTypes_dgv.Columns["ApplicationTypeTitle"].HeaderText = "Ttile";
            applicationsTypes_dgv.Columns["ApplicationFees"].HeaderText = "Fees";

            applicationsTypes_dgv.Columns["ApplicationTypeTitle"].FillWeight = 600;
            recordsLabel.Text = $"Records : {applicationsTypes_dgv.RowCount}";

        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {
            refersh_all();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplicationTypeSmapleForm frm = new EditApplicationTypeSmapleForm((int)applicationsTypes_dgv.CurrentRow.Cells[0].Value
                , (string)applicationsTypes_dgv.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
