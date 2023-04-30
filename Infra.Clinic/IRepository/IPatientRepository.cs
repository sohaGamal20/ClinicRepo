using Infra.Clinic.DTOs;
using Infra.Clinic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.IRepository
{
    public interface IPatientRepository
    {
        bool CheckPatientExists(long Id);
        List<Patient> SelectAllPatients();
        PatientDTO SelectPatientByID(long Id);
        List<Patient> SelectPatientByName(string Name);
        List<PatientDTO> SearchPatient(string? Name, string? Mobile, string? LastName);
       
        List<Diagnosis> SelectDiagnosisByPatientID(long Id);
        List<Treatment> SelectTreatmentByPatientID(long Id);
        List<FollowUp> SelectFollowupByPatientID(long Id);
        List<PhysicalHistory> SelectPhysicalHistoryByPatintID(long Id);
        List<DiagnosisMainCategory> SelectDiagnosisMainCategory();
        List<DiagnosisSubCategory> SelectDiagnosisSubCategory(long Id);
        List<DiagnosisLeafNodes> SelectDiagnosisLeafNodesCategory(long Id);

        bool InsertDiagnosis(Diagnosis diagnosis);
        bool InsertTreatment(Treatment treatment);
        bool InsertFollowUp(FollowUp followUp);
        bool InsertPhysicalHistory(PhysicalHistory physicalHistory);
        bool InsertPatient(Patient patient);
        bool UpdatePatient(Patient patient, long Id);
        bool DeletePatient(long Id);
        bool InsertVisit(Visit visit);
        ClinicUser Login(string username, string password);
        DiscountLookup GetDiscountById(long Id);
        List<Visit> GetVisitsByPatientID(long Id);

        List<TreatmentLookup> GetTreatmentCategory();
        List<TreatmentProductionName> GetTreatmentsByCategory( long categoryID);

        List<DiscountLookup> GetInsuranceCompany();
        bool FinishPatientVisit(long patientId);
        int GetTotalPatientsInVisitByDate();
        int GetPendingPatientsInVisitByDate();


    }
}
