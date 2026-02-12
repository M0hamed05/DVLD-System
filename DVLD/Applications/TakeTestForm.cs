using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class TakeTestForm : Form
    {
        int testAppiontmnetID = -1;
        public TakeTestForm(int LDLA_ID, string licenseClass, string ApplicantName, int trial, byte typeID,int testAppiontmnetID)
        {
            this.testAppiontmnetID = testAppiontmnetID;

            InitializeComponent();

            applyView(typeID);
            load_data(LDLA_ID, licenseClass, ApplicantName, trial, typeID);
        }

        bool saved = false;
        private void TakeTestForm_Load(object sender, EventArgs e)
        {

        }

        private void load_data(int LDLA_ID, string licenseClass, string ApplicantName, int trial, byte typeID)
        {
            applicationIDtxtBox.Text = LDLA_ID.ToString();
            LicenseTxtBox.Text = licenseClass.ToString();
            nameTxtBox.Text = ApplicantName;
            trialTxtBox.Text = trial.ToString();
            FeesTxtBox.Text = DVLD_BL.Applications.get_testTypeFees(typeID).ToString();

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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save? After this, you can't change the Pass/false result after you save!", "Confrim",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DVLD_BL.Applications.save_test_withCase(testAppiontmnetID, PassRadioButton.Checked ? true : false, notesTxtBox.Text))
                {
                    MessageBox.Show("Date Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saved = true;
                    Form frm = Application.OpenForms["VisionTestForm"];
                    if (frm != null)
                    {
                        ((VisionTestForm)frm).refresh_table();
                        if(PassRadioButton.Checked)
                        ((VisionTestForm)frm).update_test_passed();
                    }
                    frm = Application.OpenForms["LocalDrivingLicenseApplicationsForm"];
                    if (frm != null)
                        ((LocalDrivingLicenseApplicationsForm)frm).refersh_all();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Saving the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void applyView(byte type)
        {
            if (type == 2)
            {
                infoGroupBox.Text = "Written test";
                topicPictureBox.Image = Properties.Resources.writtenTest;
                return;
            }
            if (type == 3)
            {
                infoGroupBox.Text = "Street test";
                topicPictureBox.Image = Properties.Resources.streetTest;
                return;
            }

        }


    }
}
