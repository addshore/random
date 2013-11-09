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
    public partial class frmLogin : Form
    {

        public static int attemptcount = 0;
        public static int lockcount = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Setup the login Form
            btnLogin.Enabled = false; //Disable the login button
            lblLoginStatus.Text = "Waiting for user login"; //Set the status
        }

        //If the user textbox or the password text box text changes then check to see if we should allow login
        private void txtPassword_TextChanged(object sender, EventArgs e) { CheckUserData(); }
        private void txtUsername_TextChanged(object sender, EventArgs e) { CheckUserData(); }

        private void CheckUserData()
        {

            if ((txtPassword.Text.Length > 0) && (txtUsername.Text.Length > 0))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Disable form controls
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;

            //Increment the attempt counter.
            attemptcount = attemptcount + 1;

            //Update the status
            lblLoginStatus.Text = "Checking Use Details";
            loadStatus.Value = +1;

            //Get the username and password
            string myuser = txtUsername.Text.ToString();
            string mypass = Encryption.Encrypt(txtPassword.Text).ToString();

            //Update the status again
            lblLoginStatus.Text = "Logging In";
            loadStatus.Value = +1;

            //Start the database connection...
            int admincount = int.Parse(Database.RequestScalar("Select count(*) from Admins where Login='" + myuser + "' and Password = '" + mypass + "' ").ToString());
            if (admincount.Equals(1))
            {
                //Login Successfull
                lblLoginStatus.Text = "Password Accepted";
                loadStatus.Value = +1;

                //Set the global Variables
                Variables.username = myuser;

                //Show the Main Form and close this one
                lblLoginStatus.Text = "Opening Main Form";
                loadStatus.Value = +1;
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                if (attemptcount == 3)
                {

                    //Reset the attemp counter to 0
                    attemptcount = 0;
                    //Increment the lock count
                    lockcount = lockcount + 1;

                    //Freeze the form
                    this.Enabled = false;

                    //Count down for five seconds unitl next login
                    for (int i = 2 * (lockcount * lockcount); i != 0; i--)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }

                    //Unfreezes the form
                    this.Enabled = true;



                }

                //Login Insucessfull, Reset form
                lblLoginStatus.Text = "Invalid Username or Password";
                loadStatus.Value = 0;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtUsername.Text = "";
                txtPassword.Text = "";

            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On a return keypress in either box login
            if (e.KeyChar.ToString().Equals("\r")) { if (btnLogin.Enabled.Equals(true)) { btnLogin.Enabled = false; btnLogin_Click(null, null); } }
        }
    }
}