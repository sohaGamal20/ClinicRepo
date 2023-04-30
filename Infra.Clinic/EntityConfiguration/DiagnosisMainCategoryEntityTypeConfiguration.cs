    using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Infra.Clinic.EntityConfiguration
{
    public class DiagnosisMainCategoryEntityTypeConfiguration : IEntityTypeConfiguration<DiagnosisMainCategory>
    {
        public void Configure(EntityTypeBuilder<DiagnosisMainCategory> builder)
        {
            builder.ToTable("DiagnosisMainCategory");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.Category).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();

            builder.Property(b => b.CombinedField).HasComputedColumnSql("[Code] +' : '+[Category]");
            builder.HasData(
                    new  { Id = 1L, Code= "E00 - E07", Category = "Disorders of thyroid gland" },
                    new  { Id = 2L, Code = "E08 - E13", Category = "Diabetes mellitus" },
                    new  { Id = 3L, Code = "E15 - E16", Category = "Other disorders of glucose regulation and pancreatic internal secretion" },
                    new  { Id = 4L, Code = "E20-E35", Category = "Disorders of other endocrine glands" },

                    new  { Id = 5L, Code = "E36-E36.8", Category = "Intraoperative complications of endocrine system" },
                    new  { Id = 6L, Code = "E40-E46", Category = "Malnutrition" },
                    new  { Id = 7L, Code = "E50-E64", Category = "Other nutritional deficiencies" },

                    new  { Id = 8L, Code = "E65-E68", Category = "Overweight, obesity and other hyperalimentation" },
                    new  { Id = 9L, Code = "E70-E88", Category = "Metabolic disorders" },
                    new  { Id = 10L, Code = "E89-E89.89", Category = "Postprocedural endocrine and metabolic complications and disorders, not elsewhere classified" }

                );
        }
    }
}
