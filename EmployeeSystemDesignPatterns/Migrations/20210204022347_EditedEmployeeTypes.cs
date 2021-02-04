using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSystemDesignPatterns.Migrations
{
    public partial class EditedEmployeeTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeTypes_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeId",
                table: "EmployeeTypes");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeTypesId",
                table: "EmployeeTypes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes",
                column: "EmployeeTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeTypes_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "EmployeeTypesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeTypes_EmployeeTypeId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes");

            migrationBuilder.DropColumn(
                name: "EmployeeTypesId",
                table: "EmployeeTypes");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeTypeId",
                table: "EmployeeTypes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTypes",
                table: "EmployeeTypes",
                column: "EmployeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeTypes_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId",
                principalTable: "EmployeeTypes",
                principalColumn: "EmployeeTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
