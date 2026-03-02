using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Login_and_main
{
    public partial class ChangeBackgroundImageForm : Form
    {
        public ChangeBackgroundImageForm()
        {
            InitializeComponent();
        }

        bool RemovedClicked = false;

        private void delete_image_from_app_data()
        {
            if (string.IsNullOrEmpty(image_path)) return;

            try
            {
                if (File.Exists(image_path))
                {
                    File.Delete(image_path);
                }
            }
            catch
            {
                throw;
            }
        }

        private void remove_image_form_app_data(string image_path)
        {
            if (string.IsNullOrEmpty(image_path)) return;

            try
            {
                if (File.Exists(image_path))
                {
                    if (viewPictureBox.ImageLocation == image_path)
                    {
                        viewPictureBox.ImageLocation = null;
                    }
                    if(image_path != Properties.Settings.Default.BackgorundImage)
                    {
                        delete_image_from_app_data();
                    }
                }
                
            }
            catch
            {
                throw;
            }
        }

        string localappdataPath, imagesFolder, newfilename, image_path = "";
        private string copy_image_to_app_data(string orginal_image_path)
        {
            try
            {
                //get app data folder path
                localappdataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                imagesFolder = Path.Combine(localappdataPath, "DVLD_Images");// create your folder path

                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);//create floder if not exists in that path

                newfilename = Guid.NewGuid().ToString() + Path.GetExtension(orginal_image_path); //creataes file name with it's type

                image_path = Path.Combine(imagesFolder, newfilename);//creates new image address

                File.Copy(orginal_image_path, image_path, true);//copy the orginal photo to it

                return image_path;

            }
            catch
            {
                return "";
            }
        }

        private void setImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (removeImageBtn.Visible == true)
                {
                    remove_image_form_app_data(viewPictureBox.ImageLocation);
                }
                else
                {
                    removeImageBtn.Visible = true;
                    RemovedClicked = false;
                    setImageBtn.Text = "Change Image";
                }
                viewPictureBox.ImageLocation = copy_image_to_app_data(dlg.FileName);
            }
        }

        private void removeImageBtn_Click(object sender, EventArgs e)
        {
            remove_image_form_app_data(viewPictureBox.ImageLocation);
            RemovedClicked = true;
            removeImageBtn.Visible = false;
            setImageBtn.Text = "Set Image";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!RemovedClicked)
            {
                if (image_path != Properties.Settings.Default.BackgorundImage)
                {
                    Properties.Settings.Default.BackgorundImage = image_path;
                    Properties.Settings.Default.Save();
                    MainForm frm = (MainForm)Application.OpenForms["MainForm"];
                    if (frm != null && frm is MainForm)
                    {
                        frm.show_image();
                    }
                    MessageBox.Show("Image Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (Properties.Settings.Default.BackgorundImage != "")
                {
                    Properties.Settings.Default.BackgorundImage = "";
                    Properties.Settings.Default.Save();

                    MainForm frm = (MainForm)Application.OpenForms["MainForm"];
                    if (frm != null && frm is MainForm)
                    {
                        frm.remove_image();
                        delete_image_from_app_data();
                    }
                    MessageBox.Show("Image Reomved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeBackgroundImageForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackgorundImage) &&
                    File.Exists(Properties.Settings.Default.BackgorundImage))
            {
                removeImageBtn.Visible = true;
                setImageBtn.Text = "Change Image";
                viewPictureBox.ImageLocation = Properties.Settings.Default.BackgorundImage;//should be form file here
            }
            image_path = viewPictureBox.ImageLocation;
        }
    }
}
