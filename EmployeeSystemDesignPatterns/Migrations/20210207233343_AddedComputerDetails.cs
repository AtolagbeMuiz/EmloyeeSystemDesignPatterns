using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSystemDesignPatterns.Migrations
{
    public partial class AddedComputerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComputerDetails",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerDetails",
                table: "Employee");
        }
    }
}
