using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class ReleaseDetainedLicenseForm : Form
    {
        public ReleaseDetainedLicenseForm()
        {
            InitializeComponent();
        }

        public void set_comboBoxID(int licenseID)
        {
            drvierLicenseInfo_WithFilterUserControl1.load_data(licenseID);
            drvierLicenseInfo_WithFilterUserControl1.disable_filter_panel();
            if (!drvierLicenseInfo_WithFilterUserControl1.IsDetain())
            {
                MessageBox.Show($"Selected License is not Detain to release, Choose another license",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReleaseBtn.Enabled = false;
            }
            else
            {
                ReleaseBtn.Enabled = true;
            }

            detainLicense = DVLD_BL.Licenses.get_detain_license_info(drvierLicenseInfo_WithFilterUserControl1.get_licenseID());

            detainIDTxtBox.Text = detainLicense.DetainID.ToString();
            LicenseIDTxtBox.Text = detainLicense.LicenseID.ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            DetainDateTxtBox.Text = detainLicense.DetainDate.ToShortDateString();
            FineFeesTxtBox.Text = detainLicense.FineFees.ToString();
            ApplicationFeesTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReleaseDetainedDrivingLicsense).Fees.ToString();
            totalFeesTxtBox.Text = (Convert.ToDecimal(ApplicationFeesTxtBox.Text) + Convert.ToDecimal(FineFeesTxtBox.Text)).ToString();
            showLicenseHistoryBtn.Enabled = true;
            drvierLicenseInfo_WithFilterUserControl1.set_licenseComboBox(licenseID);
        }

        private void ReleaseDetainedLicenseForm_Load(object sender, EventArgs e)
        {
            drvierLicenseInfo_WithFilterUserControl1.addButtonClicked += userControl_addButtonClicked;
        }

        DVLDShared.stDetainLicense detainLicense = new DVLDShared.stDetainLicense();

        private void userControl_addButtonClicked(object sender,EventArgs e)
        {
            if (!drvierLicenseInfo_WithFilterUserControl1.IsDetain())
            {
                MessageBox.Show($"Selected License is not Detain to release, Choose another license",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReleaseBtn.Enabled = false;
            }
            else
            {
                ReleaseBtn.Enabled = true;
            }

            detainLicense = DVLD_BL.Licenses.get_detain_license_info(drvierLicenseInfo_WithFilterUserControl1.get_licenseID());

            detainIDTxtBox.Text = detainLicense.DetainID.ToString();
            LicenseIDTxtBox.Text = detainLicense.LicenseID.ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            DetainDateTxtBox.Text = detainLicense.DetainDate.ToShortDateString();
            FineFeesTxtBox.Text = detainLicense.FineFees.ToString();
            ApplicationFeesTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.ReleaseDetainedDrivingLicsense).Fees.ToString();
            totalFeesTxtBox.Text = (Convert.ToDecimal(ApplicationFeesTxtBox.Text) + Convert.ToDecimal(FineFeesTxtBox.Text)).ToString();
            showLicenseHistoryBtn.Enabled = true;
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

        private void ShowLicenseInfoBtn_Click(object sender, EventArgs e)
        {
            ShowLicenseInfo frm = new ShowLicenseInfo(drvierLicenseInfo_WithFilterUserControl1.get_licenseID(), true);
            frm.ShowDialog();
        }

        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to release this Licesne?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int applicationID = DVLD_BL.Applications.add_new_application(drvierLicenseInfo_WithFilterUserControl1.get_personID(),
                    (int)DVLDShared.enAppplicationTyoes.ReleaseDetainedDrivingLicsense, Convert.ToDecimal(totalFeesTxtBox.Text.ToString()));
                if (applicationID != -1)
                {
                    if (DVLD_BL.Licenses.release_detainLicense(detainLicense.DetainID, applicationID))
                    {

                        ShowLicenseInfoBtn.Enabled = true;
                        ReleaseBtn.Enabled = false;
                        drvierLicenseInfo_WithFilterUserControl1.disable_filter_panel();
                        drvierLicenseInfo_WithFilterUserControl1.set_not_active();
                        applicationIDTxtBox.Text = applicationID.ToString();
                        drvierLicenseInfo_WithFilterUserControl1.set_not_detain();

                        MessageBox.Show("License Relaesed Successfully", "Release Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form frm = Application.OpenForms["ManageDetainLicensesForm"];
                        if (frm != null)
                            ((ManageDetainLicensesForm)frm).refersh_all();
                    }
                    else
                    {
                        MessageBox.Show("Unexpcted error Happend Releasing the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Unexpcted error Happend Adding the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
