using DVLD.Applications;
using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddLocalDrivingLicenseApplicationForm : Form
    {
        public AddLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        bool nextClicked = false;
        bool saved = false;

        private void AddLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            DVLD_BL.Applications.get_all_licenseClasses();
            licenseClassComboBox.DataSource = DVLDShared.LicenseClasses;
            licenseClassComboBox.SelectedIndex = 2;
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            if (!nextClicked)
            {
                if (!peersonInfoWithFilterUserControl1.is_add_selected()) peersonInfoWithFilterUserControl1.preform_add_click();
                dateTxtBox.Text = $"{DateTime.Now.ToShortDateString()}";
                usernameTxtBox.Text = $"{DVLDShared.currentUser.username}";

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
                MessageBox.Show($"error adding the user", "operation failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
