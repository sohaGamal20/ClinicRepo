using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class DiscountSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Agency", "CreatedById", "CreatedDate", "DiscountPercentage", "ModifiedById", "ModifiedDate" },
                values: new object[,]
                {
                    { 1L, "nkabt mohndsen", null, null, 25.0, null, null },
                    { 2L, "nkabt atba2", null, null, 20.0, null, null },
                    { 3L, "nkabt siadla", null, null, 20.0, null, null }
                });

            migrationBuilder.InsertData(
                table: "TreatmentLookUp",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "ModifiedById", "ModifiedDate", "Treatment" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "treatment 1" },
                    { 2L, null, null, null, null, "treatment 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TreatmentLookUp",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TreatmentLookUp",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
