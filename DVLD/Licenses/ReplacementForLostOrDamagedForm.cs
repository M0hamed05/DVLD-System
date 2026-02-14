using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class ReplacementForLostOrDamagedForm : Form
    {
        public ReplacementForLostOrDamagedForm()
        {
            InitializeComponent();
        }
        int applicationID = -1;

        private void ReplacementForLostOrDamagedForm_Load(object sender, EventArgs e)
        {
            drvierLicenseInfo_WithFilterUserControl1.addButtonClicked += userControl_addButtonClicked;
        }

        private void userControl_addButtonClicked(object sender, EventArgs e)
        {
            if (!drvierLicenseInfo_WithFilterUserControl1.IsActive())
            {
                MessageBox.Show($"Selected License is not Active, choose an active license",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                issueReplacmentBtn.Enabled = false;
            }
            else
            {
                issueReplacmentBtn.Enabled = true;
            }

            ApplicationDateTxtBox.Text = DateTime.Now.ToShortDateString();
            oldLicenseIDTxtBox.Text = drvierLicenseInfo_WithFilterUserControl1.get_licenseID().ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            ApplicationFeesTxtBox.Text = damagedRadioButton.Checked ? DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReplacementForADamagedDrivingLicense).Fees.ToString() :
               DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReplacementForALostDrivingLicense).Fees.ToString();
            showLicenseHistoryBtn.Enabled = true;
        }

        private void damagedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            headerLabel.Text = "Replacement for Damaged License";
           ApplicationFeesTxtBox.Text =  DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReplacementForADamagedDrivingLicense).Fees.ToString();
           

        }

        private void lostRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            headerLabel.Text = "Replacement for Lost License";
            ApplicationFeesTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReplacementForALostDrivingLicense).Fees.ToString();

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
            ShowLicenseInfo frm = new ShowLicenseInfo(applicationID);
            frm.ShowDialog();
        }

        private void issueReplacmentButton_Click(object sender, EventArgs e)
        {

            if (!DVLD_BL.Licenses.set_license_not_active(drvierLicenseInfo_WithFilterUserControl1.get_licenseID()))
            {
                MessageBox.Show("Unexpcted error Happend unactive the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            applicationID = DVLD_BL.Applications.add_new_application(drvierLicenseInfo_WithFilterUserControl1.get_personID(), (int)DVLDShared.enAppplicationTyoes.RenewDrivingLicenseService);
            if (applicationID != -1)
            {
                int licenseID = DVLD_BL.Licenses.issue_new_license(save_data_to_struct(applicationID));
                if (licenseID != -1)
                {
                    LicenseReplacmentIDTxtBox.Text = licenseID.ToString();
                    LicenseReplacmentApplicationIDTxtBox.Text = applicationID.ToString();

                    ShowLicenseInfoBtn.Enabled = true;
                    issueReplacmentBtn.Enabled = false;
                    drvierLicenseInfo_WithFilterUserControl1.disable_filter_panel();
                    drvierLicenseInfo_WithFilterUserControl1.set_not_active();

                    MessageBox.Show("License Replacment Successfully", "Replcament Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unexpcted error Happend Replacing the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Unexpcted error Happend Adding the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DVLDShared.stLicense save_data_to_struct(int applicationID)
        {
            DVLDShared.stLicense license = new DVLDShared.stLicense();
            license.applicationID = applicationID;
            license.driverID = drvierLicenseInfo_WithFilterUserControl1.get_driverID();
            license.licenseClassID = drvierLicenseInfo_WithFilterUserControl1.get_licenseClassID();
            license.issueDate = DateTime.Now;
            license.ExpirationDate = drvierLicenseInfo_WithFilterUserControl1.get_expriationDate();
            license.Notes = drvierLicenseInfo_WithFilterUserControl1.get_notes();
            license.paidFees = Convert.ToDecimal(ApplicationFeesTxtBox.Text);
            license.isActive = true;
            license.issueReason = damagedRadioButton.Checked ? (byte)DVLDShared.enIssueReason.DamagedLicense : (byte)DVLDShared.enIssueReason.LostLicense;
            license.CreatedByUserID = DVLDShared.currentUser.userID;

            return license;
        }

    }
}
