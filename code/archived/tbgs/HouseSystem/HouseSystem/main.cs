using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //due to use of OLEDB and databases
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //due to use of threading
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections; //due to use fo queues

namespace HouseSystem
{

    public partial class frmMain : Form
    {

        private volatile bool _shouldStop = false;

        public frmMain()
        {
            InitializeComponent();
            // Stop the exception about thread being thrown
            Control.CheckForIllegalCrossThreadCalls = false; 
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Run our own sub to close everything nicely
            closeALL();
        }

        private void closeALL()
        {
            // Add Log
            addlog("CLOSE", "Aplication closing ("+Variables.username+")");
            // Uset the global username variable
            Variables.username = "";
            // Set the variable for the threads to stop
            _shouldStop = true;
            // Close the application
            System.Environment.Exit(0);
            Application.Exit(); 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            // Hide the main form
            this.Hide();


            //If the database file doesn't exist then exit
            if (File.Exists("Database.accdb") == false)
            {
                MessageBox.Show("Database file not found");
                System.Environment.Exit(0);
            }
            else
            {

                // Fill the Data Set from tables
                // this.notesTableAdapter.Fill(this.dsMain.Notes); // This table isnt used any more
                this.logTableAdapter.Fill(this.dsMain.Log);
                this.commendationsTableAdapter.Fill(this.dsMain.Commendations);
                this.subjectsTableAdapter.Fill(this.dsMain.Subjects);
                this.studentsTableAdapter.Fill(this.dsMain.Students);
                this.adminsTableAdapter.Fill(this.dsMain.Admins);
                this.effort_GradesTableAdapter.Fill(this.dsMain.Effort_Grades);
                this.year_GroupsTableAdapter.Fill(this.dsMain.Year_Groups);
                this.certificate_TypesTableAdapter.Fill(this.dsMain.Certificate_Types);
                this.commendation_TypesTableAdapter.Fill(this.dsMain.Commendation_Types);
                this.certificatesTableAdapter.Fill(this.dsMain.Certificates);

                // Start a new login form
                Form frmLogin = new frmLogin();

                // If the login form does not return as OK
                if (frmLogin.ShowDialog(this) != DialogResult.OK)
                {
                    // Exit the application
                    System.Environment.Exit(0);
                }
                // Else continue
                else if (Variables.username.Length == 0)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    // Add loggin log
                    addlog("LOGIN", "User " + Variables.username + " logged in");
                    // Update the most recent login for the admin
                    Database.Update("Admins", "Last Logged In", DateTime.Now.ToLongDateString(), "Login", Variables.username.ToString());
                    // Retreive the notes
                    rtbMyNotes.Text = (string)Database.RequestScalar("SELECT Admins.Note FROM Admins WHERE (((Admins.Login)='" + Variables.username + "'));");
                    rtbSysNotes.Text = Settings.get("note");//rtbSysNotes.Text = (string)Database.dbRequest("SELECT Config.Data FROM Config WHERE (((Config.ID)='note'));");

                    // Get the types of Config Statusses
                    refreshProgramSettings();

                    //Act upon the config settings


                    // Set the webpage to load on start
                    webBrowser.Url = new Uri(txtSettingWebPage.Text);

                    // Set up the thread for the clock
                    Thread threadTimeUpdater = new Thread(new ThreadStart(updateDateTime));
                    threadTimeUpdater.Priority = ThreadPriority.BelowNormal;
                    threadTimeUpdater.Start();

                    // Set up the thread to update the stats
                    Thread threadStatUpdater = new Thread(new ThreadStart(updateStats));
                    threadStatUpdater.Priority = ThreadPriority.Normal;
                    threadStatUpdater.Start();

                    // Show the Main Form
                    this.Show();
                }

                // Get rid of the login form
                frmLogin.Dispose();

            }
        }

        public void updateDateTime()
        {
            // Do this until requested to stop
            while (_shouldStop.Equals(false))
            {
                try
                {
                    // Get the datetime and put into lables
                    lblDate.Text = DateTime.Now.ToString();
                    // Wait for 1 second (*1000 due to taking ms)
                    System.Threading.Thread.Sleep(1 * 1000);
                }
                    // Catch the Error and show it in a txt box
                catch (System.Exception x){
                    MessageBox.Show(x.ToString());
                }

            }
        }

        //--------------------------------------------------------------
        //---------------------------Home Tab---------------------------
        //--------------------------------------------------------------

        private void rtbMyNotes_Leave(object sender, EventArgs e)
        {
            // When selection leaves the RTB then save its content
            Database.Update("Admins", "Note", rtbMyNotes.Text, "Login", Variables.username);
        }

        private void rtbSysNotes_Leave(object sender, EventArgs e)
        {
            // When selection leaves the RTB then save its content
            // Database.dbRequest("UPDATE Config SET Config.Data='" + rtbSysNotes.Text + "' WHERE Config.ID = 'note'");
            Settings.set("note", rtbSysNotes.Text);
        }

        private void btnChgPass_Click(object sender, EventArgs e)
        {
            // Load the change password dialog
            Form frmChangePass = new frmChangePass();
            frmChangePass.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Call the close Sub
            closeALL();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Call the close Sub
            closeALL();
            // Restarts the application
            Application.Restart(); 
        }

        private void btnLockSession_Click(object sender, EventArgs e)
        {
            // Disable the main form
            this.Enabled = false;

            addlog("SESSION", "Locked");

            // Start a new instance of the login form
            Form frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // If the result is good then get rid of the login form and unlock the main form
                frmLogin.Dispose();
                this.Enabled = true;
            }
            else
            {
                // get rid of the first login form
                frmLogin.Dispose();
                // lets try this again
                btnLockSession_Click(sender,e);
            }

        }

        private void pbStatusWeb_Click(object sender, EventArgs e)
        {
            // When clicked the internet tab will open
            tabMain.SelectedTab = tabInternet;
        }

        public void updateStats()
        {
            try
            {
                // Set Loading Images
                pbStatusDatabase.Image = Properties.Resources.loading;
                pbStatusProgram.Image = Properties.Resources.loading;
                pbStatusWeb.Image = Properties.Resources.loading;

                // Get some details
                System.IO.FileInfo fi = new System.IO.FileInfo(Application.ExecutablePath);
                DateTime buildDate = fi.LastWriteTime;

                // Add the details the labels in the form
                lblMeLoginDate.Text = lblMeLoginDate.Text.Replace("[datetime]", DateTime.Now.ToString());
                label13.Text = label13.Text.Replace("[machine]", Environment.machinename());
                label13.Text = label13.Text.Replace("[winuser]", Environment.winuser());
                label11.Text = label11.Text.Replace("[version]", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
                label12.Text = label12.Text.Replace("[builddate]", buildDate.ToString());
                lblMyNotes.Text = lblMyNotes.Text.Replace("[users]", Variables.username);
                lblMeUser.Text = lblMeUser.Text.Replace("[user]", Variables.username);

                // Program is running so say its all ok
                pbStatusProgram.Image = Properties.Resources.tick;

                // Get the database file
                FileInfo databaseFile = new FileInfo("Database.accdb");
                // If the file exists tick else cross
                if (databaseFile.Exists.Equals(true))
                {
                    pbStatusDatabase.Image = Properties.Resources.tick;
                }
                else
                {
                    pbStatusDatabase.Image = Properties.Resources.cross;
                }

                // Get the db Size and Convert the database size into kb
                long databaseSize = databaseFile.Length / 1000; 
                label5.Text = label5.Text.Replace("[size]", databaseSize.ToString());

                // Get the number of rows in the tables
                lblStatAdmins.Text = lblStatAdmins.Text.Replace("[count]", Database.RowCount("Admins").ToString());
                lblStatStudents.Text = lblStatStudents.Text.Replace("[count]", Database.RowCount("Students").ToString());
                lblStatSubjects.Text = lblStatSubjects.Text.Replace("[count]", Database.RowCount("Subjects").ToString());
                lblStatLogs.Text = lblStatLogs.Text.Replace("[count]", Database.RowCount("Log").ToString());

                // Set the number of tables
                lblStatAllTables.Text = lblStatAllTables.Text.Replace("[count]", "13");

                // Lets try this
                try
                {
                    // Get a new web REQUEST and RESPONSE
                    WebRequest request = WebRequest.Create(txtSettingWebPage.Text);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    // If the response is OK tick else cross
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        pbStatusWeb.Image = Properties.Resources.tick;
                    }
                    else
                    {
                        pbStatusWeb.Image = Properties.Resources.cross;
                    }
                }

                // If an exception is thrown presume the page is down
                catch (System.Exception)
                {
                    // Set the status image to X
                    pbStatusWeb.Image = Properties.Resources.cross;
                }

                // Add a log at end
                addlog("UPDATE", "Home Tab updated");
            }
                // If an exception is caught during the home page start when catch the error
            catch (System.Exception x) 
            {
                // Show the exception in a message box
                MessageBox.Show(x.ToString());
            }
        }

        private void listSessionLog_Click(object sender, EventArgs e)
        {
            //Load the log tab
            tabMain.SelectedIndex = 7;
        }

        //--------------------------------------------------------------
        //--------------------------ADMINS TAB--------------------------
        //--------------------------------------------------------------

        private void addadmincheck(object sender, EventArgs e)
        {
            // If everything has at least 1 char in and the passes match enable the button else disable
            if (txtAdminAddFirstName.Text.Length > 0 && txtAdminAddSecondName.Text.Length > 0 && txtAdminAddUsername.Text.Length > 0 &&
                txtAdminAddPassword1.Text.Length > 4 && txtAdminAddPassword2.Text.Length > 4 && txtAdminAddPassword1.Text.Equals(txtAdminAddPassword2.Text))
            {

                    btnAdminAdd.Enabled = true;
            }
            else
            {
                btnAdminAdd.Enabled = false;
            }

        }

        private void selectedadmincheck(object sender, EventArgs e)
        {
            // If everything has at least 1 char in and the passes match enable the buton else disable
            if (txtAdminSelectedFirstName.Text.Length > 0 && txtAdminSelectedSecondName.Text.Length > 0 && txtAdminSelectedUsername.Text.Length > 0 &&
    txtAdminSelectedPassword1.Text.Length > 0 && txtAdminSelectedPassword2.Text.Length > 0 && txtAdminSelectedPassword1.Text.Equals(txtAdminSelectedPassword2.Text))
            {

                btnAdminSave.Enabled = true;
            }
            else
            {
                btnAdminSave.Enabled = false;
            }

        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            // Add the new admin data into the table (We do it this way due to the password)
            adminsTableAdapter.Insert(txtAdminAddUsername.Text, Encryption.Encrypt(txtAdminAddPassword1.Text), txtAdminAddFirstName.Text, txtAdminAddSecondName.Text, DateTime.MinValue, DateTime.Now,"");
            // Update the dataset
            adminsTableAdapter.Fill(dsMain.Admins);

            addlog("ADMIN", "Created admin " + txtAdminAddUsername.Text);
        }

        private void btnHideAdmins_Click(object sender, EventArgs e)
        {
            // If the button displays "SHOW"
            if (btnHideAdmins.Text.Equals("Show Controls"))
            {
                // Show the controls
                panel2.Visible = true;
                // Change the button to show "HIDE"
                btnHideAdmins.Text = "Hide Controls";
                
            }
            // Else the button must display "HIDE"
            else
            {
                // Hide the controls
                panel2.Visible = false;
                // Change the button to shoe "SHOW"
                btnHideAdmins.Text = "Show Controls";
                
            }
        }

        private void btnAdminClear_Click(object sender, EventArgs e)
        {
            // Clear all of the textboxes
            txtAdminAddFirstName.Text = "";
            txtAdminAddSecondName.Text = "";
            txtAdminAddPassword1.Text = "";
            txtAdminAddPassword2.Text = "";
            txtAdminAddUsername.Text = "";
        }

        private void dgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvAdmins.CurrentRow != null)
            {
                // Get the current row number
                int currentrow = int.Parse(dgvAdmins.CurrentRow.Index.ToString());

                // If it exists then get the data from the row and add it to the text boxes
                txtAdminSelectedUsername.Text = dgvAdmins.Rows[currentrow].Cells[0].Value.ToString();
                txtAdminSelectedFirstName.Text = dgvAdmins.Rows[currentrow].Cells[2].Value.ToString();
                txtAdminSelectedSecondName.Text = dgvAdmins.Rows[currentrow].Cells[3].Value.ToString();
                // Set the two password text boxes to contain a useless string to keep the password safe
                txtAdminSelectedPassword1.Text = "**********";
                txtAdminSelectedPassword2.Text = "**********";
                // Enable the buttons so we can do stuff again
                btnAdminSave.Enabled = true;
                btnAdminDelete.Enabled = true;
            }
            else
            {
                // Clear the text boxes as nothing is selected
                txtAdminSelectedUsername.Text = "";
                txtAdminSelectedFirstName.Text = "";
                txtAdminSelectedSecondName.Text = "";
                txtAdminSelectedPassword1.Text = "";
                txtAdminSelectedPassword2.Text = "";
                // Disable the buttons so that nothing can be broken
                btnAdminSave.Enabled = false;
                btnAdminDelete.Enabled = false;
            }

        }

        private void btnAdminSave_Click(object sender, EventArgs e)
        {
            // If both passwords are the same
            if (txtAdminSelectedPassword1.Text == txtAdminSelectedPassword2.Text)
            {
                // Get the login from the text box
                string login = txtAdminSelectedUsername.Text;

                // Declare a string for our new password to be used
                string newpass;

                // If the password is still out hashed value
                if (txtAdminSelectedPassword1.Text == "**********")
                {
                    // Set the new password to the old one
                    newpass = dgvAdmins.Rows[int.Parse(dgvAdmins.CurrentRow.Index.ToString())].Cells[1].Value.ToString();
                }
                else
                {
                    // Set the new password to the new one
                    newpass = txtAdminSelectedPassword1.Text;
                    // Encrypt the new password
                    newpass = Encryption.Encrypt(newpass);
                }

                // Get the first and second name from the text boxes
                string firstname = txtAdminSelectedFirstName.Text;
                string secondname = txtAdminSelectedSecondName.Text;

                // Update all of the values of the record
                Database.RequestScalar("UPDATE Admins SET Admins.Password='" + newpass + "' WHERE Admins.Login = '" + login + "'");
                Database.RequestScalar("UPDATE Admins SET [Admins]![First Name]='" + firstname + "' WHERE Admins.Login = '" + login + "'");
                Database.RequestScalar("UPDATE Admins SET [Admins]![Second Name]='" + secondname + "' WHERE Admins.Login = '" + login + "'");

                // Refresh the dataset
                this.adminsTableAdapter.Fill(this.dsMain.Admins);

                addlog("ADMIN", "Updated admin " + login);

            }
            else
            {
                // Passwords dont match so show a message box saying so and reset them
                MessageBox.Show("Passwords do not match");
                // Reset the password textboxes to a string of useless stars
                txtAdminSelectedPassword1.Text = "**********";
                txtAdminSelectedPassword2.Text = "**********";
            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            // Get the name of the selected admin
            string login = txtAdminSelectedUsername.Text;
            // Delete the requested row
            Database.RequestScalar("DELETE * FROM Admins WHERE Admins.Login = '" + login + "'");
            // Refresh the dataset
            this.adminsTableAdapter.Fill(this.dsMain.Admins);

            addlog("ADMIN", "Deleted admin " + login);

        }

        //--------------------------------------------------------------
        //------------------------STUDENTS TAB--------------------------
        //--------------------------------------------------------------

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected student
                int id = int.Parse(dgvStudents.Rows[int.Parse(dgvStudents.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
                // Delete the requested row
                try
                {
                    Database.RequestScalar("DELETE * FROM Students WHERE [Students]![Student ID] = " + id.ToString());
                }
                catch
                {
                    MessageBox.Show("Please delete links to Students before deleting");
                }
                    // Refresh the dataset
                this.studentsTableAdapter.Fill(this.dsMain.Students);

                addlog("STUDENT", "Deleted student id " + id.ToString());
            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)//SaveSubject
        {
            if (dgvStudents.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected student
                int id = int.Parse(dgvStudents.Rows[int.Parse(dgvStudents.CurrentRow.Index.ToString())].Cells[0].Value.ToString());

                // Get the new data
                string year = txtStudentSelectedYear.Text;
                string[] name = txtStudentSelectedFullname.Text.Split(new char[] { ' ' }, 2); //Split the fullname

                // Update the database with new data
                Database.RequestScalar("UPDATE Students SET [Students]![First Name]='" + name[0].ToString() + "' WHERE [Students]![Student ID] = " + id.ToString());
                Database.RequestScalar("UPDATE Students SET [Students]![Second Name]='" + name[1].ToString() + "' WHERE [Students]![Student ID] = " + id.ToString());
                Database.RequestScalar("UPDATE Students SET [Students]![Year ID]='" + year + "' WHERE [Students]![Student ID] = " + id.ToString());

                // Refresh the dataset
                this.studentsTableAdapter.Fill(this.dsMain.Students);

                    addlog("STUDENT", "Updated student " + txtStudentSelectedFullname.Text);
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvStudents.CurrentRow != null)
            {
                // If the current row value exists then get it
                int currentrow = int.Parse(dgvStudents.CurrentRow.Index.ToString());
                // Use the current row to get the values needed
                txtStudentSelectedFullname.Text = dgvStudents.Rows[currentrow].Cells[1].Value.ToString() + " " + dgvStudents.Rows[currentrow].Cells[2].Value.ToString();
                txtStudentSelectedYear.Text = dgvStudents.Rows[currentrow].Cells[3].Value.ToString();
                //Enable the buttons so we can actually do stuff
                btnStudentDelete.Enabled = true;
                btnStudentSave.Enabled = true;
            }
            else
            {
                //Set the text boxes to blank
                txtStudentSelectedFullname.Text = "";
                txtStudentSelectedYear.Text = "";
                //Disable the buttons so we cant break anything
                btnStudentDelete.Enabled = false;
                btnStudentSave.Enabled = false;
            }
        }

        private void addstudentchanged(object sender, EventArgs e)
        {
            // If everything has at least 1 char in and the passes match enable the button else disable
            if (txtStudentAddFullname.Text.Length > 0 && txtStudentAddYear.Text.Length > 0)
            {

                btnStudentAdd.Enabled = true;
            }
            else
            {
                btnStudentAdd.Enabled = false;
            }
        }

        private void selectedstudentchanged(object sender, EventArgs e)
        {
            // If everything has at least 1 char in and the passes match enable the button else disable
            if (txtStudentSelectedFullname.Text.Length > 0 && txtStudentSelectedYear.Text.Length > 0)
            {

                btnStudentSave.Enabled = true;
            }
            else
            {
                btnStudentSave.Enabled = false;
            }
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentAddFullname.Text.Contains(" "))
            {

                // Split the fullname into a maximum of 2 substrings
                string[] name = txtStudentAddFullname.Text.Split(new char[] { ' ' }, 2);
                // Add the new data to the db
                studentsTableAdapter.Insert(name[0], name[1], DateTime.Now, int.Parse(txtStudentAddYear.Text), Variables.username);
                // Update the DataSet
                studentsTableAdapter.Fill(dsMain.Students);

                addlog("STUDENT", "Added student " + txtStudentAddFullname.Text);
            }
            else
            {
                MessageBox.Show("Only one name detected");
            }
            
        }

        private void btnHideStudents_Click(object sender, EventArgs e)
        {
            // If button displays "SHOW"
            if (btnHideStudents.Text.Equals("Show Controls"))
            {
                // Show the panel
                panel1.Visible = true;
                // Update the button text to HIDE
                btnHideStudents.Text = "Hide Controls";
                
            }
            // Else button must display "HIDE"
            else
            {
                // Hide the panel
                panel1.Visible = false;
                // Update the button text to SHOW
                btnHideStudents.Text = "Show Controls";
            }
        }

        private void btnStudentClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtStudentAddFullname.Text = "";
            txtStudentAddYear.Text = "";
        }

        //--------------------------------------------------------------
        //------------------------ATTRIBUTES TAB------------------------
        //--------------------------------------------------------------

        private void btnattributesSave_Click(object sender, EventArgs e)
        {
            // If everything has something sleected
            try
            {
                if (lbWho1.SelectedItem.ToString().Length != 0
                    && lbWhat1.SelectedItem.ToString().Length != 0
                    && lbWhat2.SelectedItem.ToString().Length != 0)
                {

                    // This is the students fullname
                    string selectedstudentdata = lbWho1.SelectedItem.ToString();
                    // Split this to get the id
                    string[] selectedstudentsplit = selectedstudentdata.Split(new char[] { '-' }, 2);
                    int studentid = int.Parse(selectedstudentsplit[0].Trim());

                    // Now to get the selected subject
                    int subjectid = int.Parse(lbWhat2.SelectedValue.ToString());

                    // Get the data / variable that the user picked
                    string data = lbWhat1.SelectedItem.ToString();

                    // Depending on which should be saved, save different stuff
                    if (rbCertificate.Checked)
                    {
                        // Get the type ID that was selected
                        string[] splitdata = data.Split(new char[] { ' ' }, 2);
                        int typeid = int.Parse(splitdata[0].ToString());

                        //Add it to the DB
                        this.certificatesTableAdapter.Insert(studentid, typeid, Variables.username, subjectid);
                        addlog("AWARD", "Added certificate award; " + studentid.ToString() + typeid.ToString() + subjectid.ToString());

                        MessageBox.Show("Award Given");

                        //Refresh
                        this.certificatesTableAdapter.Fill(this.dsMain.Certificates);

                    }
                    else if (rbCommendation.Checked)
                    {
                        // Get the type ID that was selected
                        string[] splitdata = data.Split(new char[] { ' ' }, 2);
                        int typeid = int.Parse(splitdata[0].ToString());

                        //Add it to the DB
                        this.commendationsTableAdapter.Insert(studentid, typeid, Variables.username, subjectid);
                        addlog("AWARD", "Added commendation award; " + studentid.ToString() + typeid.ToString() + subjectid.ToString());

                        MessageBox.Show("Award Given");

                        //Refresh
                        this.commendationsTableAdapter.Fill(this.dsMain.Commendations);
                    }
                    else if (rbEffort.Checked)
                    {
                        // Trim down the effort a bit more to just get the int
                        string[] spliteffort = data.Split(new char[] { ' ' }, 2);
                        int effortvalue = int.Parse(spliteffort[1].ToString());

                        // Add to DB
                        this.effort_GradesTableAdapter.Insert(studentid, effortvalue, subjectid, Variables.username);
                        addlog("AWARD", "Added effort award; " + studentid.ToString() + effortvalue.ToString() + subjectid.ToString());

                        MessageBox.Show("Award Given");

                        // Refresh
                        this.effort_GradesTableAdapter.Fill(this.dsMain.Effort_Grades);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong...");
                    }
                }
                else
                {
                    MessageBox.Show("Something was not selected");
                }
            }
            catch
            {
                MessageBox.Show("Something was not selected");
            }

        }

        private void WhatAttributesChanged(object sender, EventArgs e)
        {

            // Clear the current items
            lbWhat1.Items.Clear();

            // Do Something depending upon what is selected
            if (rbCertificate.Checked)
            {
                // Get all of the stuff we need
                Queue ids = Database.Select("Cert Types", "Cert ID");
                Queue names = Database.Select("Cert Types", "Cert Name");
                Queue descs = Database.Select("Cert Types", "Description");

                // For each of the items fetched add it to the UI
                for (int i = 0; ids.Count > 0; i++)
                {
                    lbWhat1.Items.Add(ids.Dequeue().ToString() + " - " + names.Dequeue() + " - " + descs.Dequeue());
                }

            }
            else if (rbCommendation.Checked)
            {
                // Get all of the stuff we need
                Queue ids = Database.Select("Commendation Types", "Type ID");
                Queue names = Database.Select("Commendation Types", "Type Name");
                Queue descs = Database.Select("Commendation Types", "Description");

                // For each of the items fetched add it to the UI
                for (int i = 0; ids.Count > 0; i++)
                {
                    lbWhat1.Items.Add(ids.Dequeue().ToString() + " - " + names.Dequeue() + " - " + descs.Dequeue());
                }

            }
            else if (rbEffort.Checked)
            {
                    lbWhat1.Items.Add("Grade 1");
                    lbWhat1.Items.Add("Grade 2");
                    lbWhat1.Items.Add("Grade 3");
                    lbWhat1.Items.Add("Grade 4");

            }
            else
            {
                // If nothing is selected then remove everything from the lb
                lbWhat1.Items.Clear();
            }
        }

        private void cbWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO if change from year 9 to year 7 it unselects all the people and errors
            try
            {
            if (cbWho.Items.Count != 0)
            {

                    // Get the year IF of the yeargroup currently selected
                    int yearid = int.Parse(cbWho.SelectedValue.ToString());
                    // Get the fullname of all matched students
                    Queue ids = Database.Select("Students", "Student ID", "Year ID", yearid, true);
                    Queue firstnames = Database.Select("Students", "First Name", "Year ID", yearid, true);
                    Queue secondnames = Database.Select("Students", "Second Name", "Year ID", yearid, true);

                    // Clear what is currently in the list box
                    lbWho1.Items.Clear();

                    // For each of the students returned put it in the array
                    for (int i = 0; firstnames.Count > 0; i++)
                    {
                        lbWho1.Items.Add(ids.Dequeue() + " - " + firstnames.Dequeue() + " " + secondnames.Dequeue());
                    }
                }
            }
            catch
            {
                throw;
            }

        }

        private void btnattributesClear_Click(object sender, EventArgs e)
        {
            // Clear all of the values to their default
            cbWho.SelectedIndex = 0;
            rbCertificate.Checked = true;
            // Everything else will clear by itself after these have been set
        }

        private void rbCertificate_CheckedChanged(object sender, EventArgs e)
        {
            // When the selection is changed update the other RB buttons
            attributesRBCheck();
        }

        private void rbCommendation_CheckedChanged(object sender, EventArgs e)
        {
            // When the selection is changed update the other RB buttons
            attributesRBCheck();
        }

        private void rbEffort_CheckedChanged(object sender, EventArgs e)
        {
            // When the selection is changed update the other RB buttons
            attributesRBCheck();
        }

        private void attributesRBCheck()
        {
            // Check all of the RBs. If one is selected then unselect the other two
            if (rbCertificate.Checked == true)
            {
                rbCommendation.Checked = false;
                rbEffort.Checked = false;
            }
            if (rbCommendation.Checked == true)
            {
                rbEffort.Checked = false;
                rbCertificate.Checked = false;
            }
            if (rbEffort.Checked == true)
            {
                rbCommendation.Checked = false;
                rbCertificate.Checked = false;
            }
        }

        //--------------------------------------------------------------
        //----------------------------LOG TAB---------------------------
        //--------------------------------------------------------------

        private void addlog(string type, string desc)
        {
            // Insert the relevant log
            logTableAdapter.Insert(Environment.logstamp(), Variables.username, type, desc);
            // Update the dataset
            logTableAdapter.Fill(dsMain.Log);
            // Also add this log line to our session log in the home tab
            listSessionLog.Items.Add(desc);

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {

            // Delete everything from the log table
            Database.RequestScalar("DELETE * FROM Log");
            // Add a log saying what has happened
            addlog("CLEAR", "Program log cleared");
        }

        private void dgvLog_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // If the number of rows in the gdv changes update the relevant lables
            lblDisplaying.Text = "Displaying " + dgvLog.RowCount + " entries";
            lblStatLogs.Text = "Currently " + dgvLog.RowCount + " log entries";
        }

        private void btnExternalBrowser_Click(object sender, EventArgs e)
        {
            // Try to...
            try
            {
                // Start a new web browser using the current URL
                System.Diagnostics.Process.Start(webBrowser.Url.ToString());
            }
                // Catch the NO BROWSER exception
            catch(System.ComponentModel.Win32Exception noBrowser)
            {
                // If the code is correct
                if (noBrowser.ErrorCode == -2147467259)
                    // Display a message box saying the message
                    MessageBox.Show(noBrowser.Message);
            }
                // Catch all other exceptions
            catch (System.Exception other)
            {
                // Display them in a message box
                MessageBox.Show(other.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            // Get the current date
            DateTime date = DateTime.Now;
            // Set the filename using the date
            string filename = "ExportedLog-"+date.ToString("yyyy.MM.dd.HH.mm")+".csv";

            // Start our writer using the filename
            System.IO.StreamWriter writer = new System.IO.StreamWriter(filename);

            // For every row
            for (int i = 0; i < dgvLog.Rows.Count; i++)
            {
                //Reset the strRow to ""
                string strRow = "";

                // For every cell
                for (int j = 0; j < dgvLog.Rows[i].Cells.Count; j++)
                {
                    //If the strROW has no value
                    if (strRow == "")
                    {
                        //Get the value of the cell and set it to strRow
                        strRow = dgvLog.Rows[i].Cells[j].Value.ToString();
                    }
                        // Else
                    else
                    {
                        // Append the row the strRow (The Previous Cell)
                        strRow = strRow + "," + dgvLog.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // Write the line
                writer.WriteLine(strRow);
            }
            // Close the Writer
            writer.Close();

            // Add a log saying what has happened and show a message box
            addlog("EXPORT", "Log Exported to " + filename);
            MessageBox.Show("Log Exported to "+filename);
        }

        //--------------------------------------------------------------
        //--------------------------CONFIG TAB--------------------------
        //--------------------------------------------------------------
        
        private void refreshProgramSettings()
        {
            // Get all of the settings on the page Re Get them from the DB
            txtSettingWebPage.Text = Settings.get("raleghWebPage");
        }

        private void btnSettingsRevert_Click(object sender, EventArgs e)
        {
            // Call the refresh from DB
            refreshProgramSettings();

            // Show a message box saying this has happened
            addlog("REVERT", "Program Settings Reverted");
            MessageBox.Show("Program Settings Reverted");
        }

        private void btnSettingsApply_Click(object sender, EventArgs e)
        {
            // Set all of the settings into the DB
            Settings.set("raleghWebPage", txtSettingWebPage.Text);

            // Show a message box saying this has happened
            addlog("SAVE", "Program Settings saved");
            MessageBox.Show("Settings may not take affect until you restart the application");

            // Lets update the progrm now
            refreshProgramSettings();
        }

        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            // Fill the form with the default hard coded values
            txtSettingWebPage.Text = "";
        }

        private void refreshAppearanceSettings()
        {
            //Get the appernace settings from the DB
            chkAppClock.Checked = bool.Parse(Settings.get("chkAppClock"));
            chkAppLog.Checked = bool.Parse(Settings.get("chkAppLog"));
            chkAppWeb.Checked = bool.Parse(Settings.get("chkAppWeb"));

            //Check the clock
            if (chkAppClock.Checked == true)
            {
                lblDate.Visible = true;
            }
            else
            {
                lblDate.Visible = false;
            }

            //Check the log
            if (chkAppLog.Checked == true)
            {
                tabMain.TabPages.Add(tabLog);
                listSessionLog.Visible = true;
            }
            else
            {
                
                tabMain.TabPages.Remove(tabLog);
                listSessionLog.Visible = false;
            }

            //Check the web
            if (chkAppWeb.Checked == true)
            {
                tabMain.TabPages.Add(tabInternet);
            }
            else
            {
                tabMain.TabPages.Remove(tabInternet);

            }
        }

        private void btnApperanceApply_Click(object sender, EventArgs e)
        {
            //Set the apperance settings to the DB
            Settings.set("chkAppClock", chkAppClock.Checked.ToString());
            Settings.set("chkAppLog", chkAppLog.Checked.ToString());
            Settings.set("chkAppWeb", chkAppWeb.Checked.ToString());

            //Add an event to the log saying what has happened
            MessageBox.Show("Apperance Settings Saved");
            addlog("SAVE", "Apperance Settings Saved");

            //Lets update the GUI now
            refreshAppearanceSettings();
        }

        private void btnApperanceRevert_Click(object sender, EventArgs e)
        {
            // Call the refresh from DB
            refreshAppearanceSettings();

            // Show a message box saying this has happened
            MessageBox.Show("Apperance Settings Reverted");
            addlog("REVERT", "Program settings reverted");
        }

        private void btnDefaultApperance_Click(object sender, EventArgs e)
        {


            // Fill the form with the default hard coded values
            chkAppClock.Checked = true;
            chkAppLog.Checked = true;
            chkAppWeb.Checked = true;
        }

        //--------------------------------------------------------------
        //----------------------------CAT TAB---------------------------
        //--------------------------------------------------------------

        private void btnSubjectAdd_Click(object sender, EventArgs e)
        {
            // Insert the the data
            subjectsTableAdapter.Insert(txtSubjectNew.Text, DateTime.Now);
            // Update the dataset
            subjectsTableAdapter.Fill(dsMain.Subjects);

            addlog("SUBJECT", "Added subject " + txtSubjectNew.Text);

        }

        private void btnSubjectClear_Click(object sender, EventArgs e)
        {
            //Clear the 'new' subject text box
            txtSubjectNew.Text = "";
        }

        private void btnSubjectSave_Click(object sender, EventArgs e)
        {

            if (dgvSubjects.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected subject
                int id = int.Parse(dgvSubjects.Rows[int.Parse(dgvSubjects.CurrentRow.Index.ToString())].Cells[0].Value.ToString());

                // Get the new data
                string newname = txtSubjectSelected.Text.ToString();

                // Update the database with new data
                Database.Update("Subjects", "Subject Name", newname, "Subject ID", id);

                // Refresh the dataset
                this.subjectsTableAdapter.Fill(this.dsMain.Subjects);

                addlog("SUBJECT", "Updated subject " + newname);
            }
        }

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            //Get the subject name
            string subjname = txtSubjectSelected.Text.ToString();
            // Delete the requested row
            try
            {
                Database.Delete("Subjects", "Subject Name", subjname);
            }
            catch
            {
                MessageBox.Show("Please delete links to Subjects before deleting");
            }
            // Refresh the dataset
            this.subjectsTableAdapter.Fill(this.dsMain.Subjects);

            addlog("SUBJECT", "Deleted subject " + subjname);

        }

        private void btnYearAdd_Click(object sender, EventArgs e)
        {
            // Insert the the data
            year_GroupsTableAdapter.Insert(txtYearNew.Text);
            // Update the dataset
            year_GroupsTableAdapter.Fill(dsMain.Year_Groups);

            addlog("YEAR", "Added year " + txtYearNew.Text);
        }

        private void btnYearClear_Click(object sender, EventArgs e)
        {
            //Clear the 'new' year text box
            txtYearNew.Text = "";
        }

        private void btnYearSave_Click(object sender, EventArgs e)
        {

            if (dgvYears.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected subject
                int id = int.Parse(dgvYears.Rows[int.Parse(dgvYears.CurrentRow.Index.ToString())].Cells[0].Value.ToString());

                // Get the new data
                string newname = txtYearSelected.Text.ToString();

                // Update the database with new data
                Database.Update("Year Groups", "Year Name", newname, "Year ID", id);

                // Refresh the dataset
                this.year_GroupsTableAdapter.Fill(this.dsMain.Year_Groups);

                addlog("YEAR", "Updated year " + newname);
            }

        }

        private void btnYearDelete_Click(object sender, EventArgs e)
        {
            //Get the year name
            string yearname = txtYearSelected.Text.ToString();
            // Delete the requested row
            try
            {
                Database.Delete("Year Groups", "Year Name", yearname);
            }
            catch
            {
                MessageBox.Show("Please delete links to Year Groups before deleting");
            }
            // Refresh the dataset
            this.year_GroupsTableAdapter.Fill(this.dsMain.Year_Groups);

            addlog("YEAR", "Deleted year " + yearname);
        }

        private void txtYearNew_TextChanged(object sender, EventArgs e)
        {
            //If the txt box has nothing in it dont allow it to be added, else do
            if (txtYearNew.Text.Length == 0)
            {
                btnYearAdd.Enabled = false;
                btnYearClear.Enabled = false;
            }
            else
            {
                btnYearAdd.Enabled = true;
                btnYearClear.Enabled = true;
            }

        }

        private void txtSubjectNew_TextChanged(object sender, EventArgs e)
        {
            //If the txt box has nothing in it dont allow it to be added, else do
            if (txtSubjectNew.Text.Length == 0)
            {
                btnSubjectAdd.Enabled = false;
                btnSubjectClear.Enabled = false;
            }
            else
            {
                btnSubjectAdd.Enabled = true;
                btnSubjectClear.Enabled = true;
            }
        }

        private void dgvYears_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvYears.CurrentRow != null)
            {
                // Get the current row number
                int currentrow = int.Parse(dgvYears.CurrentRow.Index.ToString());

                // If it exists then get the data from the row and add it to the text boxes
                txtYearSelected.Text = dgvYears.Rows[currentrow].Cells[1].Value.ToString();
                // Enable the buttons so we can do stuff again
                btnYearSave.Enabled = true;
                btnYearDelete.Enabled = true;
            }
            else
            {
                // Clear the text boxes as nothing is selected
                txtYearSelected.Text = "";
                // Disable the buttons so that nothing can be broken
                btnYearSave.Enabled = false;
                btnYearDelete.Enabled = false;
            }
        }

        private void dgvSubjects_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvSubjects.CurrentRow != null)
            {
                // Get the current row number
                int currentrow = int.Parse(dgvSubjects.CurrentRow.Index.ToString());

                // If it exists then get the data from the row and add it to the text boxes
                txtSubjectSelected.Text = dgvSubjects.Rows[currentrow].Cells[1].Value.ToString();
                // Enable the buttons so we can do stuff again
                btnSubjectSave.Enabled = true;
                btnSubjectDelete.Enabled = true;
            }
            else
            {
                // Clear the text boxes as nothing is selected
                txtSubjectSelected.Text = "";
                // Disable the buttons so that nothing can be broken
                btnSubjectSave.Enabled = false;
                btnSubjectDelete.Enabled = false;
            }
        }

        private void txtYearSelected_TextChanged(object sender, EventArgs e)
        {
            //If the Selected txt box has no data in it then dont let the user save it
            if (txtYearSelected.Text.Length == 0)
            {
                btnYearDelete.Enabled = false;
                btnYearSave.Enabled = false;
            }
        }

        private void txtSubjectSelected_TextChanged(object sender, EventArgs e)
        {
            //If the Selected txt box has no data in it then dont let the user save it
            if (txtSubjectSelected.Text.Length == 0)
            {
                btnSubjectDelete.Enabled = false;
                btnSubjectSave.Enabled = false;
            }
        }

        //--------------------------------------------------------------
        //--------------------------AWARDS TAB--------------------------
        //--------------------------------------------------------------

        private void btnCommendationAdd_Click(object sender, EventArgs e)
        {
            // Insert the the data
            commendation_TypesTableAdapter.Insert(txtCommendationNewName.Text,txtCommendationNewDesc.Text);
            // Update the dataset
            commendation_TypesTableAdapter.Fill(dsMain.Commendation_Types);

            addlog("TYPE", "Added commendation type " + txtCommendationNewName.Text);
        }

        private void btnCommendationClear_Click(object sender, EventArgs e)
        {
            //Clear all of the relevant txt boxes
            txtCommendationNewName.Text = "";
            txtCommendationNewDesc.Text = "";
        }

        private void btnCommendationSave_Click(object sender, EventArgs e)
        {

            if (dgvCommendations.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected subject
                int id = int.Parse(dgvCommendations.Rows[int.Parse(dgvCommendations.CurrentRow.Index.ToString())].Cells[0].Value.ToString());

                // Get the new data
                string newname = txtCommendationSelectedName.Text.ToString();
                string newdesc = txtCommendationSelectedDesc.Text.ToString();

                // Update the database with new data
                Database.Update("Commendation Types", "Type Name", newname, "Type ID", id);
                Database.Update("Commendation Types", "Description", newdesc, "Type ID", id);

                // Refresh the dataset
                this.commendation_TypesTableAdapter.Fill(this.dsMain.Commendation_Types);

                addlog("TYPE", "Updated commendation type " + txtCommendationSelectedName.Text.ToString());
            }

        }

        private void btnCommendationDelete_Click(object sender, EventArgs e)
        {
            //Delete the selected commendation type
            try
            {
                Database.Delete("Commendation Types", "Type Name", txtCommendationSelectedName.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Please delete links to Commendation Types before deleting");
            }
            //refresh the dataset
            this.commendation_TypesTableAdapter.Fill(this.dsMain.Commendation_Types);

            addlog("TYPE", "Deleted commendation type " + txtCommendationSelectedName.Text.ToString());
        }

        private void CommendationNewTxtChanged(object sender, EventArgs e)
        {
            //If there is nothing in either of the txt boxes diable the buttons to stop things from breaking
            //Else enable them
            if (txtCommendationNewName.Text.Length.Equals(0) || txtCommendationNewDesc.Text.Length.Equals(0))
            {
                btnCommendationClear.Enabled = false;
                btnCommendationAdd.Enabled = false;
            }
            else
            {
                btnCommendationClear.Enabled = true;
                btnCommendationAdd.Enabled = true;
            }

        }

        private void CommendationSelectedTxtChanged(object sender, EventArgs e)
        {
            //If there is nothing in either of the txt boxes diable the buttons to stop things from breaking
            if (txtCommendationSelectedName.Text.Length.Equals(0) || txtCommendationSelectedDesc.Text.Length.Equals(0))
            {
                btnCommendationDelete.Enabled = false;
                btnCommendationSave.Enabled = false;
            }
        }
        
        private void dgvCommendations_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvCommendations.CurrentRow != null)
            {
                // Get the current row number
                int currentrow = int.Parse(dgvCommendations.CurrentRow.Index.ToString());

                // If it exists then get the data from the row and add it to the text boxes
                txtCommendationSelectedName.Text = dgvCommendations.Rows[currentrow].Cells[1].Value.ToString();
                txtCommendationSelectedDesc.Text = dgvCommendations.Rows[currentrow].Cells[2].Value.ToString();
                // Enable the buttons so we can do stuff again
                btnCommendationSave.Enabled = true;
                btnCommendationDelete.Enabled = true;
            }
            else
            {
                // Clear the text boxes as nothing is selected
                txtCommendationSelectedName.Text = "";
                txtCommendationSelectedDesc.Text = "";
                // Disable the buttons so that nothing can be broken
                btnCommendationSave.Enabled = false;
                btnCommendationDelete.Enabled = false;
            }

        }

        private void btnCertificateAdd_Click(object sender, EventArgs e)
        {
            // Insert the the data
            certificate_TypesTableAdapter.Insert(txtCertificateNewName.Text, txtCertificateNewDesc.Text);
            // Update the dataset
            certificate_TypesTableAdapter.Fill(dsMain.Certificate_Types);

            addlog("TYPE", "Added certificate type " + txtCertificateNewName.Text);

        }

        private void btnCertificateClear_Click(object sender, EventArgs e)
        {
            //Clear all of the relevant txt boxes
            txtCertificateNewName.Text = "";
            txtCertificateNewDesc.Text = "";
        }

        private void btnCertificateSave_Click(object sender, EventArgs e)
        {

            if (dgvCertificates.CurrentRow != null)//Make sure the value of the selected row exists
            {
                // Get the id of the current selected subject
                int id = int.Parse(dgvCertificates.Rows[int.Parse(dgvCertificates.CurrentRow.Index.ToString())].Cells[0].Value.ToString());

                // Get the new data
                string newname = txtCertificateSelectedName.Text.ToString();
                string newdesc = txtCertificateSelectedDesc.Text.ToString();

                // Update the database with new data
                Database.Update("Cert Types", "Cert Name", newname, "Cert ID", id);
                Database.Update("Cert Types", "Description", newdesc, "Cert ID", id);

                // Refresh the dataset
                this.certificate_TypesTableAdapter.Fill(this.dsMain.Certificate_Types);

                addlog("TYPE", "Updated certificate type " + txtCertificateSelectedName.Text.ToString());
            }

        }

        private void btnCertificateDelete_Click(object sender, EventArgs e)
        {
            //Delete the selected certificate type
            try
            {
                Database.Delete("Cert Types", "Cert Name", txtCertificateSelectedName.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Please delete links to Certificate Types before deleting");
            }

            // Refresh the dataset
            this.certificate_TypesTableAdapter.Fill(this.dsMain.Certificate_Types);

            addlog("TYPE", "Deleted certificate type " + txtCertificateSelectedName.Text.ToString());
        }

        private void CertificateNewTxtChanged(object sender, EventArgs e)
        {
            //If there is nothing in either of the txt boxes diable the buttons to stop things from breaking
            //Else enable them
            if (txtCertificateNewName.Text.Length.Equals(0) || txtCertificateNewDesc.Text.Length.Equals(0))
            {
                btnCertificateClear.Enabled = false;
                btnCertificateAdd.Enabled = false;
            }
            else
            {
                btnCertificateClear.Enabled = true;
                btnCertificateAdd.Enabled = true;
            }

        }

        private void CertificateSelectedTxtChanged(object sender, EventArgs e)
        {
            //If there is nothing in either of the txt boxes diable the buttons to stop things from breaking
            if (txtCertificateSelectedName.Text.Length.Equals(0) || txtCertificateSelectedDesc.Text.Length.Equals(0))
            {
                btnCertificateDelete.Enabled = false;
                btnCertificateSave.Enabled = false;
            }
        }

        private void dgvCertificates_SelectionChanged(object sender, EventArgs e)
        {
            // Make sure the value of the selected row exists
            if (dgvCertificates.CurrentRow != null)
            {
                // Get the current row number
                int currentrow = int.Parse(dgvCertificates.CurrentRow.Index.ToString());

                // If it exists then get the data from the row and add it to the text boxes
                txtCertificateSelectedName.Text = dgvCertificates.Rows[currentrow].Cells[1].Value.ToString();
                txtCertificateSelectedDesc.Text = dgvCertificates.Rows[currentrow].Cells[2].Value.ToString();
                // Enable the buttons so we can do stuff again
                btnCertificateSave.Enabled = true;
                btnCertificateDelete.Enabled = true;
            }
            else
            {
                // Clear the text boxes as nothing is selected
                txtCertificateSelectedName.Text = "";
                txtCertificateSelectedDesc.Text = "";
                // Disable the buttons so that nothing can be broken
                btnCertificateSave.Enabled = false;
                btnCertificateDelete.Enabled = false;
            }
        }

        //--------------------------------------------------------------
        //--------------------------REPORTS TAB-------------------------
        //--------------------------------------------------------------

        private void btnReportsRemove_Click(object sender, EventArgs e)
        {

            //Get the currently selected data and then the id from it
            string data = lbReports.SelectedItem.ToString();
            string[] splitdata = data.Split(new char[] { '-' }, 2);
            int id = int.Parse(splitdata[0].Trim().ToString());


            // Depending on is selected, different stuff should be done
            if (rbReportsCertificate.Checked)
            {
                //Delete the selected ID
                try
                {
                    Database.Delete("Certificates", "Certificate ID", id);
                }
                catch
                {
                    MessageBox.Show("Unknown error when trying to delete record");
                }

                //Refresh the Data Set
                this.certificatesTableAdapter.Fill(this.dsMain.Certificates);
            }
            else if (rbReportsCommendation.Checked)
            {
                //Delete the selected ID
                try
                {
                    Database.Delete("Commendations", "Commendation ID", id);
                }
                catch
                {
                    MessageBox.Show("Unknown error when trying to delete record");
                }

                //Refresh the Data Set
                this.commendationsTableAdapter.Fill(this.dsMain.Commendations);
            }
            else if (rbReportsEffort.Checked)
            {
                //Delete the selected ID
                try
                {
                    Database.Delete("Effort Grades", "Effort Grade ID", id);
                }
                catch
                {
                    MessageBox.Show("Unknown error when trying to delete record");
                }

                //Refresh the Data Set
                this.effort_GradesTableAdapter.Fill(this.dsMain.Effort_Grades);
            }
            else
            {
            }

            //Add a log saying what has happened
            addlog("AWARD", "Delete award with id = " + id.ToString());

            //Lets refresh the list box
            ReportVariablesChanged(sender, e);

        }

        private void cbReportsWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the list box
            lbReports.Items.Clear();

            if (cbReportsWho.Items.Count != 0)
            {
                // Get the year IF of the yeargroup currently selected
                int yearid = int.Parse(cbReportsWho.SelectedValue.ToString());
                // Get the fullname of all matched students
                Queue ids = Database.Select("Students", "Student ID", "Year ID", yearid, true);
                Queue firstnames = Database.Select("Students", "First Name", "Year ID", yearid, true);
                Queue secondnames = Database.Select("Students", "Second Name", "Year ID", yearid, true);

                // Clear what is currently in the list box
                lbReportsWho.Items.Clear();

                // For each of the students returned put it in the array
                for (int i = 0; firstnames.Count > 0; i++)
                {
                    lbReportsWho.Items.Add(ids.Dequeue() + " - " + firstnames.Dequeue() + " " + secondnames.Dequeue());
                }

            }
        }

        private void ReportVariablesChanged(object sender, EventArgs e)
        {

            // Clear the list box
            lbReports.Items.Clear();

            // This is the students fullname
            string selectedstudentdata = lbReportsWho.SelectedItem.ToString();
            // Split this to get the id
            string[] selectedstudentsplit = selectedstudentdata.Split(new char[] { '-' }, 2);
            int studentid = int.Parse(selectedstudentsplit[0].Trim());


            // Depending on which should be saved, save different stuff
            if (rbReportsCertificate.Checked)
            {
                //TODO fix get on no data
                //Get all of the cert types and IDs and subject
                Queue certtypes = Database.Select("Certificates", "Cert Type", "Student ID", studentid, true);
                Queue certids = Database.Select("Certificates", "Certificate ID", "Student ID", studentid, true);
                Queue subjects = Database.Select("Certificates", "Subject ID", "Student ID", studentid, true);

                // For each of the things in the queue
                for (int i = 0; certids.Count > 0; i++)
                {
                    // Get the bits of data we actually need
                    int tempcerttype = int.Parse(certtypes.Dequeue().ToString());
                    int tempsubjectid = int.Parse(subjects.Dequeue().ToString());
                    int tempcertid = int.Parse(certids.Dequeue().ToString());

                    string tempcertname = Database.Select("Cert Types", "Cert Name", "Cert ID", tempcerttype);
                    string tempcertdesc = Database.Select("Cert Types", "Description", "Cert ID", tempcerttype);
                    string tempsubject = Database.Select("Subjects", "Subject Name", "Subject ID", tempsubjectid);

                    //Add each one to the listbox
                    lbReports.Items.Add(tempcertid.ToString() + " - " + tempsubject + " " + tempcertname + " - " + tempcertdesc);
                }

            }
            else if (rbReportsCommendation.Checked)
            {

                //TODO fix get on no data
                //Get all of the commendation types and IDs and subject
                Queue commtypes = Database.Select("Commendations", "Commendation Type", "Student ID", studentid, true);
                Queue commids = Database.Select("Commendations", "Commendation ID", "Student ID", studentid, true);
                Queue subjects = Database.Select("Commendations", "Subject ID", "Student ID", studentid, true);

                // For each of the things in the queue
                for (int i = 0; commids.Count > 0; i++)
                {
                    // Get the bits of data we actually need
                    int tempcommtype = int.Parse(commtypes.Dequeue().ToString());
                    int tempsubjectid = int.Parse(subjects.Dequeue().ToString());
                    int tempcommid = int.Parse(commids.Dequeue().ToString());

                    string tempcommname = Database.Select("Commendation Types", "Type Name", "Type ID", tempcommtype);
                    string tempcommdesc = Database.Select("Commendation Types", "Description", "Type ID", tempcommtype);
                    string tempsubject = Database.Select("Subjects", "Subject Name", "Subject ID", tempsubjectid);

                    //Add each one to the listbox
                    lbReports.Items.Add(tempcommid.ToString() + " - " + tempsubject + " " + tempcommname + " - " + tempcommdesc);
                }

            }
            else if (rbReportsEffort.Checked)
            {

                //TODO fix get on no data
                //Get all of the effort values and IDs and subject
                Queue effortvalues = Database.Select("Effort Grades", "Effort Value", "Student ID", studentid, true);
                Queue effortids = Database.Select("Effort Grades", "Effort Grade ID", "Student ID", studentid, true);
                Queue subjects = Database.Select("Effort Grades", "Subject ID", "Student ID", studentid, true);

                // For each of the things in the queue
                for (int i = 0; effortids.Count > 0; i++)
                {
                    // Get the bits of data we actually need
                    int tempeffortvalue = int.Parse(effortvalues.Dequeue().ToString());
                    int tempsubjectid = int.Parse(subjects.Dequeue().ToString());
                    int tempeffortid = int.Parse(effortids.Dequeue().ToString());

                    string tempsubject = Database.Select("Subjects", "Subject Name", "Subject ID", tempsubjectid);

                    //Add each one to the listbox
                    lbReports.Items.Add(tempeffortid.ToString() + " - " + tempsubject + " " + "Effort Grade " + " " + tempeffortvalue.ToString());
                }

            }
            else
            {
                lbReports.Items.Clear();
            }

            //Update the label shoing how many items there currently are
            lblReportCount.Text = "Total " + lbReports.Items.Count.ToString() + "entires";

            }

        private void btnReportPrintStudent_Click(object sender, EventArgs e)
        {
            // Get the current date
            DateTime date = DateTime.Now;
            // Set the filename using the date
            string filename = "ExportedReport-" + date.ToString("yyyy.MM.dd.HH.mm") + ".txt";

            // Create a writer and open the new file
            TextWriter tw = new StreamWriter(filename);

            // For each line in the listbox
            foreach(string line in lbReports.Items)
            {
                // Write that line to the file
                tw.WriteLine(line);
            }

            // Close the file
            tw.Close();

            // Add a log saying what has happened and show a message box
            addlog("EXPORT", "Report Exported to " + filename);
            MessageBox.Show("Report Exported to " + filename);
        }

        private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    //-----------------------------------------------------------------------------------------------------------
    //--CLASSES--------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------

    public class Variables
    {
        // Define the global variables
        /// <summary>
        /// This is the currently logged in admin username
        /// </summary>
        public static string username; 
        /// <summary>
        /// Connection string to the database
        /// </summary>
        public static string connectionstring = Properties.Settings.Default.dcData.ToString();
        // Webpage to load
        public static string webpageurl; 
    }

    public class Encryption
    {

        /// <summary>
        /// Encrypt the origional string with an MD5 Hash
        /// </summary>
        /// <param name="origional"></param>
        /// <returns></returns>
        public static string Encrypt(string original)
        {
            // Get new MD5 Cryptography provider
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            // Get the origional data as a byte array data[]
            byte[] data = System.Text.Encoding.UTF8.GetBytes(original);
            // Hash the byte array data[] into the byte array crypto[]
            byte[] crypto = x.ComputeHash(data);
            // Convert the byte array crypto[] into a string md5hash
            // string md5Hash = System.Text.Encoding.UTF8.GetString(crypto);
            string md5hash = Convert.ToBase64String(crypto).Trim();
            // Return the value
            return md5hash;

        }
    }

    public class Environment
    {

        /// <summary>
        /// Get the currently logged in windows user
        /// </summary>
        /// <returns></returns>
        public static string winuser()
        {
            // Return the current logged in windows username
            return System.Environment.UserName.ToString();
        }

        /// <summary>
        /// Get the current machine name
        /// </summary>
        /// <returns></returns>
        public static string machinename()
        {
            // Return the current computer name
            return System.Environment.MachineName.ToString();
        }

        /// <summary>
        /// Get a formated date time stamp of the current date
        /// </summary>
        /// <returns></returns>
        public static string logstamp()
        {
            // Get the current date
            DateTime d = DateTime.Now;
            // Return it in a format we want to use for the STAMP
            return d.ToString("yyyyMMdd-HHmmss.fff");
        }

    }

    public class Database
    {

        /// <summary>
        /// Send an OLEDB request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static object RequestScalar(string request)
        {
            // Get a new OLEDB connection oCon using the global connectionstring
            OleDbConnection oCon = new OleDbConnection(Variables.connectionstring);
            // Open oCon for use
            oCon.Open();
            // Get a new OLEDB command cmd using the given request and connection oCon
            OleDbCommand cmd = new OleDbCommand(request, oCon);

            // Read obj as the scalar response
            object obj = cmd.ExecuteScalar();
            //object obj = cmd.ExecuteReader();

            // Close oCon for use
            oCon.Close();
            // Dispose of oCon
            oCon.Dispose();
            // Return the object
            return obj;
        }

        /// <summary>
        /// Send an OLEDB request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static Queue RequestReader(string request)
        {
            // Get a new OLEDB connection oCon using the global connectionstring
            OleDbConnection oCon = new OleDbConnection(Variables.connectionstring);

            // Get a new OLEDB command cmd using the given request and connection oCon
            OleDbCommand cmd = new OleDbCommand(request, oCon);

            // Open oCon for use
            oCon.Open();

            // Read obj as the scalar response
            //object obj = cmd.ExecuteScalar();
            OleDbDataReader reader = cmd.ExecuteReader();

            // Lets get a queue
            Queue q = new Queue(40);

            // While the reader is reading add it to the queue
            while (reader.Read())
            {
                q.Enqueue(reader[0].ToString());
            }

            // Close the reader
            reader.Close();

            // Close oCon for use
            oCon.Close();
            // Dispose of oCon
            oCon.Dispose();
            // Return the object
            return q;
        }

        /// <summary>
        /// Return the number of rows in the table given
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static int RowCount(string table)
        {
            // Ask the DB for a row count of the table given
            return int.Parse(Database.RequestScalar("SELECT count(*) from [" + table + "]").ToString());
        }

        /// <summary>
        /// Delete the row in table wher col is equal to value
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        public static void Delete(string table, string colEdit, string valEdit)
        {
            // In TABLE delete * where COL has a value of VALUE
            Database.RequestScalar("DELETE * FROM [" + table + "] WHERE [" + table + "]![" + colEdit + "] = '" + valEdit + "'");
        }

        /// <summary>
        /// Delete the row in table wher col is equal to value
        /// </summary>
        /// <param name="table"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        public static void Delete(string table, string colEdit, int valEdit)
        {
            // In TABLE delete * where COL has a value of VALUE
            Database.RequestScalar("DELETE * FROM [" + table + "] WHERE [" + table + "]![" + colEdit + "] = " + valEdit.ToString());
        }

        /// <summary>
        /// In TABLE update row with COLCHECK as VALCHECK to have COLEDIT and VALEDIT
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colEdit"></param>
        /// <param name="valEdit"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        public static void Update(string table,string colEdit,string valEdit,string colCheck, string valCheck)
        {
            // In TABLE update row with COLCHECK as VALCHECK to have COLEDIT and VALEDIT
            Database.RequestScalar("UPDATE [" + table + "] SET [" + table + "]![" + colEdit + "]='" + valEdit + "' WHERE [" + table + "]![" + colCheck + "] = '" + valCheck + "'");
        }

        /// <summary>
        /// In TABLE update row with COLCHECK as VALCHECK to have COLEDIT and VALEDIT
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colEdit"></param>
        /// <param name="valEdit"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        public static void Update(string table, string colEdit, string valEdit, string colCheck, int valCheck)
        {
            // In TABLE update row with COLCHECK as VALCHECK to have COLEDIT and VALEDIT
            Database.RequestScalar("UPDATE [" + table + "] SET [" + table + "]![" + colEdit + "]='" + valEdit + "' WHERE [" + table + "]![" + colCheck + "] = " + valCheck.ToString() + "");
        }

        /// <summary>
        /// Add a row to TABLE using VALUES in order
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        /// <returns></returns>
        public static void Add(string table,string[] valEdit)
        {
            // Define our values to add
            string values = "";
            // For each of the value we want to edit as value
            foreach (string value in valEdit)
            {
                // Add the value to out values string
                values = values + value;
                // Then add the ", " that is needed to seperate in the request
                values = values + ", ";
            }
            // As we have nothing else to add to the string remove the last ", "
            values = values.Remove(values.Length - 2, 2);
            // Send the request to the database
            Database.RequestScalar("INSERT INTO [" + table + "] VALUES (" + values + ")");
        }

        /// <summary>
        /// In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        /// <returns></returns>
        public static string Select(string table,string colGet,string colCheck,string valCheck)
        {
            // In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
            return Database.RequestScalar("SELECT [" + table + "]![" + colGet + "] FROM [" + table + "] WHERE ((([" + table + "]![" + colCheck + "])='" + valCheck + "'));").ToString();
        }

        /// <summary>
        /// In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        /// <returns></returns>
        public static string Select(string table, string colGet, string colCheck, int valCheck)
        {
            // In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
            return Database.RequestScalar("SELECT [" + table + "]![" + colGet + "] FROM [" + table + "] WHERE ((([" + table + "]![" + colCheck + "])=" + valCheck.ToString() + "));").ToString();
        }

        /// <summary>
        /// In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        /// <param name="multiple"></param>
        /// <returns></returns>
        public static Queue Select(string table, string colGet, string colCheck, string valCheck, bool multiple)
        {
            // In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
            return Database.RequestReader("SELECT [" + table + "]![" + colGet + "] FROM [" + table + "] WHERE ((([" + table + "]![" + colCheck + "])='" + valCheck + "'));");
        }

        /// <summary>
        /// In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <param name="colCheck"></param>
        /// <param name="valCheck"></param>
        /// <param name="multiple"></param>
        /// <returns></returns>
        public static Queue Select(string table, string colGet, string colCheck, int valCheck, bool multiple)
        {
            // In TABLE find row where COLCHECK has value of VALCHECK and get value from COLGET
            return Database.RequestReader("SELECT [" + table + "]![" + colGet + "] FROM [" + table + "] WHERE ((([" + table + "]![" + colCheck + "])=" + valCheck.ToString() + "));");
        }

        /// <summary>
        /// In TABLE Get all values in collum colGET
        /// </summary>
        /// <param name="table"></param>
        /// <param name="colGet"></param>
        /// <returns></returns>
        public static Queue Select(string table, string colGet)
        {
            //
            return Database.RequestReader("SELECT [" + table + "]![" + colGet + "] FROM [" + table + "];");
        }

        /// <summary>
        /// In TABLE delete *
        /// </summary>
        /// <param name="table"></param>
        public static void Clear(string table)
        {
            // In TABLE delete *
            Database.RequestScalar("DELETE * FROM ["+table+"]");
        }

    }

    public class Settings
    {

        /// <summary>
        /// Set the entry where ID = item to have a value of DATA
        /// </summary>
        /// <param name="item"></param>
        /// <param name="data"></param>
        public static void set(string item, string data)
        {
            // Set the entry where ID = item to have a value of DATA
            Database.RequestScalar("UPDATE Config SET Config.Data='" + data + "' WHERE Config.ID = '" + item + "'");
        }

        /// <summary>
        /// Return the entry where ID = item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string get(string item)
        {
            // Return the entry where ID = item
            return (string)Database.RequestScalar("SELECT Config.Data FROM Config WHERE (((Config.ID)='" + item + "'));");
        }
    }
}