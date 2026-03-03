using DVLD.Resources;
using DVLDBussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class EditTestTypeSmallForm : Form
    {
        int testID = -1;
        public EditTestTypeSmallForm(int id, string test_title, string test_description,double fees)
        {
            InitializeComponent();
            this.testID = id;
            load_test(id, test_title, test_description,fees);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
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
                return;
            }
            if (string.IsNullOrEmpty(DescriptionTxtBox.Text))
            {
                if (string.IsNullOrEmpty(DescriptionTxtBox.Text)) errorProvider.SetError(FeeTxtBox, "Can't be empty");
                else errorProvider.Clear();
                return;

            }
            if (string.IsNullOrEmpty(FeeTxtBox.Text))
            {
                if (string.IsNullOrEmpty(FeeTxtBox.Text)) errorProvider.SetError(FeeTxtBox, "Can't be empty");
                else errorProvider.Clear();
                return;
            }

            if (DVLD_BL.Applications.update_testType(testID, titleTxtBox.Text.ToString(),DescriptionTxtBox.Text.ToString(), FeeTxtBox.Text.ToString()))
            {
                MessageBox.Show("Test Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = Application.OpenForms["ManageApplicationTypesForm"];
                if (frm != null)
                    ((ManageApplicationTypesForm)frm).refersh_all();
            }
            else
            {
                MessageBox.Show("Error updateing the Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void titleTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxtBox.Text)) errorProvider.SetError(titleTxtBox, "Can't be empty");
            else errorProvider.Clear();
        }

        private void DescriptionTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionTxtBox.Text)) errorProvider.SetError(DescriptionTxtBox, "Can't be empty");
            else errorProvider.Clear();
        }

        private void FeeTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FeeTxtBox.Text)) errorProvider.SetError(FeeTxtBox, "Can't be empty");
            else errorProvider.Clear();
        }

        private void FeeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void load_test(int id, string test_title,string test_description, double fees)
        {
            idLabel.Text = $"ID : {id}";
            titleTxtBox.Text = test_title;
            DescriptionTxtBox.Text = test_description;
            FeeTxtBox.Text = fees.ToString();
        }
    }
}
