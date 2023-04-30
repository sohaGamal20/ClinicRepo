using Infra.Clinic.DTOs;
using Infra.Clinic.Entity;
using Infra.Clinic.IRepository;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Linq;

namespace ClinicDB.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ContextDB ctx;
        public static string errorMsg = string.Empty;
        public PatientRepository()
        {
            ctx = new ContextDB();
        }
        public bool DeletePatient(long Id)
        {
            try
            {
                var patient = ctx.Patients.FirstOrDefault(x => x.Id == Id);
                if (patient != null)
                {
                    ctx.Patients.Remove(patient);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false; 
            }
            
        }

        public bool InsertPatient(Patient patient)
        {
            try
            {
                if (!ctx.Patients.Any(p => p.Id == patient.Id))
                {
                    ctx.Patients.Add(patient);
                    ctx.SaveChanges();
                }
                else
                    throw new Exception("Failed to insert");

                return true;
            }
            catch(Exception ex) {
                errorMsg = ex.Message; 
                return false; }
        }

        public List<PatientDTO> SearchPatient(string? Name, string? Mobile, string? LastName)
        {
            var temp = (
                from p in ctx.Patients
                join v in ctx.Visits
                on p.Id equals v.PatientId into joinedTbl
                from joined in joinedTbl.DefaultIfEmpty()
                where ((string.IsNullOrEmpty(Name) || p.FirstName.Contains(Name))
               && (string.IsNullOrEmpty(Mobile) || p.Mobile.Contains(Mobile))
                && (string.IsNullOrEmpty(LastName) || p.FamilyName.Contains(LastName)))
                orderby p.Id descending
                select (new PatientDTO
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    MiddleName = p.MiddleName,
                    FamilyName = p.FamilyName,
                    CompositeName = p.CompositeName,
                    isChecked = joined.isChecked,
                    visitDate = joined.VisitDate.Date
                  
                })
            ).Distinct().OrderByDescending(p=>p.Id) ; 
            return temp.ToList();

        }

        public List<Patient> SelectAllPatients()
        {
            return ctx.Patients.ToList();
        }

        public PatientDTO? SelectPatientByID(long Id)
        {
            if (ctx.Patients.Any(p => p.Id == Id))
            {
                return (from p in ctx.Patients
                        join v in ctx.Visits
                        on p.Id equals v.PatientId 
                        where p.Id == Id
                        orderby v.Id descending
                        select (new PatientDTO
                        {
                            Id = p.Id,
                            FirstName = p.FirstName,
                            MiddleName = p.MiddleName,
                            FamilyName = p.FamilyName,
                            Age = p.Age,
                            BirthdDate = p.BirthdDate,
                            CompositeName = p.CompositeName,
                            Gender = p.Gender,
                            Mobile = p.Mobile,
                            InsuranceCompanyID = v.InsuranceCompanyID,
                            InsuranceNumber = v.InsuranceNumber,
                            Consultation = v.Consultation,
                            Cash = v.Cash,
                            FamilyHistory = p.FamilyHistory,
                            PastHistory = p.PastHistory
                        })).FirstOrDefault();
                
            }
            else
                return null;

        }

        public List<Patient> SelectPatientByName(string Name)
        {
            return ctx.Patients.Where(s => s.CompositeName.Contains(Name)).ToList<Patient>();
        }

        public bool UpdatePatient(Patient patient,long Id)
        {
            try
            {
                var inst = ctx.Patients?.Find(Id);
                if (inst != null)
                {
                    //inst.InsuranceNumber = patient.InsuranceNumber;
                    //inst.InsuranceCompanyID = patient.InsuranceCompanyID;

                    inst.FirstName = patient.FirstName;
                    inst.MiddleName = patient.MiddleName;
                    inst.FamilyName = patient.FamilyName;

                    inst.FamilyHistory = patient.FamilyHistory;
                    inst.PastHistory = patient.PastHistory;
                    inst.BirthdDate = patient.BirthdDate;

                   // inst.Cash = patient.Cash;
                    inst.Age = patient.Age;
                    //inst.Consultation = patient.Consultation;
                    inst.Gender = patient.Gender;
                    inst.BirthdDate = patient.BirthdDate;

                    ctx.Update(inst);
                    ctx.SaveChanges();
                }
                return true;
            }
            catch(Exception ex) {
                errorMsg = ex.Message;
                return false; 
            }
        }

        public List<Diagnosis> SelectDiagnosisByPatientID(long Id)
        {
            return ctx.Diagnoses.Where(f => f.PatientID == Id)
                .ToList();
        }

        public List<Treatment> SelectTreatmentByPatientID(long Id)
        {
            return ctx.Treatments.Where(f => f.PatientID == Id).ToList();
        }

        public List<FollowUp> SelectFollowupByPatientID(long Id)
        {
            return ctx.FollowUps.Where(f=>f.PatientID == Id).ToList();

        }

        public bool InsertDiagnosis(Diagnosis diagnosis)
        {
            try
            {
                ctx.Diagnoses.Add(diagnosis);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool InsertTreatment(Treatment treatment)
        {
            try
            {
                ctx.Treatments.Add(treatment);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool InsertFollowUp(FollowUp followUp)
        {
            try
            {
                ctx.FollowUps.Add(followUp);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool CheckPatientExists(long Id)
        {
           return ctx.Patients.Any(p=>p.Id == Id);
        }

        public List<DiagnosisMainCategory> SelectDiagnosisMainCategory()
        {
            return ctx.DiagnosisMainCategories.ToList()
                .Prepend(new DiagnosisMainCategory{CombinedField = " ----SelectALL---" }).ToList();
            
        }

        public List<DiagnosisSubCategory> SelectDiagnosisSubCategory(long Id)
        {
            return ctx.DiagnosisSubCategories.Where(d=>d.DiagnosisMainCategoryId == Id).ToList();
        }

        public List<DiagnosisLeafNodes> SelectDiagnosisLeafNodesCategory(long Id)
        {
            return ctx.DiagnosisLeafNodes.Where(d => d.DiagnosisSubCategoryId == Id).ToList();
        }

        public ClinicUser Login(string username, string password)
        {
            return ctx.ClinicUsers.Where(c => c.UserName == username && c.Password == password).SingleOrDefault();
        }

        public List<PhysicalHistory> SelectPhysicalHistoryByPatintID(long Id)
        {
            return (from ph in ctx.PhysicalHistory
                    where ph.PatientID == Id
                    orderby ph.Id descending
                    select (ph)
                   
                ).ToList();
        }

        public bool InsertPhysicalHistory(PhysicalHistory physicalHistory)
        {
            try
            {
                ctx.PhysicalHistory.Add(physicalHistory);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                errorMsg = ex.ToString();
                return false;
            }
        }

        public bool InsertVisit(Visit visit)
        {
            try
            {
                ctx.Visits.Add(visit);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                errorMsg = ex.ToString();
                return false;
            }
        }

        public DiscountLookup GetDiscountById(long Id)
        {
            return ctx.Discounts.FirstOrDefault(d=>d.Id == Id);
        }

        public List<Visit> GetVisitsByPatientID(long Id)
        {
            var temp = (
                from v in ctx.Visits
                join p in ctx.Patients  
                on v.PatientId equals p.Id
                where p.Id == Id
                orderby v.Id descending
                select(
                new Visit{ 
                    VisitDate=v.VisitDate,
                    Cash=v.Cash,
                    Consultation=v.Consultation,
                    InsuranceCompanyID =v.InsuranceCompanyID,
                    InsuranceNumber=v.InsuranceNumber,
                    fees = v.fees
                })
                );
            return temp.ToList();
        }

        public List<TreatmentLookup> GetTreatmentCategory()
        {
            return ctx.Treatmentlookup.ToList()
                .Prepend(new TreatmentLookup { category = " ----SelectALL---" }).ToList(); 
        }

        public List<TreatmentProductionName> GetTreatmentsByCategory(long categoryID)
        {
            var result = ( from t in ctx.TreatmentProductionNames
                               where t.TreatmentLookupId == categoryID
                           select new TreatmentProductionName { 
                           productImage=t.productImage,
                           productName=t.productName
                           }

                );
            return result.ToList();
        }

        public List<DiscountLookup> GetInsuranceCompany()
        {
            return ctx.Set<DiscountLookup>().ToList();

        }

        public bool FinishPatientVisit(long patientId)
        {
            var temp = (from p in ctx.Patients
                        join v in ctx.Visits
                        on p.Id equals v.PatientId
                        where p.Id == patientId &&
                        v.VisitDate.Date == DateTime.Today.Date
                        select new {
                        visitId = v.Id
                        }) ;
            var visit =  temp.ToList().FirstOrDefault();
            if(visit != null)
            {
                var editVisit = ctx.Visits.Find(visit.visitId);
                editVisit.isChecked = true;
                
                ctx.Update(editVisit);
                ctx.SaveChanges();
                return true;
            }
            return false;

        }

        public int GetTotalPatientsInVisitByDate()
        {
            var temp = (from p in ctx.Patients
                        join v in ctx.Visits
                        on p.Id equals v.PatientId
                        where
                        v.VisitDate.Date == DateTime.Today.Date
                        select new
                        {
                           patientID=p.Id
                        });

           return temp.ToList().Count();
        }

        public int GetPendingPatientsInVisitByDate()
        {
            var temp = (from p in ctx.Patients
                        join v in ctx.Visits
                        on p.Id equals v.PatientId
                        where v.isChecked == false &&
                        v.VisitDate.Date == DateTime.Today.Date
                        
                        select new
                        {
                            patientID = p.Id
                        });

            return temp.ToList().Count();
        }
    }
}
