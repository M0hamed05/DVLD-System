using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class RenewLicenseApplicationForm : Form
    {
        public RenewLicenseApplicationForm()
        {
            InitializeComponent();
        }

        int applicationID = -1;

        private void issueBtn_Click(object sender, EventArgs e)
        {
            if (!drvierLicenseInfo_WithFilterUserControl1.IsActive())
            {
                MessageBox.Show("license is renewed before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!DVLD_BL.Licenses.set_license_not_active(drvierLicenseInfo_WithFilterUserControl1.get_licenseID()))
            {
                MessageBox.Show("Unexpcted error Happend unactive the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            applicationID = DVLD_BL.Applications.add_new_application(drvierLicenseInfo_WithFilterUserControl1.get_personID(), (int)DVLDShared.enAppplicationTyoes.RenewDrivingLicenseService,
                Convert.ToDecimal(TotalFeesTxtBox.Text.ToString()));
            if (applicationID != -1)
            {
                int licenseID = DVLD_BL.Licenses.issue_new_license(save_data_to_struct(applicationID));
                if (licenseID != -1)
                {
                    renewedLicenseIDTxtBox.Text = licenseID.ToString();
                    RenewLicenseApplicationIDTxtBox.Text = applicationID.ToString();

                    ShowLicenseInfoBtn.Enabled = true;
                    renewButton.Enabled = false;
                    drvierLicenseInfo_WithFilterUserControl1.disable_filter_panel();
                    drvierLicenseInfo_WithFilterUserControl1.set_not_active();

                    MessageBox.Show("License Renewed Successfully", "Renew Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unexpcted error Happend Adding the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Unexpcted error Happend Adding the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenewLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            drvierLicenseInfo_WithFilterUserControl1.addButtonClicked += userControl_addButtonClicked;
        }

        private void userControl_addButtonClicked(object sender, EventArgs e)
        {
            if(drvierLicenseInfo_WithFilterUserControl1.get_expriationDate() > DateTime.Now)
            {
                MessageBox.Show($"Selected License is not yet expired, it will expired on {drvierLicenseInfo_WithFilterUserControl1.get_expriationDate().ToShortDateString()}",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                renewButton.Enabled = false;
            }
            else
            {
                renewButton.Enabled = true;
            }

            ApplicationDateTxtBox.Text = DateTime.Now.ToShortDateString();
            IssueDateTxtBox.Text = DateTime.Now.ToShortDateString();
            expirationDateTxtBox.Text = DateTime.Now.AddYears(DVLD_BL.Licenses.DefaultValidityLengthAge(drvierLicenseInfo_WithFilterUserControl1.get_licenseClassID())).ToShortDateString();
            oldLicenseIDTxtBox.Text = drvierLicenseInfo_WithFilterUserControl1.get_licenseID().ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            ApplicationFeesTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.RenewDrivingLicenseService).Fees.ToString();
            LicenseFeesTxtBox.Text = DVLD_BL.Licenses.get_licenseClassFees((drvierLicenseInfo_WithFilterUserControl1.get_licenseClassID())).ToString();
            TotalFeesTxtBox.Text = (Convert.ToDecimal(ApplicationFeesTxtBox.Text) + Convert.ToDecimal(LicenseFeesTxtBox.Text)).ToString();
            showLicenseHistoryBtn.Enabled = true;
        }

        public DVLDShared.stLicense save_data_to_struct(int applicationID)
        {
            DVLDShared.stLicense license = new DVLDShared.stLicense();
            license.applicationID = applicationID;
            license.driverID = drvierLicenseInfo_WithFilterUserControl1.get_driverID();
            license.licenseClassID = drvierLicenseInfo_WithFilterUserControl1.get_licenseClassID();
            license.issueDate = DateTime.Now;
            license.ExpirationDate = Convert.ToDateTime(expirationDateTxtBox.Text);
            license.Notes = string.IsNullOrWhiteSpace(NotesTxtBox.Text)?"" : NotesTxtBox.Text.ToString();
            license.paidFees = Convert.ToDecimal(TotalFeesTxtBox.Text);
            license.isActive = true;
            license.issueReason = (int)DVLDShared.enIssueReason.RenewLicense;
            license.CreatedByUserID = DVLDShared.currentUser.userID;

            return license;
        }

        private void ShowLicenseInfoBtn_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(applicationID);
            frm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseHistoryBtn_Click(object sender, EventArgs e)
        {
            PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(drvierLicenseInfo_WithFilterUserControl1.get_personID());
            frm.ShowDialog();
        }
    }
}
