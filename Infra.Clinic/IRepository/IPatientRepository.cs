using Infra.Clinic.DTOs;
using Infra.Clinic.Entity;
using Serilog;
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
        bool CheckPatientExists(long Id, ILogger logger);
        List<Patient> SelectAllPatients(ILogger logger);
        PatientDTO SelectPatientByID(long Id, ILogger logger);
        List<Patient> SelectPatientByName(string Name, ILogger logger);
        List<PatientDTO> SearchPatient(string? Name, string? Mobile, string? LastName, ILogger logger);

        List<Diagnosis> SelectDiagnosisByPatientID(long Id, ILogger logger);
        List<Treatment> SelectTreatmentByPatientID(long Id, ILogger logger);
        List<FollowUp> SelectFollowupByPatientID(long Id, ILogger logger);
        List<PhysicalHistory> SelectPhysicalHistoryByPatintID(long Id, ILogger logger);
        List<DiagnosisMainCategory> SelectDiagnosisMainCategory(ILogger logger);
        List<DiagnosisSubCategory> SelectDiagnosisSubCategory(long Id, ILogger logger);
        List<DiagnosisLeafNodes> SelectDiagnosisLeafNodesCategory(long Id, ILogger logger);

        bool InsertDiagnosis(Diagnosis diagnosis, ILogger logger);
        bool InsertTreatment(Treatment treatment, ILogger logger);
        bool InsertFollowUp(FollowUp followUp, ILogger logger);
        bool InsertPhysicalHistory(PhysicalHistory physicalHistory, ILogger logger);
        bool InsertPatient(Patient patient, ILogger logger);
        bool UpdatePatient(Patient patient, long Id, ILogger logger);
        bool DeletePatient(long Id, ILogger logger);
        bool InsertVisit(Visit visit, ILogger logger);
        ClinicUser Login(string username, string password, ILogger logger);
        DiscountLookup GetDiscountById(long Id, ILogger logger);
        List<Visit> GetVisitsByPatientID(long Id, ILogger logger);

        List<TreatmentLookup> GetTreatmentCategory(ILogger logger);
        List<TreatmentProductionName> GetTreatmentsByCategory( long categoryID, ILogger logger);

        List<DiscountLookup> GetInsuranceCompany(ILogger  logger);
        bool FinishPatientVisit(long patientId, ILogger logger);
        int GetTotalPatientsInVisitByDate(ILogger logger);
        int GetPendingPatientsInVisitByDate(ILogger logger);


    }
}
