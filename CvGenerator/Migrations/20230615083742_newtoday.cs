using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvGenerator.Migrations
{
    /// <inheritdoc />
    public partial class newtoday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriptionId",
                table: "Descriptions",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AllId",
                table: "WorkExperiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllId",
                table: "Reference",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllId",
                table: "Educations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllId",
                table: "Descriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllId",
                table: "CertificationAndTrainings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_AllId",
                table: "WorkExperiences",
                column: "AllId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_AllId",
                table: "Reference",
                column: "AllId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_AllId",
                table: "Educations",
                column: "AllId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_AllId",
                table: "Descriptions",
                column: "AllId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationAndTrainings_AllId",
                table: "CertificationAndTrainings",
                column: "AllId");

            migrationBuilder.AddForeignKey(
                name: "FK_CertificationAndTrainings_All_AllId",
                table: "CertificationAndTrainings",
                column: "AllId",
                principalTable: "All",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_All_AllId",
                table: "Descriptions",
                column: "AllId",
                principalTable: "All",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_All_AllId",
                table: "Educations",
                column: "AllId",
                principalTable: "All",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reference_All_AllId",
                table: "Reference",
                column: "AllId",
                principalTable: "All",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_All_AllId",
                table: "WorkExperiences",
                column: "AllId",
                principalTable: "All",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificationAndTrainings_All_AllId",
                table: "CertificationAndTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_All_AllId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_All_AllId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reference_All_AllId",
                table: "Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_All_AllId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_AllId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_Reference_AllId",
                table: "Reference");

            migrationBuilder.DropIndex(
                name: "IX_Educations_AllId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Descriptions_AllId",
                table: "Descriptions");

            migrationBuilder.DropIndex(
                name: "IX_CertificationAndTrainings_AllId",
                table: "CertificationAndTrainings");

            migrationBuilder.DropColumn(
                name: "AllId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "AllId",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "AllId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AllId",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "AllId",
                table: "CertificationAndTrainings");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Descriptions",
                newName: "DescriptionId");
        }
    }
}
