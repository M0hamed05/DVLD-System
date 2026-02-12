using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;
using static DVLDBussinessLayer.DVLD_BL;

namespace DVLD.Applications
{
    public partial class IssueDrivingLicenseApplicaionForm : Form
    {
        public IssueDrivingLicenseApplicaionForm(int LDLA_ID,string lincenseClass,byte passedTests)
        {
            InitializeComponent();
            application_Info_UserControl1.load_data(LDLA_ID,lincenseClass,passedTests);
        }

        bool saved = false;

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                MessageBox.Show("Close and open again for a new action", "Changes already made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            int id = DVLD_BL.Licenses.issue_new_license(save_data_to_struct());

            if (id != -1)
            {
                MessageBox.Show($"License Issued Successfully with ID = {id}", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = Application.OpenForms["LocalDrivingLicenseApplicationsForm"];
                if (frm != null)
                    ((LocalDrivingLicenseApplicationsForm)frm).refersh_all();
                saved = true;

            }
            else
            {
                MessageBox.Show("Error Issue the License", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DVLDShared.stLicense save_data_to_struct()
        {
            DVLDShared.stLicense license = new DVLDShared.stLicense();
            license.applicationID = application_Info_UserControl1.get_applicantion_ID();

            int driverID = DVLD_BL.Drivers.get_DriverID_by_PerosnID(license.applicationID);
            if (driverID == -1)
            {
                license.driverID = Drivers.add_new_driver(new DVLDShared.stDriver
                {
                    personID = DVLD_BL.Applications.get_application_basic_info(license.applicationID).ApplicationPersonID
                                ,
                    createdByUserID = DVLDShared.currentUser.userID
                                ,
                    createdDate = DateTime.Now
                });
            }
            else
            {
                license.driverID = driverID;
            }

                license.licenseClassID = DVLD_BL.Licenses.get_license_class_ID(application_Info_UserControl1.get_licenseClass());

            license.issueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(DVLD_BL.Licenses.DefaultValidityLengthAge(license.licenseClassID));

            license.Notes = Convert.ToString(notesTxtBox.Text);

            license.paidFees = application_Info_UserControl1.get_applicationFees();

            license.isActive = true;

            license.issueReason = 1;

            license.CreatedByUserID = DVLDShared.currentUser.userID;

            return license;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Nothing Saved, Are you Sure to Close?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
            }
            else
                this.Close();
        }
    }
}
