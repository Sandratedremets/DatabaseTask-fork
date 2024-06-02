using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class ValmisMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loanings_LoanableItems_LoanableItemId",
                table: "Loanings");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employee_EmployeeId",
                table: "Vacations");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Vacations",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations",
                newName: "IX_Vacations_EmployeesId");

            migrationBuilder.RenameColumn(
                name: "LoanableItemId",
                table: "Loanings",
                newName: "LoanableItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_Loanings_LoanableItemId",
                table: "Loanings",
                newName: "IX_Loanings_LoanableItemsId");

            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "HealthChecks",
                newName: "DoctorsName");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Employee",
                newName: "Phonenumber");

            migrationBuilder.RenameColumn(
                name: "AccessLevelPermissionList",
                table: "AccessLevels",
                newName: "PermissionList");

            migrationBuilder.RenameColumn(
                name: "AccessLevelName",
                table: "AccessLevels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AccessLevelDescription",
                table: "AccessLevels",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "AccessLevelId",
                table: "AccessLevels",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "JobTenures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ChildrenId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Loanings_LoanableItems_LoanableItemsId",
                table: "Loanings",
                column: "LoanableItemsId",
                principalTable: "LoanableItems",
                principalColumn: "LoanableItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employee_EmployeesId",
                table: "Vacations",
                column: "EmployeesId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loanings_LoanableItems_LoanableItemsId",
                table: "Loanings");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employee_EmployeesId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "JobTenures");

            migrationBuilder.DropColumn(
                name: "ChildrenId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "Vacations",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacations_EmployeesId",
                table: "Vacations",
                newName: "IX_Vacations_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "LoanableItemsId",
                table: "Loanings",
                newName: "LoanableItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Loanings_LoanableItemsId",
                table: "Loanings",
                newName: "IX_Loanings_LoanableItemId");

            migrationBuilder.RenameColumn(
                name: "DoctorsName",
                table: "HealthChecks",
                newName: "DoctorName");

            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "Employee",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "PermissionList",
                table: "AccessLevels",
                newName: "AccessLevelPermissionList");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AccessLevels",
                newName: "AccessLevelName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AccessLevels",
                newName: "AccessLevelDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccessLevels",
                newName: "AccessLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loanings_LoanableItems_LoanableItemId",
                table: "Loanings",
                column: "LoanableItemId",
                principalTable: "LoanableItems",
                principalColumn: "LoanableItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employee_EmployeeId",
                table: "Vacations",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
