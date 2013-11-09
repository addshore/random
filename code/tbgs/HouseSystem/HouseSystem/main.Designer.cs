namespace HouseSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new HouseSystem.dsMain();
            this.commendationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsTableAdapter = new HouseSystem.dsMainTableAdapters.AdminsTableAdapter();
            this.studentsTableAdapter = new HouseSystem.dsMainTableAdapters.StudentsTableAdapter();
            this.subjectsTableAdapter = new HouseSystem.dsMainTableAdapters.SubjectsTableAdapter();
            this.commendationsTableAdapter = new HouseSystem.dsMainTableAdapters.CommendationsTableAdapter();
            this.logTableAdapter = new HouseSystem.dsMainTableAdapters.LogTableAdapter();
            this.boxAddSubjects = new System.Windows.Forms.GroupBox();
            this.txtAddSubjectName = new System.Windows.Forms.TextBox();
            this.lblAddSubjectName = new System.Windows.Forms.Label();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnClearSubject = new System.Windows.Forms.Button();
            this.boxSelectedSubjects = new System.Windows.Forms.GroupBox();
            this.txtSelectedSubjectName = new System.Windows.Forms.TextBox();
            this.lblSelectedSubjectName = new System.Windows.Forms.Label();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnHideSubjects = new System.Windows.Forms.Button();
            this.dateAddedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInternet = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExternalBrowser = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.boxApperance = new System.Windows.Forms.GroupBox();
            this.btnDefaultApperance = new System.Windows.Forms.Button();
            this.btnApperanceRevert = new System.Windows.Forms.Button();
            this.btnApperanceApply = new System.Windows.Forms.Button();
            this.chkAppLog = new System.Windows.Forms.CheckBox();
            this.chkAppWeb = new System.Windows.Forms.CheckBox();
            this.chkAppClock = new System.Windows.Forms.CheckBox();
            this.boxSettings = new System.Windows.Forms.GroupBox();
            this.btnDefaultSettings = new System.Windows.Forms.Button();
            this.btnSettingsApply = new System.Windows.Forms.Button();
            this.btnSettingsRevert = new System.Windows.Forms.Button();
            this.txtSettingWebPage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.logIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplaying = new System.Windows.Forms.Label();
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.boxAttributesWhat = new System.Windows.Forms.GroupBox();
            this.lbWhat1 = new System.Windows.Forms.ListBox();
            this.lbWhat2 = new System.Windows.Forms.ListBox();
            this.btnattributesClear = new System.Windows.Forms.Button();
            this.btnattributesSave = new System.Windows.Forms.Button();
            this.rbEffort = new System.Windows.Forms.RadioButton();
            this.rbCommendation = new System.Windows.Forms.RadioButton();
            this.rbCertificate = new System.Windows.Forms.RadioButton();
            this.boxAttributesWho = new System.Windows.Forms.GroupBox();
            this.lbWho1 = new System.Windows.Forms.ListBox();
            this.cbWho = new System.Windows.Forms.ComboBox();
            this.yeargroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxAddStudents = new System.Windows.Forms.GroupBox();
            this.btnStudentClear = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.txtStudentAddYear = new System.Windows.Forms.TextBox();
            this.lblStudentFullname = new System.Windows.Forms.Label();
            this.txtStudentAddFullname = new System.Windows.Forms.TextBox();
            this.boxSelectedStudents = new System.Windows.Forms.GroupBox();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentSelectedYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentSelectedFullname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHideStudents = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoggedInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHideAdmins = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxAddAdmin = new System.Windows.Forms.GroupBox();
            this.lblSecondName1 = new System.Windows.Forms.Label();
            this.txtAdminAddSecondName = new System.Windows.Forms.TextBox();
            this.btnAdminClear = new System.Windows.Forms.Button();
            this.btnAdminAdd = new System.Windows.Forms.Button();
            this.lblPassword12 = new System.Windows.Forms.Label();
            this.txtAdminAddPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword11 = new System.Windows.Forms.Label();
            this.txtAdminAddPassword1 = new System.Windows.Forms.TextBox();
            this.lblUsername1 = new System.Windows.Forms.Label();
            this.txtAdminAddUsername = new System.Windows.Forms.TextBox();
            this.lblFirstname1 = new System.Windows.Forms.Label();
            this.txtAdminAddFirstName = new System.Windows.Forms.TextBox();
            this.boxSelectedAdmin = new System.Windows.Forms.GroupBox();
            this.lblSecondName2 = new System.Windows.Forms.Label();
            this.txtAdminSelectedSecondName = new System.Windows.Forms.TextBox();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.btnAdminSave = new System.Windows.Forms.Button();
            this.lblPassword22 = new System.Windows.Forms.Label();
            this.txtAdminSelectedPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword21 = new System.Windows.Forms.Label();
            this.txtAdminSelectedPassword1 = new System.Windows.Forms.TextBox();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.txtAdminSelectedUsername = new System.Windows.Forms.TextBox();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.txtAdminSelectedFirstName = new System.Windows.Forms.TextBox();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.boxHome = new System.Windows.Forms.GroupBox();
            this.listSessionLog = new System.Windows.Forms.ListBox();
            this.btnLockSession = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMeUser = new System.Windows.Forms.Label();
            this.lblMeLoginDate = new System.Windows.Forms.Label();
            this.btnChgPass = new System.Windows.Forms.Button();
            this.pbHomeUser = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.boxNotes = new System.Windows.Forms.GroupBox();
            this.rtbMyNotes = new System.Windows.Forms.RichTextBox();
            this.rtbSysNotes = new System.Windows.Forms.RichTextBox();
            this.lblMyNotes = new System.Windows.Forms.Label();
            this.lblSysNotes = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbStatusDatabase = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbStatusProgram = new System.Windows.Forms.PictureBox();
            this.lblStatusProgram = new System.Windows.Forms.Label();
            this.pbStatusWeb = new System.Windows.Forms.PictureBox();
            this.lblStatusWeb = new System.Windows.Forms.Label();
            this.boxStatistics = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatAllTables = new System.Windows.Forms.Label();
            this.lblStatLogs = new System.Windows.Forms.Label();
            this.lblStatSubjects = new System.Windows.Forms.Label();
            this.lblStatStudents = new System.Windows.Forms.Label();
            this.lblStatAdmins = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvYears = new System.Windows.Forms.DataGridView();
            this.yearIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.boxYears = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearSelected = new System.Windows.Forms.TextBox();
            this.btnYearDelete = new System.Windows.Forms.Button();
            this.btnYearSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearNew = new System.Windows.Forms.TextBox();
            this.btnYearClear = new System.Windows.Forms.Button();
            this.btnYearAdd = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.subjectIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.boxSubjects = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubjectSelected = new System.Windows.Forms.TextBox();
            this.btnSubjectDelete = new System.Windows.Forms.Button();
            this.btnSubjectSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubjectNew = new System.Windows.Forms.TextBox();
            this.btnSubjectClear = new System.Windows.Forms.Button();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.tabAwards = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvCommendations = new System.Windows.Forms.DataGridView();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commendationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.boxCommendationTypes = new System.Windows.Forms.GroupBox();
            this.btnCommendationDelete = new System.Windows.Forms.Button();
            this.btnCommendationSave = new System.Windows.Forms.Button();
            this.txtCommendationSelectedDesc = new System.Windows.Forms.TextBox();
            this.txtCommendationSelectedName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCommendationClear = new System.Windows.Forms.Button();
            this.btnCommendationAdd = new System.Windows.Forms.Button();
            this.txtCommendationNewDesc = new System.Windows.Forms.TextBox();
            this.txtCommendationNewName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCertificates = new System.Windows.Forms.DataGridView();
            this.certIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.boxCertificateTypes = new System.Windows.Forms.GroupBox();
            this.btnCertificateDelete = new System.Windows.Forms.Button();
            this.btnCertificateSave = new System.Windows.Forms.Button();
            this.txtCertificateSelectedDesc = new System.Windows.Forms.TextBox();
            this.txtCertificateSelectedName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCertificateClear = new System.Windows.Forms.Button();
            this.btnCertificateAdd = new System.Windows.Forms.Button();
            this.txtCertificateNewDesc = new System.Windows.Forms.TextBox();
            this.txtCertificateNewName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReportPrintStudent = new System.Windows.Forms.Button();
            this.lblReportCount = new System.Windows.Forms.Label();
            this.lbReports = new System.Windows.Forms.ListBox();
            this.btnReportsRemove = new System.Windows.Forms.Button();
            this.rbReportsEffort = new System.Windows.Forms.RadioButton();
            this.rbReportsCommendation = new System.Windows.Forms.RadioButton();
            this.rbReportsCertificate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReportsWho = new System.Windows.Forms.ListBox();
            this.cbReportsWho = new System.Windows.Forms.ComboBox();
            this.effortgradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.effort_GradesTableAdapter = new HouseSystem.dsMainTableAdapters.Effort_GradesTableAdapter();
            this.year_GroupsTableAdapter = new HouseSystem.dsMainTableAdapters.Year_GroupsTableAdapter();
            this.commendation_TypesTableAdapter = new HouseSystem.dsMainTableAdapters.Commendation_TypesTableAdapter();
            this.certificate_TypesTableAdapter = new HouseSystem.dsMainTableAdapters.Certificate_TypesTableAdapter();
            this.certificatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificatesTableAdapter = new HouseSystem.dsMainTableAdapters.CertificatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commendationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.tabInternet.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.boxApperance.SuspendLayout();
            this.boxSettings.SuspendLayout();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabAttributes.SuspendLayout();
            this.boxAttributesWhat.SuspendLayout();
            this.boxAttributesWho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeargroupsBindingSource)).BeginInit();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.boxAddStudents.SuspendLayout();
            this.boxSelectedStudents.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.boxAddAdmin.SuspendLayout();
            this.boxSelectedAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.boxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeUser)).BeginInit();
            this.boxNotes.SuspendLayout();
            this.boxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusWeb)).BeginInit();
            this.boxStatistics.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCategories.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).BeginInit();
            this.panel6.SuspendLayout();
            this.boxYears.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panel5.SuspendLayout();
            this.boxSubjects.SuspendLayout();
            this.tabAwards.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommendations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commendationTypesBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            this.boxCommendationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesBindingSource)).BeginInit();
            this.panel11.SuspendLayout();
            this.boxCertificateTypes.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effortgradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AccessibleName = "Current Date and Time";
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(718, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "[date]";
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            this.logBindingSource.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "dsMain";
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commendationsBindingSource
            // 
            this.commendationsBindingSource.DataMember = "Commendations";
            this.commendationsBindingSource.DataSource = this.dsMain;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.dsMain;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.dsMain;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dsMain;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "Log ID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "Log ID";
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            // 
            // adminIDDataGridViewTextBoxColumn1
            // 
            this.adminIDDataGridViewTextBoxColumn1.DataPropertyName = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn1.HeaderText = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn1.Name = "adminIDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Log ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Log ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // commendationsTableAdapter
            // 
            this.commendationsTableAdapter.ClearBeforeFill = true;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // boxAddSubjects
            // 
            this.boxAddSubjects.Location = new System.Drawing.Point(3, 3);
            this.boxAddSubjects.Name = "boxAddSubjects";
            this.boxAddSubjects.Size = new System.Drawing.Size(226, 72);
            this.boxAddSubjects.TabIndex = 27;
            this.boxAddSubjects.TabStop = false;
            // 
            // txtAddSubjectName
            // 
            this.txtAddSubjectName.Location = new System.Drawing.Point(96, 16);
            this.txtAddSubjectName.Name = "txtAddSubjectName";
            this.txtAddSubjectName.Size = new System.Drawing.Size(120, 20);
            this.txtAddSubjectName.TabIndex = 0;
            // 
            // lblAddSubjectName
            // 
            this.lblAddSubjectName.AutoSize = true;
            this.lblAddSubjectName.Location = new System.Drawing.Point(6, 16);
            this.lblAddSubjectName.Name = "lblAddSubjectName";
            this.lblAddSubjectName.Size = new System.Drawing.Size(74, 13);
            this.lblAddSubjectName.TabIndex = 1;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(141, 42);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 10;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnClearSubject
            // 
            this.btnClearSubject.Location = new System.Drawing.Point(60, 43);
            this.btnClearSubject.Name = "btnClearSubject";
            this.btnClearSubject.Size = new System.Drawing.Size(75, 23);
            this.btnClearSubject.TabIndex = 16;
            this.btnClearSubject.Text = "Clear";
            this.btnClearSubject.UseVisualStyleBackColor = true;
            // 
            // boxSelectedSubjects
            // 
            this.boxSelectedSubjects.Location = new System.Drawing.Point(3, 81);
            this.boxSelectedSubjects.Name = "boxSelectedSubjects";
            this.boxSelectedSubjects.Size = new System.Drawing.Size(226, 74);
            this.boxSelectedSubjects.TabIndex = 28;
            this.boxSelectedSubjects.TabStop = false;
            // 
            // txtSelectedSubjectName
            // 
            this.txtSelectedSubjectName.Location = new System.Drawing.Point(96, 16);
            this.txtSelectedSubjectName.Name = "txtSelectedSubjectName";
            this.txtSelectedSubjectName.Size = new System.Drawing.Size(120, 20);
            this.txtSelectedSubjectName.TabIndex = 0;
            // 
            // lblSelectedSubjectName
            // 
            this.lblSelectedSubjectName.AutoSize = true;
            this.lblSelectedSubjectName.Location = new System.Drawing.Point(6, 16);
            this.lblSelectedSubjectName.Name = "lblSelectedSubjectName";
            this.lblSelectedSubjectName.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedSubjectName.TabIndex = 1;
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(141, 42);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSubject.TabIndex = 10;
            this.btnSaveSubject.Text = "Save";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(60, 42);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubject.TabIndex = 16;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // btnHideSubjects
            // 
            this.btnHideSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideSubjects.Location = new System.Drawing.Point(434, 4);
            this.btnHideSubjects.Name = "btnHideSubjects";
            this.btnHideSubjects.Size = new System.Drawing.Size(82, 23);
            this.btnHideSubjects.TabIndex = 31;
            this.btnHideSubjects.Text = "Hide Controls";
            this.btnHideSubjects.UseVisualStyleBackColor = true;
            // 
            // dateAddedDataGridViewTextBoxColumn1
            // 
            this.dateAddedDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateAddedDataGridViewTextBoxColumn1.DataPropertyName = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn1.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn1.Name = "dateAddedDataGridViewTextBoxColumn1";
            this.dateAddedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "Subject Name";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "Subject Name";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            this.subjectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "Subject ID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "Subject ID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabInternet
            // 
            this.tabInternet.AccessibleName = "Internet Tab";
            this.tabInternet.Controls.Add(this.webBrowser);
            this.tabInternet.Controls.Add(this.panel4);
            this.tabInternet.Location = new System.Drawing.Point(4, 22);
            this.tabInternet.Name = "tabInternet";
            this.tabInternet.Size = new System.Drawing.Size(760, 622);
            this.tabInternet.TabIndex = 7;
            this.tabInternet.Text = "WebPage";
            this.tabInternet.ToolTipText = "Access to Internet";
            this.tabInternet.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(760, 593);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExternalBrowser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 593);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 29);
            this.panel4.TabIndex = 2;
            // 
            // btnExternalBrowser
            // 
            this.btnExternalBrowser.Location = new System.Drawing.Point(641, 3);
            this.btnExternalBrowser.Name = "btnExternalBrowser";
            this.btnExternalBrowser.Size = new System.Drawing.Size(110, 23);
            this.btnExternalBrowser.TabIndex = 1;
            this.btnExternalBrowser.Text = "External Browser";
            this.btnExternalBrowser.UseVisualStyleBackColor = true;
            this.btnExternalBrowser.Click += new System.EventHandler(this.btnExternalBrowser_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.AccessibleName = "Settings Tab";
            this.tabSettings.AutoScroll = true;
            this.tabSettings.Controls.Add(this.boxApperance);
            this.tabSettings.Controls.Add(this.boxSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(760, 622);
            this.tabSettings.TabIndex = 6;
            this.tabSettings.Text = "Settings";
            this.tabSettings.ToolTipText = "Access to Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // boxApperance
            // 
            this.boxApperance.Controls.Add(this.btnDefaultApperance);
            this.boxApperance.Controls.Add(this.btnApperanceRevert);
            this.boxApperance.Controls.Add(this.btnApperanceApply);
            this.boxApperance.Controls.Add(this.chkAppLog);
            this.boxApperance.Controls.Add(this.chkAppWeb);
            this.boxApperance.Controls.Add(this.chkAppClock);
            this.boxApperance.Location = new System.Drawing.Point(342, 3);
            this.boxApperance.Name = "boxApperance";
            this.boxApperance.Size = new System.Drawing.Size(415, 150);
            this.boxApperance.TabIndex = 2;
            this.boxApperance.TabStop = false;
            this.boxApperance.Text = "Apperance";
            // 
            // btnDefaultApperance
            // 
            this.btnDefaultApperance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultApperance.Location = new System.Drawing.Point(172, 120);
            this.btnDefaultApperance.Name = "btnDefaultApperance";
            this.btnDefaultApperance.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultApperance.TabIndex = 3;
            this.btnDefaultApperance.Text = "Default";
            this.btnDefaultApperance.UseVisualStyleBackColor = true;
            this.btnDefaultApperance.Click += new System.EventHandler(this.btnDefaultApperance_Click);
            // 
            // btnApperanceRevert
            // 
            this.btnApperanceRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApperanceRevert.Location = new System.Drawing.Point(253, 120);
            this.btnApperanceRevert.Name = "btnApperanceRevert";
            this.btnApperanceRevert.Size = new System.Drawing.Size(75, 23);
            this.btnApperanceRevert.TabIndex = 4;
            this.btnApperanceRevert.Text = "Revert";
            this.btnApperanceRevert.UseVisualStyleBackColor = true;
            this.btnApperanceRevert.Click += new System.EventHandler(this.btnApperanceRevert_Click);
            // 
            // btnApperanceApply
            // 
            this.btnApperanceApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApperanceApply.Location = new System.Drawing.Point(334, 120);
            this.btnApperanceApply.Name = "btnApperanceApply";
            this.btnApperanceApply.Size = new System.Drawing.Size(75, 23);
            this.btnApperanceApply.TabIndex = 5;
            this.btnApperanceApply.Text = "Apply";
            this.btnApperanceApply.UseVisualStyleBackColor = true;
            this.btnApperanceApply.Click += new System.EventHandler(this.btnApperanceApply_Click);
            // 
            // chkAppLog
            // 
            this.chkAppLog.AutoSize = true;
            this.chkAppLog.Checked = true;
            this.chkAppLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppLog.Location = new System.Drawing.Point(6, 42);
            this.chkAppLog.Name = "chkAppLog";
            this.chkAppLog.Size = new System.Drawing.Size(74, 17);
            this.chkAppLog.TabIndex = 1;
            this.chkAppLog.Text = "Show Log";
            this.chkAppLog.UseVisualStyleBackColor = true;
            // 
            // chkAppWeb
            // 
            this.chkAppWeb.AutoSize = true;
            this.chkAppWeb.Checked = true;
            this.chkAppWeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppWeb.Location = new System.Drawing.Point(6, 65);
            this.chkAppWeb.Name = "chkAppWeb";
            this.chkAppWeb.Size = new System.Drawing.Size(104, 17);
            this.chkAppWeb.TabIndex = 2;
            this.chkAppWeb.Text = "Show WebPage";
            this.chkAppWeb.UseVisualStyleBackColor = true;
            // 
            // chkAppClock
            // 
            this.chkAppClock.AutoSize = true;
            this.chkAppClock.Checked = true;
            this.chkAppClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppClock.Location = new System.Drawing.Point(6, 19);
            this.chkAppClock.Name = "chkAppClock";
            this.chkAppClock.Size = new System.Drawing.Size(83, 17);
            this.chkAppClock.TabIndex = 0;
            this.chkAppClock.Text = "Show Clock";
            this.chkAppClock.UseVisualStyleBackColor = true;
            // 
            // boxSettings
            // 
            this.boxSettings.Controls.Add(this.btnDefaultSettings);
            this.boxSettings.Controls.Add(this.btnSettingsApply);
            this.boxSettings.Controls.Add(this.btnSettingsRevert);
            this.boxSettings.Controls.Add(this.txtSettingWebPage);
            this.boxSettings.Controls.Add(this.label7);
            this.boxSettings.Location = new System.Drawing.Point(3, 3);
            this.boxSettings.Name = "boxSettings";
            this.boxSettings.Size = new System.Drawing.Size(333, 150);
            this.boxSettings.TabIndex = 1;
            this.boxSettings.TabStop = false;
            this.boxSettings.Text = "Settings";
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultSettings.Location = new System.Drawing.Point(87, 121);
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultSettings.TabIndex = 1;
            this.btnDefaultSettings.Text = "Default";
            this.btnDefaultSettings.UseVisualStyleBackColor = true;
            this.btnDefaultSettings.Click += new System.EventHandler(this.btnDefaultSettings_Click);
            // 
            // btnSettingsApply
            // 
            this.btnSettingsApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsApply.Location = new System.Drawing.Point(249, 121);
            this.btnSettingsApply.Name = "btnSettingsApply";
            this.btnSettingsApply.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsApply.TabIndex = 3;
            this.btnSettingsApply.Text = "Apply";
            this.btnSettingsApply.UseVisualStyleBackColor = true;
            this.btnSettingsApply.Click += new System.EventHandler(this.btnSettingsApply_Click);
            // 
            // btnSettingsRevert
            // 
            this.btnSettingsRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsRevert.Location = new System.Drawing.Point(168, 121);
            this.btnSettingsRevert.Name = "btnSettingsRevert";
            this.btnSettingsRevert.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsRevert.TabIndex = 2;
            this.btnSettingsRevert.Text = "Revert";
            this.btnSettingsRevert.UseVisualStyleBackColor = true;
            this.btnSettingsRevert.Click += new System.EventHandler(this.btnSettingsRevert_Click);
            // 
            // txtSettingWebPage
            // 
            this.txtSettingWebPage.Location = new System.Drawing.Point(9, 32);
            this.txtSettingWebPage.Name = "txtSettingWebPage";
            this.txtSettingWebPage.Size = new System.Drawing.Size(243, 20);
            this.txtSettingWebPage.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "WebPage Default Url";
            // 
            // tabLog
            // 
            this.tabLog.AccessibleName = "Log Tab";
            this.tabLog.Controls.Add(this.dgvLog);
            this.tabLog.Controls.Add(this.panel9);
            this.tabLog.Controls.Add(this.panel8);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(760, 622);
            this.tabLog.TabIndex = 5;
            this.tabLog.Text = "Log";
            this.tabLog.ToolTipText = "Access to Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn1,
            this.adminIDDataGridViewTextBoxColumn2,
            this.logTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvLog.DataSource = this.logBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 32);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLog.Size = new System.Drawing.Size(760, 561);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLog_RowsAdded);
            // 
            // logIDDataGridViewTextBoxColumn1
            // 
            this.logIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.logIDDataGridViewTextBoxColumn1.DataPropertyName = "Log ID";
            this.logIDDataGridViewTextBoxColumn1.HeaderText = "Log ID";
            this.logIDDataGridViewTextBoxColumn1.Name = "logIDDataGridViewTextBoxColumn1";
            this.logIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.logIDDataGridViewTextBoxColumn1.Width = 64;
            // 
            // adminIDDataGridViewTextBoxColumn2
            // 
            this.adminIDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adminIDDataGridViewTextBoxColumn2.DataPropertyName = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn2.HeaderText = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn2.Name = "adminIDDataGridViewTextBoxColumn2";
            this.adminIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.adminIDDataGridViewTextBoxColumn2.Width = 75;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            this.logTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.logTypeDataGridViewTextBoxColumn.DataPropertyName = "Log Type";
            this.logTypeDataGridViewTextBoxColumn.HeaderText = "Log Type";
            this.logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            this.logTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.logTypeDataGridViewTextBoxColumn.Width = 77;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnExport);
            this.panel9.Controls.Add(this.btnClearLog);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 593);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(760, 29);
            this.panel9.TabIndex = 36;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(678, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.lblDisplaying);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(760, 32);
            this.panel8.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Most recent entries are at the top";
            // 
            // lblDisplaying
            // 
            this.lblDisplaying.AutoSize = true;
            this.lblDisplaying.Location = new System.Drawing.Point(3, 10);
            this.lblDisplaying.Name = "lblDisplaying";
            this.lblDisplaying.Size = new System.Drawing.Size(98, 13);
            this.lblDisplaying.TabIndex = 32;
            this.lblDisplaying.Text = "Displaying 0 entries";
            // 
            // tabAttributes
            // 
            this.tabAttributes.AccessibleName = "Attributes Tab";
            this.tabAttributes.Controls.Add(this.boxAttributesWhat);
            this.tabAttributes.Controls.Add(this.boxAttributesWho);
            this.tabAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttributes.Size = new System.Drawing.Size(760, 622);
            this.tabAttributes.TabIndex = 9;
            this.tabAttributes.Text = "Give Tab";
            this.tabAttributes.ToolTipText = "Access to Giving Awards";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // boxAttributesWhat
            // 
            this.boxAttributesWhat.Controls.Add(this.lbWhat1);
            this.boxAttributesWhat.Controls.Add(this.lbWhat2);
            this.boxAttributesWhat.Controls.Add(this.btnattributesClear);
            this.boxAttributesWhat.Controls.Add(this.btnattributesSave);
            this.boxAttributesWhat.Controls.Add(this.rbEffort);
            this.boxAttributesWhat.Controls.Add(this.rbCommendation);
            this.boxAttributesWhat.Controls.Add(this.rbCertificate);
            this.boxAttributesWhat.Location = new System.Drawing.Point(175, 6);
            this.boxAttributesWhat.Name = "boxAttributesWhat";
            this.boxAttributesWhat.Size = new System.Drawing.Size(578, 610);
            this.boxAttributesWhat.TabIndex = 1;
            this.boxAttributesWhat.TabStop = false;
            this.boxAttributesWhat.Text = "2 - What?";
            // 
            // lbWhat1
            // 
            this.lbWhat1.FormattingEnabled = true;
            this.lbWhat1.Location = new System.Drawing.Point(107, 19);
            this.lbWhat1.Name = "lbWhat1";
            this.lbWhat1.Size = new System.Drawing.Size(287, 576);
            this.lbWhat1.TabIndex = 6;
            // 
            // lbWhat2
            // 
            this.lbWhat2.DataSource = this.subjectsBindingSource;
            this.lbWhat2.DisplayMember = "Subject Name";
            this.lbWhat2.FormattingEnabled = true;
            this.lbWhat2.Location = new System.Drawing.Point(400, 19);
            this.lbWhat2.Name = "lbWhat2";
            this.lbWhat2.Size = new System.Drawing.Size(172, 576);
            this.lbWhat2.TabIndex = 5;
            this.lbWhat2.ValueMember = "Subject ID";
            // 
            // btnattributesClear
            // 
            this.btnattributesClear.Location = new System.Drawing.Point(13, 91);
            this.btnattributesClear.Name = "btnattributesClear";
            this.btnattributesClear.Size = new System.Drawing.Size(75, 23);
            this.btnattributesClear.TabIndex = 4;
            this.btnattributesClear.Text = "Clear";
            this.btnattributesClear.UseVisualStyleBackColor = true;
            this.btnattributesClear.Click += new System.EventHandler(this.btnattributesClear_Click);
            // 
            // btnattributesSave
            // 
            this.btnattributesSave.Location = new System.Drawing.Point(13, 120);
            this.btnattributesSave.Name = "btnattributesSave";
            this.btnattributesSave.Size = new System.Drawing.Size(75, 23);
            this.btnattributesSave.TabIndex = 2;
            this.btnattributesSave.Text = "Give Award";
            this.btnattributesSave.UseVisualStyleBackColor = true;
            this.btnattributesSave.Click += new System.EventHandler(this.btnattributesSave_Click);
            // 
            // rbEffort
            // 
            this.rbEffort.AutoSize = true;
            this.rbEffort.Location = new System.Drawing.Point(6, 65);
            this.rbEffort.Name = "rbEffort";
            this.rbEffort.Size = new System.Drawing.Size(82, 17);
            this.rbEffort.TabIndex = 2;
            this.rbEffort.TabStop = true;
            this.rbEffort.Text = "Effort Grade";
            this.rbEffort.UseVisualStyleBackColor = true;
            this.rbEffort.CheckedChanged += new System.EventHandler(this.WhatAttributesChanged);
            // 
            // rbCommendation
            // 
            this.rbCommendation.AutoSize = true;
            this.rbCommendation.Location = new System.Drawing.Point(6, 42);
            this.rbCommendation.Name = "rbCommendation";
            this.rbCommendation.Size = new System.Drawing.Size(95, 17);
            this.rbCommendation.TabIndex = 1;
            this.rbCommendation.TabStop = true;
            this.rbCommendation.Text = "Commendation";
            this.rbCommendation.UseVisualStyleBackColor = true;
            this.rbCommendation.CheckedChanged += new System.EventHandler(this.WhatAttributesChanged);
            // 
            // rbCertificate
            // 
            this.rbCertificate.AutoSize = true;
            this.rbCertificate.Checked = true;
            this.rbCertificate.Location = new System.Drawing.Point(6, 19);
            this.rbCertificate.Name = "rbCertificate";
            this.rbCertificate.Size = new System.Drawing.Size(72, 17);
            this.rbCertificate.TabIndex = 0;
            this.rbCertificate.TabStop = true;
            this.rbCertificate.Text = "Certificate";
            this.rbCertificate.UseVisualStyleBackColor = true;
            this.rbCertificate.CheckedChanged += new System.EventHandler(this.WhatAttributesChanged);
            // 
            // boxAttributesWho
            // 
            this.boxAttributesWho.Controls.Add(this.lbWho1);
            this.boxAttributesWho.Controls.Add(this.cbWho);
            this.boxAttributesWho.Location = new System.Drawing.Point(6, 6);
            this.boxAttributesWho.Name = "boxAttributesWho";
            this.boxAttributesWho.Size = new System.Drawing.Size(163, 610);
            this.boxAttributesWho.TabIndex = 0;
            this.boxAttributesWho.TabStop = false;
            this.boxAttributesWho.Text = "1 - Who?";
            // 
            // lbWho1
            // 
            this.lbWho1.FormattingEnabled = true;
            this.lbWho1.Location = new System.Drawing.Point(6, 46);
            this.lbWho1.Name = "lbWho1";
            this.lbWho1.Size = new System.Drawing.Size(150, 550);
            this.lbWho1.TabIndex = 1;
            // 
            // cbWho
            // 
            this.cbWho.DataSource = this.yeargroupsBindingSource;
            this.cbWho.DisplayMember = "Year Name";
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Location = new System.Drawing.Point(6, 19);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(150, 21);
            this.cbWho.TabIndex = 0;
            this.cbWho.ValueMember = "Year ID";
            this.cbWho.SelectedIndexChanged += new System.EventHandler(this.cbWho_SelectedIndexChanged);
            // 
            // yeargroupsBindingSource
            // 
            this.yeargroupsBindingSource.DataMember = "Year Groups";
            this.yeargroupsBindingSource.DataSource = this.dsMain;
            // 
            // tabStudents
            // 
            this.tabStudents.AccessibleName = "Students Tab";
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.panel1);
            this.tabStudents.Controls.Add(this.panel3);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Size = new System.Drawing.Size(760, 622);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Students";
            this.tabStudents.ToolTipText = "Access to Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.secondNameDataGridViewTextBoxColumn1,
            this.yearIDDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 115);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(760, 473);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // secondNameDataGridViewTextBoxColumn1
            // 
            this.secondNameDataGridViewTextBoxColumn1.DataPropertyName = "Second Name";
            this.secondNameDataGridViewTextBoxColumn1.HeaderText = "Second Name";
            this.secondNameDataGridViewTextBoxColumn1.Name = "secondNameDataGridViewTextBoxColumn1";
            this.secondNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearIDDataGridViewTextBoxColumn
            // 
            this.yearIDDataGridViewTextBoxColumn.DataPropertyName = "Year ID";
            this.yearIDDataGridViewTextBoxColumn.HeaderText = "Year ID";
            this.yearIDDataGridViewTextBoxColumn.Name = "yearIDDataGridViewTextBoxColumn";
            this.yearIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin ID";
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxAddStudents);
            this.panel1.Controls.Add(this.boxSelectedStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 115);
            this.panel1.TabIndex = 29;
            // 
            // boxAddStudents
            // 
            this.boxAddStudents.Controls.Add(this.btnStudentClear);
            this.boxAddStudents.Controls.Add(this.btnStudentAdd);
            this.boxAddStudents.Controls.Add(this.lblStudentYear);
            this.boxAddStudents.Controls.Add(this.txtStudentAddYear);
            this.boxAddStudents.Controls.Add(this.lblStudentFullname);
            this.boxAddStudents.Controls.Add(this.txtStudentAddFullname);
            this.boxAddStudents.Location = new System.Drawing.Point(3, 3);
            this.boxAddStudents.Name = "boxAddStudents";
            this.boxAddStudents.Size = new System.Drawing.Size(199, 104);
            this.boxAddStudents.TabIndex = 23;
            this.boxAddStudents.TabStop = false;
            this.boxAddStudents.Text = "Add Student";
            // 
            // btnStudentClear
            // 
            this.btnStudentClear.Location = new System.Drawing.Point(34, 68);
            this.btnStudentClear.Name = "btnStudentClear";
            this.btnStudentClear.Size = new System.Drawing.Size(75, 23);
            this.btnStudentClear.TabIndex = 2;
            this.btnStudentClear.Text = "Clear";
            this.btnStudentClear.UseVisualStyleBackColor = true;
            this.btnStudentClear.Click += new System.EventHandler(this.btnStudentClear_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Enabled = false;
            this.btnStudentAdd.Location = new System.Drawing.Point(118, 68);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 3;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(6, 42);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(29, 13);
            this.lblStudentYear.TabIndex = 3;
            this.lblStudentYear.Text = "Year";
            // 
            // txtStudentAddYear
            // 
            this.txtStudentAddYear.Location = new System.Drawing.Point(70, 42);
            this.txtStudentAddYear.Name = "txtStudentAddYear";
            this.txtStudentAddYear.Size = new System.Drawing.Size(120, 20);
            this.txtStudentAddYear.TabIndex = 1;
            this.txtStudentAddYear.TextChanged += new System.EventHandler(this.addstudentchanged);
            // 
            // lblStudentFullname
            // 
            this.lblStudentFullname.AutoSize = true;
            this.lblStudentFullname.Location = new System.Drawing.Point(6, 16);
            this.lblStudentFullname.Name = "lblStudentFullname";
            this.lblStudentFullname.Size = new System.Drawing.Size(54, 13);
            this.lblStudentFullname.TabIndex = 1;
            this.lblStudentFullname.Text = "Full Name";
            // 
            // txtStudentAddFullname
            // 
            this.txtStudentAddFullname.Location = new System.Drawing.Point(70, 16);
            this.txtStudentAddFullname.Name = "txtStudentAddFullname";
            this.txtStudentAddFullname.Size = new System.Drawing.Size(120, 20);
            this.txtStudentAddFullname.TabIndex = 0;
            this.txtStudentAddFullname.TextChanged += new System.EventHandler(this.addstudentchanged);
            // 
            // boxSelectedStudents
            // 
            this.boxSelectedStudents.Controls.Add(this.btnStudentDelete);
            this.boxSelectedStudents.Controls.Add(this.btnStudentSave);
            this.boxSelectedStudents.Controls.Add(this.label1);
            this.boxSelectedStudents.Controls.Add(this.txtStudentSelectedYear);
            this.boxSelectedStudents.Controls.Add(this.label2);
            this.boxSelectedStudents.Controls.Add(this.txtStudentSelectedFullname);
            this.boxSelectedStudents.Location = new System.Drawing.Point(208, 3);
            this.boxSelectedStudents.Name = "boxSelectedStudents";
            this.boxSelectedStudents.Size = new System.Drawing.Size(200, 104);
            this.boxSelectedStudents.TabIndex = 24;
            this.boxSelectedStudents.TabStop = false;
            this.boxSelectedStudents.Text = "Selected Student";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(34, 68);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 2;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.Location = new System.Drawing.Point(115, 68);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(75, 23);
            this.btnStudentSave.TabIndex = 3;
            this.btnStudentSave.Text = "Save";
            this.btnStudentSave.UseVisualStyleBackColor = true;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year";
            // 
            // txtStudentSelectedYear
            // 
            this.txtStudentSelectedYear.Location = new System.Drawing.Point(70, 42);
            this.txtStudentSelectedYear.Name = "txtStudentSelectedYear";
            this.txtStudentSelectedYear.Size = new System.Drawing.Size(120, 20);
            this.txtStudentSelectedYear.TabIndex = 1;
            this.txtStudentSelectedYear.TextChanged += new System.EventHandler(this.selectedstudentchanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // txtStudentSelectedFullname
            // 
            this.txtStudentSelectedFullname.Location = new System.Drawing.Point(70, 16);
            this.txtStudentSelectedFullname.Name = "txtStudentSelectedFullname";
            this.txtStudentSelectedFullname.Size = new System.Drawing.Size(120, 20);
            this.txtStudentSelectedFullname.TabIndex = 0;
            this.txtStudentSelectedFullname.TextChanged += new System.EventHandler(this.selectedstudentchanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHideStudents);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 34);
            this.panel3.TabIndex = 31;
            // 
            // btnHideStudents
            // 
            this.btnHideStudents.Location = new System.Drawing.Point(667, 6);
            this.btnHideStudents.Name = "btnHideStudents";
            this.btnHideStudents.Size = new System.Drawing.Size(90, 23);
            this.btnHideStudents.TabIndex = 25;
            this.btnHideStudents.Text = "Hide Controls";
            this.btnHideStudents.UseVisualStyleBackColor = true;
            this.btnHideStudents.Click += new System.EventHandler(this.btnHideStudents_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.AccessibleName = "Admin Tab";
            this.tabAdmin.Controls.Add(this.dgvAdmins);
            this.tabAdmin.Controls.Add(this.panel7);
            this.tabAdmin.Controls.Add(this.panel2);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(760, 622);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Admins";
            this.tabAdmin.ToolTipText = "Access to Admins";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.AllowUserToResizeColumns = false;
            this.dgvAdmins.AllowUserToResizeRows = false;
            this.dgvAdmins.AutoGenerateColumns = false;
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.lastLoggedInDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dgvAdmins.DataSource = this.adminsBindingSource;
            this.dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmins.Location = new System.Drawing.Point(3, 188);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.Size = new System.Drawing.Size(754, 402);
            this.dgvAdmins.TabIndex = 0;
            this.dgvAdmins.SelectionChanged += new System.EventHandler(this.dgvAdmins_SelectionChanged);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 58;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "Second Name";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second Name";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.secondNameDataGridViewTextBoxColumn.Width = 92;
            // 
            // lastLoggedInDataGridViewTextBoxColumn
            // 
            this.lastLoggedInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastLoggedInDataGridViewTextBoxColumn.DataPropertyName = "Last Logged In";
            this.lastLoggedInDataGridViewTextBoxColumn.HeaderText = "Last Logged In";
            this.lastLoggedInDataGridViewTextBoxColumn.Name = "lastLoggedInDataGridViewTextBoxColumn";
            this.lastLoggedInDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastLoggedInDataGridViewTextBoxColumn.Width = 87;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCreatedDataGridViewTextBoxColumn.Width = 88;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHideAdmins);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 590);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(754, 29);
            this.panel7.TabIndex = 33;
            // 
            // btnHideAdmins
            // 
            this.btnHideAdmins.Location = new System.Drawing.Point(660, 3);
            this.btnHideAdmins.Name = "btnHideAdmins";
            this.btnHideAdmins.Size = new System.Drawing.Size(90, 23);
            this.btnHideAdmins.TabIndex = 0;
            this.btnHideAdmins.Text = "Hide Controls";
            this.btnHideAdmins.UseVisualStyleBackColor = true;
            this.btnHideAdmins.Click += new System.EventHandler(this.btnHideAdmins_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boxAddAdmin);
            this.panel2.Controls.Add(this.boxSelectedAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 185);
            this.panel2.TabIndex = 32;
            // 
            // boxAddAdmin
            // 
            this.boxAddAdmin.Controls.Add(this.lblSecondName1);
            this.boxAddAdmin.Controls.Add(this.txtAdminAddSecondName);
            this.boxAddAdmin.Controls.Add(this.btnAdminClear);
            this.boxAddAdmin.Controls.Add(this.btnAdminAdd);
            this.boxAddAdmin.Controls.Add(this.lblPassword12);
            this.boxAddAdmin.Controls.Add(this.txtAdminAddPassword2);
            this.boxAddAdmin.Controls.Add(this.lblPassword11);
            this.boxAddAdmin.Controls.Add(this.txtAdminAddPassword1);
            this.boxAddAdmin.Controls.Add(this.lblUsername1);
            this.boxAddAdmin.Controls.Add(this.txtAdminAddUsername);
            this.boxAddAdmin.Controls.Add(this.lblFirstname1);
            this.boxAddAdmin.Controls.Add(this.txtAdminAddFirstName);
            this.boxAddAdmin.Location = new System.Drawing.Point(3, 3);
            this.boxAddAdmin.Name = "boxAddAdmin";
            this.boxAddAdmin.Size = new System.Drawing.Size(199, 177);
            this.boxAddAdmin.TabIndex = 27;
            this.boxAddAdmin.TabStop = false;
            this.boxAddAdmin.Text = "Add Admin";
            // 
            // lblSecondName1
            // 
            this.lblSecondName1.AutoSize = true;
            this.lblSecondName1.Location = new System.Drawing.Point(6, 42);
            this.lblSecondName1.Name = "lblSecondName1";
            this.lblSecondName1.Size = new System.Drawing.Size(58, 13);
            this.lblSecondName1.TabIndex = 22;
            this.lblSecondName1.Text = "Last Name";
            // 
            // txtAdminAddSecondName
            // 
            this.txtAdminAddSecondName.Location = new System.Drawing.Point(70, 42);
            this.txtAdminAddSecondName.Name = "txtAdminAddSecondName";
            this.txtAdminAddSecondName.Size = new System.Drawing.Size(120, 20);
            this.txtAdminAddSecondName.TabIndex = 1;
            this.txtAdminAddSecondName.TextChanged += new System.EventHandler(this.addadmincheck);
            // 
            // btnAdminClear
            // 
            this.btnAdminClear.Location = new System.Drawing.Point(115, 146);
            this.btnAdminClear.Name = "btnAdminClear";
            this.btnAdminClear.Size = new System.Drawing.Size(75, 23);
            this.btnAdminClear.TabIndex = 6;
            this.btnAdminClear.Text = "Clear";
            this.btnAdminClear.UseVisualStyleBackColor = true;
            this.btnAdminClear.Click += new System.EventHandler(this.btnAdminClear_Click);
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.Enabled = false;
            this.btnAdminAdd.Location = new System.Drawing.Point(34, 146);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdminAdd.TabIndex = 5;
            this.btnAdminAdd.Text = "Add";
            this.btnAdminAdd.UseVisualStyleBackColor = true;
            this.btnAdminAdd.Click += new System.EventHandler(this.btnAdminAdd_Click);
            // 
            // lblPassword12
            // 
            this.lblPassword12.AutoSize = true;
            this.lblPassword12.Location = new System.Drawing.Point(6, 120);
            this.lblPassword12.Name = "lblPassword12";
            this.lblPassword12.Size = new System.Drawing.Size(53, 13);
            this.lblPassword12.TabIndex = 7;
            this.lblPassword12.Text = "Password";
            // 
            // txtAdminAddPassword2
            // 
            this.txtAdminAddPassword2.Location = new System.Drawing.Point(70, 120);
            this.txtAdminAddPassword2.Name = "txtAdminAddPassword2";
            this.txtAdminAddPassword2.Size = new System.Drawing.Size(120, 20);
            this.txtAdminAddPassword2.TabIndex = 4;
            this.txtAdminAddPassword2.UseSystemPasswordChar = true;
            this.txtAdminAddPassword2.TextChanged += new System.EventHandler(this.addadmincheck);
            // 
            // lblPassword11
            // 
            this.lblPassword11.AutoSize = true;
            this.lblPassword11.Location = new System.Drawing.Point(6, 94);
            this.lblPassword11.Name = "lblPassword11";
            this.lblPassword11.Size = new System.Drawing.Size(53, 13);
            this.lblPassword11.TabIndex = 5;
            this.lblPassword11.Text = "Password";
            // 
            // txtAdminAddPassword1
            // 
            this.txtAdminAddPassword1.Location = new System.Drawing.Point(70, 94);
            this.txtAdminAddPassword1.Name = "txtAdminAddPassword1";
            this.txtAdminAddPassword1.Size = new System.Drawing.Size(120, 20);
            this.txtAdminAddPassword1.TabIndex = 3;
            this.txtAdminAddPassword1.UseSystemPasswordChar = true;
            this.txtAdminAddPassword1.TextChanged += new System.EventHandler(this.addadmincheck);
            // 
            // lblUsername1
            // 
            this.lblUsername1.AutoSize = true;
            this.lblUsername1.Location = new System.Drawing.Point(6, 68);
            this.lblUsername1.Name = "lblUsername1";
            this.lblUsername1.Size = new System.Drawing.Size(55, 13);
            this.lblUsername1.TabIndex = 3;
            this.lblUsername1.Text = "Username";
            // 
            // txtAdminAddUsername
            // 
            this.txtAdminAddUsername.Location = new System.Drawing.Point(70, 68);
            this.txtAdminAddUsername.Name = "txtAdminAddUsername";
            this.txtAdminAddUsername.Size = new System.Drawing.Size(120, 20);
            this.txtAdminAddUsername.TabIndex = 2;
            this.txtAdminAddUsername.TextChanged += new System.EventHandler(this.addadmincheck);
            // 
            // lblFirstname1
            // 
            this.lblFirstname1.AutoSize = true;
            this.lblFirstname1.Location = new System.Drawing.Point(6, 16);
            this.lblFirstname1.Name = "lblFirstname1";
            this.lblFirstname1.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname1.TabIndex = 1;
            this.lblFirstname1.Text = "First Name";
            // 
            // txtAdminAddFirstName
            // 
            this.txtAdminAddFirstName.Location = new System.Drawing.Point(70, 16);
            this.txtAdminAddFirstName.Name = "txtAdminAddFirstName";
            this.txtAdminAddFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtAdminAddFirstName.TabIndex = 0;
            this.txtAdminAddFirstName.TextChanged += new System.EventHandler(this.addadmincheck);
            // 
            // boxSelectedAdmin
            // 
            this.boxSelectedAdmin.Controls.Add(this.lblSecondName2);
            this.boxSelectedAdmin.Controls.Add(this.txtAdminSelectedSecondName);
            this.boxSelectedAdmin.Controls.Add(this.btnAdminDelete);
            this.boxSelectedAdmin.Controls.Add(this.btnAdminSave);
            this.boxSelectedAdmin.Controls.Add(this.lblPassword22);
            this.boxSelectedAdmin.Controls.Add(this.txtAdminSelectedPassword2);
            this.boxSelectedAdmin.Controls.Add(this.lblPassword21);
            this.boxSelectedAdmin.Controls.Add(this.txtAdminSelectedPassword1);
            this.boxSelectedAdmin.Controls.Add(this.lblUsername2);
            this.boxSelectedAdmin.Controls.Add(this.txtAdminSelectedUsername);
            this.boxSelectedAdmin.Controls.Add(this.lblFirstName2);
            this.boxSelectedAdmin.Controls.Add(this.txtAdminSelectedFirstName);
            this.boxSelectedAdmin.Location = new System.Drawing.Point(208, 3);
            this.boxSelectedAdmin.Name = "boxSelectedAdmin";
            this.boxSelectedAdmin.Size = new System.Drawing.Size(200, 177);
            this.boxSelectedAdmin.TabIndex = 0;
            this.boxSelectedAdmin.TabStop = false;
            this.boxSelectedAdmin.Text = "Selected Admin";
            // 
            // lblSecondName2
            // 
            this.lblSecondName2.AutoSize = true;
            this.lblSecondName2.Location = new System.Drawing.Point(6, 42);
            this.lblSecondName2.Name = "lblSecondName2";
            this.lblSecondName2.Size = new System.Drawing.Size(58, 13);
            this.lblSecondName2.TabIndex = 23;
            this.lblSecondName2.Text = "Last Name";
            // 
            // txtAdminSelectedSecondName
            // 
            this.txtAdminSelectedSecondName.Location = new System.Drawing.Point(70, 42);
            this.txtAdminSelectedSecondName.Name = "txtAdminSelectedSecondName";
            this.txtAdminSelectedSecondName.Size = new System.Drawing.Size(120, 20);
            this.txtAdminSelectedSecondName.TabIndex = 1;
            this.txtAdminSelectedSecondName.TextChanged += new System.EventHandler(this.selectedadmincheck);
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.Location = new System.Drawing.Point(115, 146);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAdminDelete.TabIndex = 6;
            this.btnAdminDelete.Text = "Delete";
            this.btnAdminDelete.UseVisualStyleBackColor = true;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // btnAdminSave
            // 
            this.btnAdminSave.Location = new System.Drawing.Point(34, 146);
            this.btnAdminSave.Name = "btnAdminSave";
            this.btnAdminSave.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSave.TabIndex = 5;
            this.btnAdminSave.Text = "Save";
            this.btnAdminSave.UseVisualStyleBackColor = true;
            this.btnAdminSave.Click += new System.EventHandler(this.btnAdminSave_Click);
            // 
            // lblPassword22
            // 
            this.lblPassword22.AutoSize = true;
            this.lblPassword22.Location = new System.Drawing.Point(6, 117);
            this.lblPassword22.Name = "lblPassword22";
            this.lblPassword22.Size = new System.Drawing.Size(53, 13);
            this.lblPassword22.TabIndex = 7;
            this.lblPassword22.Text = "Password";
            // 
            // txtAdminSelectedPassword2
            // 
            this.txtAdminSelectedPassword2.Location = new System.Drawing.Point(70, 117);
            this.txtAdminSelectedPassword2.Name = "txtAdminSelectedPassword2";
            this.txtAdminSelectedPassword2.Size = new System.Drawing.Size(120, 20);
            this.txtAdminSelectedPassword2.TabIndex = 4;
            this.txtAdminSelectedPassword2.UseSystemPasswordChar = true;
            this.txtAdminSelectedPassword2.TextChanged += new System.EventHandler(this.selectedadmincheck);
            // 
            // lblPassword21
            // 
            this.lblPassword21.AutoSize = true;
            this.lblPassword21.Location = new System.Drawing.Point(6, 91);
            this.lblPassword21.Name = "lblPassword21";
            this.lblPassword21.Size = new System.Drawing.Size(53, 13);
            this.lblPassword21.TabIndex = 5;
            this.lblPassword21.Text = "Password";
            // 
            // txtAdminSelectedPassword1
            // 
            this.txtAdminSelectedPassword1.Location = new System.Drawing.Point(70, 91);
            this.txtAdminSelectedPassword1.Name = "txtAdminSelectedPassword1";
            this.txtAdminSelectedPassword1.Size = new System.Drawing.Size(120, 20);
            this.txtAdminSelectedPassword1.TabIndex = 3;
            this.txtAdminSelectedPassword1.UseSystemPasswordChar = true;
            this.txtAdminSelectedPassword1.TextChanged += new System.EventHandler(this.selectedadmincheck);
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Location = new System.Drawing.Point(6, 65);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(55, 13);
            this.lblUsername2.TabIndex = 3;
            this.lblUsername2.Text = "Username";
            // 
            // txtAdminSelectedUsername
            // 
            this.txtAdminSelectedUsername.Enabled = false;
            this.txtAdminSelectedUsername.Location = new System.Drawing.Point(70, 65);
            this.txtAdminSelectedUsername.Name = "txtAdminSelectedUsername";
            this.txtAdminSelectedUsername.Size = new System.Drawing.Size(120, 20);
            this.txtAdminSelectedUsername.TabIndex = 2;
            this.txtAdminSelectedUsername.TextChanged += new System.EventHandler(this.selectedadmincheck);
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.Location = new System.Drawing.Point(6, 16);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName2.TabIndex = 1;
            this.lblFirstName2.Text = "First Name";
            // 
            // txtAdminSelectedFirstName
            // 
            this.txtAdminSelectedFirstName.Location = new System.Drawing.Point(70, 16);
            this.txtAdminSelectedFirstName.Name = "txtAdminSelectedFirstName";
            this.txtAdminSelectedFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtAdminSelectedFirstName.TabIndex = 0;
            this.txtAdminSelectedFirstName.TextChanged += new System.EventHandler(this.selectedadmincheck);
            // 
            // tabHome
            // 
            this.tabHome.AccessibleName = "Home Tab";
            this.tabHome.Controls.Add(this.splitContainer1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(760, 622);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.ToolTipText = "General Access";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.boxHome);
            this.splitContainer1.Panel1.Controls.Add(this.boxNotes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.boxStatus);
            this.splitContainer1.Panel2.Controls.Add(this.boxStatistics);
            this.splitContainer1.Size = new System.Drawing.Size(754, 616);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 13;
            // 
            // boxHome
            // 
            this.boxHome.Controls.Add(this.listSessionLog);
            this.boxHome.Controls.Add(this.btnLockSession);
            this.boxHome.Controls.Add(this.btnExit);
            this.boxHome.Controls.Add(this.lblMeUser);
            this.boxHome.Controls.Add(this.lblMeLoginDate);
            this.boxHome.Controls.Add(this.btnChgPass);
            this.boxHome.Controls.Add(this.pbHomeUser);
            this.boxHome.Controls.Add(this.btnLogout);
            this.boxHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxHome.Location = new System.Drawing.Point(0, 0);
            this.boxHome.Name = "boxHome";
            this.boxHome.Size = new System.Drawing.Size(366, 327);
            this.boxHome.TabIndex = 0;
            this.boxHome.TabStop = false;
            this.boxHome.Text = "Home";
            // 
            // listSessionLog
            // 
            this.listSessionLog.FormattingEnabled = true;
            this.listSessionLog.Location = new System.Drawing.Point(12, 65);
            this.listSessionLog.Name = "listSessionLog";
            this.listSessionLog.ScrollAlwaysVisible = true;
            this.listSessionLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listSessionLog.Size = new System.Drawing.Size(219, 251);
            this.listSessionLog.TabIndex = 0;
            this.listSessionLog.Click += new System.EventHandler(this.listSessionLog_Click);
            // 
            // btnLockSession
            // 
            this.btnLockSession.Location = new System.Drawing.Point(237, 237);
            this.btnLockSession.Name = "btnLockSession";
            this.btnLockSession.Size = new System.Drawing.Size(110, 23);
            this.btnLockSession.TabIndex = 3;
            this.btnLockSession.Text = "Lock Session";
            this.btnLockSession.UseVisualStyleBackColor = true;
            this.btnLockSession.Click += new System.EventHandler(this.btnLockSession_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMeUser
            // 
            this.lblMeUser.AutoSize = true;
            this.lblMeUser.Location = new System.Drawing.Point(17, 16);
            this.lblMeUser.Name = "lblMeUser";
            this.lblMeUser.Size = new System.Drawing.Size(147, 13);
            this.lblMeUser.TabIndex = 0;
            this.lblMeUser.Text = "Currently logged in as \"[user]\"";
            // 
            // lblMeLoginDate
            // 
            this.lblMeLoginDate.AutoSize = true;
            this.lblMeLoginDate.Location = new System.Drawing.Point(17, 33);
            this.lblMeLoginDate.Name = "lblMeLoginDate";
            this.lblMeLoginDate.Size = new System.Drawing.Size(115, 13);
            this.lblMeLoginDate.TabIndex = 1;
            this.lblMeLoginDate.Text = "Logged in at [datetime]";
            // 
            // btnChgPass
            // 
            this.btnChgPass.Location = new System.Drawing.Point(237, 155);
            this.btnChgPass.Name = "btnChgPass";
            this.btnChgPass.Size = new System.Drawing.Size(110, 23);
            this.btnChgPass.TabIndex = 1;
            this.btnChgPass.Text = "Change Password";
            this.btnChgPass.UseVisualStyleBackColor = true;
            this.btnChgPass.Click += new System.EventHandler(this.btnChgPass_Click);
            // 
            // pbHomeUser
            // 
            this.pbHomeUser.ErrorImage = null;
            this.pbHomeUser.Image = global::HouseSystem.Properties.Resources.face;
            this.pbHomeUser.InitialImage = null;
            this.pbHomeUser.Location = new System.Drawing.Point(237, 14);
            this.pbHomeUser.Name = "pbHomeUser";
            this.pbHomeUser.Size = new System.Drawing.Size(110, 135);
            this.pbHomeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomeUser.TabIndex = 7;
            this.pbHomeUser.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(237, 266);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Switch User";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // boxNotes
            // 
            this.boxNotes.Controls.Add(this.rtbMyNotes);
            this.boxNotes.Controls.Add(this.rtbSysNotes);
            this.boxNotes.Controls.Add(this.lblMyNotes);
            this.boxNotes.Controls.Add(this.lblSysNotes);
            this.boxNotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.boxNotes.Location = new System.Drawing.Point(372, 0);
            this.boxNotes.Name = "boxNotes";
            this.boxNotes.Size = new System.Drawing.Size(382, 327);
            this.boxNotes.TabIndex = 1;
            this.boxNotes.TabStop = false;
            this.boxNotes.Text = "Notes";
            // 
            // rtbMyNotes
            // 
            this.rtbMyNotes.Location = new System.Drawing.Point(6, 188);
            this.rtbMyNotes.Name = "rtbMyNotes";
            this.rtbMyNotes.Size = new System.Drawing.Size(370, 130);
            this.rtbMyNotes.TabIndex = 1;
            this.rtbMyNotes.Text = "";
            this.rtbMyNotes.Leave += new System.EventHandler(this.rtbMyNotes_Leave);
            // 
            // rtbSysNotes
            // 
            this.rtbSysNotes.Location = new System.Drawing.Point(6, 30);
            this.rtbSysNotes.Name = "rtbSysNotes";
            this.rtbSysNotes.Size = new System.Drawing.Size(370, 130);
            this.rtbSysNotes.TabIndex = 0;
            this.rtbSysNotes.Text = "";
            this.rtbSysNotes.Leave += new System.EventHandler(this.rtbSysNotes_Leave);
            // 
            // lblMyNotes
            // 
            this.lblMyNotes.AutoSize = true;
            this.lblMyNotes.Location = new System.Drawing.Point(3, 172);
            this.lblMyNotes.Name = "lblMyNotes";
            this.lblMyNotes.Size = new System.Drawing.Size(76, 13);
            this.lblMyNotes.TabIndex = 2;
            this.lblMyNotes.Text = "[users]\'s Notes";
            // 
            // lblSysNotes
            // 
            this.lblSysNotes.AutoSize = true;
            this.lblSysNotes.Location = new System.Drawing.Point(3, 14);
            this.lblSysNotes.Name = "lblSysNotes";
            this.lblSysNotes.Size = new System.Drawing.Size(68, 13);
            this.lblSysNotes.TabIndex = 0;
            this.lblSysNotes.Text = "Global Notes";
            // 
            // boxStatus
            // 
            this.boxStatus.Controls.Add(this.label13);
            this.boxStatus.Controls.Add(this.label12);
            this.boxStatus.Controls.Add(this.pbStatusDatabase);
            this.boxStatus.Controls.Add(this.label11);
            this.boxStatus.Controls.Add(this.label6);
            this.boxStatus.Controls.Add(this.pbStatusProgram);
            this.boxStatus.Controls.Add(this.lblStatusProgram);
            this.boxStatus.Controls.Add(this.pbStatusWeb);
            this.boxStatus.Controls.Add(this.lblStatusWeb);
            this.boxStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.boxStatus.Location = new System.Drawing.Point(372, 0);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(382, 285);
            this.boxStatus.TabIndex = 0;
            this.boxStatus.TabStop = false;
            this.boxStatus.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Logged in on [machine] from user [winuser]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Built [builddate]";
            // 
            // pbStatusDatabase
            // 
            this.pbStatusDatabase.Location = new System.Drawing.Point(113, 31);
            this.pbStatusDatabase.Name = "pbStatusDatabase";
            this.pbStatusDatabase.Size = new System.Drawing.Size(20, 20);
            this.pbStatusDatabase.TabIndex = 18;
            this.pbStatusDatabase.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Currently running version [version]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Database";
            // 
            // pbStatusProgram
            // 
            this.pbStatusProgram.Location = new System.Drawing.Point(113, 53);
            this.pbStatusProgram.Name = "pbStatusProgram";
            this.pbStatusProgram.Size = new System.Drawing.Size(20, 20);
            this.pbStatusProgram.TabIndex = 16;
            this.pbStatusProgram.TabStop = false;
            // 
            // lblStatusProgram
            // 
            this.lblStatusProgram.AutoSize = true;
            this.lblStatusProgram.Location = new System.Drawing.Point(16, 60);
            this.lblStatusProgram.Name = "lblStatusProgram";
            this.lblStatusProgram.Size = new System.Drawing.Size(86, 13);
            this.lblStatusProgram.TabIndex = 1;
            this.lblStatusProgram.Text = "House Organiser";
            // 
            // pbStatusWeb
            // 
            this.pbStatusWeb.Location = new System.Drawing.Point(113, 75);
            this.pbStatusWeb.Name = "pbStatusWeb";
            this.pbStatusWeb.Size = new System.Drawing.Size(20, 20);
            this.pbStatusWeb.TabIndex = 14;
            this.pbStatusWeb.TabStop = false;
            this.pbStatusWeb.Click += new System.EventHandler(this.pbStatusWeb_Click);
            // 
            // lblStatusWeb
            // 
            this.lblStatusWeb.AutoSize = true;
            this.lblStatusWeb.Location = new System.Drawing.Point(16, 82);
            this.lblStatusWeb.Name = "lblStatusWeb";
            this.lblStatusWeb.Size = new System.Drawing.Size(91, 13);
            this.lblStatusWeb.TabIndex = 2;
            this.lblStatusWeb.Text = "Ralegh Webpage";
            // 
            // boxStatistics
            // 
            this.boxStatistics.Controls.Add(this.label5);
            this.boxStatistics.Controls.Add(this.lblStatAllTables);
            this.boxStatistics.Controls.Add(this.lblStatLogs);
            this.boxStatistics.Controls.Add(this.lblStatSubjects);
            this.boxStatistics.Controls.Add(this.lblStatStudents);
            this.boxStatistics.Controls.Add(this.lblStatAdmins);
            this.boxStatistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxStatistics.Location = new System.Drawing.Point(0, 0);
            this.boxStatistics.Name = "boxStatistics";
            this.boxStatistics.Size = new System.Drawing.Size(366, 285);
            this.boxStatistics.TabIndex = 1;
            this.boxStatistics.TabStop = false;
            this.boxStatistics.Text = "Statistics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current Database Size [size]kb";
            // 
            // lblStatAllTables
            // 
            this.lblStatAllTables.AutoSize = true;
            this.lblStatAllTables.Location = new System.Drawing.Point(17, 140);
            this.lblStatAllTables.Name = "lblStatAllTables";
            this.lblStatAllTables.Size = new System.Drawing.Size(179, 13);
            this.lblStatAllTables.TabIndex = 4;
            this.lblStatAllTables.Text = "Currently [count] Tables in Database";
            // 
            // lblStatLogs
            // 
            this.lblStatLogs.AutoSize = true;
            this.lblStatLogs.Location = new System.Drawing.Point(17, 97);
            this.lblStatLogs.Name = "lblStatLogs";
            this.lblStatLogs.Size = new System.Drawing.Size(135, 13);
            this.lblStatLogs.TabIndex = 3;
            this.lblStatLogs.Text = "Currently [count] log entries";
            // 
            // lblStatSubjects
            // 
            this.lblStatSubjects.AutoSize = true;
            this.lblStatSubjects.Location = new System.Drawing.Point(17, 75);
            this.lblStatSubjects.Name = "lblStatSubjects";
            this.lblStatSubjects.Size = new System.Drawing.Size(126, 13);
            this.lblStatSubjects.TabIndex = 2;
            this.lblStatSubjects.Text = "Currently [count] subjects";
            // 
            // lblStatStudents
            // 
            this.lblStatStudents.AutoSize = true;
            this.lblStatStudents.Location = new System.Drawing.Point(17, 53);
            this.lblStatStudents.Name = "lblStatStudents";
            this.lblStatStudents.Size = new System.Drawing.Size(127, 13);
            this.lblStatStudents.TabIndex = 1;
            this.lblStatStudents.Text = "Currently [count] students";
            // 
            // lblStatAdmins
            // 
            this.lblStatAdmins.AutoSize = true;
            this.lblStatAdmins.Location = new System.Drawing.Point(17, 31);
            this.lblStatAdmins.Name = "lblStatAdmins";
            this.lblStatAdmins.Size = new System.Drawing.Size(120, 13);
            this.lblStatAdmins.TabIndex = 0;
            this.lblStatAdmins.Text = "Currently [count] admins";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabAdmin);
            this.tabMain.Controls.Add(this.tabStudents);
            this.tabMain.Controls.Add(this.tabCategories);
            this.tabMain.Controls.Add(this.tabAwards);
            this.tabMain.Controls.Add(this.tabAttributes);
            this.tabMain.Controls.Add(this.tabReports);
            this.tabMain.Controls.Add(this.tabLog);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabInternet);
            this.tabMain.Location = new System.Drawing.Point(0, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(768, 648);
            this.tabMain.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.AccessibleName = "Categories Tab";
            this.tabCategories.Controls.Add(this.splitContainer2);
            this.tabCategories.Location = new System.Drawing.Point(4, 22);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(760, 622);
            this.tabCategories.TabIndex = 11;
            this.tabCategories.Text = "Categories";
            this.tabCategories.ToolTipText = "Access to Year Groups and Subjects";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvYears);
            this.splitContainer2.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvSubjects);
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(754, 616);
            this.splitContainer2.SplitterDistance = 377;
            this.splitContainer2.TabIndex = 3;
            // 
            // dgvYears
            // 
            this.dgvYears.AllowUserToAddRows = false;
            this.dgvYears.AllowUserToDeleteRows = false;
            this.dgvYears.AutoGenerateColumns = false;
            this.dgvYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYears.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearIDDataGridViewTextBoxColumn1,
            this.yearNameDataGridViewTextBoxColumn});
            this.dgvYears.DataSource = this.yeargroupsBindingSource;
            this.dgvYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYears.Location = new System.Drawing.Point(0, 91);
            this.dgvYears.Name = "dgvYears";
            this.dgvYears.ReadOnly = true;
            this.dgvYears.Size = new System.Drawing.Size(377, 525);
            this.dgvYears.TabIndex = 0;
            this.dgvYears.SelectionChanged += new System.EventHandler(this.dgvYears_SelectionChanged);
            // 
            // yearIDDataGridViewTextBoxColumn1
            // 
            this.yearIDDataGridViewTextBoxColumn1.DataPropertyName = "Year ID";
            this.yearIDDataGridViewTextBoxColumn1.HeaderText = "Year ID";
            this.yearIDDataGridViewTextBoxColumn1.Name = "yearIDDataGridViewTextBoxColumn1";
            this.yearIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearNameDataGridViewTextBoxColumn
            // 
            this.yearNameDataGridViewTextBoxColumn.DataPropertyName = "Year Name";
            this.yearNameDataGridViewTextBoxColumn.HeaderText = "Year Name";
            this.yearNameDataGridViewTextBoxColumn.Name = "yearNameDataGridViewTextBoxColumn";
            this.yearNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.boxYears);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 91);
            this.panel6.TabIndex = 1;
            // 
            // boxYears
            // 
            this.boxYears.Controls.Add(this.label9);
            this.boxYears.Controls.Add(this.txtYearSelected);
            this.boxYears.Controls.Add(this.btnYearDelete);
            this.boxYears.Controls.Add(this.btnYearSave);
            this.boxYears.Controls.Add(this.label4);
            this.boxYears.Controls.Add(this.txtYearNew);
            this.boxYears.Controls.Add(this.btnYearClear);
            this.boxYears.Controls.Add(this.btnYearAdd);
            this.boxYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxYears.Location = new System.Drawing.Point(0, 0);
            this.boxYears.Name = "boxYears";
            this.boxYears.Size = new System.Drawing.Size(377, 91);
            this.boxYears.TabIndex = 0;
            this.boxYears.TabStop = false;
            this.boxYears.Text = "Year Groups";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Selected";
            // 
            // txtYearSelected
            // 
            this.txtYearSelected.Location = new System.Drawing.Point(57, 48);
            this.txtYearSelected.Name = "txtYearSelected";
            this.txtYearSelected.Size = new System.Drawing.Size(146, 20);
            this.txtYearSelected.TabIndex = 3;
            this.txtYearSelected.TextChanged += new System.EventHandler(this.txtYearSelected_TextChanged);
            // 
            // btnYearDelete
            // 
            this.btnYearDelete.Location = new System.Drawing.Point(290, 48);
            this.btnYearDelete.Name = "btnYearDelete";
            this.btnYearDelete.Size = new System.Drawing.Size(75, 23);
            this.btnYearDelete.TabIndex = 5;
            this.btnYearDelete.Text = "Delete";
            this.btnYearDelete.UseVisualStyleBackColor = true;
            this.btnYearDelete.Click += new System.EventHandler(this.btnYearDelete_Click);
            // 
            // btnYearSave
            // 
            this.btnYearSave.Location = new System.Drawing.Point(209, 48);
            this.btnYearSave.Name = "btnYearSave";
            this.btnYearSave.Size = new System.Drawing.Size(75, 23);
            this.btnYearSave.TabIndex = 4;
            this.btnYearSave.Text = "Save";
            this.btnYearSave.UseVisualStyleBackColor = true;
            this.btnYearSave.Click += new System.EventHandler(this.btnYearSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New";
            // 
            // txtYearNew
            // 
            this.txtYearNew.Location = new System.Drawing.Point(57, 19);
            this.txtYearNew.Name = "txtYearNew";
            this.txtYearNew.Size = new System.Drawing.Size(146, 20);
            this.txtYearNew.TabIndex = 0;
            this.txtYearNew.TextChanged += new System.EventHandler(this.txtYearNew_TextChanged);
            // 
            // btnYearClear
            // 
            this.btnYearClear.Location = new System.Drawing.Point(290, 19);
            this.btnYearClear.Name = "btnYearClear";
            this.btnYearClear.Size = new System.Drawing.Size(75, 23);
            this.btnYearClear.TabIndex = 2;
            this.btnYearClear.Text = "Clear";
            this.btnYearClear.UseVisualStyleBackColor = true;
            this.btnYearClear.Click += new System.EventHandler(this.btnYearClear_Click);
            // 
            // btnYearAdd
            // 
            this.btnYearAdd.Enabled = false;
            this.btnYearAdd.Location = new System.Drawing.Point(209, 19);
            this.btnYearAdd.Name = "btnYearAdd";
            this.btnYearAdd.Size = new System.Drawing.Size(75, 23);
            this.btnYearAdd.TabIndex = 1;
            this.btnYearAdd.Text = "Add";
            this.btnYearAdd.UseVisualStyleBackColor = true;
            this.btnYearAdd.Click += new System.EventHandler(this.btnYearAdd_Click);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoGenerateColumns = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDDataGridViewTextBoxColumn2,
            this.subjectNameDataGridViewTextBoxColumn1});
            this.dgvSubjects.DataSource = this.subjectsBindingSource;
            this.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjects.Location = new System.Drawing.Point(0, 91);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.Size = new System.Drawing.Size(373, 525);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.SelectionChanged += new System.EventHandler(this.dgvSubjects_SelectionChanged);
            // 
            // subjectIDDataGridViewTextBoxColumn2
            // 
            this.subjectIDDataGridViewTextBoxColumn2.DataPropertyName = "Subject ID";
            this.subjectIDDataGridViewTextBoxColumn2.HeaderText = "Subject ID";
            this.subjectIDDataGridViewTextBoxColumn2.Name = "subjectIDDataGridViewTextBoxColumn2";
            this.subjectIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // subjectNameDataGridViewTextBoxColumn1
            // 
            this.subjectNameDataGridViewTextBoxColumn1.DataPropertyName = "Subject Name";
            this.subjectNameDataGridViewTextBoxColumn1.HeaderText = "Subject Name";
            this.subjectNameDataGridViewTextBoxColumn1.Name = "subjectNameDataGridViewTextBoxColumn1";
            this.subjectNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.boxSubjects);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 91);
            this.panel5.TabIndex = 2;
            // 
            // boxSubjects
            // 
            this.boxSubjects.Controls.Add(this.label10);
            this.boxSubjects.Controls.Add(this.txtSubjectSelected);
            this.boxSubjects.Controls.Add(this.btnSubjectDelete);
            this.boxSubjects.Controls.Add(this.btnSubjectSave);
            this.boxSubjects.Controls.Add(this.label8);
            this.boxSubjects.Controls.Add(this.txtSubjectNew);
            this.boxSubjects.Controls.Add(this.btnSubjectClear);
            this.boxSubjects.Controls.Add(this.btnSubjectAdd);
            this.boxSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxSubjects.Location = new System.Drawing.Point(0, 0);
            this.boxSubjects.Name = "boxSubjects";
            this.boxSubjects.Size = new System.Drawing.Size(373, 91);
            this.boxSubjects.TabIndex = 1;
            this.boxSubjects.TabStop = false;
            this.boxSubjects.Text = "Subjects";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Selected";
            // 
            // txtSubjectSelected
            // 
            this.txtSubjectSelected.Location = new System.Drawing.Point(57, 48);
            this.txtSubjectSelected.Name = "txtSubjectSelected";
            this.txtSubjectSelected.Size = new System.Drawing.Size(141, 20);
            this.txtSubjectSelected.TabIndex = 3;
            this.txtSubjectSelected.TextChanged += new System.EventHandler(this.txtSubjectSelected_TextChanged);
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.Location = new System.Drawing.Point(285, 48);
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectDelete.TabIndex = 5;
            this.btnSubjectDelete.Text = "Delete";
            this.btnSubjectDelete.UseVisualStyleBackColor = true;
            this.btnSubjectDelete.Click += new System.EventHandler(this.btnSubjectDelete_Click);
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.Location = new System.Drawing.Point(204, 48);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectSave.TabIndex = 4;
            this.btnSubjectSave.Text = "Save";
            this.btnSubjectSave.UseVisualStyleBackColor = true;
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "New";
            // 
            // txtSubjectNew
            // 
            this.txtSubjectNew.Location = new System.Drawing.Point(57, 19);
            this.txtSubjectNew.Name = "txtSubjectNew";
            this.txtSubjectNew.Size = new System.Drawing.Size(141, 20);
            this.txtSubjectNew.TabIndex = 0;
            this.txtSubjectNew.TextChanged += new System.EventHandler(this.txtSubjectNew_TextChanged);
            // 
            // btnSubjectClear
            // 
            this.btnSubjectClear.Location = new System.Drawing.Point(285, 19);
            this.btnSubjectClear.Name = "btnSubjectClear";
            this.btnSubjectClear.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectClear.TabIndex = 2;
            this.btnSubjectClear.Text = "Clear";
            this.btnSubjectClear.UseVisualStyleBackColor = true;
            this.btnSubjectClear.Click += new System.EventHandler(this.btnSubjectClear_Click);
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.Enabled = false;
            this.btnSubjectAdd.Location = new System.Drawing.Point(204, 19);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSubjectAdd.TabIndex = 1;
            this.btnSubjectAdd.Text = "Add";
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.btnSubjectAdd_Click);
            // 
            // tabAwards
            // 
            this.tabAwards.AccessibleName = "Awards Tab";
            this.tabAwards.Controls.Add(this.splitContainer3);
            this.tabAwards.Location = new System.Drawing.Point(4, 22);
            this.tabAwards.Name = "tabAwards";
            this.tabAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tabAwards.Size = new System.Drawing.Size(760, 622);
            this.tabAwards.TabIndex = 10;
            this.tabAwards.Text = "Awards";
            this.tabAwards.ToolTipText = "Access to Commendation and Certificate Types";
            this.tabAwards.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvCommendations);
            this.splitContainer3.Panel1.Controls.Add(this.panel10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvCertificates);
            this.splitContainer3.Panel2.Controls.Add(this.panel11);
            this.splitContainer3.Size = new System.Drawing.Size(754, 616);
            this.splitContainer3.SplitterDistance = 377;
            this.splitContainer3.TabIndex = 4;
            // 
            // dgvCommendations
            // 
            this.dgvCommendations.AllowUserToAddRows = false;
            this.dgvCommendations.AllowUserToDeleteRows = false;
            this.dgvCommendations.AutoGenerateColumns = false;
            this.dgvCommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommendations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIDDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dgvCommendations.DataSource = this.commendationTypesBindingSource;
            this.dgvCommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommendations.Location = new System.Drawing.Point(0, 132);
            this.dgvCommendations.Name = "dgvCommendations";
            this.dgvCommendations.ReadOnly = true;
            this.dgvCommendations.Size = new System.Drawing.Size(377, 484);
            this.dgvCommendations.TabIndex = 0;
            this.dgvCommendations.SelectionChanged += new System.EventHandler(this.dgvCommendations_SelectionChanged);
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "Type ID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "Type ID";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "Type Name";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Type Name";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // commendationTypesBindingSource
            // 
            this.commendationTypesBindingSource.DataMember = "Commendation Types";
            this.commendationTypesBindingSource.DataSource = this.dsMain;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.boxCommendationTypes);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(377, 132);
            this.panel10.TabIndex = 1;
            // 
            // boxCommendationTypes
            // 
            this.boxCommendationTypes.Controls.Add(this.btnCommendationDelete);
            this.boxCommendationTypes.Controls.Add(this.btnCommendationSave);
            this.boxCommendationTypes.Controls.Add(this.txtCommendationSelectedDesc);
            this.boxCommendationTypes.Controls.Add(this.txtCommendationSelectedName);
            this.boxCommendationTypes.Controls.Add(this.label18);
            this.boxCommendationTypes.Controls.Add(this.label19);
            this.boxCommendationTypes.Controls.Add(this.btnCommendationClear);
            this.boxCommendationTypes.Controls.Add(this.btnCommendationAdd);
            this.boxCommendationTypes.Controls.Add(this.txtCommendationNewDesc);
            this.boxCommendationTypes.Controls.Add(this.txtCommendationNewName);
            this.boxCommendationTypes.Controls.Add(this.label14);
            this.boxCommendationTypes.Controls.Add(this.label15);
            this.boxCommendationTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxCommendationTypes.Location = new System.Drawing.Point(0, 0);
            this.boxCommendationTypes.Name = "boxCommendationTypes";
            this.boxCommendationTypes.Size = new System.Drawing.Size(377, 132);
            this.boxCommendationTypes.TabIndex = 0;
            this.boxCommendationTypes.TabStop = false;
            this.boxCommendationTypes.Text = "Commendation Types";
            // 
            // btnCommendationDelete
            // 
            this.btnCommendationDelete.Location = new System.Drawing.Point(290, 72);
            this.btnCommendationDelete.Name = "btnCommendationDelete";
            this.btnCommendationDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCommendationDelete.TabIndex = 11;
            this.btnCommendationDelete.Text = "Delete";
            this.btnCommendationDelete.UseVisualStyleBackColor = true;
            this.btnCommendationDelete.Click += new System.EventHandler(this.btnCommendationDelete_Click);
            // 
            // btnCommendationSave
            // 
            this.btnCommendationSave.Location = new System.Drawing.Point(209, 72);
            this.btnCommendationSave.Name = "btnCommendationSave";
            this.btnCommendationSave.Size = new System.Drawing.Size(75, 23);
            this.btnCommendationSave.TabIndex = 10;
            this.btnCommendationSave.Text = "Save";
            this.btnCommendationSave.UseVisualStyleBackColor = true;
            this.btnCommendationSave.Click += new System.EventHandler(this.btnCommendationSave_Click);
            // 
            // txtCommendationSelectedDesc
            // 
            this.txtCommendationSelectedDesc.Location = new System.Drawing.Point(72, 102);
            this.txtCommendationSelectedDesc.Name = "txtCommendationSelectedDesc";
            this.txtCommendationSelectedDesc.Size = new System.Drawing.Size(293, 20);
            this.txtCommendationSelectedDesc.TabIndex = 9;
            this.txtCommendationSelectedDesc.TextChanged += new System.EventHandler(this.CommendationSelectedTxtChanged);
            // 
            // txtCommendationSelectedName
            // 
            this.txtCommendationSelectedName.Location = new System.Drawing.Point(72, 75);
            this.txtCommendationSelectedName.Name = "txtCommendationSelectedName";
            this.txtCommendationSelectedName.Size = new System.Drawing.Size(131, 20);
            this.txtCommendationSelectedName.TabIndex = 8;
            this.txtCommendationSelectedName.TextChanged += new System.EventHandler(this.CommendationSelectedTxtChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Name";
            // 
            // btnCommendationClear
            // 
            this.btnCommendationClear.Location = new System.Drawing.Point(290, 16);
            this.btnCommendationClear.Name = "btnCommendationClear";
            this.btnCommendationClear.Size = new System.Drawing.Size(75, 23);
            this.btnCommendationClear.TabIndex = 3;
            this.btnCommendationClear.Text = "Clear";
            this.btnCommendationClear.UseVisualStyleBackColor = true;
            this.btnCommendationClear.Click += new System.EventHandler(this.btnCommendationClear_Click);
            // 
            // btnCommendationAdd
            // 
            this.btnCommendationAdd.Enabled = false;
            this.btnCommendationAdd.Location = new System.Drawing.Point(209, 16);
            this.btnCommendationAdd.Name = "btnCommendationAdd";
            this.btnCommendationAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCommendationAdd.TabIndex = 2;
            this.btnCommendationAdd.Text = "Add";
            this.btnCommendationAdd.UseVisualStyleBackColor = true;
            this.btnCommendationAdd.Click += new System.EventHandler(this.btnCommendationAdd_Click);
            // 
            // txtCommendationNewDesc
            // 
            this.txtCommendationNewDesc.Location = new System.Drawing.Point(72, 46);
            this.txtCommendationNewDesc.Name = "txtCommendationNewDesc";
            this.txtCommendationNewDesc.Size = new System.Drawing.Size(293, 20);
            this.txtCommendationNewDesc.TabIndex = 1;
            this.txtCommendationNewDesc.TextChanged += new System.EventHandler(this.CommendationNewTxtChanged);
            // 
            // txtCommendationNewName
            // 
            this.txtCommendationNewName.Location = new System.Drawing.Point(72, 19);
            this.txtCommendationNewName.Name = "txtCommendationNewName";
            this.txtCommendationNewName.Size = new System.Drawing.Size(131, 20);
            this.txtCommendationNewName.TabIndex = 0;
            this.txtCommendationNewName.TextChanged += new System.EventHandler(this.CommendationNewTxtChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Name";
            // 
            // dgvCertificates
            // 
            this.dgvCertificates.AllowUserToAddRows = false;
            this.dgvCertificates.AllowUserToDeleteRows = false;
            this.dgvCertificates.AutoGenerateColumns = false;
            this.dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.certIDDataGridViewTextBoxColumn,
            this.certNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn2});
            this.dgvCertificates.DataSource = this.certificateTypesBindingSource;
            this.dgvCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCertificates.Location = new System.Drawing.Point(0, 132);
            this.dgvCertificates.Name = "dgvCertificates";
            this.dgvCertificates.ReadOnly = true;
            this.dgvCertificates.Size = new System.Drawing.Size(373, 484);
            this.dgvCertificates.TabIndex = 0;
            this.dgvCertificates.SelectionChanged += new System.EventHandler(this.dgvCertificates_SelectionChanged);
            // 
            // certIDDataGridViewTextBoxColumn
            // 
            this.certIDDataGridViewTextBoxColumn.DataPropertyName = "Cert ID";
            this.certIDDataGridViewTextBoxColumn.HeaderText = "Cert ID";
            this.certIDDataGridViewTextBoxColumn.Name = "certIDDataGridViewTextBoxColumn";
            this.certIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certNameDataGridViewTextBoxColumn
            // 
            this.certNameDataGridViewTextBoxColumn.DataPropertyName = "Cert Name";
            this.certNameDataGridViewTextBoxColumn.HeaderText = "Cert Name";
            this.certNameDataGridViewTextBoxColumn.Name = "certNameDataGridViewTextBoxColumn";
            this.certNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // certificateTypesBindingSource
            // 
            this.certificateTypesBindingSource.DataMember = "Certificate Types";
            this.certificateTypesBindingSource.DataSource = this.dsMain;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.boxCertificateTypes);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(373, 132);
            this.panel11.TabIndex = 2;
            // 
            // boxCertificateTypes
            // 
            this.boxCertificateTypes.Controls.Add(this.btnCertificateDelete);
            this.boxCertificateTypes.Controls.Add(this.btnCertificateSave);
            this.boxCertificateTypes.Controls.Add(this.txtCertificateSelectedDesc);
            this.boxCertificateTypes.Controls.Add(this.txtCertificateSelectedName);
            this.boxCertificateTypes.Controls.Add(this.label20);
            this.boxCertificateTypes.Controls.Add(this.label21);
            this.boxCertificateTypes.Controls.Add(this.btnCertificateClear);
            this.boxCertificateTypes.Controls.Add(this.btnCertificateAdd);
            this.boxCertificateTypes.Controls.Add(this.txtCertificateNewDesc);
            this.boxCertificateTypes.Controls.Add(this.txtCertificateNewName);
            this.boxCertificateTypes.Controls.Add(this.label16);
            this.boxCertificateTypes.Controls.Add(this.label17);
            this.boxCertificateTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxCertificateTypes.Location = new System.Drawing.Point(0, 0);
            this.boxCertificateTypes.Name = "boxCertificateTypes";
            this.boxCertificateTypes.Size = new System.Drawing.Size(373, 132);
            this.boxCertificateTypes.TabIndex = 1;
            this.boxCertificateTypes.TabStop = false;
            this.boxCertificateTypes.Text = "Certificate Types";
            // 
            // btnCertificateDelete
            // 
            this.btnCertificateDelete.Location = new System.Drawing.Point(288, 68);
            this.btnCertificateDelete.Name = "btnCertificateDelete";
            this.btnCertificateDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCertificateDelete.TabIndex = 17;
            this.btnCertificateDelete.Text = "Delete";
            this.btnCertificateDelete.UseVisualStyleBackColor = true;
            this.btnCertificateDelete.Click += new System.EventHandler(this.btnCertificateDelete_Click);
            // 
            // btnCertificateSave
            // 
            this.btnCertificateSave.Location = new System.Drawing.Point(207, 68);
            this.btnCertificateSave.Name = "btnCertificateSave";
            this.btnCertificateSave.Size = new System.Drawing.Size(75, 23);
            this.btnCertificateSave.TabIndex = 16;
            this.btnCertificateSave.Text = "Save";
            this.btnCertificateSave.UseVisualStyleBackColor = true;
            this.btnCertificateSave.Click += new System.EventHandler(this.btnCertificateSave_Click);
            // 
            // txtCertificateSelectedDesc
            // 
            this.txtCertificateSelectedDesc.Location = new System.Drawing.Point(70, 98);
            this.txtCertificateSelectedDesc.Name = "txtCertificateSelectedDesc";
            this.txtCertificateSelectedDesc.Size = new System.Drawing.Size(293, 20);
            this.txtCertificateSelectedDesc.TabIndex = 15;
            this.txtCertificateSelectedDesc.TextChanged += new System.EventHandler(this.CertificateSelectedTxtChanged);
            // 
            // txtCertificateSelectedName
            // 
            this.txtCertificateSelectedName.Location = new System.Drawing.Point(70, 71);
            this.txtCertificateSelectedName.Name = "txtCertificateSelectedName";
            this.txtCertificateSelectedName.Size = new System.Drawing.Size(131, 20);
            this.txtCertificateSelectedName.TabIndex = 14;
            this.txtCertificateSelectedName.TextChanged += new System.EventHandler(this.CertificateSelectedTxtChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Description";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Name";
            // 
            // btnCertificateClear
            // 
            this.btnCertificateClear.Location = new System.Drawing.Point(288, 16);
            this.btnCertificateClear.Name = "btnCertificateClear";
            this.btnCertificateClear.Size = new System.Drawing.Size(75, 23);
            this.btnCertificateClear.TabIndex = 3;
            this.btnCertificateClear.Text = "Clear";
            this.btnCertificateClear.UseVisualStyleBackColor = true;
            this.btnCertificateClear.Click += new System.EventHandler(this.btnCertificateClear_Click);
            // 
            // btnCertificateAdd
            // 
            this.btnCertificateAdd.Enabled = false;
            this.btnCertificateAdd.Location = new System.Drawing.Point(207, 16);
            this.btnCertificateAdd.Name = "btnCertificateAdd";
            this.btnCertificateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCertificateAdd.TabIndex = 2;
            this.btnCertificateAdd.Text = "Add";
            this.btnCertificateAdd.UseVisualStyleBackColor = true;
            this.btnCertificateAdd.Click += new System.EventHandler(this.btnCertificateAdd_Click);
            // 
            // txtCertificateNewDesc
            // 
            this.txtCertificateNewDesc.Location = new System.Drawing.Point(70, 46);
            this.txtCertificateNewDesc.Name = "txtCertificateNewDesc";
            this.txtCertificateNewDesc.Size = new System.Drawing.Size(293, 20);
            this.txtCertificateNewDesc.TabIndex = 1;
            this.txtCertificateNewDesc.TextChanged += new System.EventHandler(this.CertificateNewTxtChanged);
            // 
            // txtCertificateNewName
            // 
            this.txtCertificateNewName.Location = new System.Drawing.Point(70, 19);
            this.txtCertificateNewName.Name = "txtCertificateNewName";
            this.txtCertificateNewName.Size = new System.Drawing.Size(131, 20);
            this.txtCertificateNewName.TabIndex = 0;
            this.txtCertificateNewName.TextChanged += new System.EventHandler(this.CertificateNewTxtChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Description";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Name";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.groupBox2);
            this.tabReports.Controls.Add(this.groupBox1);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(760, 622);
            this.tabReports.TabIndex = 12;
            this.tabReports.Text = "Reports";
            this.tabReports.ToolTipText = "Acccess to Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReportPrintStudent);
            this.groupBox2.Controls.Add(this.lblReportCount);
            this.groupBox2.Controls.Add(this.lbReports);
            this.groupBox2.Controls.Add(this.btnReportsRemove);
            this.groupBox2.Controls.Add(this.rbReportsEffort);
            this.groupBox2.Controls.Add(this.rbReportsCommendation);
            this.groupBox2.Controls.Add(this.rbReportsCertificate);
            this.groupBox2.Location = new System.Drawing.Point(175, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 610);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - What?";
            // 
            // btnReportPrintStudent
            // 
            this.btnReportPrintStudent.Location = new System.Drawing.Point(497, 16);
            this.btnReportPrintStudent.Name = "btnReportPrintStudent";
            this.btnReportPrintStudent.Size = new System.Drawing.Size(75, 23);
            this.btnReportPrintStudent.TabIndex = 8;
            this.btnReportPrintStudent.Text = "Print";
            this.btnReportPrintStudent.UseVisualStyleBackColor = true;
            this.btnReportPrintStudent.Click += new System.EventHandler(this.btnReportPrintStudent_Click);
            // 
            // lblReportCount
            // 
            this.lblReportCount.AutoSize = true;
            this.lblReportCount.Location = new System.Drawing.Point(290, 22);
            this.lblReportCount.Name = "lblReportCount";
            this.lblReportCount.Size = new System.Drawing.Size(74, 13);
            this.lblReportCount.TabIndex = 7;
            this.lblReportCount.Text = "Total 0 entires";
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.Location = new System.Drawing.Point(6, 46);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(566, 550);
            this.lbReports.TabIndex = 6;
            this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
            // 
            // btnReportsRemove
            // 
            this.btnReportsRemove.Location = new System.Drawing.Point(370, 16);
            this.btnReportsRemove.Name = "btnReportsRemove";
            this.btnReportsRemove.Size = new System.Drawing.Size(121, 23);
            this.btnReportsRemove.TabIndex = 2;
            this.btnReportsRemove.Text = "Remove Selected";
            this.btnReportsRemove.UseVisualStyleBackColor = true;
            this.btnReportsRemove.Click += new System.EventHandler(this.btnReportsRemove_Click);
            // 
            // rbReportsEffort
            // 
            this.rbReportsEffort.AutoSize = true;
            this.rbReportsEffort.Location = new System.Drawing.Point(185, 20);
            this.rbReportsEffort.Name = "rbReportsEffort";
            this.rbReportsEffort.Size = new System.Drawing.Size(82, 17);
            this.rbReportsEffort.TabIndex = 2;
            this.rbReportsEffort.TabStop = true;
            this.rbReportsEffort.Text = "Effort Grade";
            this.rbReportsEffort.UseVisualStyleBackColor = true;
            this.rbReportsEffort.CheckedChanged += new System.EventHandler(this.ReportVariablesChanged);
            // 
            // rbReportsCommendation
            // 
            this.rbReportsCommendation.AutoSize = true;
            this.rbReportsCommendation.Location = new System.Drawing.Point(84, 20);
            this.rbReportsCommendation.Name = "rbReportsCommendation";
            this.rbReportsCommendation.Size = new System.Drawing.Size(95, 17);
            this.rbReportsCommendation.TabIndex = 1;
            this.rbReportsCommendation.TabStop = true;
            this.rbReportsCommendation.Text = "Commendation";
            this.rbReportsCommendation.UseVisualStyleBackColor = true;
            this.rbReportsCommendation.CheckedChanged += new System.EventHandler(this.ReportVariablesChanged);
            // 
            // rbReportsCertificate
            // 
            this.rbReportsCertificate.AutoSize = true;
            this.rbReportsCertificate.Checked = true;
            this.rbReportsCertificate.Location = new System.Drawing.Point(6, 19);
            this.rbReportsCertificate.Name = "rbReportsCertificate";
            this.rbReportsCertificate.Size = new System.Drawing.Size(72, 17);
            this.rbReportsCertificate.TabIndex = 0;
            this.rbReportsCertificate.TabStop = true;
            this.rbReportsCertificate.Text = "Certificate";
            this.rbReportsCertificate.UseVisualStyleBackColor = true;
            this.rbReportsCertificate.CheckedChanged += new System.EventHandler(this.ReportVariablesChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbReportsWho);
            this.groupBox1.Controls.Add(this.cbReportsWho);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 610);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Who?";
            // 
            // lbReportsWho
            // 
            this.lbReportsWho.FormattingEnabled = true;
            this.lbReportsWho.Location = new System.Drawing.Point(6, 46);
            this.lbReportsWho.Name = "lbReportsWho";
            this.lbReportsWho.Size = new System.Drawing.Size(150, 550);
            this.lbReportsWho.TabIndex = 1;
            this.lbReportsWho.SelectedIndexChanged += new System.EventHandler(this.ReportVariablesChanged);
            // 
            // cbReportsWho
            // 
            this.cbReportsWho.DataSource = this.yeargroupsBindingSource;
            this.cbReportsWho.DisplayMember = "Year Name";
            this.cbReportsWho.FormattingEnabled = true;
            this.cbReportsWho.Location = new System.Drawing.Point(6, 19);
            this.cbReportsWho.Name = "cbReportsWho";
            this.cbReportsWho.Size = new System.Drawing.Size(150, 21);
            this.cbReportsWho.TabIndex = 0;
            this.cbReportsWho.ValueMember = "Year ID";
            this.cbReportsWho.SelectedIndexChanged += new System.EventHandler(this.cbReportsWho_SelectedIndexChanged);
            // 
            // effortgradesBindingSource
            // 
            this.effortgradesBindingSource.DataMember = "Effort Grades";
            this.effortgradesBindingSource.DataSource = this.dsMain;
            // 
            // effort_GradesTableAdapter
            // 
            this.effort_GradesTableAdapter.ClearBeforeFill = true;
            // 
            // year_GroupsTableAdapter
            // 
            this.year_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // commendation_TypesTableAdapter
            // 
            this.commendation_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // certificate_TypesTableAdapter
            // 
            this.certificate_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // certificatesBindingSource
            // 
            this.certificatesBindingSource.DataMember = "Certificates";
            this.certificatesBindingSource.DataSource = this.dsMain;
            // 
            // certificatesTableAdapter
            // 
            this.certificatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 667);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Organiser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commendationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.tabInternet.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.boxApperance.ResumeLayout(false);
            this.boxApperance.PerformLayout();
            this.boxSettings.ResumeLayout(false);
            this.boxSettings.PerformLayout();
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabAttributes.ResumeLayout(false);
            this.boxAttributesWhat.ResumeLayout(false);
            this.boxAttributesWhat.PerformLayout();
            this.boxAttributesWho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yeargroupsBindingSource)).EndInit();
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.boxAddStudents.ResumeLayout(false);
            this.boxAddStudents.PerformLayout();
            this.boxSelectedStudents.ResumeLayout(false);
            this.boxSelectedStudents.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.boxAddAdmin.ResumeLayout(false);
            this.boxAddAdmin.PerformLayout();
            this.boxSelectedAdmin.ResumeLayout(false);
            this.boxSelectedAdmin.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.boxHome.ResumeLayout(false);
            this.boxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeUser)).EndInit();
            this.boxNotes.ResumeLayout(false);
            this.boxNotes.PerformLayout();
            this.boxStatus.ResumeLayout(false);
            this.boxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusWeb)).EndInit();
            this.boxStatistics.ResumeLayout(false);
            this.boxStatistics.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabCategories.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYears)).EndInit();
            this.panel6.ResumeLayout(false);
            this.boxYears.ResumeLayout(false);
            this.boxYears.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panel5.ResumeLayout(false);
            this.boxSubjects.ResumeLayout(false);
            this.boxSubjects.PerformLayout();
            this.tabAwards.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommendations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commendationTypesBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.boxCommendationTypes.ResumeLayout(false);
            this.boxCommendationTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesBindingSource)).EndInit();
            this.panel11.ResumeLayout(false);
            this.boxCertificateTypes.ResumeLayout(false);
            this.boxCertificateTypes.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.effortgradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private dsMain dsMain;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private HouseSystem.dsMainTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private HouseSystem.dsMainTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private HouseSystem.dsMainTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource commendationsBindingSource;
        private HouseSystem.dsMainTableAdapters.CommendationsTableAdapter commendationsTableAdapter;
        private System.Windows.Forms.BindingSource logBindingSource;
        private HouseSystem.dsMainTableAdapters.LogTableAdapter logTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox boxAddSubjects;
        private System.Windows.Forms.TextBox txtAddSubjectName;
        private System.Windows.Forms.Label lblAddSubjectName;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnClearSubject;
        private System.Windows.Forms.GroupBox boxSelectedSubjects;
        private System.Windows.Forms.TextBox txtSelectedSubjectName;
        private System.Windows.Forms.Label lblSelectedSubjectName;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnHideSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabInternet;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExternalBrowser;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox boxSettings;
        private System.Windows.Forms.Button btnSettingsApply;
        private System.Windows.Forms.Button btnSettingsRevert;
        private System.Windows.Forms.TextBox txtSettingWebPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplaying;
        private System.Windows.Forms.TabPage tabAttributes;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox boxAddStudents;
        private System.Windows.Forms.Button btnStudentClear;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label lblStudentYear;
        private System.Windows.Forms.TextBox txtStudentAddYear;
        private System.Windows.Forms.Label lblStudentFullname;
        private System.Windows.Forms.TextBox txtStudentAddFullname;
        private System.Windows.Forms.GroupBox boxSelectedStudents;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentSelectedYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentSelectedFullname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHideStudents;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoggedInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHideAdmins;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox boxAddAdmin;
        private System.Windows.Forms.Label lblSecondName1;
        private System.Windows.Forms.TextBox txtAdminAddSecondName;
        private System.Windows.Forms.Button btnAdminClear;
        private System.Windows.Forms.Button btnAdminAdd;
        private System.Windows.Forms.Label lblPassword12;
        private System.Windows.Forms.TextBox txtAdminAddPassword2;
        private System.Windows.Forms.Label lblPassword11;
        private System.Windows.Forms.TextBox txtAdminAddPassword1;
        private System.Windows.Forms.Label lblUsername1;
        private System.Windows.Forms.TextBox txtAdminAddUsername;
        private System.Windows.Forms.Label lblFirstname1;
        private System.Windows.Forms.TextBox txtAdminAddFirstName;
        private System.Windows.Forms.GroupBox boxSelectedAdmin;
        private System.Windows.Forms.Label lblSecondName2;
        private System.Windows.Forms.TextBox txtAdminSelectedSecondName;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.Button btnAdminSave;
        private System.Windows.Forms.Label lblPassword22;
        private System.Windows.Forms.TextBox txtAdminSelectedPassword2;
        private System.Windows.Forms.Label lblPassword21;
        private System.Windows.Forms.TextBox txtAdminSelectedPassword1;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.TextBox txtAdminSelectedUsername;
        private System.Windows.Forms.Label lblFirstName2;
        private System.Windows.Forms.TextBox txtAdminSelectedFirstName;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox boxHome;
        private System.Windows.Forms.Button btnLockSession;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMeUser;
        private System.Windows.Forms.Label lblMeLoginDate;
        private System.Windows.Forms.Button btnChgPass;
        private System.Windows.Forms.PictureBox pbHomeUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox boxNotes;
        private System.Windows.Forms.RichTextBox rtbMyNotes;
        private System.Windows.Forms.RichTextBox rtbSysNotes;
        private System.Windows.Forms.Label lblMyNotes;
        private System.Windows.Forms.Label lblSysNotes;
        private System.Windows.Forms.GroupBox boxStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbStatusDatabase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbStatusProgram;
        private System.Windows.Forms.Label lblStatusProgram;
        private System.Windows.Forms.PictureBox pbStatusWeb;
        private System.Windows.Forms.Label lblStatusWeb;
        private System.Windows.Forms.GroupBox boxStatistics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatAllTables;
        private System.Windows.Forms.Label lblStatLogs;
        private System.Windows.Forms.Label lblStatSubjects;
        private System.Windows.Forms.Label lblStatStudents;
        private System.Windows.Forms.Label lblStatAdmins;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.BindingSource effortgradesBindingSource;
        private HouseSystem.dsMainTableAdapters.Effort_GradesTableAdapter effort_GradesTableAdapter;
        private System.Windows.Forms.BindingSource yeargroupsBindingSource;
        private HouseSystem.dsMainTableAdapters.Year_GroupsTableAdapter year_GroupsTableAdapter;
        private System.Windows.Forms.GroupBox boxAttributesWho;
        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.ListBox lbWho1;
        private System.Windows.Forms.GroupBox boxAttributesWhat;
        private System.Windows.Forms.RadioButton rbEffort;
        private System.Windows.Forms.RadioButton rbCommendation;
        private System.Windows.Forms.RadioButton rbCertificate;
        private System.Windows.Forms.Button btnattributesSave;
        private System.Windows.Forms.Button btnattributesClear;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvYears;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.TabPage tabAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox boxYears;
        private System.Windows.Forms.GroupBox boxSubjects;
        private System.Windows.Forms.Button btnYearClear;
        private System.Windows.Forms.Button btnYearAdd;
        private System.Windows.Forms.Button btnSubjectClear;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearSelected;
        private System.Windows.Forms.Button btnYearDelete;
        private System.Windows.Forms.Button btnYearSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYearNew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubjectSelected;
        private System.Windows.Forms.Button btnSubjectDelete;
        private System.Windows.Forms.Button btnSubjectSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubjectNew;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvCommendations;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox boxCommendationTypes;
        private System.Windows.Forms.DataGridView dgvCertificates;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.GroupBox boxCertificateTypes;
        private System.Windows.Forms.Button btnCommendationClear;
        private System.Windows.Forms.Button btnCommendationAdd;
        private System.Windows.Forms.TextBox txtCommendationNewDesc;
        private System.Windows.Forms.TextBox txtCommendationNewName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCertificateClear;
        private System.Windows.Forms.Button btnCertificateAdd;
        private System.Windows.Forms.TextBox txtCertificateNewDesc;
        private System.Windows.Forms.TextBox txtCertificateNewName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listSessionLog;
        private System.Windows.Forms.GroupBox boxApperance;
        private System.Windows.Forms.Button btnApperanceRevert;
        private System.Windows.Forms.Button btnApperanceApply;
        private System.Windows.Forms.CheckBox chkAppLog;
        private System.Windows.Forms.CheckBox chkAppWeb;
        private System.Windows.Forms.CheckBox chkAppClock;
        private System.Windows.Forms.Button btnDefaultApperance;
        private System.Windows.Forms.Button btnDefaultSettings;
        private System.Windows.Forms.Button btnCommendationDelete;
        private System.Windows.Forms.Button btnCommendationSave;
        private System.Windows.Forms.TextBox txtCommendationSelectedDesc;
        private System.Windows.Forms.TextBox txtCommendationSelectedName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCertificateDelete;
        private System.Windows.Forms.Button btnCertificateSave;
        private System.Windows.Forms.TextBox txtCertificateSelectedDesc;
        private System.Windows.Forms.TextBox txtCertificateSelectedName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.BindingSource commendationTypesBindingSource;
        private HouseSystem.dsMainTableAdapters.Commendation_TypesTableAdapter commendation_TypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource certificateTypesBindingSource;
        private HouseSystem.dsMainTableAdapters.Certificate_TypesTableAdapter certificate_TypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn certIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource certificatesBindingSource;
        private HouseSystem.dsMainTableAdapters.CertificatesTableAdapter certificatesTableAdapter;
        private System.Windows.Forms.ListBox lbWhat1;
        private System.Windows.Forms.ListBox lbWhat2;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbReports;
        private System.Windows.Forms.Button btnReportsRemove;
        private System.Windows.Forms.RadioButton rbReportsEffort;
        private System.Windows.Forms.RadioButton rbReportsCommendation;
        private System.Windows.Forms.RadioButton rbReportsCertificate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbReportsWho;
        private System.Windows.Forms.ComboBox cbReportsWho;
        private System.Windows.Forms.Label lblReportCount;
        private System.Windows.Forms.Button btnReportPrintStudent;
    }
}

