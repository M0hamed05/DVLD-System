using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ShowLicenseInfo : Form
    {
        public ShowLicenseInfo(int appID)
        {
            InitializeComponent();
            driverLicenseInfoUserCiontrol1.load_data_by_aaplicationID(appID);
        }

        private void ShowLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
