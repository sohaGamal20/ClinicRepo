using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisSubCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +' : '+[Category]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +':'+[Category]");

            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisMainCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +' : '+[Category]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +':'+[Category]");

            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisLeafNodes",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +' : '+[Title]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +':'+[Title]");

            migrationBuilder.CreateTable(
                name: "ClinicUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: true),
                    Row_Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClinicUser",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "DisplayName", "ModifiedById", "ModifiedDate", "Password", "UserName" },
                values: new object[,]
                {
                    { 1L, null, null, "Dr. Wafaa", null, null, "Wafaa", "Wafaa" },
                    { 2L, null, null, "User", null, null, "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicUser");

            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisSubCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Category]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +' : '+[Category]");

            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisMainCategory",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Category]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +' : '+[Category]");

            migrationBuilder.AlterColumn<string>(
                name: "CombinedField",
                table: "DiagnosisLeafNodes",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[Code] +':'+[Title]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComputedColumnSql: "[Code] +' : '+[Title]");
        }
    }
}
