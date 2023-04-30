using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class DiagnosisLeafNodeEntityTypeConfiguration : IEntityTypeConfiguration<DiagnosisLeafNodes>
    {
        public void Configure(EntityTypeBuilder<DiagnosisLeafNodes> builder)
        {
            builder.ToTable("DiagnosisLeafNodes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.Title).IsRequired();

            builder.Property(b => b.CreatedDate);
            builder.Property(b => b.CreatedById);
            builder.Property(b => b.ModifiedDate);
            builder.Property(b => b.ModifiedById);
            builder.Property(b => b.RowVersion).HasColumnName("Row_Version").IsRowVersion();
            builder.Property(b => b.CombinedField).HasComputedColumnSql("[Code] +' : '+[Title]");

            builder.HasData(
                new { Id = 1L, DiagnosisSubCategoryId = 1l, Code = "E00.0", Title= "Congenital iodine-deficiency syndrome, neurological type" },
                new { Id = 2L, DiagnosisSubCategoryId = 1l, Code = "E00.1", Title = "Congenital iodine-deficiency syndrome, myxedematous type" },
                new { Id = 3L, DiagnosisSubCategoryId = 1l, Code = "E00.2", Title = "Congenital iodine-deficiency syndrome, mixed type" },
                new { Id = 4L, DiagnosisSubCategoryId = 1l, Code = "E00.9", Title = "Congenital iodine-deficiency syndrome, unspecified" },

                new { Id = 5L, DiagnosisSubCategoryId = 2l, Code = "E01.0", Title = "Iodine - deficiency related diffuse(endemic) goiter" },
                new { Id = 6L, DiagnosisSubCategoryId = 2l, Code = "E01.1", Title = "Iodine - deficiency related multinodular(endemic) goiter" },
                new { Id = 7L, DiagnosisSubCategoryId = 2l, Code = "E01.2", Title = "Iodine - deficiency related(endemic) goiter, unspecified" },
                new { Id = 8L, DiagnosisSubCategoryId = 2l, Code = "E01.8", Title = "Other iodine-deficiency related thyroid disorders and allied conditions" },

                new { Id = 9L,  DiagnosisSubCategoryId = 4l, Code = "E03.0", Title = "Congenital hypothyroidism with diffuse goiter" },
                new { Id = 10L, DiagnosisSubCategoryId = 4l, Code = "E03.1", Title = "Congenital hypothyroidism without goiter" },
                new { Id = 11L, DiagnosisSubCategoryId = 4l, Code = "E03.2", Title = "Hypothyroidism due to medicaments and other exogenous substances" },
                new { Id = 12L, DiagnosisSubCategoryId = 4l, Code = "E03.3", Title = "Postinfectious hypothyroidism" },
                new { Id = 13L, DiagnosisSubCategoryId = 4l, Code = "E03.4", Title = "Atrophy of thyroid(acquired)" },
                new { Id = 14L, DiagnosisSubCategoryId = 4l, Code = "E03.5", Title = "Myxedema coma" },
                new { Id = 15L, DiagnosisSubCategoryId = 4l, Code = "E03.8", Title = "Other specified hypothyroidism" },
                new { Id = 16L, DiagnosisSubCategoryId = 4l, Code = "E03.9", Title = "Hypothyroidism, unspecified" },

                new { Id = 17L, DiagnosisSubCategoryId = 5l, Code = "E04.0", Title = "Nontoxic diffuse goiter" },
                new { Id = 18L, DiagnosisSubCategoryId = 5l, Code = "E04.1", Title = "Nontoxic single thyroid nodule" },
                new { Id = 19L, DiagnosisSubCategoryId = 5l, Code = "E04.2", Title = "Nontoxic multinodular goiter" },
                new { Id = 20L, DiagnosisSubCategoryId = 5l, Code = "E04.8", Title = "Other specified nontoxic goiter" },
                new { Id = 21L, DiagnosisSubCategoryId = 5l, Code = "E04.9", Title = "Nontoxic goiter, unspecified" },

                new { Id = 22L, DiagnosisSubCategoryId = 6l, Code = "E05.0", Title = "Thyrotoxicosis with diffuse goiter" },
                new { Id = 23L, DiagnosisSubCategoryId = 6l, Code = "E05.1", Title = "Thyrotoxicosis with toxic single thyroid nodule" },
                new { Id = 24L, DiagnosisSubCategoryId = 6l, Code = "E05.2", Title = "Thyrotoxicosis with toxic multinodular goiter" },
                new { Id = 25L, DiagnosisSubCategoryId = 6l, Code = "E05.3", Title = "Thyrotoxicosis from ectopic thyroid tissue" },
                new { Id = 26L, DiagnosisSubCategoryId = 6l, Code = "E05.4", Title = "Thyrotoxicosis factitia" },
                new { Id = 27L, DiagnosisSubCategoryId = 6l, Code = "E05.8", Title = "Other thyrotoxicosis" },
                new { Id = 28L, DiagnosisSubCategoryId = 6l, Code = "E05.9", Title = "Thyrotoxicosis, unspecified" },

                new { Id = 29L, DiagnosisSubCategoryId = 7l, Code = "E06.0", Title = "Acute thyroiditis" },
                new { Id = 30L, DiagnosisSubCategoryId = 7l, Code = "E06.1", Title = "Subacute thyroiditis" },
                new { Id = 31L, DiagnosisSubCategoryId = 7l, Code = "E06.2", Title = "Chronic thyroiditis with transient thyrotoxicosis" },
                new { Id = 32L, DiagnosisSubCategoryId = 7l, Code = "E06.3", Title = "Autoimmune thyroiditis" },
                new { Id = 33L, DiagnosisSubCategoryId = 7l, Code = "E06.4", Title = "Drug - induced thyroiditis" },
                new { Id = 34L, DiagnosisSubCategoryId = 7l, Code = "E06.5", Title = "Other chronic thyroiditis" },
                new { Id = 35L, DiagnosisSubCategoryId = 7l, Code = "E06.9", Title = "Thyroiditis, unspecified" },

                new { Id = 36L, DiagnosisSubCategoryId = 8l, Code = "E07.0", Title = "Hypersecretion of calcitonin" },
                new { Id = 37L, DiagnosisSubCategoryId = 8l, Code = "E07.1", Title = "Dyshormogenetic goiter" },
                new { Id = 38L, DiagnosisSubCategoryId = 8l, Code = "E07.8", Title = "Other specified disorders of thyroid" },
                new { Id = 39L, DiagnosisSubCategoryId = 8l, Code = "E07.9", Title = "Disorder of thyroid, unspecified" }


                );


























        }
    }
}
