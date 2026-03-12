using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Project.Configurations
{
    public class CourseSessionAttendanceConfiguration : IEntityTypeConfiguration<CourseSessionAttendance>
    {
        public void Configure(EntityTypeBuilder<CourseSessionAttendance> builder)
        {
            builder.ToTable("CourseSessionAttendance");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Notes)
                .HasColumnType("varchar(max)");

            // Attendance -> CourseSession (many-to-one, required)
            builder.HasOne(a => a.CourseSession)
                .WithMany(cs => cs.Attendances)
                .HasForeignKey(a => a.CourseSessionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Attendance -> Student (many-to-one, required)
            builder.HasOne(a => a.Student)
                .WithMany(s => s.CourseSessionAttendances)
                .HasForeignKey(a => a.StudentID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
