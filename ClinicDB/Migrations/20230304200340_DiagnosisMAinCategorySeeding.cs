using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class DiagnosisMAinCategorySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiagnosisMainCategory",
                columns: new[] { "Id", "Category", "Code", "CreatedById", "CreatedDate", "ModifiedById", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "Disorders of thyroid gland", "E00 - E07", null, null, null, null },
                    { 2L, "Diabetes mellitus", "E08 - E13", null, null, null, null },
                    { 3L, "Other disorders of glucose regulation and pancreatic internal secretion", "E15 - E16", null, null, null, null },
                    { 4L, "Disorders of other endocrine glands", "E20-E35", null, null, null, null },
                    { 5L, "Intraoperative complications of endocrine system", "E36-E36.8", null, null, null, null },
                    { 6L, "Malnutrition", "E40-E46", null, null, null, null },
                    { 7L, "Other nutritional deficiencies", "E50-E64", null, null, null, null },
                    { 8L, "Overweight, obesity and other hyperalimentation", "E65-E68", null, null, null, null },
                    { 9L, "Metabolic disorders", "E70-E88", null, null, null, null },
                    { 10L, "Postprocedural endocrine and metabolic complications and disorders, not elsewhere classified", "E89-E89.89", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "DiagnosisMainCategory",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
