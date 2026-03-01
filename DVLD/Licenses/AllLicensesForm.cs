using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class AllLicensesForm : Form
    {
        public AllLicensesForm()
        {
            InitializeComponent();
        }

        private void AllLicensesForm_Load(object sender, EventArgs e)
        {
            AllLicenses_dgv.DataSource = DVLD_BL.Licenses.get_all_local_licenses();
        }
    }
}
