using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Project.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");

            builder.HasKey(c => c.ID);

            builder.Property(c => c.Name)
                .HasMaxLength(255);

            // Course -> Department (many-to-one, required)
            builder.HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade);

            // Course -> Instructor (many-to-one, optional)
            builder.HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
