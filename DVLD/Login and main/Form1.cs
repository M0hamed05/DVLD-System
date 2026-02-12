using System;
using System.Windows.Forms;

using DVLDBussinessLayer;

namespace DVLD
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginForm_Shown(object sender, EventArgs e)//when it finished the loading
        {
            int saved_id = Properties.Settings.Default.SavedID;
            if (DVLD_BL.People.is_person_found(saved_id))
                if (saved_id != 0)
                {
                    MainForm mainForm = new MainForm(saved_id);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    Properties.Settings.Default.SavedID = 0;
                }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int personID = DVLD_BL.Users.authonticate(usernameTextBox.Text, passwordTextBox.Text);

            if (personID == 0)
            {
                errorLabel.Text = "";
                System.Threading.Thread.Sleep(50);
                errorLabel.Text = "Invalid username or password!";
                return;
            }
            else if (personID == -1)
            {
                errorLabel.Text = "";
                System.Threading.Thread.Sleep(50);
                errorLabel.Text = "Database Error!";
                return;
            }

            //remember me
            if (rememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.SavedID = personID;
            }
            else
            {
                Properties.Settings.Default.SavedID = 0;
            }
            Properties.Settings.Default.Save();

            //active or not
            if (!DVLD_BL.Users.is_active_user(personID))
            {
                errorLabel.Text = "User is not active";
                return;
            }

            //show main form
            this.Hide();

            Form frm = Application.OpenForms["MainForm"];

            if (frm != null)
            {
                MainForm mainForm = (MainForm)frm;
                mainForm.update_user_info(personID);
                mainForm.Show();
            }
            else
            {
                MainForm frm2 = new MainForm(personID);
                frm2.Show();
            }

        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if(usernameTextBox.Focused) passwordTextBox.Focus();
                else if(passwordTextBox.Focused) loginBtn.PerformClick();
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length < 4) usernameErrorProvider.SetError(usernameTextBox, "Username Should be 4 at least");
            else usernameErrorProvider.Clear();
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 4) passowrdErrorProvider.SetError(passwordTextBox, "Password Should be 4 at least");
            else passowrdErrorProvider.Clear();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
