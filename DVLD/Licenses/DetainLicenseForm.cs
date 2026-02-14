using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class DetainLicenseForm : Form
    {
        public DetainLicenseForm()
        {
            InitializeComponent();
        }

        private void FineFeesTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void DetainLicenseForm_Load(object sender, EventArgs e)
        {
            drvierLicenseInfo_WithFilterUserControl1.addButtonClicked += userControl_addButtonClicked;
        }

        private void userControl_addButtonClicked(object sender, EventArgs e)
        {
            if (drvierLicenseInfo_WithFilterUserControl1.IsDetain())
            {
                MessageBox.Show("License is Already Detained, Choose anthor License", "Not Allowrd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DetainBtn.Enabled = true;
            }
            ApplicationDateTxtBox.Text = DateTime.Now.ToShortDateString();
            LicenseIDTxtBox.Text = drvierLicenseInfo_WithFilterUserControl1.get_licenseID().ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReplacementForALostDrivingLicense).Fees.ToString();
            showLicenseHistoryBtn.Enabled = true;
        }

        private void showLicenseHistoryBtn_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(drvierLicenseInfo_WithFilterUserControl1.get_personID());
            frm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicenseInfoBtn_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(drvierLicenseInfo_WithFilterUserControl1.get_licenseID(),true);
            frm.ShowDialog();
        }

        private void DetainBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FineFeesTxtBox.Text))
            {
                MessageBox.Show("Please Enter a Fine Fee", "Required Field is empty", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int applicationID = DVLD_BL.Applications.add_new_application(drvierLicenseInfo_WithFilterUserControl1.get_personID(), (int)DVLDShared.enAppplicationTyoes.RenewDrivingLicenseService);
            if (applicationID != -1)
            {
                int detainLicenseID = DVLD_BL.Licenses.add_detain_license(save_data_to_struct(applicationID));
                if (detainLicenseID != -1)
                {
                    detainIDTxtBox.Text = detainLicenseID.ToString();

                    ShowLicenseInfoBtn.Enabled = true;
                    DetainBtn.Enabled = false;
                    drvierLicenseInfo_WithFilterUserControl1.disable_filter_panel();
                    drvierLicenseInfo_WithFilterUserControl1.set_not_active();

                    MessageBox.Show("License Detained Successfully", "Detain Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unexpcted error Happend Detaining the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Unexpcted error Happend Adding the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DVLDShared.stDetainLicense save_data_to_struct(int applicationID)
        {
            DVLDShared.stDetainLicense detainLicense = new DVLDShared.stDetainLicense();
            detainLicense.ReleaseApplicationID = applicationID;
            detainLicense.LicenseID = drvierLicenseInfo_WithFilterUserControl1.get_licenseID();
            detainLicense.DetainDate = DateTime.Now;
            detainLicense.FineFees = Convert.ToDecimal(FineFeesTxtBox.Text.ToString());
            detainLicense.CreatedByUserID = DVLDShared.currentUser.userID;
            detainLicense.IsReleased = false;
            detainLicense.ReleaseDate = null;
            detainLicense.ReleasedByUserID = null;
            detainLicense.ReleaseApplicationID = null;

            return detainLicense;
        }

    }
}
