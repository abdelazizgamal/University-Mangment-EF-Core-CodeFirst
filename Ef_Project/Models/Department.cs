namespace Ef_Project.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public int? ManagerID { get; set; }
        public string Name { get; set; } = null!;
        public string? Location { get; set; }

        public Instructor? Manager { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
