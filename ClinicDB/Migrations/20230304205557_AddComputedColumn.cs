using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class AddComputedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CombinedField",
                table: "DiagnosisSubCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Category]");

            migrationBuilder.AddColumn<string>(
                name: "CombinedField",
                table: "DiagnosisMainCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Category]");

            migrationBuilder.AddColumn<string>(
                name: "CombinedField",
                table: "DiagnosisLeafNodes",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Title]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CombinedField",
                table: "DiagnosisSubCategory");

            migrationBuilder.DropColumn(
                name: "CombinedField",
                table: "DiagnosisMainCategory");

            migrationBuilder.DropColumn(
                name: "CombinedField",
                table: "DiagnosisLeafNodes");
        }
    }
}
