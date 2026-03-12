using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Project.Configurations
{
    public class CourseSessionConfiguration : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.ToTable("CourseSession");

            builder.HasKey(cs => cs.Id);

            builder.Property(cs => cs.Title)
                .HasMaxLength(255);

            builder.Property(cs => cs.Date)
                .HasColumnType("date");

            // CourseSession -> Course (many-to-one, required)
            builder.HasOne(cs => cs.Course)
                .WithMany(c => c.CourseSessions)
                .HasForeignKey(cs => cs.CourseID)
                .OnDelete(DeleteBehavior.Cascade);

            // CourseSession -> Instructor (many-to-one, required)
            builder.HasOne(cs => cs.Instructor)
                .WithMany(i => i.CourseSessions)
                .HasForeignKey(cs => cs.InstructorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
