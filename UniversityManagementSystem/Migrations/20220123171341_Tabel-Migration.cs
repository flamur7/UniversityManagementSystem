using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManagementSystem.Migrations
{
    public partial class TabelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nationalitys_Nationalitys_NationalityId1",
                table: "Nationalitys");

            migrationBuilder.DropIndex(
                name: "IX_Nationalitys_NationalityId1",
                table: "Nationalitys");

            migrationBuilder.DropColumn(
                name: "NationalityId1",
                table: "Nationalitys");

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_NationalityId",
                table: "Staffs",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Nationalitys_NationalityId",
                table: "Staffs",
                column: "NationalityId",
                principalTable: "Nationalitys",
                principalColumn: "NationalityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Nationalitys_NationalityId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_NationalityId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Staffs");

            migrationBuilder.AddColumn<int>(
                name: "NationalityId1",
                table: "Nationalitys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nationalitys_NationalityId1",
                table: "Nationalitys",
                column: "NationalityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalitys_Nationalitys_NationalityId1",
                table: "Nationalitys",
                column: "NationalityId1",
                principalTable: "Nationalitys",
                principalColumn: "NationalityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
