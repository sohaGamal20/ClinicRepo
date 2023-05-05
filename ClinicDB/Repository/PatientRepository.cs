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
        public static string errorMsg { get; set; }
        public PatientRepository()
        {
            ctx = new ContextDB();
        }
        public bool DeletePatient(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
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
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }

        }

        public bool InsertPatient(Patient patient, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

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
            catch (Exception ex)
            {
                errorMsg = ex.Message; 
                logger.Error(ex.ToString());
                return false;
            }
        }

        public List<PatientDTO> SearchPatient(string? Name, string? Mobile, string? LastName, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var temp = (
               from p in ctx.Patients
               join v in ctx.Visits
               on p.Id equals v.PatientId
               where ((string.IsNullOrEmpty(Name) || p.FirstName.Contains(Name))
               && (string.IsNullOrEmpty(Mobile) || p.Mobile.Contains(Mobile))
               && (string.IsNullOrEmpty(LastName) || p.FamilyName.Contains(LastName)))
               orderby v.Id descending
               select (new PatientDTO
               {
                   Id = p.Id,
                   FirstName = p.FirstName,
                   MiddleName = p.MiddleName,
                   FamilyName = p.FamilyName,
                   CompositeName = p.CompositeName,
                   isChecked = v.isChecked,
                   visitDate = v.VisitDate.Date,
                   visitType = v.Consultation ? "استشارة" : "كشف",
                   visitId = v.Id
               })
               ).OrderByDescending(v => v.visitId); //.Distinct()

                return temp.ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<Patient> SelectAllPatients(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try { return ctx.Patients.ToList(); }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }
        }

        public PatientDTO? SelectPatientByID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
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
                                PastHistory = p.PastHistory,
                                visitDate = v.VisitDate
                            })).FirstOrDefault();

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }


        }

        public List<Patient> SelectPatientByName(string Name, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                return ctx.Patients.Where(s => s.CompositeName.Contains(Name)).ToList<Patient>();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }
        }

        public bool UpdatePatient(Patient patient, long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var inst = ctx.Patients?.Find(Id);
                if (inst != null)
                {
                    //inst.InsuranceNumber = patient.InsuranceNumber;
                    //inst.InsuranceCompanyID = patient.InsuranceCompanyID;
                    if(!string.IsNullOrEmpty(patient.FirstName))
                        inst.FirstName = patient.FirstName;
                    if (!string.IsNullOrEmpty(patient.MiddleName))
                        inst.MiddleName = patient.MiddleName;

                    if (!string.IsNullOrEmpty(patient.FamilyName))
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
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public List<Diagnosis> SelectDiagnosisByPatientID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                return ctx.Diagnoses.Where(f => f.PatientID == Id)
                    .ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }
        }

        public List<Treatment> SelectTreatmentByPatientID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try { return ctx.Treatments.Where(f => f.PatientID == Id).ToList(); }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }
        }

        public List<FollowUp> SelectFollowupByPatientID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.FollowUps.Where(f => f.PatientID == Id).ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public bool InsertDiagnosis(Diagnosis diagnosis, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ctx.Diagnoses.Add(diagnosis);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public bool InsertTreatment(Treatment treatment, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ctx.Treatments.Add(treatment);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public bool InsertFollowUp(FollowUp followUp, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ctx.FollowUps.Add(followUp);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public bool CheckPatientExists(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.Patients.Any(p => p.Id == Id);
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }

        }

        public List<DiagnosisMainCategory> SelectDiagnosisMainCategory(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.DiagnosisMainCategories.ToList()
              .Prepend(new DiagnosisMainCategory { CombinedField = " ----SelectALL---" }).ToList();

            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<DiagnosisSubCategory> SelectDiagnosisSubCategory(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.DiagnosisSubCategories.Where(d => d.DiagnosisMainCategoryId == Id).ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }
        }

        public List<DiagnosisLeafNodes> SelectDiagnosisLeafNodesCategory(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.DiagnosisLeafNodes.Where(d => d.DiagnosisSubCategoryId == Id).ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public ClinicUser Login(string username, string password, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.ClinicUsers.Where(c => c.UserName == username && c.Password == password).SingleOrDefault();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<PhysicalHistory> SelectPhysicalHistoryByPatintID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return (from ph in ctx.PhysicalHistory
                        where ph.PatientID == Id
                        orderby ph.Id descending
                        select (ph)

               ).ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public bool InsertPhysicalHistory(PhysicalHistory physicalHistory, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ctx.PhysicalHistory.Add(physicalHistory);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public bool InsertVisit(Visit visit, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                ctx.Visits.Add(visit);
                ctx.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public DiscountLookup GetDiscountById(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.Discounts.FirstOrDefault(d => d.Id == Id);
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<Visit> GetVisitsByPatientID(long Id, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var temp = (
                   from v in ctx.Visits
                   join p in ctx.Patients
                   on v.PatientId equals p.Id
                   where p.Id == Id
                   orderby v.Id descending
                   select (
                   new Visit
                   {
                       VisitDate = v.VisitDate,
                       Cash = v.Cash,
                       Consultation = v.Consultation,
                       InsuranceCompanyID = v.InsuranceCompanyID,
                       InsuranceNumber = v.InsuranceNumber,
                       fees = v.fees
                   })
                   );
                return temp.ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }


        }

        public List<TreatmentLookup> GetTreatmentCategory(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                return ctx.Treatmentlookup.ToList()
              .Prepend(new TreatmentLookup { category = " ----SelectALL---" }).ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<TreatmentProductionName> GetTreatmentsByCategory(long categoryID, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                var result = (from t in ctx.TreatmentProductionNames
                              where t.TreatmentLookupId == categoryID
                              select new TreatmentProductionName
                              {
                                  productImage = t.productImage,
                                  productName = t.productName
                              }

           );
                return result.ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public List<DiscountLookup> GetInsuranceCompany(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                return ctx.Set<DiscountLookup>().ToList();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return null;
            }

        }

        public bool FinishPatientVisit(long patientId, Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var temp = (from p in ctx.Patients
                            join v in ctx.Visits
                            on p.Id equals v.PatientId
                            where p.Id == patientId &&
                            v.VisitDate.Date == DateTime.Today.Date
                            select new
                            {
                                visitId = v.Id
                            });
                var visit = temp.ToList().FirstOrDefault();
                if (visit != null)
                {
                    var editVisit = ctx.Visits.Find(visit.visitId);
                    editVisit.isChecked = true;

                    ctx.Update(editVisit);
                    ctx.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return false;
            }
        }

        public int GetTotalPatientsInVisitByDate(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                var temp = (from p in ctx.Patients
                            join v in ctx.Visits
                            on p.Id equals v.PatientId
                            where
                            v.VisitDate.Date == DateTime.Today.Date
                            select new
                            {
                                patientID = p.Id
                            });

                return temp.ToList().Count();
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return 0;
            }
        }

        public int GetPendingPatientsInVisitByDate(Serilog.ILogger logger)
        {
            logger.Information("method Name ==> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
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
            catch (Exception ex)
            {
                errorMsg = ex.Message;  logger.Error(ex.ToString());
                return 0;
            }
        }

    }
}