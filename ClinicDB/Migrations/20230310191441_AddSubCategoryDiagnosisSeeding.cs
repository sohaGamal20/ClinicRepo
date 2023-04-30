using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCategoryDiagnosisSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiagnosisSubCategory",
                columns: new[] { "Id", "Category", "Code", "CreatedById", "CreatedDate", "DiagnosisMainCategoryId", "ModifiedById", "ModifiedDate" },
                values: new object[,]
                {
                    { 9L, "Diabetes mellitus due to underlying condition", "E08", null, null, 2L, null, null },
                    { 10L, "Drug or chemical induced diabetes mellitus", "E09", null, null, 2L, null, null },
                    { 11L, "Type 1 diabetes mellitus", "E10", null, null, 2L, null, null },
                    { 12L, "Type 2 diabetes mellitus", "E11", null, null, 2L, null, null },
                    { 13L, "Other specified diabetes mellitus", "E13", null, null, 2L, null, null },
                    { 14L, "Nondiabetic hypoglycemic coma", "E15", null, null, 3L, null, null },
                    { 15L, "Other disorders of pancreatic internal secretion", "E16", null, null, 3L, null, null },
                    { 16L, "Hypoparathyroidism", "20", null, null, 4L, null, null },
                    { 17L, "Hyperparathyroidism and other disorders of parathyroid gland", "E21", null, null, 4L, null, null },
                    { 18L, "Hyperfunction of pituitary gland", "E22", null, null, 4L, null, null },
                    { 19L, "Hypofunction and other disorders of the pituitary gland", "E23", null, null, 4L, null, null },
                    { 20L, "Cushing's syndrome", "E24", null, null, 4L, null, null },
                    { 21L, "Adrenogenital disorders", "E25", null, null, 4L, null, null },
                    { 22L, "Hyperaldosteronism", "E26", null, null, 4L, null, null },
                    { 23L, "Other disorders of adrenal gland", "E27", null, null, 4L, null, null },
                    { 24L, "Ovarian dysfunction", "E28", null, null, 4L, null, null },
                    { 25L, "Testicular dysfunction", "E29", null, null, 4L, null, null },
                    { 26L, "Disorders of puberty, not elsewhere classified", "E30", null, null, 4L, null, null },
                    { 27L, "Polyglandular dysfunction", "E31", null, null, 4L, null, null },
                    { 28L, "Diseases of thymus", "E32", null, null, 4L, null, null },
                    { 29L, "Other endocrine disorders", "E34", null, null, 4L, null, null },
                    { 30L, "Disorders of endocrine glands in diseases classified elsewhere", "E35", null, null, 4L, null, null },
                    { 31L, "Intraoperative complications of endocrine system", "E36", null, null, 5L, null, null },
                    { 32L, "Kwashiorkor", "E40", null, null, 6L, null, null },
                    { 33L, "Nutritional marasmus", "E41", null, null, 6L, null, null },
                    { 34L, "Marasmic kwashiorkor", "E42", null, null, 6L, null, null },
                    { 35L, "Unspecified severe protein-calorie malnutrition", "E43", null, null, 6L, null, null },
                    { 36L, "Protein-calorie malnutrition of moderate and mild degree", "E44", null, null, 6L, null, null },
                    { 37L, "Retarded development following protein-calorie malnutrition", "E45", null, null, 6L, null, null },
                    { 38L, "Unspecified protein-calorie malnutrition", "E46", null, null, 6L, null, null },
                    { 39L, "Vitamin A deficiency", "E50", null, null, 7L, null, null },
                    { 40L, "Thiamine deficiency", "E51", null, null, 7L, null, null },
                    { 41L, "Niacin deficiency [pellagra]", "E52", null, null, 7L, null, null },
                    { 42L, "Deficiency of other B group vitamins", "E53", null, null, 7L, null, null },
                    { 43L, "Ascorbic acid deficiency", "E54", null, null, 7L, null, null },
                    { 44L, "Vitamin D deficiency", "E55", null, null, 7L, null, null },
                    { 45L, "Other vitamin deficiencies", "E56", null, null, 7L, null, null },
                    { 46L, "Dietary calcium deficiency", "E58", null, null, 7L, null, null },
                    { 47L, "Dietary selenium deficiency", "E59", null, null, 7L, null, null },
                    { 48L, "Dietary zinc deficiency", "E60", null, null, 7L, null, null },
                    { 49L, "Deficiency of other nutrient elements", "E61", null, null, 7L, null, null },
                    { 50L, "Other nutritional deficiencies", "E63", null, null, 7L, null, null },
                    { 51L, "Sequelae of malnutrition and other nutritional deficiencies", "E64", null, null, 7L, null, null },
                    { 52L, "Localized adiposity", "E65", null, null, 8L, null, null },
                    { 53L, "Overweight and obesity", "E66", null, null, 8L, null, null },
                    { 54L, "Other hyperalimentation", "E67", null, null, 8L, null, null },
                    { 55L, "Sequelae of hyperalimentation", "E68", null, null, 8L, null, null },
                    { 56L, "Disorders of aromatic amino-acid metabolism", "E70", null, null, 9L, null, null },
                    { 57L, "Disorders of branched-chain amino-acid metabolism and fatty-acid metabolism", "E71", null, null, 9L, null, null },
                    { 58L, "Other disorders of amino-acid metabolism", "E72", null, null, 9L, null, null },
                    { 59L, "Lactose intolerance", "E73", null, null, 9L, null, null },
                    { 60L, "Other disorders of carbohydrate metabolism", "E74", null, null, 9L, null, null },
                    { 61L, "Disorders of sphingolipid metabolism and other lipid storage disorders", "E75", null, null, 9L, null, null },
                    { 62L, "Disorders of glycosaminoglycan metabolism", "E76", null, null, 9L, null, null },
                    { 63L, "Disorders of glycoprotein metabolism", "E77", null, null, 9L, null, null },
                    { 64L, "Disorders of lipoprotein metabolism and other lipidemias", "E78", null, null, 9L, null, null },
                    { 65L, "Disorders of purine and pyrimidine metabolism", "E79", null, null, 9L, null, null },
                    { 66L, "Disorders of porphyrin and bilirubin metabolism", "E80", null, null, 9L, null, null },
                    { 67L, "Disorders of mineral metabolism", "E83", null, null, 9L, null, null },
                    { 68L, "Cystic fibrosis", "E84", null, null, 9L, null, null },
                    { 69L, "Amyloidosis", "E85", null, null, 9L, null, null },
                    { 70L, "Volume depletion", "E86", null, null, 9L, null, null },
                    { 71L, "Other disorders of fluid, electrolyte and acid-base balance", "E87", null, null, 9L, null, null },
                    { 72L, "Other and unspecified metabolic disorders", "E88", null, null, 9L, null, null },
                    { 73L, "Postprocedural endocrine and metabolic complications and disorders, not elsewhere classified", "E89", null, null, 10L, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 73L);
        }
    }
}
