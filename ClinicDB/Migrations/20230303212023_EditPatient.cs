using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class EditPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Consultation",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consultation",
                table: "Patient");
        }
    }
}
