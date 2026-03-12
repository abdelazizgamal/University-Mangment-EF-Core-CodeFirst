using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ef_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Course_Student",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Student", x => new { x.CourseID, x.StudentID });
                    table.ForeignKey(
                        name: "FK_Course_Student_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Student_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSession_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessionAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseSessionId = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendance_CourseSession_CourseSessionId",
                        column: x => x.CourseSessionId,
                        principalTable: "CourseSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendance_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "Location", "ManagerID", "Name" },
                values: new object[,]
                {
                    { 1, "Building A", null, "Computer Science" },
                    { 2, "Building B", null, "Mathematics" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Omar", "Khaled", "0110000001" },
                    { 2, "Nora", "Youssef", "0110000002" },
                    { 3, "Ali", "Mostafa", "0110000003" }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "ID", "DepartmentID", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "Ahmed", "Ali", "0100000001" },
                    { 2, 2, "Sara", "Hassan", "0100000002" },
                    { 3, 1, "Mohamed", "Saeed", "0100000003" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "ID", "DepartmentID", "Duration", "InstructorID", "Name" },
                values: new object[,]
                {
                    { 1, 1, 40, 1, "C# Fundamentals" },
                    { 2, 1, 30, 3, "Database Systems" },
                    { 3, 2, 25, 2, "Linear Algebra" }
                });

            migrationBuilder.InsertData(
                table: "CourseSession",
                columns: new[] { "Id", "CourseID", "Date", "InstructorID", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Intro to C#" },
                    { 2, 1, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "OOP Basics" },
                    { 3, 2, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "SQL Joins" },
                    { 4, 3, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Matrix Operations" }
                });

            migrationBuilder.InsertData(
                table: "Course_Student",
                columns: new[] { "CourseID", "StudentID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "CourseSessionAttendance",
                columns: new[] { "Id", "CourseSessionId", "Grade", "Notes", "StudentID" },
                values: new object[,]
                {
                    { 1, 1, 85, "Good", 1 },
                    { 2, 1, 90, "Excellent", 2 },
                    { 3, 2, 78, null, 1 },
                    { 4, 3, 88, "Well done", 3 },
                    { 5, 4, 92, "Outstanding", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentID",
                table: "Course",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstructorID",
                table: "Course",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Student_StudentID",
                table: "Course_Student",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSession_CourseID",
                table: "CourseSession",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSession_InstructorID",
                table: "CourseSession",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendance_CourseSessionId",
                table: "CourseSessionAttendance",
                column: "CourseSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendance_StudentID",
                table: "CourseSessionAttendance",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerID",
                table: "Department",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                table: "Instructor",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_InstructorID",
                table: "Course",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSession_Instructor_InstructorID",
                table: "CourseSession",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_ManagerID",
                table: "Department",
                column: "ManagerID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DepartmentID",
                table: "Instructor");

            migrationBuilder.DropTable(
                name: "Course_Student");

            migrationBuilder.DropTable(
                name: "CourseSessionAttendance");

            migrationBuilder.DropTable(
                name: "CourseSession");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Instructor");
        }
    }
}
