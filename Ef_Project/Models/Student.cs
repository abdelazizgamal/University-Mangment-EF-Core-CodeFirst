using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_Project.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(255)]
        public string? FirstName { get; set; }

        [MaxLength(255)]
        public string? LastName { get; set; }

        [MaxLength(255)]
        public string? Phone { get; set; }

        public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new List<CourseSessionAttendance>();
    }
}
