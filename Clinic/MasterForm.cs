using Azure;
using ClinicDB;
using ClinicDB.Repository;
using Infra.Clinic.Entity;
using Infra.Clinic.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinic
{
    public partial class MasterForm : Form
    {
        public PatientRepository patientRepository;
        private readonly ILogger logger;
        public int linesPerPage = 0;
        public MasterForm()
        {
            logger = GlobalVariables.initializeLogger();
            GlobalVariables.LogCurrentUSer("Master Form Page");

            patientRepository = new PatientRepository();

            InitializeComponent();

            SetTabsAccess();
            
            InitData();

        }
        public void SetTabsAccess()
        {
            tabAddPatient.Visible = true;
            tabSearchPatient.Visible = true;
            if (GlobalVariables.ShowTabs)//mamy
            {
                pnl_PatientHistory.Visible = true;
                tabFollowUp.TabPages.Remove(tabAddPatient);
            }
            else
            {
                pnl_PatientHistory.Visible = false;
                tabFollowUp.TabPages.Remove(tabPhysicalHistory);
                tabFollowUp.TabPages.Remove(tabDiagnosis);
                tabFollowUp.TabPages.Remove(tabFollowUps);
                tabFollowUp.TabPages.Remove(tabTreatment);
                tabFollowUp.TabPages.Remove(tabPatientHistory);

            }
        }
        public void InitData()
        {
            SetMainCategory();
            FillInsuranceCompany();
            FillTreatmentCategoryList();

            SetPatientInfo();
            SetPatientDiagnosis();
            SetPatientTreatment();
            SetPatientFollowUp();
            SetPhysicialHistory();
            SetPatientName();

            SetSearchPatientData();
            LoadPatientHistory();

            lblAddPatientFees.Text = GlobalVariables.DiagnosisFees + " LE";

            rad_Cash.Checked = true;
            pnlInsurandeDetails.Visible = false;

        }
        public void SetPatientName()
        {

            lblDiagnosisPatientName.Text = SetPatientIdNameLabels();
            lblTreatmentPatientNAme.Text = SetPatientIdNameLabels();
            lblFollowUpPatientName.Text = SetPatientIdNameLabels();
            lblPhysicalHistory.Text = SetPatientIdNameLabels();
            lblSearchPatientName.Text = SetPatientIdNameLabels();
            lblPatientHistoryNAme.Text = SetPatientIdNameLabels();

        }
        public void ClearGlobals()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            GlobalVariables.LoggedUserName = string.Empty;
            GlobalVariables.loggedUserDisplayName = string.Empty;
            GlobalVariables.PatientID = 0;
            GlobalVariables.PatientName = string.Empty;

            rad_SearchCash.Checked = false;
            rad_SearchConsultation.Checked = false;

            rad_SearchDiagnosis.Checked = false;
            rad_SearchInsurance.Checked = false;
        }
        public void SetSearchPatientData()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var visits = patientRepository.GetVisitsByPatientID(GlobalVariables.PatientID, logger);
                if (visits.Count > 0)
                {
                    if (visits[0].Cash)
                        rad_SearchCash.Checked = visits[0].Cash;
                    else
                    {
                        rad_SearchInsurance.Checked = true;
                        ddl_SearchInsuranceCompany.SelectedValue = visits[0].InsuranceCompanyID;
                        txtSearchInsuranceNumber.Text = visits[0].InsuranceNumber;
                    }

                    if (visits[0].Consultation)
                        rad_SearchConsultation.Checked = visits[0].Consultation;
                    else
                        rad_SearchDiagnosis.Checked = true;

                    lblSearchFeesAmount.Text = visits[0].fees.ToString();
                }
                else
                {
                    lblSearchFeesAmount.Text = string.Empty;
                    rad_SearchCash.Checked = false;
                    rad_SearchDiagnosis.Checked = false;
                    rad_SearchInsurance.Checked = false;
                    rad_SearchConsultation.Checked = false;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        public string SetPatientIdNameLabels()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            return ErrorMessages.patientID + GlobalVariables.PatientID + " - " + ErrorMessages.patientName + GlobalVariables.PatientName;
        }
        public void SetMainCategory()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var result = patientRepository.SelectDiagnosisMainCategory(logger);

                ddlMainCategory.DisplayMember = "CombinedField";
                ddlMainCategory.ValueMember = "Id";

                ddlMainCategory.DataSource = result;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }
        }
        public void SetPhysicialHistory()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            txtPatientHeight.Clear();
            txtPatientWeight.Clear();
            txtRBS.Clear();
            txtBMI.Clear();
            try
            {
                if (GlobalVariables.PatientID > 0)
                {
                    var physicals = patientRepository.SelectPhysicalHistoryByPatintID(GlobalVariables.PatientID, logger);
                    if (physicals != null)
                    {
                        foreach (PhysicalHistory p in physicals)
                        {
                            txtPatientHeight.Text = p.Height.ToString();
                            txtPatientWeight.Text = p.Weight.ToString();
                            txtRBS.Text = p.RBS.ToString();
                            txtBMI.Text = p.BMI.ToString();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }


        }
        public void SetPatientInfo()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if (GlobalVariables.PatientID > 0)
                {
                    var patient = patientRepository.SelectPatientByID(GlobalVariables.PatientID, logger);
                    if (patient != null)
                    {
                        txtFirstName.Text = patient.FirstName;
                        txtMiddleName.Text = patient.MiddleName;
                        txtLastName.Text = patient.FamilyName;

                        txtMobile.Text = patient.Mobile;
                        txtAge.Text = patient.Age.ToString();
                        txtFamilyHistory.Text = patient.FamilyHistory;
                        txtPatientHistory.Text = patient.PastHistory;

                        if (patient.Cash)
                            rad_Cash.Checked = true;
                        else
                            rad_Insurance.Checked = true;

                        //if (patient.Consultation)
                        //    rad_Consultation.Checked = true;
                        //else
                        rad_Diagnosis.Checked = true;

                        if (patient.Gender)
                            rad_Male.Checked = true;
                        else
                            rad_Female.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        public void SetPatientDiagnosis()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                StringBuilder strBuilder = new StringBuilder();
                if (GlobalVariables.PatientID > 0)
                {
                    List<Diagnosis> diagnosesLst = patientRepository.SelectDiagnosisByPatientID(GlobalVariables.PatientID, logger);
                    if (diagnosesLst.Count > 0)
                    {
                        foreach (Diagnosis diagnosis in diagnosesLst)
                        {
                            strBuilder.Append("*****************************************************");
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(diagnosis.Date.ToShortDateString());
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append("*****************************************************");

                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(diagnosis.Text);
                            strBuilder.Append(Environment.NewLine);
                        }
                        txtOldDiagnosis.Text = strBuilder.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        public void SetPatientTreatment()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                StringBuilder strBuilder = new StringBuilder();

                if (GlobalVariables.PatientID > 0)
                {
                    List<Treatment> treatments = patientRepository.SelectTreatmentByPatientID(GlobalVariables.PatientID, logger);
                    if (treatments.Count > 0)
                    {
                        foreach (Treatment treatment in treatments)
                        {
                            strBuilder.Append("*****************************************************");
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(treatment.Date.ToShortDateString());
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append("*****************************************************");

                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(treatment.Text);
                            strBuilder.Append(Environment.NewLine);
                        }
                        txtOldTreatment.Text = strBuilder.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }
        }

        public void SetPatientFollowUp()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                StringBuilder strBuilder = new StringBuilder();

                if (GlobalVariables.PatientID > 0)
                {
                    List<FollowUp> followUps = patientRepository.SelectFollowupByPatientID(GlobalVariables.PatientID, logger);
                    if (followUps.Count > 0)
                    {
                        foreach (FollowUp followUp in followUps)
                        {
                            strBuilder.Append("*****************************************************");
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(followUp.Date.ToShortDateString());
                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append("*****************************************************");

                            strBuilder.Append(Environment.NewLine);
                            strBuilder.Append(followUp.Text);
                            strBuilder.Append(Environment.NewLine);
                        }
                        txtOldFollowup.Text = strBuilder.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        private void rad_Insurance_CheckedChanged(object sender, EventArgs e)
        {
            pnlInsurandeDetails.Visible = true;
        }

        private void rad_Cash_CheckedChanged(object sender, EventArgs e)
        {
            pnlInsurandeDetails.Visible = false;
        }

        private async Task FillInsuranceCompany()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {

                var result = patientRepository.GetInsuranceCompany(logger);

                lstInsuranceCompany.DisplayMember = "Agency";
                lstInsuranceCompany.ValueMember = "Id";
                lstInsuranceCompany.DataSource = result;

                ddl_SearchInsuranceCompany.DisplayMember = "Agency";
                ddl_SearchInsuranceCompany.ValueMember = "Id";
                ddl_SearchInsuranceCompany.DataSource = result;

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        private void btn_savePatient_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {

                string strFirstName = txtFirstName.Text;
                string strMiddleName = txtMiddleName.Text;
                string strFamilyName = txtLastName.Text;

                int iAge = 0;
                int.TryParse(txtAge.Text, out iAge);

                DateTime birthDate = DateTime.MinValue;
                DateTime.TryParse(txtBirthDate.Text, CultureInfo.CurrentCulture, out birthDate);

                string strMobile = txtMobile.Text;

                bool bGender = rad_Female.Checked;
                bool bInsurance = rad_Insurance.Checked;
                // bool bConsultation = rad_Consultation.Checked;
                bool bCash = rad_Cash.Checked;

                string insuranceNumber = null;
                string strInsuranceCompany = null;
                int insuranceCompany = 0;

                if (bInsurance)
                {
                    insuranceNumber = txtInsuranceNumber.Text;
                    strInsuranceCompany = lstInsuranceCompany.SelectedValue.ToString();
                    int.TryParse(strInsuranceCompany, out insuranceCompany);
                }

                string strFamilyHistory = txtFamilyHistory.Text;
                string strPastHistory = txtPatientHistory.Text;

                Patient patient = new Patient();
                patient.FirstName = strFirstName;
                patient.MiddleName = strMiddleName;
                patient.FamilyName = strFamilyName;

                patient.Age = iAge;
                patient.Mobile = strMobile;
                patient.Gender = bGender;

                patient.FamilyHistory = strFamilyHistory;
                patient.PastHistory = strPastHistory;
                patient.BirthdDate = birthDate;



                if (GlobalVariables.PatientID > 0)
                {
                    patient.ModifiedDate = DateTime.Now;
                    patient.ModifiedById = GlobalVariables.loggedUserID;
                    if (patientRepository.UpdatePatient(patient, GlobalVariables.PatientID, logger))
                    {
                        MessageBox.Show(ErrorMessages.updatePatientInfo_ar);
                        SetPatientInfo();
                    }
                    else
                        MessageBox.Show("failed to update Patient due to " + PatientRepository.errorMsg);

                }
                else
                {
                    patient.CreatedDate = DateTime.Now;
                    patient.CreatedById = GlobalVariables.loggedUserID;
                    if (patientRepository.InsertPatient(patient, logger))
                    {
                        Visit visit = new Visit();
                        visit.PatientId = patient.Id;

                        if (bCash)
                        {
                            visit.Cash = bCash;
                        }
                        else
                        {
                            visit.Cash = false;
                            visit.InsuranceNumber = insuranceNumber;
                            visit.InsuranceCompanyID = insuranceCompany;
                        }


                        //if (bConsultation)
                        //{
                        //    visit.Consultation = bConsultation;
                        //    visit.fees = GlobalVariables.ConsultationFees;
                        //}
                        //else
                        //{
                        visit.Consultation = false;
                        visit.fees = GlobalVariables.DiagnosisFees;
                        // }
                        visit.VisitDate = DateTime.Now;

                        visit.CreatedDate = DateTime.Now;
                        visit.CreatedById = GlobalVariables.loggedUserID;

                        patientRepository.InsertVisit(visit, logger);
                        MessageBox.Show(ErrorMessages.addedPatientInfo_ar);
                        SetPatientInfo();
                    }
                    else
                        MessageBox.Show("failed to add Patient due to " + PatientRepository.errorMsg);

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }


        }

        private async void btn_SearchPatients_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var patientLst = patientRepository.SearchPatient(txtSearchFirstname.Text, txtSearchMobile.Text, txtSearchLastName.Text, logger);
                if (patientLst != null)
                    GenerateGrid();

                grdPatientSearchResult.DataSource = patientLst;

                if (patientLst.Count > 0)
                    grdPatientSearchResult.Show();
                else
                    grdPatientSearchResult.Hide();
                lblSearchEmptyGrid.Text = patientLst.Count > 0 ? "total: " + patientLst.Count.ToString() : " لا توجد نتائج";



                lblPatientsCount.Text = "pending " + patientRepository.GetPendingPatientsInVisitByDate(logger) +
                    " / " + patientRepository.GetTotalPatientsInVisitByDate(logger) + " patients";

                lblPatientsCount.Visible = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }


        }
        public void GenerateGrid()
        {
            grdPatientSearchResult.Columns.Clear();
            grdPatientSearchResult.DataSource = null;

            grdPatientSearchResult.AutoGenerateColumns = false;
            //Set Columns Count
            grdPatientSearchResult.ColumnCount = 5;

            grdPatientSearchResult.Columns[0].HeaderText = "Id";
            grdPatientSearchResult.Columns[0].Name = "Id";
            grdPatientSearchResult.Columns[0].DataPropertyName = "Id";

            grdPatientSearchResult.Columns[1].HeaderText = "Patient Name";
            grdPatientSearchResult.Columns[1].Name = "PatientName";
            grdPatientSearchResult.Columns[1].DataPropertyName = "CompositeName";

            grdPatientSearchResult.Columns[2].HeaderText = "visitType";
            grdPatientSearchResult.Columns[2].Name = "visitType";
            grdPatientSearchResult.Columns[2].DataPropertyName = "visitType";

            grdPatientSearchResult.Columns[3].HeaderText = "Visit Date";
            grdPatientSearchResult.Columns[3].Name = "Date";
            grdPatientSearchResult.Columns[3].DataPropertyName = "visitDate";

            grdPatientSearchResult.Columns[4].HeaderText = "Finished";
            grdPatientSearchResult.Columns[4].Name = "Finished";
            grdPatientSearchResult.Columns[4].DataPropertyName = "isChecked";


            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Display Patient Details";
            btnEdit.Text = "Display";
            btnEdit.Name = "EditButton";
            btnEdit.UseColumnTextForButtonValue = true;
            grdPatientSearchResult.Columns.Add(btnEdit);

            grdPatientSearchResult.CellClick += grdPatientSearchResult_CellClick;

            grdPatientSearchResult.Columns[0].Width = 50;
            grdPatientSearchResult.Columns[1].Width = 400;
            grdPatientSearchResult.Columns[2].Width = 100;
            grdPatientSearchResult.Columns[3].Width = 100;
            grdPatientSearchResult.Columns[4].Width = 150;
            grdPatientSearchResult.Columns[5].Width = 200;
        }
        private void grdPatientSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if (e.ColumnIndex == grdPatientSearchResult.Columns["EditButton"].Index && e.RowIndex > -1)
                {
                    string strId = grdPatientSearchResult.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    int Id = 0;
                    int.TryParse(strId, out Id);

                    string CompositeName = grdPatientSearchResult.Rows[e.RowIndex].Cells["PatientName"].Value.ToString();
                    if (Id > 0)
                    {
                        GlobalVariables.PatientID = Id;
                        GlobalVariables.PatientName = CompositeName;

                        InitData();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }
        }

        private void grdPatientSearchResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in grdPatientSearchResult.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToBoolean(Myrow.Cells[4].Value))// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                //else
                //{
                //    Myrow.DefaultCellStyle.BackColor = Color.Green;
                //}
            }
        }
        private void btnSaveDiadnosis_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.PatientID > 0)
                {
                    Diagnosis diagnosis = new Diagnosis();
                    diagnosis.PatientID = GlobalVariables.PatientID;
                    diagnosis.Text = txtNewDiagnosis.Text;
                    diagnosis.Date = DateTime.Now;

                    diagnosis.CreatedDate = DateTime.Now;
                    diagnosis.CreatedById = GlobalVariables.loggedUserID;

                    if (patientRepository.InsertDiagnosis(diagnosis, logger))
                    {
                        MessageBox.Show("Addedd Suuccessfully");
                        SetPatientDiagnosis();
                    }
                    else
                    {
                        MessageBox.Show("failed to add due to" + PatientRepository.errorMsg);
                        logger.Error("failed to add due to" + PatientRepository.errorMsg);
                    }

                }
                else
                {
                    MessageBox.Show(ErrorMessages.unspecifiedaPatient);
                    logger.Error(ErrorMessages.unspecifiedaPatient);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }


        }

        private void btnSaveFollowUp_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if (GlobalVariables.PatientID > 0)
                {
                    FollowUp followUp = new FollowUp();
                    followUp.PatientID = GlobalVariables.PatientID;
                    followUp.Text = txtNewFollowup.Text;
                    followUp.Date = DateTime.Now;

                    followUp.CreatedDate = DateTime.Now;
                    followUp.CreatedById = GlobalVariables.loggedUserID;

                    if (patientRepository.InsertFollowUp(followUp, logger))
                    {
                        MessageBox.Show("Addedd Suuccessfully");
                        SetPatientFollowUp();
                    }
                    else
                    {
                        MessageBox.Show("failed to add due to" + PatientRepository.errorMsg);
                        logger.Error("failed to add due to" + PatientRepository.errorMsg);
                    }

                }
                else
                {
                    MessageBox.Show("failed to add due to unspecified patient");
                    logger.Error("failed to add due to unspecified patient");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }

        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if (GlobalVariables.PatientID > 0)
                {
                    Treatment treatment = new Treatment();
                    treatment.PatientID = GlobalVariables.PatientID;
                    treatment.Text = txtNewTreatment.Text;
                    treatment.Date = DateTime.Now;

                    treatment.CreatedDate = DateTime.Now;
                    treatment.CreatedById = GlobalVariables.loggedUserID;

                    if (patientRepository.InsertTreatment(treatment, logger))
                    {
                        MessageBox.Show("Addedd Suuccessfully");
                        SetPatientTreatment();
                    }
                    else
                    {
                        MessageBox.Show("failed to add due to" + PatientRepository.errorMsg);
                        logger.Error("failed to add due to" + PatientRepository.errorMsg);
                    }

                }
                else
                {
                    MessageBox.Show("failed to add due to unspecified patient");
                    logger.Error("failed to add due to unspecified patient");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        public void ClearTextArea(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = string.Empty;
        }

        public void SetSubCategory(long Id)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var result = patientRepository.SelectDiagnosisSubCategory(Id, logger);

                ddlSubCategory.DisplayMember = "CombinedField";
                ddlSubCategory.ValueMember = "Id";
                ddlSubCategory.DataSource = result;

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        private void ddlMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var mainCategoryID = ddlMainCategory.SelectedValue;
                SetSubCategory((long)mainCategoryID);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlMainCategory.SelectedIndex > 0 && ddlSubCategory.SelectedIndex > -1)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(((DiagnosisSubCategory)(ddlSubCategory.SelectedItem)).CombinedField);
                    str.Append(Environment.NewLine);
                    txtNewDiagnosis.Text += str;
                }
                else
                    MessageBox.Show("Make Sure you have Specified Diagnosis and Diagnosis Catgeory");



            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }

        private void btnSavePhysicialHistory_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            PhysicalHistory physicalHistory = new PhysicalHistory();

            double height = 0.0;
            double.TryParse(txtPatientHeight.Text, out height);
            physicalHistory.Height = height;

            double weight = 0.0;
            double.TryParse(txtPatientWeight.Text, out weight);
            physicalHistory.Weight = weight;

            double RBS = 0.0;
            double.TryParse(txtRBS.Text, out RBS);
            physicalHistory.RBS = RBS;

            double BMI = 0.0;
            double.TryParse(txtBMI.Text, out BMI);
            physicalHistory.BMI = BMI;

            physicalHistory.PatientID = GlobalVariables.PatientID;

            physicalHistory.CreatedDate = DateTime.Now;
            physicalHistory.CreatedById = GlobalVariables.loggedUserID;

            try
            {
                patientRepository.InsertPhysicalHistory(physicalHistory, logger);
                MessageBox.Show("Successfully Added");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "failed to Add Patient Physical History due to forementioned Exception");
                MessageBox.Show("failed to Add Patient Physical History due to " + ex.Message);
            }

        }
        public void ClearFields()
        {
            ClearTextArea(txtFirstName);
            ClearTextArea(txtMiddleName);
            ClearTextArea(txtLastName);
            ClearTextArea(txtMobile);
            ClearTextArea(txtAge);

            ClearTextArea(txtSearchFirstname);
            ClearTextArea(txtSearchLastName);
            ClearTextArea(txtSearchMobile);

            lblSearchFeesAmount.Text = string.Empty;
            grdPatientSearchResult.DataSource = null;
            grdPatientSearchResult.Hide();

            //ClearTextArea(txtFamilyHistory);
            //ClearTextArea(txtPatientHistory);

            txtOldDiagnosis.Text = string.Empty;
            txtOldFollowup.Text = string.Empty;
            txtOldTreatment.Text = string.Empty;

            lblSearchEmptyGrid.Text = string.Empty;
        }
        private void btn_CancelPatient_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            ClearFields();

            btnCancelSearch_Click(sender, e);

            lblPatientsCount.Text = "";
            lblPatientsCount.Visible = false;
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            ClearFields();
            InitData();
            ClearGlobals();
            lblPatientsCount.Visible = false;

        }
        public double CalculateBMI()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                double weight = 0;
                double.TryParse(txtPatientWeight.Text, out weight);

                double height = 0;
                double.TryParse(txtPatientHeight.Text, out height);


                if (weight > 0 && height > 0)
                    return Math.Round((weight / Math.Pow((height / 100), 2)), 2);

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

            return 0;
        }

        private void txtPatientHeight_TextChanged(object sender, EventArgs e)
        {
            txtBMI.Text = CalculateBMI().ToString();
        }

        private void txtPatientWeight_TextChanged(object sender, EventArgs e)
        {
            txtBMI.Text = CalculateBMI().ToString();
        }

        private void btnPrintTreatment_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            //Open print dialog
            linesPerPage = 0;


            //printPreviewDialog1.ShowDialog();
            
          // if(printPreviewDialog1.DialogResult.Equals(DialogResult.OK) )
                printDocument1.Print();
            
        }
        private void getImageDimensions(Image img, System.Drawing.Printing.PrintPageEventArgs e,
            ref int xr, ref int yr, int mx, int my)
        {
            Rectangle bounds = e.PageBounds;

            int x = img.Width;
            int y = img.Height;
            int xp = bounds.Width * 9 / 10; // for some reason (I can't explain why)
            int yp = bounds.Height * 9 / 10; // 100% appears larger than the page...

            if (x > y)
            {
                xr = xp - mx;
                yr = xr * y / x;
            }
            else
            {
                yr = yp - my;
                xr = yr * x / y;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int linesCount = 0;
            int maxAcceptedLines = 15;

            StringBuilder stringHeader = new StringBuilder();
            string stringBody = "";//= new StringBuilder();

            string finalTextToBePrinted = "";

            printDocument1.DefaultPageSettings.PaperSize = printDocument1.PrinterSettings.
                PaperSizes.Cast<PaperSize>().FirstOrDefault(e => e.PaperName == "A5");
            

            Image img = menuStrip1.BackgroundImage; // this is what I want to print
            int xr = 0, yr = 0;
            getImageDimensions(img, e, ref xr, ref yr, 30, 30);

            Size size = new Size(xr, yr);
            Image copy = (Image)img.Clone();

            int charactersOnPage = 0;
            stringHeader = SetPrescriptionHeaderForPrint();


            if (linesPerPage == 0)
            {
                stringBody=GetTreatmentForPrint(out linesCount).ToString();
                e.Graphics.MeasureString(stringBody.ToString(), this.Font,e.MarginBounds.Size,
                    StringFormat.GenericTypographic,out charactersOnPage, out linesPerPage);
            }

            if (linesPerPage > maxAcceptedLines)
            { 
                string[] numbers = txtNewTreatment.Lines.Take(maxAcceptedLines).Select(i => i.ToString()).ToArray();

                stringBody = string.Join(System.Environment.NewLine,numbers);
                
                linesPerPage -= maxAcceptedLines;
                
                finalTextToBePrinted = stringHeader.ToString() + stringBody.ToString();
                e.Graphics.DrawString(finalTextToBePrinted, new Font("Times New Roman", 13, FontStyle.Italic), Brushes.Black,
               new PointF(25, 220));

                e.HasMorePages = true;

            }
            else
            { 
                stringBody=(string.Join(System.Environment.NewLine,
                    (txtNewTreatment.Lines.Skip(maxAcceptedLines).ToArray())));

                finalTextToBePrinted = stringHeader.ToString() + stringBody.ToString();

                e.Graphics.DrawString(finalTextToBePrinted, new Font("Times New Roman", 13, FontStyle.Italic), Brushes.Black,
               new PointF(25, 220));
                
                e.HasMorePages = false;

            }

            //e.Graphics.DrawString(finalTextToBePrinted, new Font("Times New Roman", 13, FontStyle.Italic), Brushes.Black,
            //    new PointF(25, 220));

            Image img2 = pnlFooter.BackgroundImage; // this is what I want to print
            int xr2 = 0, yr2 = 0;
            getImageDimensions(img2, e, ref xr2, ref yr2, 30, 900);

            Size size2 = new Size(xr2, yr2);
            Image copy2 = (Image)img2.Clone();


        }
     
        public StringBuilder SetPrescriptionHeaderForPrint()//string inputTreatment, out int lineCount)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            StringBuilder printText = new StringBuilder();
            printText.Append((GlobalVariables.PatientTitle + "/ " + GlobalVariables.PatientName).PadLeft(90));

            printText.Append(Environment.NewLine);
            printText.Append(Environment.NewLine);
            printText.Append(Environment.NewLine);
            printText.Append(Environment.NewLine);

            printText.Append("Rx.");
            printText.Append(Environment.NewLine);
            printText.Append(Environment.NewLine);

            //printText.Append(inputTreatment);
          //  printText.Append(Environment.NewLine);

            //lineCount = 8 + txtNewTreatment.Lines.Count();
            return printText;
        }
        public StringBuilder GetTreatmentForPrint(out int lineCount)
        {
            StringBuilder printText = new StringBuilder();
            printText.Append(txtNewTreatment.Text);
            printText.Append(Environment.NewLine);
            lineCount = 8 + txtNewTreatment.Lines.Count();
            return printText;
        }

        private void rad_SearchInsurance_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchInsuranceOptions.Visible = true;
        }

        private void rad_SearchCash_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchInsuranceOptions.Visible = false;
        }
        public bool CheckIfCanConsult()
        {
            var patientID = GlobalVariables.PatientID;
            var patientRecor= patientRepository.SelectPatientByID(patientID, logger);
            if (patientRecor != null)
            {
                if(patientRecor.visitDate < DateTime.Today.Date)
                {
                    if(DateTime.Today.Date.Day <= patientRecor.visitDate.Value.Day + 10)
                            return true;
                    else
                    {
                        logger.Error(ErrorMessages.failedToAddConsultation);
                        MessageBox.Show(ErrorMessages.failedToAddConsultation);
                        return false;
                    }    
                }
                else
                {
                    logger.Error(ErrorMessages.failedToAddConsultationSameDayError);
                    MessageBox.Show(ErrorMessages.failedToAddConsultationSameDayError);
                    return false;
                }
            }
            else
                return false;

        }
        private void btn_SearchSaveNewData_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                Visit visit = new Visit();
                visit.PatientId = GlobalVariables.PatientID;

                if (rad_SearchConsultation.Checked)
                    visit.Consultation = rad_SearchConsultation.Checked;
                else
                    visit.Consultation = false;


                if(CheckIfCanConsult())
                {
                    visit.fees = double.Parse(lblSearchFeesAmount.Text);

                    if (rad_SearchCash.Checked)
                        visit.Cash = rad_SearchCash.Checked;
                    else
                    {
                        visit.Cash = false;
                        visit.InsuranceNumber = txtSearchInsuranceNumber.Text;
                        int iInsuranceCompany = 0;
                        var temp = ddl_SearchInsuranceCompany.SelectedValue.ToString();
                        int.TryParse(temp, out iInsuranceCompany);

                        if (iInsuranceCompany > 0)
                            visit.InsuranceCompanyID = iInsuranceCompany;
                    }

                    visit.VisitDate = DateTime.Now;
                    visit.ModifiedById = GlobalVariables.loggedUserID;


                    if (patientRepository.InsertVisit(visit, logger))
                        MessageBox.Show(ErrorMessages.visitAdded);
                    else
                    {
                        MessageBox.Show(ErrorMessages.failedToAdd);
                        logger.Error(ErrorMessages.failedToAdd);
                    }
                }
                else
                {
                    logger.Error(ErrorMessages.failedToAddConsultation);
                    MessageBox.Show(ErrorMessages.failedToAddConsultation);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }

        private void rad_SearchDiagnosis_CheckedChanged(object sender, EventArgs e)
        {
            lblSearchFeesAmount.Text = GlobalVariables.DiagnosisFees.ToString() + " LE";
        }

        private void rad_SearchConsultation_CheckedChanged(object sender, EventArgs e)
        {
            lblSearchFeesAmount.Text = GlobalVariables.ConsultationFees.ToString();
        }

        private void ddl_SearchInsuranceCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var tempID = ddl_SearchInsuranceCompany.SelectedValue != null ?
                ddl_SearchInsuranceCompany.SelectedValue.ToString() : "";
                int Id = 0;
                int.TryParse(tempID, out Id);

                var Discount = patientRepository.GetDiscountById(Id, logger);
                if (Discount != null)
                {
                    if (rad_SearchDiagnosis.Checked)
                    {
                        lblSearchFeesAmount.Text =
                            (GlobalVariables.DiagnosisFees - (GlobalVariables.DiagnosisFees * (Discount.DiscountPercentage / 100))).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }

        private void txtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                DateTime enteredBirthDate = DateTime.MinValue;
                DateTime? today = DateTime.Now;

                DateTime.TryParse(txtBirthDate.Value.ToString(), out enteredBirthDate);

                if (enteredBirthDate > DateTime.MinValue)
                {
                    int calculatedAge = ((int)(today - enteredBirthDate).Value.TotalDays) / 365;
                    txtAge.Text = calculatedAge.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        public void FillTreatmentCategoryList()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var categories = patientRepository.GetTreatmentCategory(logger);
                ddlTreatmentCategory.DataSource = categories;

                ddlTreatmentCategory.DisplayMember = "category";
                ddlTreatmentCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }
        }

        private void ddlTreatmentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var treatmentCategory = ddlTreatmentCategory.SelectedValue;
                if (treatmentCategory != null)
                {
                    var result = patientRepository.GetTreatmentsByCategory((long)treatmentCategory, logger);

                    ddlTreatmentMedication.DataSource = result;

                    ddlTreatmentMedication.DisplayMember = "productName";
                    ddlTreatmentMedication.ValueMember = "Id";
                    
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }

        }
        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if(ddlTreatmentMedication.SelectedIndex > -1 && ddlTreatmentCategory.SelectedIndex > 0)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(((TreatmentProductionName)(ddlTreatmentMedication.SelectedItem)).productName);
                    str.Append(Environment.NewLine);
                    txtNewTreatment.Text += str;
                }
                else
                    MessageBox.Show("Make Sure you have Specified treatment and treatment Catgeory");

            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
                MessageBox.Show(ErrorMessages.failedToAdd_en);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                if (patientRepository.FinishPatientVisit(GlobalVariables.PatientID, logger))
                {
                    GlobalVariables.PatientID = 0;
                    GlobalVariables.PatientName = string.Empty;
                    InitData();

                    MessageBox.Show("Patient File is closed Successfully");
                }
                else
                    MessageBox.Show("failed to Finish");
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
                MessageBox.Show("failed to Finish");
            }
        }

        private void btnSignout_Click_1(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                this.Close();
                this.Dispose();
                Login login = new Login();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
                MessageBox.Show("failed to Signout");
            }

        }
        public void LoadPatientHistory()
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var patient = patientRepository.SelectPatientByID(GlobalVariables.PatientID, logger);
                if (patient != null)
                {
                    txtFamilyHistory.Text = patient.FamilyHistory;
                    txtPatientHistory.Text = patient.PastHistory;

                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ErrorMessages.catchException);
            }
        }
        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            string strFamilyHistory = txtFamilyHistory.Text;
            string strPastHistory = txtPatientHistory.Text;

            Patient patient = new Patient();

            patient.FamilyHistory = strFamilyHistory;
            patient.PastHistory = strPastHistory;

            if (GlobalVariables.PatientID > 0)
            {
                patient.ModifiedDate = DateTime.Now;
                patient.ModifiedById = GlobalVariables.loggedUserID;
                if (patientRepository.UpdatePatient(patient, GlobalVariables.PatientID, logger))
                {
                    MessageBox.Show(ErrorMessages.updatePatientInfo_ar);
                    SetPatientInfo();
                }
                else
                    MessageBox.Show("failed to update Patient due to " + PatientRepository.errorMsg);

            }
            else
                MessageBox.Show(ErrorMessages.unspecifiedaPatient);
        }

        
    }
}
