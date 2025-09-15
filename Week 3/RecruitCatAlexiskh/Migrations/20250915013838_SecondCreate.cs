using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAlexiskh.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_Company_CompanyID",
                table: "JobTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitle_Industry_IndustryID",
                table: "JobTitle");

            migrationBuilder.DropTable(
                name: "CandidateJobTitle");

            migrationBuilder.DropIndex(
                name: "IX_JobTitle_CompanyID",
                table: "JobTitle");

            migrationBuilder.DropIndex(
                name: "IX_JobTitle_IndustryID",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "IndustryID",
                table: "JobTitle");

            migrationBuilder.AddColumn<bool>(
                name: "IsRemote",
                table: "JobTitle",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxSalary",
                table: "JobTitle",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MinSalary",
                table: "JobTitle",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Candidate",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Candidate",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TargetSalary",
                table: "Candidate",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IndustryId",
                table: "Candidate",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_IndustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_IndustryId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IsRemote",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "MaxSalary",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "MinSalary",
                table: "JobTitle");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "TargetSalary",
                table: "Candidate");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "JobTitle",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryID",
                table: "JobTitle",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CandidateJobTitle",
                columns: table => new
                {
                    CandidatesID = table.Column<int>(type: "INTEGER", nullable: false),
                    JobTitlesID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateJobTitle", x => new { x.CandidatesID, x.JobTitlesID });
                    table.ForeignKey(
                        name: "FK_CandidateJobTitle_Candidate_CandidatesID",
                        column: x => x.CandidatesID,
                        principalTable: "Candidate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateJobTitle_JobTitle_JobTitlesID",
                        column: x => x.JobTitlesID,
                        principalTable: "JobTitle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_CompanyID",
                table: "JobTitle",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_IndustryID",
                table: "JobTitle",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateJobTitle_JobTitlesID",
                table: "CandidateJobTitle",
                column: "JobTitlesID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_Company_CompanyID",
                table: "JobTitle",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitle_Industry_IndustryID",
                table: "JobTitle",
                column: "IndustryID",
                principalTable: "Industry",
                principalColumn: "ID");
        }
    }
}
