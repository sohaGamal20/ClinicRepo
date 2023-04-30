using Infra.Clinic.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.EntityConfiguration
{
    public class DiagnosisSubCategoryEntityTypeConfiguration : IEntityTypeConfiguration<DiagnosisSubCategory>
    {
        public void Configure(EntityTypeBuilder<DiagnosisSubCategory> builder)
        {
            builder.ToTable("DiagnosisSubCategory");

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
                    new { Id = 1L, Code = "E00", Category= "Congenital iodine - deficiency syndrome", DiagnosisMainCategoryId=1L },
                    new { Id = 2L, Code = "E01", Category = "Iodine - deficiency related thyroid disorders and allied conditions", DiagnosisMainCategoryId = 1L },
                    new { Id = 3L, Code = "E02", Category = "Subclinical iodine - deficiency hypothyroidism", DiagnosisMainCategoryId = 1L },
                    new { Id = 4L, Code = "E03", Category = "Other hypothyroidism", DiagnosisMainCategoryId = 1L },
                    new { Id = 5L, Code = "E04", Category = "Other nontoxic goiter", DiagnosisMainCategoryId = 1L },
                    new { Id = 6L, Code = "E05", Category = "Thyrotoxicosis[hyperthyroidism]", DiagnosisMainCategoryId = 1L },
                    new { Id = 7L, Code = "E06", Category = "Thyroiditis", DiagnosisMainCategoryId = 1L },
                    new { Id = 8L, Code = "E07", Category = "Other disorders of thyroid", DiagnosisMainCategoryId = 1L },

                    new { Id = 9L, Code ="E08", Category = "Diabetes mellitus due to underlying condition", DiagnosisMainCategoryId = 2L },
                    new { Id = 10L, Code ="E09", Category = "Drug or chemical induced diabetes mellitus", DiagnosisMainCategoryId = 2L },
                    new { Id = 11L, Code ="E10", Category = "Type 1 diabetes mellitus", DiagnosisMainCategoryId = 2L },
                    new { Id = 12L, Code ="E11", Category = "Type 2 diabetes mellitus", DiagnosisMainCategoryId = 2L },
                    new { Id = 13L, Code ="E13", Category ="Other specified diabetes mellitus", DiagnosisMainCategoryId = 2L },

                    new { Id = 14L, Code ="E15", Category = "Nondiabetic hypoglycemic coma", DiagnosisMainCategoryId = 3L },
                    new { Id = 15L, Code ="E16", Category = "Other disorders of pancreatic internal secretion", DiagnosisMainCategoryId = 3L },

                    new { Id = 16L, Code ="20", Category = "Hypoparathyroidism", DiagnosisMainCategoryId = 4L },
                    new { Id = 17L, Code ="E21", Category = "Hyperparathyroidism and other disorders of parathyroid gland", DiagnosisMainCategoryId = 4L },
                    new { Id = 18L, Code ="E22", Category = "Hyperfunction of pituitary gland", DiagnosisMainCategoryId = 4L },
                    new { Id = 19L, Code ="E23", Category = "Hypofunction and other disorders of the pituitary gland", DiagnosisMainCategoryId = 4L },
                    new { Id = 20L, Code ="E24", Category = "Cushing's syndrome", DiagnosisMainCategoryId = 4L },
                    new { Id = 21L, Code ="E25", Category = "Adrenogenital disorders", DiagnosisMainCategoryId = 4L },
                    new { Id = 22L, Code ="E26", Category = "Hyperaldosteronism", DiagnosisMainCategoryId = 4L },
                    new { Id = 23L, Code ="E27", Category = "Other disorders of adrenal gland", DiagnosisMainCategoryId = 4L },
                    new { Id = 24L, Code ="E28", Category = "Ovarian dysfunction", DiagnosisMainCategoryId = 4L },
                    new { Id = 25L, Code ="E29", Category = "Testicular dysfunction", DiagnosisMainCategoryId = 4L },
                    new { Id = 26L, Code ="E30", Category = "Disorders of puberty, not elsewhere classified", DiagnosisMainCategoryId = 4L },
                    new { Id = 27L, Code ="E31", Category = "Polyglandular dysfunction", DiagnosisMainCategoryId = 4L },
                    new { Id = 28L, Code ="E32", Category = "Diseases of thymus", DiagnosisMainCategoryId = 4L },
                    new { Id = 29L, Code ="E34", Category = "Other endocrine disorders", DiagnosisMainCategoryId = 4L },
                    new { Id = 30L, Code ="E35", Category = "Disorders of endocrine glands in diseases classified elsewhere", DiagnosisMainCategoryId = 4L },

                    new { Id = 31L, Code ="E36", Category = "Intraoperative complications of endocrine system", DiagnosisMainCategoryId = 5L },

                    new { Id = 32L, Code ="E40", Category = "Kwashiorkor", DiagnosisMainCategoryId = 6L },
                    new { Id = 33L, Code ="E41", Category = "Nutritional marasmus", DiagnosisMainCategoryId = 6L },
                    new { Id = 34L, Code ="E42", Category = "Marasmic kwashiorkor", DiagnosisMainCategoryId = 6L },
                    new { Id = 35L, Code ="E43", Category = "Unspecified severe protein-calorie malnutrition", DiagnosisMainCategoryId = 6L },
                    new { Id = 36L, Code ="E44", Category = "Protein-calorie malnutrition of moderate and mild degree", DiagnosisMainCategoryId = 6L },
                    new { Id = 37L, Code ="E45", Category = "Retarded development following protein-calorie malnutrition", DiagnosisMainCategoryId = 6L },
                    new { Id = 38L, Code ="E46", Category = "Unspecified protein-calorie malnutrition", DiagnosisMainCategoryId = 6L },

                    new { Id = 39L, Code ="E50", Category = "Vitamin A deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 40L, Code ="E51", Category = "Thiamine deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 41L, Code ="E52", Category = "Niacin deficiency [pellagra]", DiagnosisMainCategoryId = 7L },
                    new { Id = 42L, Code ="E53", Category = "Deficiency of other B group vitamins", DiagnosisMainCategoryId = 7L },
                    new { Id = 43L, Code ="E54", Category = "Ascorbic acid deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 44L, Code ="E55", Category = "Vitamin D deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 45L, Code ="E56", Category = "Other vitamin deficiencies", DiagnosisMainCategoryId = 7L },
                    new { Id = 46L, Code ="E58", Category = "Dietary calcium deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 47L, Code ="E59", Category = "Dietary selenium deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 48L, Code ="E60", Category = "Dietary zinc deficiency", DiagnosisMainCategoryId = 7L },
                    new { Id = 49L, Code ="E61", Category = "Deficiency of other nutrient elements", DiagnosisMainCategoryId = 7L },
                    new { Id = 50L, Code ="E63", Category = "Other nutritional deficiencies", DiagnosisMainCategoryId = 7L },
                    new { Id = 51L, Code ="E64", Category = "Sequelae of malnutrition and other nutritional deficiencies", DiagnosisMainCategoryId = 7L },

                    new { Id = 52L, Code ="E65", Category = "Localized adiposity", DiagnosisMainCategoryId = 8L },
                    new { Id = 53L, Code ="E66", Category = "Overweight and obesity", DiagnosisMainCategoryId = 8L },
                    new { Id = 54L, Code ="E67", Category = "Other hyperalimentation", DiagnosisMainCategoryId = 8L },
                    new { Id = 55L, Code ="E68", Category = "Sequelae of hyperalimentation", DiagnosisMainCategoryId = 8L },

                    new { Id = 56L, Code ="E70", Category = "Disorders of aromatic amino-acid metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 57L, Code ="E71", Category = "Disorders of branched-chain amino-acid metabolism and fatty-acid metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 58L, Code ="E72", Category = "Other disorders of amino-acid metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 59L, Code ="E73", Category = "Lactose intolerance", DiagnosisMainCategoryId = 9L },
                    new { Id = 60L, Code ="E74", Category = "Other disorders of carbohydrate metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 61L, Code ="E75", Category = "Disorders of sphingolipid metabolism and other lipid storage disorders", DiagnosisMainCategoryId = 9L },
                    new { Id = 62L, Code ="E76", Category = "Disorders of glycosaminoglycan metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 63L, Code ="E77", Category = "Disorders of glycoprotein metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 64L, Code ="E78", Category = "Disorders of lipoprotein metabolism and other lipidemias", DiagnosisMainCategoryId = 9L },
                    new { Id = 65L, Code ="E79", Category = "Disorders of purine and pyrimidine metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 66L, Code ="E80", Category = "Disorders of porphyrin and bilirubin metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 67L, Code ="E83", Category = "Disorders of mineral metabolism", DiagnosisMainCategoryId = 9L },
                    new { Id = 68L, Code ="E84", Category = "Cystic fibrosis", DiagnosisMainCategoryId = 9L },
                    new { Id = 69L, Code ="E85", Category = "Amyloidosis", DiagnosisMainCategoryId = 9L },
                    new { Id = 70L, Code ="E86", Category = "Volume depletion", DiagnosisMainCategoryId = 9L },
                    new { Id = 71L, Code ="E87", Category = "Other disorders of fluid, electrolyte and acid-base balance", DiagnosisMainCategoryId = 9L },
                    new { Id = 72L, Code ="E88", Category = "Other and unspecified metabolic disorders", DiagnosisMainCategoryId = 9L },

                    new { Id = 73L, Code ="E89", Category = "Postprocedural endocrine and metabolic complications and disorders, not elsewhere classified", DiagnosisMainCategoryId = 10L }

                );


        }
    }
}
