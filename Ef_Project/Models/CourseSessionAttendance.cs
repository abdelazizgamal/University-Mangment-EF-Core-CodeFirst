namespace Ef_Project.Models
{
    public class CourseSessionAttendance
    {
        public int Id { get; set; }
        public int CourseSessionId { get; set; }
        public int StudentID { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; }

        public CourseSession CourseSession { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
