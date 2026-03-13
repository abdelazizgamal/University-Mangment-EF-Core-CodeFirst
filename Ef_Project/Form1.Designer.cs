namespace Ef_Project
{
    partial class Form1
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
            btnDeptInstructor = new Button();
            btnStudentCourse = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnDeptInstructor
            // 
            btnDeptInstructor.Font = new Font("Segoe UI", 12F);
            btnDeptInstructor.Location = new Point(150, 120);
            btnDeptInstructor.Name = "btnDeptInstructor";
            btnDeptInstructor.Size = new Size(480, 80);
            btnDeptInstructor.TabIndex = 1;
            btnDeptInstructor.Text = "Manage Departments && Instructors";
            btnDeptInstructor.UseVisualStyleBackColor = true;
            btnDeptInstructor.Click += btnDeptInstructor_Click;
            // 
            // btnStudentCourse
            // 
            btnStudentCourse.Font = new Font("Segoe UI", 12F);
            btnStudentCourse.Location = new Point(150, 230);
            btnStudentCourse.Name = "btnStudentCourse";
            btnStudentCourse.Size = new Size(480, 80);
            btnStudentCourse.TabIndex = 2;
            btnStudentCourse.Text = "Manage Students && Courses";
            btnStudentCourse.UseVisualStyleBackColor = true;
            btnStudentCourse.Click += btnStudentCourse_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(220, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "School Database Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(lblTitle);
            Controls.Add(btnDeptInstructor);
            Controls.Add(btnStudentCourse);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School DB - Main Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnDeptInstructor;
        private Button btnStudentCourse;
        private Label lblTitle;
    }
}
