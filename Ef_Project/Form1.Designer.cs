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
            this.btnDeptInstructor = new System.Windows.Forms.Button();
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(220, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "School Database Management";
            // 
            // btnDeptInstructor
            // 
            this.btnDeptInstructor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeptInstructor.Location = new System.Drawing.Point(150, 120);
            this.btnDeptInstructor.Name = "btnDeptInstructor";
            this.btnDeptInstructor.Size = new System.Drawing.Size(480, 80);
            this.btnDeptInstructor.TabIndex = 1;
            this.btnDeptInstructor.Text = "Manage Departments && Instructors";
            this.btnDeptInstructor.UseVisualStyleBackColor = true;
            this.btnDeptInstructor.Click += new System.EventHandler(this.btnDeptInstructor_Click);
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudentCourse.Location = new System.Drawing.Point(150, 230);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Size = new System.Drawing.Size(480, 80);
            this.btnStudentCourse.TabIndex = 2;
            this.btnStudentCourse.Text = "Manage Students && Courses";
            this.btnStudentCourse.UseVisualStyleBackColor = true;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeptInstructor);
            this.Controls.Add(this.btnStudentCourse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School DB - Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeptInstructor;
        private Button btnStudentCourse;
        private Label lblTitle;
    }
}
