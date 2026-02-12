using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageTestTypeForm : Form
    {
        public ManageTestTypeForm()
        {
            InitializeComponent();
        }

        public void refersh_all()
        {
            TestTypes_dgv.DataSource = DVLD_BL.Applications.get_all_TestTypes();
            TestTypes_dgv.Columns["TestTypeID"].HeaderText = "ID";
            TestTypes_dgv.Columns["TestTypeTitle"].HeaderText = "Ttile";
            TestTypes_dgv.Columns["TestTypeDescription"].HeaderText = "Description";
            TestTypes_dgv.Columns["TestTypeFees"].HeaderText = "Fees";


            TestTypes_dgv.Columns["TestTypeDescription"].FillWeight = 500;
            recordsLabel.Text = $"Records : {TestTypes_dgv.RowCount}";

        }

        private void ManageTestTypeForm_Load(object sender, EventArgs e)
        {
            refersh_all();
        }

        private void editTextTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypeSmallForm frm = new EditTestTypeSmallForm((int)TestTypes_dgv.CurrentRow.Cells[0].Value, 
                (string)TestTypes_dgv.CurrentRow.Cells[1].Value, (string)TestTypes_dgv.CurrentRow.Cells[2].Value);
            frm.Show();
        }
    }
}
