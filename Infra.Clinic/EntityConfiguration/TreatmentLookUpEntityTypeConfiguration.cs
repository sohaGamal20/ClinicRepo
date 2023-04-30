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
    public class TreatmentLookUpEntityTypeConfiguration : EntityTypeConfiguration<TreatmentLookup>
    {
        public void Configure(EntityTypeBuilder<TreatmentLookup> builder)
        {
            builder.ToTable("TreatmentLookUp");

            builder.HasKey(x => x.Id);

            builder.Property(b => b.category).IsRequired();
            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();

            builder.HasData(
                new { Id = 1L, category="Diabetes Mellitus" },
                new { Id = 2L, category= "Anti-hestaminic & Respiratory Drugs" },
                new { Id = 3L, category= "Anti-inflammatory Drugs" },
                new { Id = 4L, category= "ANTI-FUNGAL" },
                new { Id = 5L, category= "CIRCULATORY DISTURBANCE AGENTS" },
                new { Id = 6L, category= "CORTECOSTEROIDS" },
                new { Id = 7L, category= "DRUG AFFECTING CENTRAL NERVOUS SYSTEM" },
                new { Id = 8L, category= "LIVER SUPPORT > MULTIVITAMINS" },
                new { Id = 9L, category= "Anti-hypertensive drugs > Loop duiretics" },
                new { Id = 10L, category= "Anti-hypertensive drugs > Aldosterone antagonist duiretics" },
                new { Id = 11L, category= "Sexual Wellness Supplements" },
                new { Id = 12L, category= "strong anti-emetic & adjuvent used with anti-neoplastic" },
                new { Id = 13L, category= "Vitamins & Supplements> folic acid > Calcium" },
                new { Id = 14L, category= "Vitamins & Supplements> folic acid > Multivitamins" }

                );

          
        }


    }
}
