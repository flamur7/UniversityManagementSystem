using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManagementSystem.Migrations
{
    public partial class UpdateModelsDizajn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfessorName",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "ProfessorSurname",
                table: "Professors");

            

            migrationBuilder.AddColumn<DateTime>(
                name: "StaredJob",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true);

            

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            

            migrationBuilder.DropColumn(
                name: "ProgramUniversityId",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "StaredJob",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Assessments");

            migrationBuilder.AddColumn<string>(
                name: "ProfessorName",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessorSurname",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
