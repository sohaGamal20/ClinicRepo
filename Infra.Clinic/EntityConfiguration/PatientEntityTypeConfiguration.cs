using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.MiddleName).IsRequired();
            builder.Property(x => x.FamilyName).IsRequired();

            builder.Property(x => x.CompositeName).HasComputedColumnSql("[FirstName] +' ' +[MiddleName] +' '+ [FamilyName]");
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Gender).IsRequired();

            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(11);
            
            builder.Property(x => x.FamilyHistory).IsRequired(false);
            builder.Property(x => x.PastHistory).IsRequired(false);

            builder.Property(x => x.BirthdDate).IsRequired(true);

            builder.HasMany<Visit>(x => x.LstVisits);
            builder.HasMany<PhysicalHistory>(x => x.LstPhysicalHistory);
            builder.HasMany<FollowUp>(x => x.LstFollowUp);
            builder.HasMany<Treatment>(x => x.LstTreatment);

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();

            
        }
      
       
    }
}
