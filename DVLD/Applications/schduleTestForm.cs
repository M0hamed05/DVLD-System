using DVLD_Shared;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class schduleTestForm : Form
    {
        byte typeID = 0;
        int appointmentID = -1;
        public schduleTestForm(int LDLA_ID,string licenseClass,string ApplicantName, int trial, byte typeID,int appointmentID = -1)
        {
            InitializeComponent();
            this.typeID = typeID;
            if(appointmentID != -1)
            {
                headerLabel.Text = "Update Schedule Test";
            }
            if(trial > 0)
            {
                headerLabel.Text = "Schedule Retake Test";
                retakeInfoGroupBox.Enabled = true;
                if(trial > 1)
                {

                }
            }

            this.appointmentID = appointmentID;
            applyView(typeID);
            load_data(LDLA_ID, licenseClass, ApplicantName, trial, typeID);
        }
        bool saved = false;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (appointmentID == -1)
            {
                if (DVLD_BL.Applications.add_testApptoitments(Convert.ToInt32(applicationIDtxtBox.Text), typeID, TestdateTimePicker.Value, DVLDShared.currentUser.userID,
                    Convert.ToDecimal(totalFeesTxtBox.Text)))
                {
                    MessageBox.Show("Test Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saved = true;
                    Form frm = Application.OpenForms["VisionTestForm"];
                    if (frm != null)
                    {
                        ((VisionTestForm)frm).refresh_table();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unexcepted Error Happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (DVLD_BL.Applications.update_testAppoitment(appointmentID, TestdateTimePicker.Value))
                {
                    MessageBox.Show("Test Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saved = true;
                    Form frm = Application.OpenForms["VisionTestForm"];
                    if (frm != null)
                        ((VisionTestForm)frm).refresh_table();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Unexcepted Error Happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void load_data(int LDLA_ID, string licenseClass, string ApplicantName, int trial, byte typeID)
        {
            applicationIDtxtBox.Text = LDLA_ID.ToString();
            LicenseTxtBox.Text = licenseClass.ToString();
            nameTxtBox.Text = ApplicantName;
            trialTxtBox.Text = trial.ToString();
            FeesTxtBox.Text = DVLD_BL.Applications.get_testTypeFees(typeID).ToString();


            retakeAppIDTxtBox.Text = "N/A";
            r_appFeesTxtBox.Text = $"{trial * 5}";
            totalFeesTxtBox.Text = $"{trial * 5 + DVLD_BL.Applications.get_testTypeFees(typeID)}";

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
    
        public void show_app_id(int appID)
        {
            retakeAppIDTxtBox.Text = $"{Convert.ToString(appID)}";
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
