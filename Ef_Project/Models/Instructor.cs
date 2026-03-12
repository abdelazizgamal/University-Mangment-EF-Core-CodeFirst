using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_Project.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        [MaxLength(255)]
        public string? FirstName { get; set; }

        [MaxLength(255)]
        public string? LastName { get; set; }

        [MaxLength(255)]
        public string? Phone { get; set; }

        public Department Department { get; set; } = null!;
        public Department? ManagedDepartment { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new List<CourseSession>();
    }
}
