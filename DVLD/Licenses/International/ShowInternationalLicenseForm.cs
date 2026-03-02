using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class ShowInternationalLicenseForm : Form
    {
        public ShowInternationalLicenseForm(int internationalLicenseID)
        {
            InitializeComponent();
            internationaLicenseInfoUserControl1.load_data(internationalLicenseID);
        }

        private void ShowInternationalLicenseForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
