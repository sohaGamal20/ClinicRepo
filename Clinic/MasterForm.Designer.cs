namespace Clinic
{
    partial class MasterForm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabFollowUp = new System.Windows.Forms.TabControl();
            this.tabAddPatient = new System.Windows.Forms.TabPage();
            this.btn_CancelPatient = new System.Windows.Forms.Button();
            this.btn_savePatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAddPatientFees = new System.Windows.Forms.Label();
            this.rad_Diagnosis = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rad_Insurance = new System.Windows.Forms.RadioButton();
            this.rad_Cash = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rad_Female = new System.Windows.Forms.RadioButton();
            this.rad_Male = new System.Windows.Forms.RadioButton();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlInsurandeDetails = new System.Windows.Forms.Panel();
            this.lstInsuranceCompany = new System.Windows.Forms.ComboBox();
            this.txtInsuranceNumber = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSearchPatient = new System.Windows.Forms.TabPage();
            this.lblSearchPatientName = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblSearchFeesAmount = new System.Windows.Forms.Label();
            this.btn_SearchSaveNewData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rad_SearchConsultation = new System.Windows.Forms.RadioButton();
            this.rad_SearchDiagnosis = new System.Windows.Forms.RadioButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rad_SearchInsurance = new System.Windows.Forms.RadioButton();
            this.rad_SearchCash = new System.Windows.Forms.RadioButton();
            this.pnlSearchInsuranceOptions = new System.Windows.Forms.Panel();
            this.ddl_SearchInsuranceCompany = new System.Windows.Forms.ComboBox();
            this.txtSearchInsuranceNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblPatientsCount = new System.Windows.Forms.Label();
            this.lblSearchEmptyGrid = new System.Windows.Forms.Label();
            this.grdPatientSearchResult = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btn_SearchEmployee = new System.Windows.Forms.Button();
            this.txtSearchMobile = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSearchFirstname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPhysicalHistory = new System.Windows.Forms.TabPage();
            this.lblPhysicalHistory = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSavePhysicialHistory = new System.Windows.Forms.Button();
            this.lblRBS = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtRBS = new System.Windows.Forms.TextBox();
            this.txtPatientWeight = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtPatientHeight = new System.Windows.Forms.TextBox();
            this.tabPatientHistory = new System.Windows.Forms.TabPage();
            this.lblPatientHistoryNAme = new System.Windows.Forms.Label();
            this.pnl_PatientHistory = new System.Windows.Forms.Panel();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.txtPatientHistory = new System.Windows.Forms.RichTextBox();
            this.txtFamilyHistory = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabDiagnosis = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.ddlSubCategory = new System.Windows.Forms.ComboBox();
            this.ddlMainCategory = new System.Windows.Forms.ComboBox();
            this.lblDiagnosisPatientName = new System.Windows.Forms.Label();
            this.txtNewDiagnosis = new System.Windows.Forms.RichTextBox();
            this.btnSaveDiadnosis = new System.Windows.Forms.Button();
            this.txtOldDiagnosis = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabTreatment = new System.Windows.Forms.TabPage();
            this.lblTreatmentPatientNAme = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.ddlTreatmentMedication = new System.Windows.Forms.ComboBox();
            this.ddlTreatmentCategory = new System.Windows.Forms.ComboBox();
            this.btnPrintTreatment = new System.Windows.Forms.Button();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.txtOldTreatment = new System.Windows.Forms.RichTextBox();
            this.txtNewTreatment = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabFollowUps = new System.Windows.Forms.TabPage();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFollowUpPatientName = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnSaveFollowUp = new System.Windows.Forms.Button();
            this.txtOldFollowup = new System.Windows.Forms.RichTextBox();
            this.txtNewFollowup = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnSignout = new System.Windows.Forms.Button();
            this.tabFollowUp.SuspendLayout();
            this.tabAddPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInsurandeDetails.SuspendLayout();
            this.tabSearchPatient.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlSearchInsuranceOptions.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientSearchResult)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPhysicalHistory.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPatientHistory.SuspendLayout();
            this.pnl_PatientHistory.SuspendLayout();
            this.tabDiagnosis.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabTreatment.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabFollowUps.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabFollowUp
            // 
            this.tabFollowUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFollowUp.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabFollowUp.Controls.Add(this.tabAddPatient);
            this.tabFollowUp.Controls.Add(this.tabSearchPatient);
            this.tabFollowUp.Controls.Add(this.tabPhysicalHistory);
            this.tabFollowUp.Controls.Add(this.tabPatientHistory);
            this.tabFollowUp.Controls.Add(this.tabDiagnosis);
            this.tabFollowUp.Controls.Add(this.tabTreatment);
            this.tabFollowUp.Controls.Add(this.tabFollowUps);
            this.tabFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabFollowUp.ItemSize = new System.Drawing.Size(90, 28);
            this.tabFollowUp.Location = new System.Drawing.Point(-113, 27);
            this.tabFollowUp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tabFollowUp.Multiline = true;
            this.tabFollowUp.Name = "tabFollowUp";
            this.tabFollowUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabFollowUp.RightToLeftLayout = true;
            this.tabFollowUp.SelectedIndex = 0;
            this.tabFollowUp.Size = new System.Drawing.Size(1359, 920);
            this.tabFollowUp.TabIndex = 1;
            // 
            // tabAddPatient
            // 
            this.tabAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabAddPatient.Controls.Add(this.btn_CancelPatient);
            this.tabAddPatient.Controls.Add(this.btn_savePatient);
            this.tabAddPatient.Controls.Add(this.panel1);
            this.tabAddPatient.Location = new System.Drawing.Point(4, 32);
            this.tabAddPatient.Name = "tabAddPatient";
            this.tabAddPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPatient.Size = new System.Drawing.Size(1351, 884);
            this.tabAddPatient.TabIndex = 1;
            this.tabAddPatient.Text = "اضافة مريض";
            // 
            // btn_CancelPatient
            // 
            this.btn_CancelPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelPatient.Location = new System.Drawing.Point(840, 737);
            this.btn_CancelPatient.Name = "btn_CancelPatient";
            this.btn_CancelPatient.Size = new System.Drawing.Size(94, 45);
            this.btn_CancelPatient.TabIndex = 8;
            this.btn_CancelPatient.Text = "الغاء";
            this.btn_CancelPatient.UseVisualStyleBackColor = true;
            this.btn_CancelPatient.Click += new System.EventHandler(this.btn_CancelPatient_Click);
            // 
            // btn_savePatient
            // 
            this.btn_savePatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_savePatient.Location = new System.Drawing.Point(981, 737);
            this.btn_savePatient.Name = "btn_savePatient";
            this.btn_savePatient.Size = new System.Drawing.Size(94, 45);
            this.btn_savePatient.TabIndex = 1;
            this.btn_savePatient.Text = "جفظ";
            this.btn_savePatient.UseVisualStyleBackColor = true;
            this.btn_savePatient.Click += new System.EventHandler(this.btn_savePatient_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtBirthDate);
            this.panel1.Controls.Add(this.txtMiddleName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.pnlInsurandeDetails);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(327, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 672);
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(850, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "العمر";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(381, 274);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(350, 27);
            this.txtAge.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblAddPatientFees);
            this.panel6.Controls.Add(this.rad_Diagnosis);
            this.panel6.Location = new System.Drawing.Point(671, 422);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 53);
            this.panel6.TabIndex = 31;
            // 
            // lblAddPatientFees
            // 
            this.lblAddPatientFees.AutoSize = true;
            this.lblAddPatientFees.Location = new System.Drawing.Point(26, 18);
            this.lblAddPatientFees.Name = "lblAddPatientFees";
            this.lblAddPatientFees.Size = new System.Drawing.Size(51, 20);
            this.lblAddPatientFees.TabIndex = 34;
            this.lblAddPatientFees.Text = "label1";
            // 
            // rad_Diagnosis
            // 
            this.rad_Diagnosis.AutoSize = true;
            this.rad_Diagnosis.Checked = true;
            this.rad_Diagnosis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_Diagnosis.Location = new System.Drawing.Point(174, 14);
            this.rad_Diagnosis.Name = "rad_Diagnosis";
            this.rad_Diagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_Diagnosis.Size = new System.Drawing.Size(66, 24);
            this.rad_Diagnosis.TabIndex = 25;
            this.rad_Diagnosis.TabStop = true;
            this.rad_Diagnosis.Text = "كشف";
            this.rad_Diagnosis.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rad_Insurance);
            this.panel7.Controls.Add(this.rad_Cash);
            this.panel7.Location = new System.Drawing.Point(326, 422);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 64);
            this.panel7.TabIndex = 30;
            // 
            // rad_Insurance
            // 
            this.rad_Insurance.AutoSize = true;
            this.rad_Insurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_Insurance.Location = new System.Drawing.Point(42, 20);
            this.rad_Insurance.Name = "rad_Insurance";
            this.rad_Insurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_Insurance.Size = new System.Drawing.Size(63, 24);
            this.rad_Insurance.TabIndex = 19;
            this.rad_Insurance.Text = "تأمين";
            this.rad_Insurance.UseVisualStyleBackColor = true;
            this.rad_Insurance.CheckedChanged += new System.EventHandler(this.rad_Insurance_CheckedChanged);
            // 
            // rad_Cash
            // 
            this.rad_Cash.AutoSize = true;
            this.rad_Cash.Checked = true;
            this.rad_Cash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_Cash.Location = new System.Drawing.Point(131, 20);
            this.rad_Cash.Name = "rad_Cash";
            this.rad_Cash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_Cash.Size = new System.Drawing.Size(60, 24);
            this.rad_Cash.TabIndex = 18;
            this.rad_Cash.TabStop = true;
            this.rad_Cash.Text = "كاش";
            this.rad_Cash.UseVisualStyleBackColor = true;
            this.rad_Cash.CheckedChanged += new System.EventHandler(this.rad_Cash_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rad_Female);
            this.panel2.Controls.Add(this.rad_Male);
            this.panel2.Location = new System.Drawing.Point(671, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 52);
            this.panel2.TabIndex = 29;
            // 
            // rad_Female
            // 
            this.rad_Female.AutoSize = true;
            this.rad_Female.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_Female.Location = new System.Drawing.Point(71, 12);
            this.rad_Female.Name = "rad_Female";
            this.rad_Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_Female.Size = new System.Drawing.Size(57, 24);
            this.rad_Female.TabIndex = 13;
            this.rad_Female.TabStop = true;
            this.rad_Female.Text = "انثى";
            this.rad_Female.UseVisualStyleBackColor = true;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_Male.Location = new System.Drawing.Point(185, 12);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_Male.Size = new System.Drawing.Size(55, 24);
            this.rad_Male.TabIndex = 12;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "رجل";
            this.rad_Male.UseVisualStyleBackColor = true;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(381, 344);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(350, 27);
            this.txtMobile.TabIndex = 28;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(381, 222);
            this.txtBirthDate.MinDate = new System.DateTime(1900, 12, 1, 0, 0, 0, 0);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(350, 27);
            this.txtBirthDate.TabIndex = 27;
            this.txtBirthDate.ValueChanged += new System.EventHandler(this.txtBirthDate_ValueChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(381, 110);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(350, 27);
            this.txtMiddleName.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(381, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(350, 27);
            this.txtFirstName.TabIndex = 25;
            // 
            // pnlInsurandeDetails
            // 
            this.pnlInsurandeDetails.Controls.Add(this.lstInsuranceCompany);
            this.pnlInsurandeDetails.Controls.Add(this.txtInsuranceNumber);
            this.pnlInsurandeDetails.Controls.Add(this.label23);
            this.pnlInsurandeDetails.Controls.Add(this.label22);
            this.pnlInsurandeDetails.Location = new System.Drawing.Point(97, 503);
            this.pnlInsurandeDetails.Name = "pnlInsurandeDetails";
            this.pnlInsurandeDetails.Size = new System.Drawing.Size(463, 125);
            this.pnlInsurandeDetails.TabIndex = 18;
            // 
            // lstInsuranceCompany
            // 
            this.lstInsuranceCompany.FormattingEnabled = true;
            this.lstInsuranceCompany.Location = new System.Drawing.Point(51, 75);
            this.lstInsuranceCompany.Name = "lstInsuranceCompany";
            this.lstInsuranceCompany.Size = new System.Drawing.Size(261, 28);
            this.lstInsuranceCompany.TabIndex = 26;
            // 
            // txtInsuranceNumber
            // 
            this.txtInsuranceNumber.Location = new System.Drawing.Point(45, 23);
            this.txtInsuranceNumber.Name = "txtInsuranceNumber";
            this.txtInsuranceNumber.Size = new System.Drawing.Size(267, 27);
            this.txtInsuranceNumber.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(353, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 20);
            this.label23.TabIndex = 20;
            this.label23.Text = "رقم التأمين";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(353, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 20);
            this.label22.TabIndex = 22;
            this.label22.Text = "شركة التأمين";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(843, 344);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "موبايل";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(168, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 20);
            this.label20.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(828, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "تاريخ الميلاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(820, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "لقب العائلة";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(381, 166);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(350, 27);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(809, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "الاسم الوسط";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(822, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الأول";
            // 
            // tabSearchPatient
            // 
            this.tabSearchPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabSearchPatient.Controls.Add(this.lblSearchPatientName);
            this.tabSearchPatient.Controls.Add(this.panel10);
            this.tabSearchPatient.Controls.Add(this.panel9);
            this.tabSearchPatient.Controls.Add(this.panel8);
            this.tabSearchPatient.Location = new System.Drawing.Point(4, 32);
            this.tabSearchPatient.Name = "tabSearchPatient";
            this.tabSearchPatient.Size = new System.Drawing.Size(1351, 884);
            this.tabSearchPatient.TabIndex = 5;
            this.tabSearchPatient.Text = "  بحث مريض ";
            // 
            // lblSearchPatientName
            // 
            this.lblSearchPatientName.AutoSize = true;
            this.lblSearchPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSearchPatientName.Location = new System.Drawing.Point(632, 20);
            this.lblSearchPatientName.Name = "lblSearchPatientName";
            this.lblSearchPatientName.Size = new System.Drawing.Size(63, 20);
            this.lblSearchPatientName.TabIndex = 4;
            this.lblSearchPatientName.Text = "Patient:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblSearchFeesAmount);
            this.panel10.Controls.Add(this.btn_SearchSaveNewData);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.pnlSearchInsuranceOptions);
            this.panel10.Location = new System.Drawing.Point(39, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(602, 366);
            this.panel10.TabIndex = 2;
            // 
            // lblSearchFeesAmount
            // 
            this.lblSearchFeesAmount.AutoSize = true;
            this.lblSearchFeesAmount.Location = new System.Drawing.Point(398, 120);
            this.lblSearchFeesAmount.Name = "lblSearchFeesAmount";
            this.lblSearchFeesAmount.Size = new System.Drawing.Size(38, 20);
            this.lblSearchFeesAmount.TabIndex = 36;
            this.lblSearchFeesAmount.Text = "fees";
            // 
            // btn_SearchSaveNewData
            // 
            this.btn_SearchSaveNewData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SearchSaveNewData.Location = new System.Drawing.Point(123, 300);
            this.btn_SearchSaveNewData.Name = "btn_SearchSaveNewData";
            this.btn_SearchSaveNewData.Size = new System.Drawing.Size(99, 53);
            this.btn_SearchSaveNewData.TabIndex = 35;
            this.btn_SearchSaveNewData.Text = "حفظ";
            this.btn_SearchSaveNewData.UseVisualStyleBackColor = true;
            this.btn_SearchSaveNewData.Click += new System.EventHandler(this.btn_SearchSaveNewData_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rad_SearchConsultation);
            this.panel4.Controls.Add(this.rad_SearchDiagnosis);
            this.panel4.Location = new System.Drawing.Point(358, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 64);
            this.panel4.TabIndex = 34;
            // 
            // rad_SearchConsultation
            // 
            this.rad_SearchConsultation.AutoSize = true;
            this.rad_SearchConsultation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_SearchConsultation.Location = new System.Drawing.Point(120, 12);
            this.rad_SearchConsultation.Name = "rad_SearchConsultation";
            this.rad_SearchConsultation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_SearchConsultation.Size = new System.Drawing.Size(82, 24);
            this.rad_SearchConsultation.TabIndex = 26;
            this.rad_SearchConsultation.TabStop = true;
            this.rad_SearchConsultation.Text = "استشارة";
            this.rad_SearchConsultation.UseVisualStyleBackColor = true;
            this.rad_SearchConsultation.CheckedChanged += new System.EventHandler(this.rad_SearchConsultation_CheckedChanged);
            // 
            // rad_SearchDiagnosis
            // 
            this.rad_SearchDiagnosis.AutoSize = true;
            this.rad_SearchDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_SearchDiagnosis.Location = new System.Drawing.Point(33, 12);
            this.rad_SearchDiagnosis.Name = "rad_SearchDiagnosis";
            this.rad_SearchDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_SearchDiagnosis.Size = new System.Drawing.Size(66, 24);
            this.rad_SearchDiagnosis.TabIndex = 25;
            this.rad_SearchDiagnosis.TabStop = true;
            this.rad_SearchDiagnosis.Text = "كشف";
            this.rad_SearchDiagnosis.UseVisualStyleBackColor = true;
            this.rad_SearchDiagnosis.CheckedChanged += new System.EventHandler(this.rad_SearchDiagnosis_CheckedChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.rad_SearchInsurance);
            this.panel13.Controls.Add(this.rad_SearchCash);
            this.panel13.Location = new System.Drawing.Point(94, 35);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(229, 64);
            this.panel13.TabIndex = 33;
            // 
            // rad_SearchInsurance
            // 
            this.rad_SearchInsurance.AutoSize = true;
            this.rad_SearchInsurance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_SearchInsurance.Location = new System.Drawing.Point(42, 20);
            this.rad_SearchInsurance.Name = "rad_SearchInsurance";
            this.rad_SearchInsurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_SearchInsurance.Size = new System.Drawing.Size(63, 24);
            this.rad_SearchInsurance.TabIndex = 19;
            this.rad_SearchInsurance.TabStop = true;
            this.rad_SearchInsurance.Text = "تأمين";
            this.rad_SearchInsurance.UseVisualStyleBackColor = true;
            this.rad_SearchInsurance.CheckedChanged += new System.EventHandler(this.rad_SearchInsurance_CheckedChanged);
            // 
            // rad_SearchCash
            // 
            this.rad_SearchCash.AutoSize = true;
            this.rad_SearchCash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rad_SearchCash.Location = new System.Drawing.Point(131, 20);
            this.rad_SearchCash.Name = "rad_SearchCash";
            this.rad_SearchCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad_SearchCash.Size = new System.Drawing.Size(60, 24);
            this.rad_SearchCash.TabIndex = 18;
            this.rad_SearchCash.TabStop = true;
            this.rad_SearchCash.Text = "كاش";
            this.rad_SearchCash.UseVisualStyleBackColor = true;
            this.rad_SearchCash.CheckedChanged += new System.EventHandler(this.rad_SearchCash_CheckedChanged);
            // 
            // pnlSearchInsuranceOptions
            // 
            this.pnlSearchInsuranceOptions.Controls.Add(this.ddl_SearchInsuranceCompany);
            this.pnlSearchInsuranceOptions.Controls.Add(this.txtSearchInsuranceNumber);
            this.pnlSearchInsuranceOptions.Controls.Add(this.label11);
            this.pnlSearchInsuranceOptions.Controls.Add(this.label13);
            this.pnlSearchInsuranceOptions.Location = new System.Drawing.Point(123, 169);
            this.pnlSearchInsuranceOptions.Name = "pnlSearchInsuranceOptions";
            this.pnlSearchInsuranceOptions.Size = new System.Drawing.Size(463, 125);
            this.pnlSearchInsuranceOptions.TabIndex = 32;
            this.pnlSearchInsuranceOptions.Visible = false;
            // 
            // ddl_SearchInsuranceCompany
            // 
            this.ddl_SearchInsuranceCompany.FormattingEnabled = true;
            this.ddl_SearchInsuranceCompany.Location = new System.Drawing.Point(51, 75);
            this.ddl_SearchInsuranceCompany.Name = "ddl_SearchInsuranceCompany";
            this.ddl_SearchInsuranceCompany.Size = new System.Drawing.Size(261, 28);
            this.ddl_SearchInsuranceCompany.TabIndex = 26;
            this.ddl_SearchInsuranceCompany.SelectedIndexChanged += new System.EventHandler(this.ddl_SearchInsuranceCompany_SelectedIndexChanged);
            // 
            // txtSearchInsuranceNumber
            // 
            this.txtSearchInsuranceNumber.Location = new System.Drawing.Point(45, 23);
            this.txtSearchInsuranceNumber.Name = "txtSearchInsuranceNumber";
            this.txtSearchInsuranceNumber.Size = new System.Drawing.Size(267, 27);
            this.txtSearchInsuranceNumber.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(353, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "رقم التأمين";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(353, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "شركة التأمين";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblPatientsCount);
            this.panel9.Controls.Add(this.lblSearchEmptyGrid);
            this.panel9.Controls.Add(this.grdPatientSearchResult);
            this.panel9.Location = new System.Drawing.Point(103, 415);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1163, 433);
            this.panel9.TabIndex = 1;
            // 
            // lblPatientsCount
            // 
            this.lblPatientsCount.AutoSize = true;
            this.lblPatientsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPatientsCount.Location = new System.Drawing.Point(808, 12);
            this.lblPatientsCount.Name = "lblPatientsCount";
            this.lblPatientsCount.Size = new System.Drawing.Size(60, 20);
            this.lblPatientsCount.TabIndex = 2;
            this.lblPatientsCount.Text = "label14";
            // 
            // lblSearchEmptyGrid
            // 
            this.lblSearchEmptyGrid.AutoSize = true;
            this.lblSearchEmptyGrid.Location = new System.Drawing.Point(559, 12);
            this.lblSearchEmptyGrid.Name = "lblSearchEmptyGrid";
            this.lblSearchEmptyGrid.Size = new System.Drawing.Size(60, 20);
            this.lblSearchEmptyGrid.TabIndex = 1;
            this.lblSearchEmptyGrid.Text = "label14";
            // 
            // grdPatientSearchResult
            // 
            this.grdPatientSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatientSearchResult.Location = new System.Drawing.Point(28, 44);
            this.grdPatientSearchResult.Name = "grdPatientSearchResult";
            this.grdPatientSearchResult.RowHeadersWidth = 51;
            this.grdPatientSearchResult.RowTemplate.Height = 29;
            this.grdPatientSearchResult.Size = new System.Drawing.Size(1116, 369);
            this.grdPatientSearchResult.TabIndex = 0;
            this.grdPatientSearchResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPatientSearchResult_CellFormatting);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCancelSearch);
            this.panel8.Controls.Add(this.btn_SearchEmployee);
            this.panel8.Controls.Add(this.txtSearchMobile);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.txtSearchLastName);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.txtSearchFirstname);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(658, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(638, 279);
            this.panel8.TabIndex = 0;
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelSearch.Location = new System.Drawing.Point(49, 205);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(94, 47);
            this.btnCancelSearch.TabIndex = 7;
            this.btnCancelSearch.Text = "الغاء";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btn_SearchEmployee
            // 
            this.btn_SearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SearchEmployee.Location = new System.Drawing.Point(166, 205);
            this.btn_SearchEmployee.Name = "btn_SearchEmployee";
            this.btn_SearchEmployee.Size = new System.Drawing.Size(94, 47);
            this.btn_SearchEmployee.TabIndex = 6;
            this.btn_SearchEmployee.Text = "بحث";
            this.btn_SearchEmployee.UseVisualStyleBackColor = true;
            this.btn_SearchEmployee.Click += new System.EventHandler(this.btn_SearchPatients_Click);
            // 
            // txtSearchMobile
            // 
            this.txtSearchMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchMobile.Location = new System.Drawing.Point(230, 145);
            this.txtSearchMobile.Name = "txtSearchMobile";
            this.txtSearchMobile.Size = new System.Drawing.Size(291, 27);
            this.txtSearchMobile.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(555, 147);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "الموبايل";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchLastName.Location = new System.Drawing.Point(230, 92);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(291, 27);
            this.txtSearchLastName.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(555, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "لقب العائلة";
            // 
            // txtSearchFirstname
            // 
            this.txtSearchFirstname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchFirstname.Location = new System.Drawing.Point(230, 29);
            this.txtSearchFirstname.Name = "txtSearchFirstname";
            this.txtSearchFirstname.Size = new System.Drawing.Size(291, 27);
            this.txtSearchFirstname.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(555, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "الاسم الاول";
            // 
            // tabPhysicalHistory
            // 
            this.tabPhysicalHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPhysicalHistory.Controls.Add(this.lblPhysicalHistory);
            this.tabPhysicalHistory.Controls.Add(this.panel12);
            this.tabPhysicalHistory.Location = new System.Drawing.Point(4, 32);
            this.tabPhysicalHistory.Name = "tabPhysicalHistory";
            this.tabPhysicalHistory.Size = new System.Drawing.Size(1351, 884);
            this.tabPhysicalHistory.TabIndex = 6;
            this.tabPhysicalHistory.Text = "Physical History";
            // 
            // lblPhysicalHistory
            // 
            this.lblPhysicalHistory.AutoSize = true;
            this.lblPhysicalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPhysicalHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhysicalHistory.Location = new System.Drawing.Point(887, 29);
            this.lblPhysicalHistory.Name = "lblPhysicalHistory";
            this.lblPhysicalHistory.Size = new System.Drawing.Size(67, 20);
            this.lblPhysicalHistory.TabIndex = 1;
            this.lblPhysicalHistory.Text = "Patient: ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label28);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.btnSavePhysicialHistory);
            this.panel12.Controls.Add(this.lblRBS);
            this.panel12.Controls.Add(this.lblBMI);
            this.panel12.Controls.Add(this.lblWeight);
            this.panel12.Controls.Add(this.lblHeight);
            this.panel12.Controls.Add(this.txtRBS);
            this.panel12.Controls.Add(this.txtPatientWeight);
            this.panel12.Controls.Add(this.txtBMI);
            this.panel12.Controls.Add(this.txtPatientHeight);
            this.panel12.Location = new System.Drawing.Point(701, 52);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(623, 468);
            this.panel12.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(485, 179);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 20);
            this.label28.TabIndex = 10;
            this.label28.Text = "(Kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(485, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "(cm)";
            // 
            // btnSavePhysicialHistory
            // 
            this.btnSavePhysicialHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavePhysicialHistory.Location = new System.Drawing.Point(387, 387);
            this.btnSavePhysicialHistory.Name = "btnSavePhysicialHistory";
            this.btnSavePhysicialHistory.Size = new System.Drawing.Size(184, 29);
            this.btnSavePhysicialHistory.TabIndex = 8;
            this.btnSavePhysicialHistory.Text = "save";
            this.btnSavePhysicialHistory.UseVisualStyleBackColor = true;
            this.btnSavePhysicialHistory.Click += new System.EventHandler(this.btnSavePhysicialHistory_Click);
            // 
            // lblRBS
            // 
            this.lblRBS.AutoSize = true;
            this.lblRBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRBS.Location = new System.Drawing.Point(186, 287);
            this.lblRBS.Name = "lblRBS";
            this.lblRBS.Size = new System.Drawing.Size(37, 20);
            this.lblRBS.TabIndex = 7;
            this.lblRBS.Text = "RBS";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBMI.Location = new System.Drawing.Point(186, 232);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(38, 20);
            this.lblBMI.TabIndex = 6;
            this.lblBMI.Text = "BMI";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(186, 171);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(60, 20);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(186, 112);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 20);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // txtRBS
            // 
            this.txtRBS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRBS.Location = new System.Drawing.Point(273, 287);
            this.txtRBS.Name = "txtRBS";
            this.txtRBS.Size = new System.Drawing.Size(173, 27);
            this.txtRBS.TabIndex = 3;
            // 
            // txtPatientWeight
            // 
            this.txtPatientWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPatientWeight.Location = new System.Drawing.Point(273, 171);
            this.txtPatientWeight.Name = "txtPatientWeight";
            this.txtPatientWeight.Size = new System.Drawing.Size(173, 27);
            this.txtPatientWeight.TabIndex = 2;
            this.txtPatientWeight.TextChanged += new System.EventHandler(this.txtPatientWeight_TextChanged);
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBMI.Location = new System.Drawing.Point(273, 232);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(173, 27);
            this.txtBMI.TabIndex = 1;
            // 
            // txtPatientHeight
            // 
            this.txtPatientHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPatientHeight.Location = new System.Drawing.Point(273, 112);
            this.txtPatientHeight.Name = "txtPatientHeight";
            this.txtPatientHeight.Size = new System.Drawing.Size(173, 27);
            this.txtPatientHeight.TabIndex = 0;
            this.txtPatientHeight.TextChanged += new System.EventHandler(this.txtPatientHeight_TextChanged);
            // 
            // tabPatientHistory
            // 
            this.tabPatientHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPatientHistory.Controls.Add(this.lblPatientHistoryNAme);
            this.tabPatientHistory.Controls.Add(this.pnl_PatientHistory);
            this.tabPatientHistory.Location = new System.Drawing.Point(4, 32);
            this.tabPatientHistory.Name = "tabPatientHistory";
            this.tabPatientHistory.Size = new System.Drawing.Size(1351, 884);
            this.tabPatientHistory.TabIndex = 7;
            this.tabPatientHistory.Text = "Patient History";
            // 
            // lblPatientHistoryNAme
            // 
            this.lblPatientHistoryNAme.AutoSize = true;
            this.lblPatientHistoryNAme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPatientHistoryNAme.Location = new System.Drawing.Point(667, 18);
            this.lblPatientHistoryNAme.Name = "lblPatientHistoryNAme";
            this.lblPatientHistoryNAme.Size = new System.Drawing.Size(63, 20);
            this.lblPatientHistoryNAme.TabIndex = 13;
            this.lblPatientHistoryNAme.Text = "Patient:";
            // 
            // pnl_PatientHistory
            // 
            this.pnl_PatientHistory.AutoScroll = true;
            this.pnl_PatientHistory.Controls.Add(this.btnSaveHistory);
            this.pnl_PatientHistory.Controls.Add(this.txtPatientHistory);
            this.pnl_PatientHistory.Controls.Add(this.txtFamilyHistory);
            this.pnl_PatientHistory.Controls.Add(this.label6);
            this.pnl_PatientHistory.Controls.Add(this.label7);
            this.pnl_PatientHistory.Location = new System.Drawing.Point(61, 41);
            this.pnl_PatientHistory.Name = "pnl_PatientHistory";
            this.pnl_PatientHistory.Size = new System.Drawing.Size(1191, 781);
            this.pnl_PatientHistory.TabIndex = 12;
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Location = new System.Drawing.Point(528, 683);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(286, 61);
            this.btnSaveHistory.TabIndex = 6;
            this.btnSaveHistory.Text = "Save";
            this.btnSaveHistory.UseVisualStyleBackColor = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // txtPatientHistory
            // 
            this.txtPatientHistory.Location = new System.Drawing.Point(649, 58);
            this.txtPatientHistory.Name = "txtPatientHistory";
            this.txtPatientHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtPatientHistory.Size = new System.Drawing.Size(519, 594);
            this.txtPatientHistory.TabIndex = 5;
            this.txtPatientHistory.Text = "";
            // 
            // txtFamilyHistory
            // 
            this.txtFamilyHistory.Location = new System.Drawing.Point(53, 58);
            this.txtFamilyHistory.Name = "txtFamilyHistory";
            this.txtFamilyHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtFamilyHistory.Size = new System.Drawing.Size(563, 594);
            this.txtFamilyHistory.TabIndex = 4;
            this.txtFamilyHistory.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(844, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Patient History";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(247, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Family History";
            // 
            // tabDiagnosis
            // 
            this.tabDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabDiagnosis.Controls.Add(this.panel3);
            this.tabDiagnosis.Location = new System.Drawing.Point(4, 32);
            this.tabDiagnosis.Name = "tabDiagnosis";
            this.tabDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnosis.Size = new System.Drawing.Size(1351, 884);
            this.tabDiagnosis.TabIndex = 2;
            this.tabDiagnosis.Text = "Diagnosis";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddDiagnosis);
            this.panel3.Controls.Add(this.ddlSubCategory);
            this.panel3.Controls.Add(this.ddlMainCategory);
            this.panel3.Controls.Add(this.lblDiagnosisPatientName);
            this.panel3.Controls.Add(this.txtNewDiagnosis);
            this.panel3.Controls.Add(this.btnSaveDiadnosis);
            this.panel3.Controls.Add(this.txtOldDiagnosis);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1631, 867);
            this.panel3.TabIndex = 2;
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiagnosis.Location = new System.Drawing.Point(1144, 133);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(153, 47);
            this.btnAddDiagnosis.TabIndex = 12;
            this.btnAddDiagnosis.Text = "Add Diagnosis";
            this.btnAddDiagnosis.UseVisualStyleBackColor = true;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // ddlSubCategory
            // 
            this.ddlSubCategory.FormattingEnabled = true;
            this.ddlSubCategory.Location = new System.Drawing.Point(558, 60);
            this.ddlSubCategory.Name = "ddlSubCategory";
            this.ddlSubCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddlSubCategory.Size = new System.Drawing.Size(668, 28);
            this.ddlSubCategory.TabIndex = 10;
            // 
            // ddlMainCategory
            // 
            this.ddlMainCategory.FormattingEnabled = true;
            this.ddlMainCategory.Location = new System.Drawing.Point(153, 60);
            this.ddlMainCategory.Name = "ddlMainCategory";
            this.ddlMainCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddlMainCategory.Size = new System.Drawing.Size(397, 28);
            this.ddlMainCategory.TabIndex = 9;
            this.ddlMainCategory.SelectedIndexChanged += new System.EventHandler(this.ddlMainCategory_SelectedIndexChanged);
            // 
            // lblDiagnosisPatientName
            // 
            this.lblDiagnosisPatientName.AutoSize = true;
            this.lblDiagnosisPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDiagnosisPatientName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiagnosisPatientName.Location = new System.Drawing.Point(539, 25);
            this.lblDiagnosisPatientName.Name = "lblDiagnosisPatientName";
            this.lblDiagnosisPatientName.Size = new System.Drawing.Size(67, 20);
            this.lblDiagnosisPatientName.TabIndex = 8;
            this.lblDiagnosisPatientName.Text = "Patient: ";
            // 
            // txtNewDiagnosis
            // 
            this.txtNewDiagnosis.Location = new System.Drawing.Point(153, 501);
            this.txtNewDiagnosis.Name = "txtNewDiagnosis";
            this.txtNewDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewDiagnosis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtNewDiagnosis.Size = new System.Drawing.Size(970, 300);
            this.txtNewDiagnosis.TabIndex = 7;
            this.txtNewDiagnosis.Text = "";
            // 
            // btnSaveDiadnosis
            // 
            this.btnSaveDiadnosis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDiadnosis.Location = new System.Drawing.Point(1144, 547);
            this.btnSaveDiadnosis.Name = "btnSaveDiadnosis";
            this.btnSaveDiadnosis.Size = new System.Drawing.Size(151, 48);
            this.btnSaveDiadnosis.TabIndex = 3;
            this.btnSaveDiadnosis.Text = "save";
            this.btnSaveDiadnosis.UseVisualStyleBackColor = true;
            this.btnSaveDiadnosis.Click += new System.EventHandler(this.btnSaveDiadnosis_Click);
            // 
            // txtOldDiagnosis
            // 
            this.txtOldDiagnosis.ReadOnly = true;
            this.txtOldDiagnosis.Location = new System.Drawing.Point(153, 133);
            this.txtOldDiagnosis.Name = "txtOldDiagnosis";
            this.txtOldDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOldDiagnosis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtOldDiagnosis.Size = new System.Drawing.Size(970, 321);
            this.txtOldDiagnosis.TabIndex = 6;
            this.txtOldDiagnosis.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(93, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "New Diagnosis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(93, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "History";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 23);
            this.label12.TabIndex = 0;
            // 
            // tabTreatment
            // 
            this.tabTreatment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTreatment.Controls.Add(this.lblTreatmentPatientNAme);
            this.tabTreatment.Controls.Add(this.panel5);
            this.tabTreatment.Location = new System.Drawing.Point(4, 32);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreatment.Size = new System.Drawing.Size(1351, 884);
            this.tabTreatment.TabIndex = 3;
            this.tabTreatment.Text = "Treatment";
            // 
            // lblTreatmentPatientNAme
            // 
            this.lblTreatmentPatientNAme.AutoSize = true;
            this.lblTreatmentPatientNAme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTreatmentPatientNAme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTreatmentPatientNAme.Location = new System.Drawing.Point(625, 19);
            this.lblTreatmentPatientNAme.Name = "lblTreatmentPatientNAme";
            this.lblTreatmentPatientNAme.Size = new System.Drawing.Size(63, 20);
            this.lblTreatmentPatientNAme.TabIndex = 9;
            this.lblTreatmentPatientNAme.Text = "Patient:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFinish);
            this.panel5.Controls.Add(this.btnAddTreatment);
            this.panel5.Controls.Add(this.ddlTreatmentMedication);
            this.panel5.Controls.Add(this.ddlTreatmentCategory);
            this.panel5.Controls.Add(this.btnPrintTreatment);
            this.panel5.Controls.Add(this.btnSaveTreatment);
            this.panel5.Controls.Add(this.txtOldTreatment);
            this.panel5.Controls.Add(this.txtNewTreatment);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Location = new System.Drawing.Point(126, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1202, 809);
            this.panel5.TabIndex = 3;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(1026, 516);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(173, 51);
            this.btnFinish.TabIndex = 12;
            this.btnFinish.Text = "Finished";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(1026, 32);
            this.btnAddTreatment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(154, 56);
            this.btnAddTreatment.TabIndex = 11;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // ddlTreatmentMedication
            // 
            this.ddlTreatmentMedication.FormattingEnabled = true;
            this.ddlTreatmentMedication.Location = new System.Drawing.Point(86, 47);
            this.ddlTreatmentMedication.Name = "ddlTreatmentMedication";
            this.ddlTreatmentMedication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddlTreatmentMedication.Size = new System.Drawing.Size(927, 28);
            this.ddlTreatmentMedication.TabIndex = 10;
            // 
            // ddlTreatmentCategory
            // 
            this.ddlTreatmentCategory.FormattingEnabled = true;
            this.ddlTreatmentCategory.Location = new System.Drawing.Point(86, 0);
            this.ddlTreatmentCategory.Name = "ddlTreatmentCategory";
            this.ddlTreatmentCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddlTreatmentCategory.Size = new System.Drawing.Size(927, 28);
            this.ddlTreatmentCategory.TabIndex = 9;
            this.ddlTreatmentCategory.SelectedIndexChanged += new System.EventHandler(this.ddlTreatmentCategory_SelectedIndexChanged);
            // 
            // btnPrintTreatment
            // 
            this.btnPrintTreatment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintTreatment.Location = new System.Drawing.Point(802, 755);
            this.btnPrintTreatment.Name = "btnPrintTreatment";
            this.btnPrintTreatment.Size = new System.Drawing.Size(201, 51);
            this.btnPrintTreatment.TabIndex = 8;
            this.btnPrintTreatment.Text = "Print";
            this.btnPrintTreatment.UseVisualStyleBackColor = true;
            this.btnPrintTreatment.Click += new System.EventHandler(this.btnPrintTreatment_Click);
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveTreatment.Location = new System.Drawing.Point(567, 755);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(201, 51);
            this.btnSaveTreatment.TabIndex = 4;
            this.btnSaveTreatment.Text = "save";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // txtOldTreatment
            // 
            this.txtOldTreatment.ReadOnly = true;
            this.txtOldTreatment.Location = new System.Drawing.Point(86, 108);
            this.txtOldTreatment.Name = "txtOldTreatment";
            this.txtOldTreatment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOldTreatment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtOldTreatment.Size = new System.Drawing.Size(927, 267);
            this.txtOldTreatment.TabIndex = 7;
            this.txtOldTreatment.Text = "";
            // 
            // txtNewTreatment
            // 
            this.txtNewTreatment.Location = new System.Drawing.Point(86, 420);
            this.txtNewTreatment.Name = "txtNewTreatment";
            this.txtNewTreatment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewTreatment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtNewTreatment.Size = new System.Drawing.Size(927, 313);
            this.txtNewTreatment.TabIndex = 6;
            this.txtNewTreatment.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "New Treatment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(14, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "History";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 23);
            this.label27.TabIndex = 0;
            // 
            // tabFollowUps
            // 
            this.tabFollowUps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabFollowUps.Controls.Add(this.pnlFooter);
            this.tabFollowUps.Controls.Add(this.lblFollowUpPatientName);
            this.tabFollowUps.Controls.Add(this.panel11);
            this.tabFollowUps.Location = new System.Drawing.Point(4, 32);
            this.tabFollowUps.Name = "tabFollowUps";
            this.tabFollowUps.Padding = new System.Windows.Forms.Padding(3);
            this.tabFollowUps.Size = new System.Drawing.Size(1351, 884);
            this.tabFollowUps.TabIndex = 4;
            this.tabFollowUps.Text = "Follow up";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.Location = new System.Drawing.Point(1872, 413);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(24, 43);
            this.pnlFooter.TabIndex = 10;
            // 
            // lblFollowUpPatientName
            // 
            this.lblFollowUpPatientName.AutoSize = true;
            this.lblFollowUpPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFollowUpPatientName.Location = new System.Drawing.Point(639, 24);
            this.lblFollowUpPatientName.Name = "lblFollowUpPatientName";
            this.lblFollowUpPatientName.Size = new System.Drawing.Size(63, 20);
            this.lblFollowUpPatientName.TabIndex = 9;
            this.lblFollowUpPatientName.Text = "Patient:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnSaveFollowUp);
            this.panel11.Controls.Add(this.txtOldFollowup);
            this.panel11.Controls.Add(this.txtNewFollowup);
            this.panel11.Controls.Add(this.label29);
            this.panel11.Controls.Add(this.label30);
            this.panel11.Controls.Add(this.label31);
            this.panel11.Location = new System.Drawing.Point(146, 47);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1123, 796);
            this.panel11.TabIndex = 4;
            // 
            // btnSaveFollowUp
            // 
            this.btnSaveFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFollowUp.Location = new System.Drawing.Point(811, 733);
            this.btnSaveFollowUp.Name = "btnSaveFollowUp";
            this.btnSaveFollowUp.Size = new System.Drawing.Size(201, 60);
            this.btnSaveFollowUp.TabIndex = 4;
            this.btnSaveFollowUp.Text = "save";
            this.btnSaveFollowUp.UseVisualStyleBackColor = true;
            this.btnSaveFollowUp.Click += new System.EventHandler(this.btnSaveFollowUp_Click);
            // 
            // txtOldFollowup
            // 
            this.txtOldFollowup.Enabled = false;
            this.txtOldFollowup.Location = new System.Drawing.Point(75, 45);
            this.txtOldFollowup.Name = "txtOldFollowup";
            this.txtOldFollowup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOldFollowup.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtOldFollowup.Size = new System.Drawing.Size(911, 301);
            this.txtOldFollowup.TabIndex = 7;
            this.txtOldFollowup.Text = "";
            // 
            // txtNewFollowup
            // 
            this.txtNewFollowup.Location = new System.Drawing.Point(75, 400);
            this.txtNewFollowup.Name = "txtNewFollowup";
            this.txtNewFollowup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewFollowup.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtNewFollowup.Size = new System.Drawing.Size(927, 328);
            this.txtNewFollowup.TabIndex = 6;
            this.txtNewFollowup.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(3, 365);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 20);
            this.label29.TabIndex = 5;
            this.label29.Text = "New Followup";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(21, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 20);
            this.label30.TabIndex = 3;
            this.label30.Text = "History";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 23);
            this.label31.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnSignout);
            this.panel14.Location = new System.Drawing.Point(171, 13);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(114, 45);
            this.panel14.TabIndex = 2;
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignout.Location = new System.Drawing.Point(18, 4);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(86, 31);
            this.btnSignout.TabIndex = 0;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click_1);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.tabFollowUp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.Text = "Dr.Wafaa Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabFollowUp.ResumeLayout(false);
            this.tabAddPatient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInsurandeDetails.ResumeLayout(false);
            this.pnlInsurandeDetails.PerformLayout();
            this.tabSearchPatient.ResumeLayout(false);
            this.tabSearchPatient.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnlSearchInsuranceOptions.ResumeLayout(false);
            this.pnlSearchInsuranceOptions.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientSearchResult)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPhysicalHistory.ResumeLayout(false);
            this.tabPhysicalHistory.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabPatientHistory.ResumeLayout(false);
            this.tabPatientHistory.PerformLayout();
            this.pnl_PatientHistory.ResumeLayout(false);
            this.pnl_PatientHistory.PerformLayout();
            this.tabDiagnosis.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabTreatment.ResumeLayout(false);
            this.tabTreatment.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabFollowUps.ResumeLayout(false);
            this.tabFollowUps.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tabFollowUp;
        private TabPage tabDiagnosis;
        private TabPage tabTreatment;
        private TabPage tabFollowUps;
        private TabPage tabAddPatient;
        private Button btn_CancelPatient;
        private Button btn_savePatient;
        private Panel panel3;
        private Label label9;
        private Label label10;
        private Label label12;
        private Button btnSaveDiadnosis;
        private RichTextBox txtNewDiagnosis;
        private RichTextBox txtOldDiagnosis;
        private TabPage tabSearchPatient;
        private Label label8;
        private Panel panel9;
        private DataGridView grdPatientSearchResult;
        private Panel panel8;
        private Button btn_SearchEmployee;
        private TextBox txtSearchMobile;
        private Label label25;
        private TextBox txtSearchLastName;
        private Label label24;
        private TextBox txtSearchFirstname;
        private Label label17;
        private Panel panel10;
        private Label lblDiagnosisPatientName;
        private Panel panel11;
        private Label lblFollowUpPatientName;
        private Button btnSaveFollowUp;
        private RichTextBox txtOldFollowup;
        private RichTextBox txtNewFollowup;
        private Label label29;
        private Label label30;
        private Label label31;
        private TabPage tabPhysicalHistory;
        private ComboBox ddlSubCategory;
        private ComboBox ddlMainCategory;
        private Button btnAddDiagnosis;
        private Label lblPhysicalHistory;
        private Panel panel12;
        private Label lblRBS;
        private Label lblBMI;
        private Label lblWeight;
        private Label lblHeight;
        private TextBox txtRBS;
        private TextBox txtPatientWeight;
        private TextBox txtBMI;
        private TextBox txtPatientHeight;
        private Button btnSavePhysicialHistory;
        private Button btnCancelSearch;
        private Label label28;
        private Label label5;
        private Panel panel5;
        private Label lblTreatmentPatientNAme;
        private Button btnSaveTreatment;
        private RichTextBox txtOldTreatment;
        private RichTextBox txtNewTreatment;
        private Label label15;
        private Label label16;
        private Label label27;
        private Button btnPrintTreatment;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel pnlFooter;
        private Panel panel4;
        private RadioButton rad_SearchConsultation;
        private RadioButton rad_SearchDiagnosis;
        private Panel panel13;
        private RadioButton rad_SearchInsurance;
        private RadioButton rad_SearchCash;
        private Panel pnlSearchInsuranceOptions;
        private ComboBox ddl_SearchInsuranceCompany;
        private TextBox txtSearchInsuranceNumber;
        private Label label11;
        private Label label13;
        private Button btn_SearchSaveNewData;
        private Label lblSearchFeesAmount;
        private Panel panel1;
        private Panel panel6;
        private RadioButton rad_Diagnosis;
        private Panel panel7;
        private RadioButton rad_Insurance;
        private RadioButton rad_Cash;
        private Panel panel2;
        private RadioButton rad_Female;
        private RadioButton rad_Male;
        private TextBox txtMobile;
        private DateTimePicker txtBirthDate;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private Panel pnlInsurandeDetails;
        private ComboBox lstInsuranceCompany;
        private TextBox txtInsuranceNumber;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label18;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
        private Label label19;
        private TextBox txtAge;
        private Label lblSearchPatientName;
        private Label lblSearchEmptyGrid;
        private ComboBox ddlTreatmentMedication;
        private ComboBox ddlTreatmentCategory;
        private Button btnAddTreatment;
        private Button btnFinish;
        private Label lblPatientsCount;
        private Panel panel14;
        private Button btnSignout;
        private Label lblAddPatientFees;
        private TabPage tabPatientHistory;
        private Panel pnl_PatientHistory;
        private RichTextBox txtPatientHistory;
        private RichTextBox txtFamilyHistory;
        private Label label6;
        private Label label7;
        private Button btnSaveHistory;
        private Label lblPatientHistoryNAme;
    }
}