namespace Ef_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeptInstructor_Click(object sender, EventArgs e)
        {
            using var form = new DeptInstructorForm();
            form.ShowDialog();
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            using var form = new StudentCourseForm();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
