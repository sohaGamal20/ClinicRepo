using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class PhysicalHistoryEntityTypeConfiguration : IEntityTypeConfiguration<PhysicalHistory>
    {
        public void Configure(EntityTypeBuilder<PhysicalHistory> builder)
        {
            builder.ToTable("PhysicalHistory");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PatientID).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weight).IsRequired();

            builder.Property(x => x.BMI).IsRequired();
            builder.Property(x => x.RBS).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();
        }
       
    }
}
