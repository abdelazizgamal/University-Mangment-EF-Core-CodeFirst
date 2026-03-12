namespace Ef_Project.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public int? InstructorID { get; set; }
        public int? Duration { get; set; }
        public string? Name { get; set; }

        public Department Department { get; set; } = null!;
        public Instructor? Instructor { get; set; }
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new List<CourseSession>();
        public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();
    }
}
