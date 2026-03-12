using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Project.Migrations
{
    /// <inheritdoc />
    public partial class AssignDepartmentManagers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 1,
                column: "ManagerID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 2,
                column: "ManagerID",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 1,
                column: "ManagerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentID",
                keyValue: 2,
                column: "ManagerID",
                value: null);
        }
    }
}
