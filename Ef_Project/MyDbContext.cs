using Ef_Project.Configurations;
using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_Project
{
    public class MyDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configurations
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseSessionConfiguration());
            modelBuilder.ApplyConfiguration(new CourseSessionAttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new CourseStudentConfiguration());

            // Instructor -> Department relationship (configured here since Instructor uses Data Annotations)
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            // ---- Seed Data ----

            // Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, Name = "Computer Science", Location = "Building A", ManagerID = 1 },
                new Department { DepartmentID = 2, Name = "Mathematics", Location = "Building B", ManagerID = 2 }
            );

            // Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, DepartmentID = 1, FirstName = "Ahmed", LastName = "Ali", Phone = "0100000001" },
                new Instructor { ID = 2, DepartmentID = 2, FirstName = "Sara", LastName = "Hassan", Phone = "0100000002" },
                new Instructor { ID = 3, DepartmentID = 1, FirstName = "Mohamed", LastName = "Saeed", Phone = "0100000003" }
            );

            // Students
            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, FirstName = "Omar", LastName = "Khaled", Phone = "0110000001" },
                new Student { ID = 2, FirstName = "Nora", LastName = "Youssef", Phone = "0110000002" },
                new Student { ID = 3, FirstName = "Ali", LastName = "Mostafa", Phone = "0110000003" }
            );

            // Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, DepartmentID = 1, InstructorID = 1, Duration = 40, Name = "C# Fundamentals" },
                new Course { ID = 2, DepartmentID = 1, InstructorID = 3, Duration = 30, Name = "Database Systems" },
                new Course { ID = 3, DepartmentID = 2, InstructorID = 2, Duration = 25, Name = "Linear Algebra" }
            );

            // CourseSessions
            modelBuilder.Entity<CourseSession>().HasData(
                new CourseSession { Id = 1, CourseID = 1, InstructorID = 1, Date = new DateTime(2025, 1, 10), Title = "Intro to C#" },
                new CourseSession { Id = 2, CourseID = 1, InstructorID = 1, Date = new DateTime(2025, 1, 12), Title = "OOP Basics" },
                new CourseSession { Id = 3, CourseID = 2, InstructorID = 3, Date = new DateTime(2025, 1, 15), Title = "SQL Joins" },
                new CourseSession { Id = 4, CourseID = 3, InstructorID = 2, Date = new DateTime(2025, 1, 18), Title = "Matrix Operations" }
            );

            // CourseSessionAttendances
            modelBuilder.Entity<CourseSessionAttendance>().HasData(
                new CourseSessionAttendance { Id = 1, CourseSessionId = 1, StudentID = 1, Grade = 85, Notes = "Good" },
                new CourseSessionAttendance { Id = 2, CourseSessionId = 1, StudentID = 2, Grade = 90, Notes = "Excellent" },
                new CourseSessionAttendance { Id = 3, CourseSessionId = 2, StudentID = 1, Grade = 78, Notes = null },
                new CourseSessionAttendance { Id = 4, CourseSessionId = 3, StudentID = 3, Grade = 88, Notes = "Well done" },
                new CourseSessionAttendance { Id = 5, CourseSessionId = 4, StudentID = 2, Grade = 92, Notes = "Outstanding" }
            );

            // Course_Student (junction table)
            modelBuilder.Entity<CourseStudent>().HasData(
                new CourseStudent { CourseID = 1, StudentID = 1 },
                new CourseStudent { CourseID = 1, StudentID = 2 },
                new CourseStudent { CourseID = 2, StudentID = 1 },
                new CourseStudent { CourseID = 2, StudentID = 3 },
                new CourseStudent { CourseID = 3, StudentID = 2 }
            );
        }
    }
}
