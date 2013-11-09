using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseSystem
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Variables.username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text.Equals(txtPass2.Text))
            {
                string newpassword = Encryption.Encrypt(txtPass1.Text);
                string oldpassword = Encryption.Encrypt(txtOldPass.Text);
                string passcheck = (string)Database.RequestScalar("SELECT Admins.Password FROM Admins WHERE (((Admins.login)='"+txtUsername.Text+"'));");
                if (oldpassword == passcheck)
                {
                    Database.RequestScalar("UPDATE Admins SET Admins.Password='" + newpassword + "' WHERE Admins.Login = '" + txtUsername.Text + "'");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login password");
                    txtOldPass.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match");
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
        }

        private void textchanged(object sender, EventArgs e)
        {
            if (txtPass1.Text.Length > 0 && txtPass2.Text.Length > 0 && txtOldPass.Text.Length > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}
