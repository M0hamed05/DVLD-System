using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddLocalDrivingLicenseApplicationForm : Form
    {
        bool updateMode = false;
        public AddLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }
        int LDLA_ID; string drivingClass; DateTime applicationDate;
        public AddLocalDrivingLicenseApplicationForm(int LDLA_ID,string drivingClass,DateTime applicationDate)
        {
            InitializeComponent();
            this.LDLA_ID = LDLA_ID;
            this.drivingClass = drivingClass;
            this.applicationDate = applicationDate;
            updateMode = true;
        }

        bool nextClicked = false;
        bool saved = false;

        private void AddLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            DVLD_BL.Applications.get_all_licenseClasses();
            licenseClassComboBox.DataSource = DVLDShared.LicenseClasses;
            licenseClassComboBox.SelectedIndex = 2;

            if (updateMode)
                Load_data(LDLA_ID, drivingClass, applicationDate);

        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            if (!nextClicked)
            {
                if (!peersonInfoWithFilterUserControl1.is_add_selected()) peersonInfoWithFilterUserControl1.perform_add_click();
                dateTxtBox.Text = $"{DateTime.Now.ToShortDateString()}";
                usernameTxtBox.Text = $"{DVLDShared.currentUser.username}";
                feesTxtBox.Text = $"{DVLD_BL.Applications.get_application_Type_Info((int)DVLDShared.enAppplicationTyoes.NewLocalDrivingLicenseApplication).Fees}";
                peersonInfoWithFilterUserControl1.Enabled = false;
                applicationInfoPanel.Visible = true;
                nextClicked = true;
                saveBtn.Enabled = true;
                nxtBtn.Text = "Prev";
            }
            else
            {
                peersonInfoWithFilterUserControl1.Enabled = true;
                applicationInfoPanel.Visible = false;
                nextClicked = false;
                saveBtn.Enabled = false;
                nxtBtn.Text = "Next";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(DVLD_BL.Licenses.person_have_this_license(peersonInfoWithFilterUserControl1.get_nationalityNo(), licenseClassComboBox.SelectedValue.ToString()))
            {
                MessageBox.Show($"The selected Person Already have a License with the same License Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DVLD_BL.Applications.cant_add_new_local_driving_application(peersonInfoWithFilterUserControl1.get_nationalityNo(), licenseClassComboBox.SelectedValue.ToString()))
            {
                MessageBox.Show($"Choose Anthor License Class, The selected Person Already have an active Appliaction for the selected class With Id = {DVLD_BL.Applications.get_applicationID_by_personID(peersonInfoWithFilterUserControl1.get_personID())}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!updateMode)
            {
                int applicationID = DVLD_BL.Applications.add_new_LocalDrvingLicenseApplication(peersonInfoWithFilterUserControl1.get_personID(),
                     1, ((int)licenseClassComboBox.SelectedIndex + 1));
                if (applicationID != -1)
                {
                    MessageBox.Show($"L.L.D Application added successfully with Application id :{applicationID}", "operation success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    saved = true;
                    idTxtBox.Text = $"{applicationID}";

                    Form frm = Application.OpenForms["LocalDrivingLicenseApplicationsForm"];
                    if (frm != null)
                        ((LocalDrivingLicenseApplicationsForm)frm).refersh_all();

                }
                else
                {
                    MessageBox.Show($"error adding the Application", "update failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (DVLD_BL.Applications.update_LocalDrivingLicenseApplication(Convert.ToInt32(idTxtBox.Text), (licenseClassComboBox.SelectedIndex + 1)))
                {
                    MessageBox.Show($"L.L.D Application updated successfully", "update success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    saved = true;

                    Form frm = Application.OpenForms["LocalDrivingLicenseApplicationsForm"];
                    if (frm != null)
                        ((LocalDrivingLicenseApplicationsForm)frm).refersh_all();

                }
                else
                {
                    MessageBox.Show($"error updating the Application", "update failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void Load_data(int LDLA_ID, string drivingClass, DateTime applicationDate)
        {
            headerLabel.Text = "Update Local Driving License Application";
            peersonInfoWithFilterUserControl1.update_mode(DVLD_BL.Applications.get_applicantPersonID_by_LDLA(LDLA_ID));
            peersonInfoWithFilterUserControl1.inVisible_filterPanel();
            DVLDShared.clsApplication application = DVLD_BL.Applications.get_application_basic_info(
                DVLD_BL.Applications.get_applicationID_by_LDLA(LDLA_ID));

            nxtBtn.Enabled = false;
            saveBtn.Enabled = true;
            applicationInfoPanel.Visible = true;
            idTxtBox.Text = LDLA_ID.ToString();
            licenseClassComboBox.Text = drivingClass.ToString();
            dateTxtBox.Text = applicationDate.ToShortDateString();
            usernameTxtBox.Text = DVLD_BL.Users.get_user_data(application.UserID).username;
        }
    }
}
