using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class AddSubSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiagnosisLeafNodes",
                columns: new[] { "Id", "Code", "CreatedById", "CreatedDate", "DiagnosisSubCategoryId", "ModifiedById", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1L, "E00.0", null, null, 1L, null, null, "Congenital iodine-deficiency syndrome, neurological type" },
                    { 2L, "E00.1", null, null, 1L, null, null, "Congenital iodine-deficiency syndrome, myxedematous type" },
                    { 3L, "E00.2", null, null, 1L, null, null, "Congenital iodine-deficiency syndrome, mixed type" },
                    { 4L, "E00.9", null, null, 1L, null, null, "Congenital iodine-deficiency syndrome, unspecified" },
                    { 5L, "E01.0", null, null, 2L, null, null, "Iodine - deficiency related diffuse(endemic) goiter" },
                    { 6L, "E01.1", null, null, 2L, null, null, "Iodine - deficiency related multinodular(endemic) goiter" },
                    { 7L, "E01.2", null, null, 2L, null, null, "Iodine - deficiency related(endemic) goiter, unspecified" },
                    { 8L, "E01.8", null, null, 2L, null, null, "Other iodine-deficiency related thyroid disorders and allied conditions" },
                    { 9L, "E03.0", null, null, 4L, null, null, "Congenital hypothyroidism with diffuse goiter" },
                    { 10L, "E03.1", null, null, 4L, null, null, "Congenital hypothyroidism without goiter" },
                    { 11L, "E03.2", null, null, 4L, null, null, "Hypothyroidism due to medicaments and other exogenous substances" },
                    { 12L, "E03.3", null, null, 4L, null, null, "Postinfectious hypothyroidism" },
                    { 13L, "E03.4", null, null, 4L, null, null, "Atrophy of thyroid(acquired)" },
                    { 14L, "E03.5", null, null, 4L, null, null, "Myxedema coma" },
                    { 15L, "E03.8", null, null, 4L, null, null, "Other specified hypothyroidism" },
                    { 16L, "E03.9", null, null, 4L, null, null, "Hypothyroidism, unspecified" },
                    { 17L, "E04.0", null, null, 5L, null, null, "Nontoxic diffuse goiter" },
                    { 18L, "E04.1", null, null, 5L, null, null, "Nontoxic single thyroid nodule" },
                    { 19L, "E04.2", null, null, 5L, null, null, "Nontoxic multinodular goiter" },
                    { 20L, "E04.8", null, null, 5L, null, null, "Other specified nontoxic goiter" },
                    { 21L, "E04.9", null, null, 5L, null, null, "Nontoxic goiter, unspecified" },
                    { 22L, "E05.0", null, null, 6L, null, null, "Thyrotoxicosis with diffuse goiter" },
                    { 23L, "E05.1", null, null, 6L, null, null, "Thyrotoxicosis with toxic single thyroid nodule" },
                    { 24L, "E05.2", null, null, 6L, null, null, "Thyrotoxicosis with toxic multinodular goiter" },
                    { 25L, "E05.3", null, null, 6L, null, null, "Thyrotoxicosis from ectopic thyroid tissue" },
                    { 26L, "E05.4", null, null, 6L, null, null, "Thyrotoxicosis factitia" },
                    { 27L, "E05.8", null, null, 6L, null, null, "Other thyrotoxicosis" },
                    { 28L, "E05.9", null, null, 6L, null, null, "Thyrotoxicosis, unspecified" },
                    { 29L, "E06.0", null, null, 7L, null, null, "Acute thyroiditis" },
                    { 30L, "E06.1", null, null, 7L, null, null, "Subacute thyroiditis" },
                    { 31L, "E06.2", null, null, 7L, null, null, "Chronic thyroiditis with transient thyrotoxicosis" },
                    { 32L, "E06.3", null, null, 7L, null, null, "Autoimmune thyroiditis" },
                    { 33L, "E06.4", null, null, 7L, null, null, "Drug - induced thyroiditis" },
                    { 34L, "E06.5", null, null, 7L, null, null, "Other chronic thyroiditis" },
                    { 35L, "E06.9", null, null, 7L, null, null, "Thyroiditis, unspecified" },
                    { 36L, "E07.0", null, null, 8L, null, null, "Hypersecretion of calcitonin" },
                    { 37L, "E07.1", null, null, 8L, null, null, "Dyshormogenetic goiter" },
                    { 38L, "E07.8", null, null, 8L, null, null, "Other specified disorders of thyroid" },
                    { 39L, "E07.9", null, null, 8L, null, null, "Disorder of thyroid, unspecified" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "DiagnosisLeafNodes",
                keyColumn: "Id",
                keyValue: 39L);
        }
    }
}
