using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Project.Configurations
{
    public class CourseStudentConfiguration : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.ToTable("Course_Student");

            // Composite primary key
            builder.HasKey(cs => new { cs.CourseID, cs.StudentID });

            // CourseStudent -> Course
            builder.HasOne(cs => cs.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(cs => cs.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            // CourseStudent -> Student
            builder.HasOne(cs => cs.Student)
                .WithMany(s => s.CourseStudents)
                .HasForeignKey(cs => cs.StudentID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
