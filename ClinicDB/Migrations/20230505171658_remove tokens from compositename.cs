using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class removetokensfromcompositename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Patient",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompositeName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[FirstName] +' ' +[MiddleName] +' '+ [FamilyName]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "[FirstName] +' -' +[MiddleName] +','+ [FamilyName]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "CompositeName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[FirstName] +' -' +[MiddleName] +','+ [FamilyName]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "[FirstName] +' ' +[MiddleName] +' '+ [FamilyName]");
        }
    }
}
