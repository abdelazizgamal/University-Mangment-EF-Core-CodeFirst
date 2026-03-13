using Ef_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_Project
{
    public partial class DeptInstructorForm : Form
    {
        private int? _selectedDeptId;
        private int? _selectedInstId;

        public DeptInstructorForm()
        {
            InitializeComponent();
            this.Load += DeptInstructorForm_Load;
            this.tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void DeptInstructorForm_Load(object? sender, EventArgs e)
        {
            //Default to first tab Department Data load
            LoadDepartments();
            LoadManagerCombo();
         
        }

        private void TabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                LoadDepartments();
                LoadManagerCombo();
            }
            else
            {
                LoadInstructors();
                LoadDeptCombo();
            }
        }

        // ===================== DEPARTMENT =====================

        private void LoadDepartments()
        {
            using var ctx = new MyDbContext();
            dgvDepartments.DataSource = ctx.Departments
                .Select(d => new
                {
                    d.DepartmentID,
                    d.Name,
                    d.Location,
                    Manager = d.Manager != null ? d.Manager.FirstName + " " + d.Manager.LastName : ""
                })
                .ToList();
        }

        private void LoadManagerCombo()
        {
            using var ctx = new MyDbContext();
            var instructors = ctx.Instructors
                .Select(i => new { i.ID, FullName = i.FirstName + " " + i.LastName })
                .ToList();
            instructors.Insert(0, new { ID = 0, FullName = "(None)" });
            cmbDeptManager.DataSource = instructors;
            cmbDeptManager.DisplayMember = "FullName";
            cmbDeptManager.ValueMember = "ID";
        }

        private void dgvDepartments_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow == null) return;
            _selectedDeptId = (int)dgvDepartments.CurrentRow.Cells["DepartmentID"].Value;
            using var ctx = new MyDbContext();
            var dept = ctx.Departments.Find(_selectedDeptId);
            if (dept == null) return;
            txtDeptName.Text = dept.Name;
            txtDeptLocation.Text = dept.Location ?? "";
            cmbDeptManager.SelectedValue = dept.ManagerID ?? 0;
        }

        private void btnDeptAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                MessageBox.Show("Name is required.", "Validation");
                return;
            }
            using var ctx = new MyDbContext();
            var dept = new Department
            {
                Name = txtDeptName.Text.Trim(),
                Location = string.IsNullOrWhiteSpace(txtDeptLocation.Text) ? null : txtDeptLocation.Text.Trim(),
                ManagerID = (int?)cmbDeptManager.SelectedValue is 0 ? null : (int?)cmbDeptManager.SelectedValue
            };
            ctx.Departments.Add(dept);
            ctx.SaveChanges();
            ClearDeptFields();
            LoadDepartments();
        }

        private void btnDeptUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDeptId == null) { MessageBox.Show("Select a department first."); return; }
            if (string.IsNullOrWhiteSpace(txtDeptName.Text)) { MessageBox.Show("Name is required.", "Validation"); return; }
            using var ctx = new MyDbContext();
            var dept = ctx.Departments.Find(_selectedDeptId);
            if (dept == null) return;
            dept.Name = txtDeptName.Text.Trim();
            dept.Location = string.IsNullOrWhiteSpace(txtDeptLocation.Text) ? null : txtDeptLocation.Text.Trim();
            var instId = (int?)cmbDeptManager.SelectedValue;
            var inst = ctx.Instructors.Find(instId);
            if (inst.ID > 0 && instId != dept.ManagerID) {

                MessageBox.Show("This Manager Already manages another Department", "Warning");

                return;
            }
            dept.ManagerID = instId is 0 ? null : (int?)cmbDeptManager.SelectedValue;
            ctx.SaveChanges();
            ClearDeptFields();
            LoadDepartments();
        }

        private void btnDeptDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDeptId == null) { MessageBox.Show("Select a department first."); return; }
            if (MessageBox.Show($"Delete department [{_selectedDeptId}]?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using var ctx = new MyDbContext();
                var dept = ctx.Departments.Find(_selectedDeptId);
                if (dept != null)
                {
                    ctx.Departments.Remove(dept);
                    ctx.SaveChanges();
                }
                ClearDeptFields();
                LoadDepartments();
                LoadManagerCombo();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete: this department has related records.", "Error");
            }
        }

        private void btnDeptClear_Click(object sender, EventArgs e) => ClearDeptFields();

        private void ClearDeptFields()
        {
            _selectedDeptId = null;
            txtDeptName.Clear();
            txtDeptLocation.Clear();
            if (cmbDeptManager.Items.Count > 0) cmbDeptManager.SelectedIndex = 0;
        }

        // ===================== INSTRUCTOR =====================

        private void LoadInstructors()
        {
            using var ctx = new MyDbContext();
            dgvInstructors.DataSource = ctx.Instructors
                .Include(i => i.Department)
                .Select(i => new
                {
                    i.ID,
                    i.FirstName,
                    i.LastName,
                    i.Phone,
                    Department = i.Department.Name
                })
                .ToList();
        }

        private void LoadDeptCombo()
        {
            using var ctx = new MyDbContext();
            cmbInstDept.DataSource = ctx.Departments
                .Select(d => new { d.DepartmentID, d.Name })
                .ToList();
            cmbInstDept.DisplayMember = "Name";
            cmbInstDept.ValueMember = "DepartmentID";
        }

        private void dgvInstructors_Click(object sender, EventArgs e)
        {
            if (dgvInstructors.CurrentRow == null) return;
            _selectedInstId = (int)dgvInstructors.CurrentRow.Cells["ID"].Value;
            using var ctx = new MyDbContext();
            var inst = ctx.Instructors.Find(_selectedInstId);
            if (inst == null) return;
            txtInstFirst.Text = inst.FirstName ?? "";
            txtInstLast.Text = inst.LastName ?? "";
            txtInstPhone.Text = inst.Phone ?? "";
            cmbInstDept.SelectedValue = inst.DepartmentID;
        }

        private void btnInstAdd_Click(object sender, EventArgs e)
        {
            if (cmbInstDept.SelectedValue == null) { MessageBox.Show("Select a department.", "Validation"); return; }
            if (string.IsNullOrWhiteSpace(txtInstFirst.Text) || string.IsNullOrWhiteSpace(txtInstLast.Text))
            {
                MessageBox.Show("First and Last Name is required.", "Validation");
                return;
            }
            using var ctx = new MyDbContext();
            var inst = new Instructor
            {
                FirstName = txtInstFirst.Text.Trim(),
                LastName = txtInstLast.Text.Trim(),
                Phone = txtInstPhone.Text.Trim(),
                DepartmentID = (int)cmbInstDept.SelectedValue
            };
            ctx.Instructors.Add(inst);
            ctx.SaveChanges();
            ClearInstFields();
            LoadInstructors();
            LoadManagerCombo();
        }

        private void btnInstUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedInstId == null) { MessageBox.Show("Select an instructor first."); return; }
            if (cmbInstDept.SelectedValue == null) { MessageBox.Show("Select a department.", "Validation"); return; }
            using var ctx = new MyDbContext();
            var inst = ctx.Instructors.Find(_selectedInstId);
            if (inst == null) return;
            inst.FirstName = txtInstFirst.Text.Trim();
            inst.LastName = txtInstLast.Text.Trim();
            inst.Phone = txtInstPhone.Text.Trim();
            inst.DepartmentID = (int)cmbInstDept.SelectedValue;
            ctx.SaveChanges();
            ClearInstFields();
            LoadInstructors();
            LoadManagerCombo();
        }

        private void btnInstDelete_Click(object sender, EventArgs e)
        {
            if (_selectedInstId == null) { MessageBox.Show("Select an instructor first."); return; }
            if (MessageBox.Show("Delete this instructor?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using var ctx = new MyDbContext();
                var inst = ctx.Instructors.Find(_selectedInstId);
                if (inst != null)
                {
                    ctx.Instructors.Remove(inst);
                    ctx.SaveChanges();
                }
                ClearInstFields();
                LoadInstructors();
                LoadManagerCombo();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete: this instructor has related records.", "Error");
            }
        }
        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInstClear_Click(object sender, EventArgs e) => ClearInstFields();

        private void ClearInstFields()
        {
            _selectedInstId = null;
            txtInstFirst.Clear();
            txtInstLast.Clear();
            txtInstPhone.Clear();
            if (cmbInstDept.Items.Count > 0) cmbInstDept.SelectedIndex = 0;
        }

    }
}
