namespace Ef_Project
{
    partial class DeptInstructorForm
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
            tabDepartment = new TabPage();
            dgvDepartments = new DataGridView();
            lblDeptName = new Label();
            txtDeptName = new TextBox();
            lblDeptLocation = new Label();
            txtDeptLocation = new TextBox();
            lblDeptManager = new Label();
            cmbDeptManager = new ComboBox();
            btnDeptAdd = new Button();
            btnDeptUpdate = new Button();
            btnDeptDelete = new Button();
            btnDeptClear = new Button();
            tabInstructor = new TabPage();
            dgvInstructors = new DataGridView();
            lblInstFirst = new Label();
            txtInstFirst = new TextBox();
            lblInstLast = new Label();
            txtInstLast = new TextBox();
            lblInstPhone = new Label();
            txtInstPhone = new TextBox();
            lblInstDept = new Label();
            cmbInstDept = new ComboBox();
            btnInstAdd = new Button();
            btnInstUpdate = new Button();
            btnInstDelete = new Button();
            btnInstClear = new Button();
            tabControl.SuspendLayout();
            tabDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            tabInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabDepartment);
            tabControl.Controls.Add(tabInstructor);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1029, 747);
            tabControl.TabIndex = 0;
            // 
            // tabDepartment
            // 
            tabDepartment.Controls.Add(dgvDepartments);
            tabDepartment.Controls.Add(lblDeptName);
            tabDepartment.Controls.Add(txtDeptName);
            tabDepartment.Controls.Add(lblDeptLocation);
            tabDepartment.Controls.Add(txtDeptLocation);
            tabDepartment.Controls.Add(lblDeptManager);
            tabDepartment.Controls.Add(cmbDeptManager);
            tabDepartment.Controls.Add(btnDeptAdd);
            tabDepartment.Controls.Add(btnDeptUpdate);
            tabDepartment.Controls.Add(btnDeptDelete);
            tabDepartment.Controls.Add(btnDeptClear);
            tabDepartment.Location = new Point(4, 29);
            tabDepartment.Margin = new Padding(3, 4, 3, 4);
            tabDepartment.Name = "tabDepartment";
            tabDepartment.Padding = new Padding(3, 4, 3, 4);
            tabDepartment.Size = new Size(1021, 714);
            tabDepartment.TabIndex = 0;
            tabDepartment.Text = "Departments";
            tabDepartment.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.ColumnHeadersHeight = 29;
            dgvDepartments.Location = new Point(11, 13);
            dgvDepartments.Margin = new Padding(3, 4, 3, 4);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(983, 373);
            dgvDepartments.TabIndex = 0;
            dgvDepartments.Click += dgvDepartments_Click;
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Location = new Point(11, 413);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(52, 20);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Name:";
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(114, 413);
            txtDeptName.Margin = new Padding(3, 4, 3, 4);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(228, 27);
            txtDeptName.TabIndex = 2;
            // 
            // lblDeptLocation
            // 
            lblDeptLocation.AutoSize = true;
            lblDeptLocation.Location = new Point(366, 413);
            lblDeptLocation.Name = "lblDeptLocation";
            lblDeptLocation.Size = new Size(69, 20);
            lblDeptLocation.TabIndex = 3;
            lblDeptLocation.Text = "Location:";
            // 
            // txtDeptLocation
            // 
            txtDeptLocation.Location = new Point(457, 413);
            txtDeptLocation.Margin = new Padding(3, 4, 3, 4);
            txtDeptLocation.Name = "txtDeptLocation";
            txtDeptLocation.Size = new Size(228, 27);
            txtDeptLocation.TabIndex = 4;
            // 
            // lblDeptManager
            // 
            lblDeptManager.AutoSize = true;
            lblDeptManager.Location = new Point(11, 413);
            lblDeptManager.Name = "lblDeptManager";
            lblDeptManager.Size = new Size(71, 20);
            lblDeptManager.TabIndex = 5;
            lblDeptManager.Text = "Manager:";
            // 
            // cmbDeptManager
            // 
            cmbDeptManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptManager.Location = new Point(691, 413);
            cmbDeptManager.Margin = new Padding(3, 4, 3, 4);
            cmbDeptManager.Name = "cmbDeptManager";
            cmbDeptManager.Size = new Size(285, 28);
            cmbDeptManager.TabIndex = 6;
            // 
            // btnDeptAdd
            // 
            btnDeptAdd.Location = new Point(6, 463);
            btnDeptAdd.Margin = new Padding(3, 4, 3, 4);
            btnDeptAdd.Name = "btnDeptAdd";
            btnDeptAdd.Size = new Size(114, 47);
            btnDeptAdd.TabIndex = 7;
            btnDeptAdd.Text = "Add";
            btnDeptAdd.Click += btnDeptAdd_Click;
            // 
            // btnDeptUpdate
            // 
            btnDeptUpdate.Location = new Point(135, 463);
            btnDeptUpdate.Margin = new Padding(3, 4, 3, 4);
            btnDeptUpdate.Name = "btnDeptUpdate";
            btnDeptUpdate.Size = new Size(114, 47);
            btnDeptUpdate.TabIndex = 8;
            btnDeptUpdate.Text = "Update";
            btnDeptUpdate.Click += btnDeptUpdate_Click;
            // 
            // btnDeptDelete
            // 
            btnDeptDelete.Location = new Point(270, 463);
            btnDeptDelete.Margin = new Padding(3, 4, 3, 4);
            btnDeptDelete.Name = "btnDeptDelete";
            btnDeptDelete.Size = new Size(114, 47);
            btnDeptDelete.TabIndex = 9;
            btnDeptDelete.Text = "Delete";
            btnDeptDelete.Click += btnDeptDelete_Click;
            // 
            // btnDeptClear
            // 
            btnDeptClear.Location = new Point(434, 463);
            btnDeptClear.Margin = new Padding(3, 4, 3, 4);
            btnDeptClear.Name = "btnDeptClear";
            btnDeptClear.Size = new Size(114, 47);
            btnDeptClear.TabIndex = 10;
            btnDeptClear.Text = "Clear";
            btnDeptClear.Click += btnDeptClear_Click;
            // 
            // tabInstructor
            // 
            tabInstructor.Controls.Add(dgvInstructors);
            tabInstructor.Controls.Add(lblInstFirst);
            tabInstructor.Controls.Add(txtInstFirst);
            tabInstructor.Controls.Add(lblInstLast);
            tabInstructor.Controls.Add(txtInstLast);
            tabInstructor.Controls.Add(lblInstPhone);
            tabInstructor.Controls.Add(txtInstPhone);
            tabInstructor.Controls.Add(lblInstDept);
            tabInstructor.Controls.Add(cmbInstDept);
            tabInstructor.Controls.Add(btnInstAdd);
            tabInstructor.Controls.Add(btnInstUpdate);
            tabInstructor.Controls.Add(btnInstDelete);
            tabInstructor.Controls.Add(btnInstClear);
            tabInstructor.Location = new Point(4, 29);
            tabInstructor.Margin = new Padding(3, 4, 3, 4);
            tabInstructor.Name = "tabInstructor";
            tabInstructor.Padding = new Padding(3, 4, 3, 4);
            tabInstructor.Size = new Size(1021, 714);
            tabInstructor.TabIndex = 1;
            tabInstructor.Text = "Instructors";
            tabInstructor.UseVisualStyleBackColor = true;
            // 
            // dgvInstructors
            // 
            dgvInstructors.AllowUserToAddRows = false;
            dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInstructors.ColumnHeadersHeight = 29;
            dgvInstructors.Location = new Point(11, 13);
            dgvInstructors.Margin = new Padding(3, 4, 3, 4);
            dgvInstructors.MultiSelect = false;
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstructors.Size = new Size(983, 373);
            dgvInstructors.TabIndex = 0;
            dgvInstructors.Click += dgvInstructors_Click;
            // 
            // lblInstFirst
            // 
            lblInstFirst.AutoSize = true;
            lblInstFirst.Location = new Point(11, 413);
            lblInstFirst.Name = "lblInstFirst";
            lblInstFirst.Size = new Size(83, 20);
            lblInstFirst.TabIndex = 1;
            lblInstFirst.Text = "First Name:";
            // 
            // txtInstFirst
            // 
            txtInstFirst.Location = new Point(114, 413);
            txtInstFirst.Margin = new Padding(3, 4, 3, 4);
            txtInstFirst.Name = "txtInstFirst";
            txtInstFirst.Size = new Size(205, 27);
            txtInstFirst.TabIndex = 2;
            // 
            // lblInstLast
            // 
            lblInstLast.AutoSize = true;
            lblInstLast.Location = new Point(343, 413);
            lblInstLast.Name = "lblInstLast";
            lblInstLast.Size = new Size(82, 20);
            lblInstLast.TabIndex = 3;
            lblInstLast.Text = "Last Name:";
            // 
            // txtInstLast
            // 
            txtInstLast.Location = new Point(446, 413);
            txtInstLast.Margin = new Padding(3, 4, 3, 4);
            txtInstLast.Name = "txtInstLast";
            txtInstLast.Size = new Size(205, 27);
            txtInstLast.TabIndex = 4;
            // 
            // lblInstPhone
            // 
            lblInstPhone.AutoSize = true;
            lblInstPhone.Location = new Point(674, 413);
            lblInstPhone.Name = "lblInstPhone";
            lblInstPhone.Size = new Size(53, 20);
            lblInstPhone.TabIndex = 5;
            lblInstPhone.Text = "Phone:";
            // 
            // txtInstPhone
            // 
            txtInstPhone.Location = new Point(743, 413);
            txtInstPhone.Margin = new Padding(3, 4, 3, 4);
            txtInstPhone.Name = "txtInstPhone";
            txtInstPhone.Size = new Size(205, 27);
            txtInstPhone.TabIndex = 6;
            // 
            // lblInstDept
            // 
            lblInstDept.AutoSize = true;
            lblInstDept.Location = new Point(11, 413);
            lblInstDept.Name = "lblInstDept";
            lblInstDept.Size = new Size(92, 20);
            lblInstDept.TabIndex = 7;
            lblInstDept.Text = "Department:";
            // 
            // cmbInstDept
            // 
            cmbInstDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInstDept.Location = new Point(582, 459);
            cmbInstDept.Margin = new Padding(3, 4, 3, 4);
            cmbInstDept.Name = "cmbInstDept";
            cmbInstDept.Size = new Size(285, 28);
            cmbInstDept.TabIndex = 8;
            // 
            // btnInstAdd
            // 
            btnInstAdd.Location = new Point(11, 463);
            btnInstAdd.Margin = new Padding(3, 4, 3, 4);
            btnInstAdd.Name = "btnInstAdd";
            btnInstAdd.Size = new Size(114, 47);
            btnInstAdd.TabIndex = 9;
            btnInstAdd.Text = "Add";
            btnInstAdd.Click += btnInstAdd_Click;
            // 
            // btnInstUpdate
            // 
            btnInstUpdate.Location = new Point(146, 463);
            btnInstUpdate.Margin = new Padding(3, 4, 3, 4);
            btnInstUpdate.Name = "btnInstUpdate";
            btnInstUpdate.Size = new Size(114, 47);
            btnInstUpdate.TabIndex = 10;
            btnInstUpdate.Text = "Update";
            btnInstUpdate.Click += btnInstUpdate_Click;
            // 
            // btnInstDelete
            // 
            btnInstDelete.Location = new Point(277, 463);
            btnInstDelete.Margin = new Padding(3, 4, 3, 4);
            btnInstDelete.Name = "btnInstDelete";
            btnInstDelete.Size = new Size(114, 47);
            btnInstDelete.TabIndex = 11;
            btnInstDelete.Text = "Delete";
            btnInstDelete.Click += btnInstDelete_Click;
            // 
            // btnInstClear
            // 
            btnInstClear.Location = new Point(413, 463);
            btnInstClear.Margin = new Padding(3, 4, 3, 4);
            btnInstClear.Name = "btnInstClear";
            btnInstClear.Size = new Size(114, 47);
            btnInstClear.TabIndex = 12;
            btnInstClear.Text = "Clear";
            btnInstClear.Click += btnInstClear_Click;
            // 
            // DeptInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 747);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeptInstructorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Departments & Instructors";
            tabControl.ResumeLayout(false);
            tabDepartment.ResumeLayout(false);
            tabDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            tabInstructor.ResumeLayout(false);
            tabInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInstructors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDepartment;
        private System.Windows.Forms.TabPage tabInstructor;

        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptLocation;
        private System.Windows.Forms.TextBox txtDeptLocation;
        private System.Windows.Forms.Label lblDeptManager;
        private System.Windows.Forms.ComboBox cmbDeptManager;
        private System.Windows.Forms.Button btnDeptAdd;
        private System.Windows.Forms.Button btnDeptUpdate;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnDeptClear;

        private System.Windows.Forms.DataGridView dgvInstructors;
        private System.Windows.Forms.Label lblInstFirst;
        private System.Windows.Forms.TextBox txtInstFirst;
        private System.Windows.Forms.Label lblInstLast;
        private System.Windows.Forms.TextBox txtInstLast;
        private System.Windows.Forms.Label lblInstPhone;
        private System.Windows.Forms.TextBox txtInstPhone;
        private System.Windows.Forms.Label lblInstDept;
        private System.Windows.Forms.ComboBox cmbInstDept;
        private System.Windows.Forms.Button btnInstAdd;
        private System.Windows.Forms.Button btnInstUpdate;
        private System.Windows.Forms.Button btnInstDelete;
        private System.Windows.Forms.Button btnInstClear;
    }
}
