using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSystemDesignPatterns.Migrations
{
    public partial class AddedMedicalandHouseAllowance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HouseAllowance",
                table: "Employee",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MedicalAllowance",
                table: "Employee",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseAllowance",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MedicalAllowance",
                table: "Employee");
        }
    }
}
