namespace Ef_Project
{
    partial class StudentCourseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabStudent = new TabPage();
            dgvStudents = new DataGridView();
            lblStuFirst = new Label();
            txtStuFirst = new TextBox();
            lblStuLast = new Label();
            txtStuLast = new TextBox();
            lblStuPhone = new Label();
            txtStuPhone = new TextBox();
            btnStuAdd = new Button();
            btnStuUpdate = new Button();
            btnStuDelete = new Button();
            btnStuClear = new Button();
            tabCourse = new TabPage();
            dgvCourses = new DataGridView();
            lblCrsName = new Label();
            txtCrsName = new TextBox();
            lblCrsDuration = new Label();
            txtCrsDuration = new TextBox();
            lblCrsDept = new Label();
            cmbCrsDept = new ComboBox();
            lblCrsInstructor = new Label();
            cmbCrsInstructor = new ComboBox();
            btnCrsAdd = new Button();
            btnCrsUpdate = new Button();
            btnCrsDelete = new Button();
            btnCrsClear = new Button();
            tabControl.SuspendLayout();
            tabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabStudent);
            tabControl.Controls.Add(tabCourse);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1029, 747);
            tabControl.TabIndex = 0;
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(dgvStudents);
            tabStudent.Controls.Add(lblStuFirst);
            tabStudent.Controls.Add(txtStuFirst);
            tabStudent.Controls.Add(lblStuLast);
            tabStudent.Controls.Add(txtStuLast);
            tabStudent.Controls.Add(lblStuPhone);
            tabStudent.Controls.Add(txtStuPhone);
            tabStudent.Controls.Add(btnStuAdd);
            tabStudent.Controls.Add(btnStuUpdate);
            tabStudent.Controls.Add(btnStuDelete);
            tabStudent.Controls.Add(btnStuClear);
            tabStudent.Location = new Point(4, 29);
            tabStudent.Margin = new Padding(3, 4, 3, 4);
            tabStudent.Name = "tabStudent";
            tabStudent.Padding = new Padding(3, 4, 3, 4);
            tabStudent.Size = new Size(1021, 714);
            tabStudent.TabIndex = 0;
            tabStudent.Text = "Students";
            tabStudent.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeight = 29;
            dgvStudents.Location = new Point(11, 13);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(983, 373);
            dgvStudents.TabIndex = 0;
            dgvStudents.Click += dgvStudents_Click;
            // 
            // lblStuFirst
            // 
            lblStuFirst.AutoSize = true;
            lblStuFirst.Location = new Point(11, 413);
            lblStuFirst.Name = "lblStuFirst";
            lblStuFirst.Size = new Size(83, 20);
            lblStuFirst.TabIndex = 1;
            lblStuFirst.Text = "First Name:";
            // 
            // txtStuFirst
            // 
            txtStuFirst.Location = new Point(100, 410);
            txtStuFirst.Margin = new Padding(3, 4, 3, 4);
            txtStuFirst.Name = "txtStuFirst";
            txtStuFirst.Size = new Size(205, 27);
            txtStuFirst.TabIndex = 2;
            // 
            // lblStuLast
            // 
            lblStuLast.AutoSize = true;
            lblStuLast.Location = new Point(343, 413);
            lblStuLast.Name = "lblStuLast";
            lblStuLast.Size = new Size(82, 20);
            lblStuLast.TabIndex = 3;
            lblStuLast.Text = "Last Name:";
            // 
            // txtStuLast
            // 
            txtStuLast.Location = new Point(431, 413);
            txtStuLast.Margin = new Padding(3, 4, 3, 4);
            txtStuLast.Name = "txtStuLast";
            txtStuLast.Size = new Size(205, 27);
            txtStuLast.TabIndex = 4;
            // 
            // lblStuPhone
            // 
            lblStuPhone.AutoSize = true;
            lblStuPhone.Location = new Point(674, 413);
            lblStuPhone.Name = "lblStuPhone";
            lblStuPhone.Size = new Size(53, 20);
            lblStuPhone.TabIndex = 5;
            lblStuPhone.Text = "Phone:";
            // 
            // txtStuPhone
            // 
            txtStuPhone.Location = new Point(733, 413);
            txtStuPhone.Margin = new Padding(3, 4, 3, 4);
            txtStuPhone.Name = "txtStuPhone";
            txtStuPhone.Size = new Size(205, 27);
            txtStuPhone.TabIndex = 6;
            // 
            // btnStuAdd
            // 
            btnStuAdd.Location = new Point(11, 448);
            btnStuAdd.Margin = new Padding(3, 4, 3, 4);
            btnStuAdd.Name = "btnStuAdd";
            btnStuAdd.Size = new Size(114, 47);
            btnStuAdd.TabIndex = 7;
            btnStuAdd.Text = "Add";
            btnStuAdd.Click += btnStuAdd_Click;
            // 
            // btnStuUpdate
            // 
            btnStuUpdate.Location = new Point(147, 448);
            btnStuUpdate.Margin = new Padding(3, 4, 3, 4);
            btnStuUpdate.Name = "btnStuUpdate";
            btnStuUpdate.Size = new Size(114, 47);
            btnStuUpdate.TabIndex = 8;
            btnStuUpdate.Text = "Update";
            btnStuUpdate.Click += btnStuUpdate_Click;
            // 
            // btnStuDelete
            // 
            btnStuDelete.Location = new Point(277, 448);
            btnStuDelete.Margin = new Padding(3, 4, 3, 4);
            btnStuDelete.Name = "btnStuDelete";
            btnStuDelete.Size = new Size(114, 47);
            btnStuDelete.TabIndex = 9;
            btnStuDelete.Text = "Delete";
            btnStuDelete.Click += btnStuDelete_Click;
            // 
            // btnStuClear
            // 
            btnStuClear.Location = new Point(413, 448);
            btnStuClear.Margin = new Padding(3, 4, 3, 4);
            btnStuClear.Name = "btnStuClear";
            btnStuClear.Size = new Size(114, 47);
            btnStuClear.TabIndex = 10;
            btnStuClear.Text = "Clear";
            btnStuClear.Click += btnStuClear_Click;
            // 
            // tabCourse
            // 
            tabCourse.Controls.Add(dgvCourses);
            tabCourse.Controls.Add(lblCrsName);
            tabCourse.Controls.Add(txtCrsName);
            tabCourse.Controls.Add(lblCrsDuration);
            tabCourse.Controls.Add(txtCrsDuration);
            tabCourse.Controls.Add(lblCrsDept);
            tabCourse.Controls.Add(cmbCrsDept);
            tabCourse.Controls.Add(lblCrsInstructor);
            tabCourse.Controls.Add(cmbCrsInstructor);
            tabCourse.Controls.Add(btnCrsAdd);
            tabCourse.Controls.Add(btnCrsUpdate);
            tabCourse.Controls.Add(btnCrsDelete);
            tabCourse.Controls.Add(btnCrsClear);
            tabCourse.Location = new Point(4, 29);
            tabCourse.Margin = new Padding(3, 4, 3, 4);
            tabCourse.Name = "tabCourse";
            tabCourse.Padding = new Padding(3, 4, 3, 4);
            tabCourse.Size = new Size(1021, 714);
            tabCourse.TabIndex = 1;
            tabCourse.Text = "Courses";
            tabCourse.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeight = 29;
            dgvCourses.Location = new Point(11, 13);
            dgvCourses.Margin = new Padding(3, 4, 3, 4);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(983, 373);
            dgvCourses.TabIndex = 0;
            dgvCourses.Click += dgvCourses_Click;
            // 
            // lblCrsName
            // 
            lblCrsName.AutoSize = true;
            lblCrsName.Location = new Point(11, 413);
            lblCrsName.Name = "lblCrsName";
            lblCrsName.Size = new Size(52, 20);
            lblCrsName.TabIndex = 1;
            lblCrsName.Text = "Name:";
            // 
            // txtCrsName
            // 
            txtCrsName.Location = new Point(114, 413);
            txtCrsName.Margin = new Padding(3, 4, 3, 4);
            txtCrsName.Name = "txtCrsName";
            txtCrsName.Size = new Size(228, 27);
            txtCrsName.TabIndex = 2;
            // 
            // lblCrsDuration
            // 
            lblCrsDuration.AutoSize = true;
            lblCrsDuration.Location = new Point(366, 413);
            lblCrsDuration.Name = "lblCrsDuration";
            lblCrsDuration.Size = new Size(70, 20);
            lblCrsDuration.TabIndex = 3;
            lblCrsDuration.Text = "Duration:";
            // 
            // txtCrsDuration
            // 
            txtCrsDuration.Location = new Point(457, 413);
            txtCrsDuration.Margin = new Padding(3, 4, 3, 4);
            txtCrsDuration.Name = "txtCrsDuration";
            txtCrsDuration.Size = new Size(114, 27);
            txtCrsDuration.TabIndex = 4;
            // 
            // lblCrsDept
            // 
            lblCrsDept.AutoSize = true;
            lblCrsDept.Location = new Point(11, 413);
            lblCrsDept.Name = "lblCrsDept";
            lblCrsDept.Size = new Size(92, 20);
            lblCrsDept.TabIndex = 5;
            lblCrsDept.Text = "Department:";
            // 
            // cmbCrsDept
            // 
            cmbCrsDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCrsDept.Location = new Point(114, 413);
            cmbCrsDept.Margin = new Padding(3, 4, 3, 4);
            cmbCrsDept.Name = "cmbCrsDept";
            cmbCrsDept.Size = new Size(228, 28);
            cmbCrsDept.TabIndex = 6;
            // 
            // lblCrsInstructor
            // 
            lblCrsInstructor.AutoSize = true;
            lblCrsInstructor.Location = new Point(366, 413);
            lblCrsInstructor.Name = "lblCrsInstructor";
            lblCrsInstructor.Size = new Size(74, 20);
            lblCrsInstructor.TabIndex = 7;
            lblCrsInstructor.Text = "Instructor:";
            // 
            // cmbCrsInstructor
            // 
            cmbCrsInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCrsInstructor.Location = new Point(589, 410);
            cmbCrsInstructor.Margin = new Padding(3, 4, 3, 4);
            cmbCrsInstructor.Name = "cmbCrsInstructor";
            cmbCrsInstructor.Size = new Size(228, 28);
            cmbCrsInstructor.TabIndex = 8;
            // 
            // btnCrsAdd
            // 
            btnCrsAdd.Location = new Point(23, 463);
            btnCrsAdd.Margin = new Padding(3, 4, 3, 4);
            btnCrsAdd.Name = "btnCrsAdd";
            btnCrsAdd.Size = new Size(114, 47);
            btnCrsAdd.TabIndex = 9;
            btnCrsAdd.Text = "Add";
            btnCrsAdd.Click += btnCrsAdd_Click;
            // 
            // btnCrsUpdate
            // 
            btnCrsUpdate.Location = new Point(143, 463);
            btnCrsUpdate.Margin = new Padding(3, 4, 3, 4);
            btnCrsUpdate.Name = "btnCrsUpdate";
            btnCrsUpdate.Size = new Size(114, 47);
            btnCrsUpdate.TabIndex = 10;
            btnCrsUpdate.Text = "Update";
            btnCrsUpdate.Click += btnCrsUpdate_Click;
            // 
            // btnCrsDelete
            // 
            btnCrsDelete.Location = new Point(263, 463);
            btnCrsDelete.Margin = new Padding(3, 4, 3, 4);
            btnCrsDelete.Name = "btnCrsDelete";
            btnCrsDelete.Size = new Size(114, 47);
            btnCrsDelete.TabIndex = 11;
            btnCrsDelete.Text = "Delete";
            btnCrsDelete.Click += btnCrsDelete_Click;
            // 
            // btnCrsClear
            // 
            btnCrsClear.Location = new Point(393, 463);
            btnCrsClear.Margin = new Padding(3, 4, 3, 4);
            btnCrsClear.Name = "btnCrsClear";
            btnCrsClear.Size = new Size(114, 47);
            btnCrsClear.TabIndex = 12;
            btnCrsClear.Text = "Clear";
            btnCrsClear.Click += btnCrsClear_Click;
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 747);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentCourseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Students & Courses";
            tabControl.ResumeLayout(false);
            tabStudent.ResumeLayout(false);
            tabStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabCourse.ResumeLayout(false);
            tabCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabCourse;

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStuFirst;
        private System.Windows.Forms.TextBox txtStuFirst;
        private System.Windows.Forms.Label lblStuLast;
        private System.Windows.Forms.TextBox txtStuLast;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.Button btnStuAdd;
        private System.Windows.Forms.Button btnStuUpdate;
        private System.Windows.Forms.Button btnStuDelete;
        private System.Windows.Forms.Button btnStuClear;

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label lblCrsName;
        private System.Windows.Forms.TextBox txtCrsName;
        private System.Windows.Forms.Label lblCrsDuration;
        private System.Windows.Forms.TextBox txtCrsDuration;
        private System.Windows.Forms.Label lblCrsDept;
        private System.Windows.Forms.ComboBox cmbCrsDept;
        private System.Windows.Forms.Label lblCrsInstructor;
        private System.Windows.Forms.ComboBox cmbCrsInstructor;
        private System.Windows.Forms.Button btnCrsAdd;
        private System.Windows.Forms.Button btnCrsUpdate;
        private System.Windows.Forms.Button btnCrsDelete;
        private System.Windows.Forms.Button btnCrsClear;
    }
}
