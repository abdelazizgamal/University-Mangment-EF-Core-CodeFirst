namespace Ef_Project.Models
{
    public class CourseStudent
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
