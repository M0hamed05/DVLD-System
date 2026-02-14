using DVLDBussinessLayer;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class DrvierLicenseInfo_WithFilterUserControl : UserControl
    {
        public DrvierLicenseInfo_WithFilterUserControl()
        {
            InitializeComponent();
        }

        private void DrvierLicenseInfo_WithFilter_Load(object sender, EventArgs e)
        {
            licensesComboBox.DataSource = DVLD_BL.Licenses.get_all_licenseID();
            licensesComboBox.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (driverLicenseInfoUserCiontrol1.get_license_id() != (int)licensesComboBox.SelectedValue)
                driverLicenseInfoUserCiontrol1.load_data(Convert.ToInt32(licensesComboBox.SelectedValue));
            AddButtonClicked(EventArgs.Empty);//empty because no data needs to be send for now, needs to be here after loading the data
        }

        public event EventHandler addButtonClicked;//define event

        protected virtual void AddButtonClicked(EventArgs e)
        {
            addButtonClicked?.Invoke(this, e);// ? here because if no funtcion call the event not crash, invoke for work
        }

        public int get_licenseID() => driverLicenseInfoUserCiontrol1.get_license_id();
        public int get_personID() => DVLD_BL.Drivers.get_personID_FromDriverID(driverLicenseInfoUserCiontrol1.get_driverID());
        public int get_licenseClassID() => Convert.ToInt32(driverLicenseInfoUserCiontrol1.getlicenseClass_id());
        public bool IsActive() => driverLicenseInfoUserCiontrol1.IsActive();
        public DateTime get_expriationDate() => driverLicenseInfoUserCiontrol1.get_expiration_date();
        public int get_driverID() => driverLicenseInfoUserCiontrol1.get_driverID();
        public bool IsDetain() => driverLicenseInfoUserCiontrol1.IsDetain();

        public void set_not_active()
        {
            driverLicenseInfoUserCiontrol1.set_not_active();
        }


        public string get_notes() => driverLicenseInfoUserCiontrol1.get_notes();


        public void disable_filter_panel()
        {
            FilterPanel.Enabled = false;
        }

    }
}
