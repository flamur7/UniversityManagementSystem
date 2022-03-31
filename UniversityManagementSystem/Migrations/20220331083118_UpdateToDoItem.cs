using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManagementSystem.Migrations
{
    public partial class UpdateToDoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branch",
                table: "TodoItems");
        }
    }
}
