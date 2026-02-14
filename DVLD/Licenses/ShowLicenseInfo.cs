using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ShowLicenseInfo : Form
    {
        public ShowLicenseInfo(int ID, bool showByLicenseID = false)
        {
            InitializeComponent();
            if (showByLicenseID)
            {
                driverLicenseInfoUserCiontrol1.load_data(ID);
            }
            else
            {
                driverLicenseInfoUserCiontrol1.load_data_by_aaplicationID(ID);
            }
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
