using DVLD.Licenses;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class IssueInternationalLicenseApplicationForm : Form
    {
        int internationalLicenseID = -1;
        public IssueInternationalLicenseApplicationForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternationalLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            drvierLicenseInfo_WithFilter1.addButtonClicked += userControl_addButtonClicked;//connect event with this function in this form
        }

        private void userControl_addButtonClicked(object sender,EventArgs e)
        {
            LocalLicenseIDTxtBox.Text = Convert.ToString(drvierLicenseInfo_WithFilter1.get_licenseID());
            applicationDateTxtBox.Text = DateTime.Now.ToShortDateString();
            issueDateTxtBox.Text = DateTime.Now.ToShortDateString();
            feesTxtBox.Text = DVLD_BL.Applications.get_application_Type_Info((Convert.ToInt32(DVLDShared.enAppplicationTyoes.NewInternationalLicense))).Fees.ToString();
            createdByTxtBox.Text = DVLDShared.currentUser.username;
            ExpirationDateTxtBox.Text = DateTime.Now.AddYears(DVLD_BL.Licenses.DefaultValidityLengthAge(drvierLicenseInfo_WithFilter1.get_licenseClassID())).ToShortDateString();

        }

        private void showLicenseHistoryBtn_Click(object sender, EventArgs e)
        {
            if (drvierLicenseInfo_WithFilter1.get_driverID() != 0)
            {
                PersonLicenseHistoryForm frm = new PersonLicenseHistoryForm(drvierLicenseInfo_WithFilter1.get_personID());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Added yet","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public bool licenseValid()
        {
            if (drvierLicenseInfo_WithFilter1.get_driverID() == 0)
            {
                MessageBox.Show("No License Added yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!drvierLicenseInfo_WithFilter1.IsActive())
            {
                MessageBox.Show("License is not active", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DateTime.Now > drvierLicenseInfo_WithFilter1.get_expriationDate())
            {
                MessageBox.Show("License is Expired", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!DVLD_BL.Licenses.has_license_with_class3(drvierLicenseInfo_WithFilter1.get_driverID()))
            {
                MessageBox.Show("Driver Should Have License With class 3 first", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DVLD_BL.Licenses.has_same_international_license(drvierLicenseInfo_WithFilter1.get_licenseID()))
            {
                MessageBox.Show("Driver Aleardy have an international license with the same class", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            if (!licenseValid()) return;

            if (MessageBox.Show("Are you sure you want to issue the lisense", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int applicationID = DVLD_BL.Applications.add_new_application(drvierLicenseInfo_WithFilter1.get_personID(), (int)DVLDShared.enAppplicationTyoes.NewInternationalLicense);
                if (applicationID != -1)
                {
                    DVLDShared.stInternationalLicense InternationalLicense = save_data_to_struct(applicationID);

                    internationalLicenseID = DVLD_BL.Licenses.issue_new_international_license(InternationalLicense);
                    if (internationalLicenseID != -1)
                    {
                        MessageBox.Show("International Liscense Added Successfully", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        issueBtn.Enabled = false;
                        ShowLicenseInfoBtn.Enabled = true;
                        drvierLicenseInfo_WithFilter1.disable_filter_panel();

                        ApplicationIDTxtBox.Text = applicationID.ToString();
                       internationalLicenseIDTxtBox.Text = internationalLicenseID.ToString();

                        Form frm = Application.OpenForms["internationalLicenseApplicationForm"];
                        if (frm != null)
                            ((internationalLicenseApplicationForm)frm).refersh_all();

                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error issue the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Unexpected Error Adding the Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public DVLDShared.stInternationalLicense save_data_to_struct(int applicationID)
        {
            DVLDShared.stInternationalLicense internationalLicense = new DVLDShared.stInternationalLicense();
            internationalLicense.applicationID = applicationID;
            internationalLicense.driverID = drvierLicenseInfo_WithFilter1.get_driverID();
            internationalLicense.localLicenseID = drvierLicenseInfo_WithFilter1.get_licenseID();
            internationalLicense.issueDate = DateTime.Now;
            internationalLicense.ExpirationDate = Convert.ToDateTime(ExpirationDateTxtBox.Text.ToString());
            internationalLicense.isActive = true;
            internationalLicense.CreatedByUserID = DVLDShared.currentUser.userID;
            return internationalLicense;
        }

        private void ShowLicenseInfoBtn_Click(object sender, EventArgs e)
        {
            ShowInternationalLicenseForm frm = new ShowInternationalLicenseForm(internationalLicenseID);
            frm.ShowDialog();
        }
    }
}
