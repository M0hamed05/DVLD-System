using DVLD.Resources;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class EditApplicationTypeSmapleForm : Form
    {
        int applicationID = -1;
        bool saved = false;

        public EditApplicationTypeSmapleForm(int id,string application_text)
        {
            InitializeComponent();
            load_application(id, application_text);
            applicationID = id;
        }

        private void FeeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void titleTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxtBox.Text)) errorProvider.SetError(titleTxtBox, "Can't be empty");
            else errorProvider.Clear();
        }

        private void FeeTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FeeTxtBox.Text)) errorProvider.SetError(FeeTxtBox, "Can't be empty");
            else errorProvider.Clear();
        }

        private void load_application(int id, string application_text)
        {
            idLabel.Text = $"ID : {id}";
            titleTxtBox.Text = application_text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saved)
            {
                MessageBox.Show("Close and open again for a new action", "Changes already made", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            foreach (Control ctrl in Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(ctrl)))
                {
                    MessageBox.Show("Error, Please Fix the red Errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(titleTxtBox.Text))
            {
                if (string.IsNullOrEmpty(titleTxtBox.Text)) errorProvider.SetError(titleTxtBox, "Can't be empty");
                else errorProvider.Clear();
            }
            if (string.IsNullOrEmpty(FeeTxtBox.Text))
            {
                if (string.IsNullOrEmpty(FeeTxtBox.Text)) errorProvider.SetError(FeeTxtBox, "Can't be empty");
                else errorProvider.Clear();
            }

            if (DVLD_BL.Applications.update_applicationtype(applicationID,titleTxtBox.Text.ToString(),FeeTxtBox.Text.ToString()))
            {
                MessageBox.Show("Application Type Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = Application.OpenForms["ManageApplicationTypesForm"];
                if (frm != null)
                    ((ManageApplicationTypesForm)frm).refersh_all();
                saved = true;
            }
            else
            {
                MessageBox.Show("Error updateing the Application Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saved = false;
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
