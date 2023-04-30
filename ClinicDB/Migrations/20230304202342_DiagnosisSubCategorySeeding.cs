using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class DiagnosisSubCategorySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiagnosisSubCategory",
                columns: new[] { "Id", "Category", "Code", "CreatedById", "CreatedDate", "DiagnosisMainCategoryId", "ModifiedById", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "Congenital iodine - deficiency syndrome", "E00", null, null, 1L, null, null },
                    { 2L, "Iodine - deficiency related thyroid disorders and allied conditions", "E01", null, null, 1L, null, null },
                    { 3L, "Subclinical iodine - deficiency hypothyroidism", "E02", null, null, 1L, null, null },
                    { 4L, "Other hypothyroidism", "E03", null, null, 1L, null, null },
                    { 5L, "Other nontoxic goiter", "E04", null, null, 1L, null, null },
                    { 6L, "Thyrotoxicosis[hyperthyroidism]", "E05", null, null, 1L, null, null },
                    { 7L, "Thyroiditis", "E06", null, null, 1L, null, null },
                    { 8L, "Other disorders of thyroid", "E07", null, null, 1L, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "DiagnosisSubCategory",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
