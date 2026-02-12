using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ShowApplicationDetailsForm : Form
    {
        public ShowApplicationDetailsForm(int LDLA_ID, string licenseClass, byte passedtests, bool isThereLicense = false)
        {
            InitializeComponent();
            application_Info_UserControl1.load_data(LDLA_ID, licenseClass, passedtests,isThereLicense);
            
        }

        private void ApplicationInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
