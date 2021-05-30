using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCustomAction
{
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            this.TopMost = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtKey.Text))
                valid = VerifyLicenseInfo(txtName.Text, txtKey.Text);

            if (!valid)
            {
                MessageBox.Show("You license information does not appear to be valid. Please try again.", "Invalid info");
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private bool VerifyLicenseInfo(string registeredName, string key)
        {
            // Connect to License server or run algorithm check to 
            // verify license key.
            return true;
        }
    }
}
