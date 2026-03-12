using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_Project.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            builder.HasKey(d => d.DepartmentID);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(d => d.Location)
                .HasMaxLength(255);

            // Department.ManagerID -> Instructor (one-to-one, optional)
            builder.HasOne(d => d.Manager)
                .WithOne(i => i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.ManagerID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
