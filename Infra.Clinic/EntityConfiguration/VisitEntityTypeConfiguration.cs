using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class VisitEntityTypeConfiguration : EntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            this.ToTable("Visit");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.VisitDate).IsRequired();
            
            builder.Property(x => x.Consultation).IsRequired();
            builder.Property(x => x.Cash).IsRequired();
            builder.Property(x => x.fees).IsRequired();

            builder.Property(x => x.InsuranceCompanyID).HasDefaultValue(0);
            builder.Property(x=>x.InsuranceNumber).IsRequired(false);
            builder.Property(x => x.isChecked).HasDefaultValue(false);

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();
        }
     
    }
}
