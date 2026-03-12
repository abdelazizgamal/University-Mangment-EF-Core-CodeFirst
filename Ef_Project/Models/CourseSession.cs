namespace Ef_Project.Models
{
    public class CourseSession
    {
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }

        public Course Course { get; set; } = null!;
        public Instructor Instructor { get; set; } = null!;
        public virtual ICollection<CourseSessionAttendance> Attendances { get; set; } = new List<CourseSessionAttendance>();
    }
}
