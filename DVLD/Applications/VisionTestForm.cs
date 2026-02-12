using DVLDBussinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class VisionTestForm : Form
    {
        int LDLA_ID = -1;
        string licenseClass = "";
        int testpassed = 0;
        byte testype = 0;

        public VisionTestForm(int LDLA_ID, string className, byte testpassed,byte type)
        {
            this.LDLA_ID = LDLA_ID;
            licenseClass = className;
            this.testpassed = testpassed;
            testype = type;
            InitializeComponent();
            applyView(type);
            application_Info_UserControl1.load_data(LDLA_ID, className, testpassed);

        }

        public void refresh_table()
        {
            appoitments_dgv.DataSource = DVLD_BL.Applications.get_testAppoitments(LDLA_ID, testype);
            if (appoitments_dgv.Rows.Count > 0)
            {
                appoitments_dgv.Columns["TestAppointmentID"].HeaderText = "Appointment ID";
                appoitments_dgv.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                appoitments_dgv.Columns["PaidFees"].HeaderText = "Paid Fees";
                appoitments_dgv.Columns["IsLocked"].HeaderText = "Is Locked";
                recordsLabel.Text = $"Records : {appoitments_dgv.Rows.Count}";
                appoitments_dgv.Sort(appoitments_dgv.Columns["AppointmentDate"], ListSortDirection.Descending);
            }
        }

        private void VisionTestForm_Load(object sender, EventArgs e)
        {
            refresh_table();
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            if (appoitments_dgv.Rows.Count > 0)
                if (Convert.ToBoolean(appoitments_dgv.CurrentRow.Cells[3].Value) == false)
                {
                    MessageBox.Show("Person already have an active appoitment", "Add failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (appoitments_dgv.Rows.Count > 0)
                if (Convert.ToBoolean(appoitments_dgv.CurrentRow.Cells[3].Value) == true && (testype - testpassed) == 1)
                {
                }
                else
                {
                    MessageBox.Show("Person already passed this test", "Add failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            schduleTestForm frm = new schduleTestForm(LDLA_ID, licenseClass, application_Info_UserControl1.get_applicant_name(),
                get_trial(), testype);
            frm.ShowDialog();
            if (appoitments_dgv.Rows.Count > 1)
            {
                frm.show_app_id(Convert.ToInt32(appoitments_dgv.CurrentRow.Cells[0].Value));
            }
        }

        public int get_trial()
        {
            int counter = 0;
            foreach (DataGridViewRow row in appoitments_dgv.Rows)
            {
                if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true) counter++;
            }
            return counter;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (appoitments_dgv.Rows.Count > 0)
                if (Convert.ToBoolean(appoitments_dgv.CurrentRow.Cells[3].Value) == true)
                {
                    MessageBox.Show("Person already sat for a test", "Edit is Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            schduleTestForm frm = new schduleTestForm(application_Info_UserControl1.get_LDLA_ID(),
                application_Info_UserControl1.get_licenseClass(), application_Info_UserControl1.get_applicant_name(), get_trial(), testype,
                Convert.ToInt32(appoitments_dgv.CurrentRow.Cells[0].Value));
                if (appoitments_dgv.Rows.Count > 1)
                {
                    frm.show_app_id(Convert.ToInt32(appoitments_dgv.CurrentRow.Cells[0].Value));
                }

            frm.ShowDialog();
        }

        public int get_applicationID() {
            return application_Info_UserControl1.get_applicantion_ID();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(appoitments_dgv.CurrentRow.Cells[3].Value) == true)
            {
                MessageBox.Show("Appoitment is locked", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((DateTime)appoitments_dgv.CurrentRow.Cells[1].Value > DateTime.Now.AddMinutes(1))
            {
                MessageBox.Show("This Appointment Time didn't come yet, wait", "Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TakeTestForm frm = new TakeTestForm(LDLA_ID,application_Info_UserControl1.get_licenseClass(),application_Info_UserControl1.get_applicant_name()
                                            , get_trial(), testype, Convert.ToInt32(appoitments_dgv.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        public void update_test_passed()
        {
            testpassed += 1;
        }

        private void applyView(byte type)
        {
            if(type == 2)
            {
                this.Text = "Written test";
                headerLabel.Text = "Written test Apptoitments";
                peoplePictureBox.Image = Properties.Resources.writtenTest;
                return;
            }
            if(type == 3)
            {
                this.Text = "Street test";
                headerLabel.Text = "Street test Apptoitments";
                peoplePictureBox.Image = Properties.Resources.streetTest;
                return;
            }
           
        }

    } 
}
