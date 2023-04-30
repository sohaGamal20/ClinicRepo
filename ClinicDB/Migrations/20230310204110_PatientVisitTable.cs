using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class PatientVisitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cash",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Consultation",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "InsuranceCompanyID",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "Patient");

            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "Visits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCompanyID",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceNumber",
                table: "Visits",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cash",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "InsuranceCompanyID",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "Visits");

            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Consultation",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCompanyID",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceNumber",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
