using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class updatesCompositeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompositeName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[FirstName] +' -' +[MiddleName] +','+ [FamilyName]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompositeName",
                table: "Patient");
        }
    }
}
