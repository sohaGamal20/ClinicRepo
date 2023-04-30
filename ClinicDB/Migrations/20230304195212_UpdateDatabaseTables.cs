using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patient_PatientID",
                table: "Visits");

            migrationBuilder.DeleteData(
                table: "TreatmentLookUp",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TreatmentLookUp",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Visits",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_PatientID",
                table: "Visits",
                newName: "IX_Visits_PatientId");

            migrationBuilder.RenameColumn(
                name: "Treatment",
                table: "TreatmentLookUp",
                newName: "DosagePerDay");

            migrationBuilder.AddColumn<string>(
                name: "ActiveIngridient",
                table: "TreatmentLookUp",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DiagnosisMainCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: true),
                    Row_Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisMainCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentProductionName",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentLookupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: true),
                    Row_Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentProductionName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreatmentProductionName_TreatmentLookUp_TreatmentLookupId",
                        column: x => x.TreatmentLookupId,
                        principalTable: "TreatmentLookUp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisSubCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosisMainCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: true),
                    Row_Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisSubCategory_DiagnosisMainCategory_DiagnosisMainCategoryId",
                        column: x => x.DiagnosisMainCategoryId,
                        principalTable: "DiagnosisMainCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisLeafNodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosisSubCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<long>(type: "bigint", nullable: true),
                    Row_Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisLeafNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosisLeafNodes_DiagnosisSubCategory_DiagnosisSubCategoryId",
                        column: x => x.DiagnosisSubCategoryId,
                        principalTable: "DiagnosisSubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisLeafNodes_DiagnosisSubCategoryId",
                table: "DiagnosisLeafNodes",
                column: "DiagnosisSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisSubCategory_DiagnosisMainCategoryId",
                table: "DiagnosisSubCategory",
                column: "DiagnosisMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentProductionName_TreatmentLookupId",
                table: "TreatmentProductionName",
                column: "TreatmentLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patient_PatientId",
                table: "Visits",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patient_PatientId",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "DiagnosisLeafNodes");

            migrationBuilder.DropTable(
                name: "TreatmentProductionName");

            migrationBuilder.DropTable(
                name: "DiagnosisSubCategory");

            migrationBuilder.DropTable(
                name: "DiagnosisMainCategory");

            migrationBuilder.DropColumn(
                name: "ActiveIngridient",
                table: "TreatmentLookUp");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Visits",
                newName: "PatientID");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_PatientId",
                table: "Visits",
                newName: "IX_Visits_PatientID");

            migrationBuilder.RenameColumn(
                name: "DosagePerDay",
                table: "TreatmentLookUp",
                newName: "Treatment");

            migrationBuilder.InsertData(
                table: "TreatmentLookUp",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "ModifiedById", "ModifiedDate", "Treatment" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, "treatment 1" },
                    { 2L, null, null, null, null, "treatment 2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patient_PatientID",
                table: "Visits",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
