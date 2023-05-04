using Infra.Clinic.Entity;
using Infra.Clinic.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ClinicDB
{
    public class ContextDB:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
       //   => options.UseSqlServer("Server=.;Database=ClinicDB;Trusted_Connection=True;Encrypt=False;");
         =>options.UseSqlServer("Server=mssql-122542-0.cloudclusters.net,10032;Database=ClinicDB;User Id=sohaGamal;Password=246135_Soha;TrustServerCertificate=True;Encrypt=True;");
      
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Visit>? Visits { get; set; }
        public DbSet<Diagnosis>? Diagnoses { get; set; }
        public DbSet<Treatment>? Treatments { get; set; }
        public DbSet<TreatmentLookup>? Treatmentlookup { get; set; }
        public DbSet<DiscountLookup>? Discounts { get; set; }
        public DbSet<FollowUp>? FollowUps { get; set; }
        public DbSet<PhysicalHistory>? PhysicalHistory { get; set; }

        public DbSet<DiagnosisMainCategory>? DiagnosisMainCategories { get; set; }
        public DbSet<DiagnosisSubCategory>? DiagnosisSubCategories { get; set; }
        public DbSet<DiagnosisLeafNodes>? DiagnosisLeafNodes { get; set; }
        public DbSet<TreatmentProductionName>? TreatmentProductionNames { get; set; }

        public DbSet<ClinicUser>? ClinicUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DiagnosisEntityTypeConfiguration().Configure(modelBuilder.Entity<Diagnosis>());
            new DiscountsEntityTypeConfiguration().Configure(modelBuilder.Entity<DiscountLookup>());

            new FollowUpEntityTypeConfiguration().Configure(modelBuilder.Entity<FollowUp>());
            new InsuranceCompanyEntityTypeConfiguration().Configure(modelBuilder.Entity<InsuranceCompany>());

            new PatientEntityTypeConfiguration().Configure(modelBuilder.Entity<Patient>());
            new PhysicalHistoryEntityTypeConfiguration().Configure(modelBuilder.Entity<PhysicalHistory>());

            new TreatmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Treatment>());
            new TreatmentLookUpEntityTypeConfiguration().Configure(modelBuilder.Entity<TreatmentLookup>());
            new VisitEntityTypeConfiguration().Configure(modelBuilder.Entity<Visit>());

            new DiagnosisMainCategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<DiagnosisMainCategory>());
            new DiagnosisSubCategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<DiagnosisSubCategory>());
            new DiagnosisLeafNodeEntityTypeConfiguration().Configure(modelBuilder.Entity<DiagnosisLeafNodes>());
            new TreatmentProductionNameEntityTypeConfiguration().Configure(modelBuilder.Entity<TreatmentProductionName>());

            new ClinicUserEntityTypeConfiguration().Configure(modelBuilder.Entity<ClinicUser>());
        }


    }
}
