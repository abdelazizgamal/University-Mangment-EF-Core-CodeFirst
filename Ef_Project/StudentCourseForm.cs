using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_Project
{
    public partial class StudentCourseForm : Form
    {
        private int? _selectedStuId;
        private int? _selectedCrsId;

        public StudentCourseForm()
        {
            InitializeComponent();
            this.Load += StudentCourseForm_Load;
            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void StudentCourseForm_Load(object? sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();
            LoadDeptCombo();
            LoadInstructorCombo();
        }

        private void TabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                LoadStudents();
            else
            {
                LoadCourses();
                LoadDeptCombo();
                LoadInstructorCombo();
            }
        }

        // ===================== STUDENT =====================

        private void LoadStudents()
        {
            using var ctx = new MyDbContext();
            dgvStudents.DataSource = ctx.Students
                .Select(s => new
                {
                    s.ID,
                    s.FirstName,
                    s.LastName,
                    s.Phone
                })
                .ToList();
        }

        private void dgvStudents_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            _selectedStuId = (int)dgvStudents.CurrentRow.Cells["ID"].Value;
            using var ctx = new MyDbContext();
            var stu = ctx.Students.Find(_selectedStuId);
            if (stu == null) return;
            txtStuFirst.Text = stu.FirstName ?? "";
            txtStuLast.Text = stu.LastName ?? "";
            txtStuPhone.Text = stu.Phone ?? "";
        }

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            using var ctx = new MyDbContext();
            var stu = new Student
            {
                FirstName = txtStuFirst.Text.Trim(),
                LastName = txtStuLast.Text.Trim(),
                Phone = txtStuPhone.Text.Trim()
            };
            ctx.Students.Add(stu);
            ctx.SaveChanges();
            ClearStuFields();
            LoadStudents();
        }

        private void btnStuUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedStuId == null) { MessageBox.Show("Select a student first."); return; }
            using var ctx = new MyDbContext();
            var stu = ctx.Students.Find(_selectedStuId);
            if (stu == null) return;
            stu.FirstName = txtStuFirst.Text.Trim();
            stu.LastName = txtStuLast.Text.Trim();
            stu.Phone = txtStuPhone.Text.Trim();
            ctx.SaveChanges();
            ClearStuFields();
            LoadStudents();
        }

        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            if (_selectedStuId == null) { MessageBox.Show("Select a student first."); return; }
            if (MessageBox.Show("Delete this student?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using var ctx = new MyDbContext();
                var stu = ctx.Students.Find(_selectedStuId);
                if (stu != null)
                {
                    ctx.Students.Remove(stu);
                    ctx.SaveChanges();
                }
                ClearStuFields();
                LoadStudents();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete: this student has related records.", "Error");
            }
        }

        private void btnStuClear_Click(object sender, EventArgs e) => ClearStuFields();

        private void ClearStuFields()
        {
            _selectedStuId = null;
            txtStuFirst.Clear();
            txtStuLast.Clear();
            txtStuPhone.Clear();
        }

        // ===================== COURSE =====================

        private void LoadCourses()
        {
            using var ctx = new MyDbContext();
            dgvCourses.DataSource = ctx.Courses
                .Include(c => c.Department)
                .Include(c => c.Instructor)
                .Select(c => new
                {
                    c.ID,
                    c.Name,
                    c.Duration,
                    Department = c.Department.Name,
                    Instructor = c.Instructor != null ? c.Instructor.FirstName + " " + c.Instructor.LastName : ""
                })
                .ToList();
        }

        private void LoadDeptCombo()
        {
            using var ctx = new MyDbContext();
            cmbCrsDept.DataSource = ctx.Departments
                .Select(d => new { d.DepartmentID, d.Name })
                .ToList();
            cmbCrsDept.DisplayMember = "Name";
            cmbCrsDept.ValueMember = "DepartmentID";
        }

        private void LoadInstructorCombo()
        {
            using var ctx = new MyDbContext();
            var instructors = ctx.Instructors
                .Select(i => new { i.ID, FullName = i.FirstName + " " + i.LastName })
                .ToList();
            instructors.Insert(0, new { ID = 0, FullName = "(None)" });
            cmbCrsInstructor.DataSource = instructors;
            cmbCrsInstructor.DisplayMember = "FullName";
            cmbCrsInstructor.ValueMember = "ID";
        }

        private void dgvCourses_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow == null) return;
            _selectedCrsId = (int)dgvCourses.CurrentRow.Cells["ID"].Value;
            using var ctx = new MyDbContext();
            var crs = ctx.Courses.Find(_selectedCrsId);
            if (crs == null) return;
            txtCrsName.Text = crs.Name ?? "";
            txtCrsDuration.Text = crs.Duration?.ToString() ?? "";
            cmbCrsDept.SelectedValue = crs.DepartmentID;
            cmbCrsInstructor.SelectedValue = crs.InstructorID ?? 0;
        }

        private void btnCrsAdd_Click(object sender, EventArgs e)
        {
            if (cmbCrsDept.SelectedValue == null) { MessageBox.Show("Select a department.", "Validation"); return; }
            using var ctx = new MyDbContext();
            var crs = new Course
            {
                Name = txtCrsName.Text.Trim(),
                Duration = int.TryParse(txtCrsDuration.Text, out var d) ? d : null,
                DepartmentID = (int)cmbCrsDept.SelectedValue,
                InstructorID = (int?)cmbCrsInstructor.SelectedValue is 0 ? null : (int?)cmbCrsInstructor.SelectedValue
            };
            ctx.Courses.Add(crs);
            ctx.SaveChanges();
            ClearCrsFields();
            LoadCourses();
        }

        private void btnCrsUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCrsId == null) { MessageBox.Show("Select a course first."); return; }
            if (cmbCrsDept.SelectedValue == null) { MessageBox.Show("Select a department.", "Validation"); return; }
            using var ctx = new MyDbContext();
            var crs = ctx.Courses.Find(_selectedCrsId);
            if (crs == null) return;
            crs.Name = txtCrsName.Text.Trim();
            crs.Duration = int.TryParse(txtCrsDuration.Text, out var d) ? d : null;
            crs.DepartmentID = (int)cmbCrsDept.SelectedValue;
            crs.InstructorID = (int?)cmbCrsInstructor.SelectedValue is 0 ? null : (int?)cmbCrsInstructor.SelectedValue;
            ctx.SaveChanges();
            ClearCrsFields();
            LoadCourses();
        }

        private void btnCrsDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCrsId == null) { MessageBox.Show("Select a course first."); return; }
            if (MessageBox.Show("Delete this course?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using var ctx = new MyDbContext();
                var crs = ctx.Courses.Find(_selectedCrsId);
                if (crs != null)
                {
                    ctx.Courses.Remove(crs);
                    ctx.SaveChanges();
                }
                ClearCrsFields();
                LoadCourses();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete: this course has related records.", "Error");
            }
        }

        private void btnCrsClear_Click(object sender, EventArgs e) => ClearCrsFields();

        private void ClearCrsFields()
        {
            _selectedCrsId = null;
            txtCrsName.Clear();
            txtCrsDuration.Clear();
            if (cmbCrsDept.Items.Count > 0) cmbCrsDept.SelectedIndex = 0;
            if (cmbCrsInstructor.Items.Count > 0) cmbCrsInstructor.SelectedIndex = 0;
        }
    }
}
