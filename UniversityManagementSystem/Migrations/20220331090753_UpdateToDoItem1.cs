using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityManagementSystem.Migrations
{
    public partial class UpdateToDoItem1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TodoItems");
        }
    }
}
