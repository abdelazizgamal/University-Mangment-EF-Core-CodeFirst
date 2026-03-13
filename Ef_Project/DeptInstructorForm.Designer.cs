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
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 560);
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
            tabDepartment.Location = new Point(4, 24);
            tabDepartment.Name = "tabDepartment";
            tabDepartment.Padding = new Padding(3);
            tabDepartment.Size = new Size(892, 532);
            tabDepartment.TabIndex = 0;
            tabDepartment.Text = "Departments";
            tabDepartment.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.ColumnHeadersHeight = 29;
            dgvDepartments.Location = new Point(10, 10);
            dgvDepartments.MultiSelect = false;
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.ReadOnly = true;
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.Size = new Size(860, 280);
            dgvDepartments.TabIndex = 0;
            dgvDepartments.CellContentClick += dgvDepartments_CellContentClick;
            dgvDepartments.Click += dgvDepartments_Click;
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Location = new Point(10, 310);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(42, 15);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Name:";
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(100, 310);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(200, 23);
            txtDeptName.TabIndex = 2;
            // 
            // lblDeptLocation
            // 
            lblDeptLocation.AutoSize = true;
            lblDeptLocation.Location = new Point(320, 310);
            lblDeptLocation.Name = "lblDeptLocation";
            lblDeptLocation.Size = new Size(56, 15);
            lblDeptLocation.TabIndex = 3;
            lblDeptLocation.Text = "Location:";
            // 
            // txtDeptLocation
            // 
            txtDeptLocation.Location = new Point(400, 310);
            txtDeptLocation.Name = "txtDeptLocation";
            txtDeptLocation.Size = new Size(200, 23);
            txtDeptLocation.TabIndex = 4;
            // 
            // lblDeptManager
            // 
            lblDeptManager.AutoSize = true;
            lblDeptManager.Location = new Point(558, 357);
            lblDeptManager.Name = "lblDeptManager";
            lblDeptManager.Size = new Size(57, 15);
            lblDeptManager.TabIndex = 5;
            lblDeptManager.Text = "Manager:";
            // 
            // cmbDeptManager
            // 
            cmbDeptManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptManager.Location = new Point(620, 354);
            cmbDeptManager.Name = "cmbDeptManager";
            cmbDeptManager.Size = new Size(250, 23);
            cmbDeptManager.TabIndex = 6;
            // 
            // btnDeptAdd
            // 
            btnDeptAdd.Location = new Point(5, 347);
            btnDeptAdd.Name = "btnDeptAdd";
            btnDeptAdd.Size = new Size(100, 35);
            btnDeptAdd.TabIndex = 7;
            btnDeptAdd.Text = "Add";
            btnDeptAdd.Click += btnDeptAdd_Click;
            // 
            // btnDeptUpdate
            // 
            btnDeptUpdate.Location = new Point(118, 347);
            btnDeptUpdate.Name = "btnDeptUpdate";
            btnDeptUpdate.Size = new Size(100, 35);
            btnDeptUpdate.TabIndex = 8;
            btnDeptUpdate.Text = "Update";
            btnDeptUpdate.Click += btnDeptUpdate_Click;
            // 
            // btnDeptDelete
            // 
            btnDeptDelete.Location = new Point(236, 347);
            btnDeptDelete.Name = "btnDeptDelete";
            btnDeptDelete.Size = new Size(100, 35);
            btnDeptDelete.TabIndex = 9;
            btnDeptDelete.Text = "Delete";
            btnDeptDelete.Click += btnDeptDelete_Click;
            // 
            // btnDeptClear
            // 
            btnDeptClear.Location = new Point(380, 347);
            btnDeptClear.Name = "btnDeptClear";
            btnDeptClear.Size = new Size(100, 35);
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
            tabInstructor.Location = new Point(4, 24);
            tabInstructor.Name = "tabInstructor";
            tabInstructor.Padding = new Padding(3);
            tabInstructor.Size = new Size(892, 532);
            tabInstructor.TabIndex = 1;
            tabInstructor.Text = "Instructors";
            tabInstructor.UseVisualStyleBackColor = true;
            // 
            // dgvInstructors
            // 
            dgvInstructors.AllowUserToAddRows = false;
            dgvInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInstructors.ColumnHeadersHeight = 29;
            dgvInstructors.Location = new Point(10, 10);
            dgvInstructors.MultiSelect = false;
            dgvInstructors.Name = "dgvInstructors";
            dgvInstructors.ReadOnly = true;
            dgvInstructors.RowHeadersWidth = 51;
            dgvInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstructors.Size = new Size(860, 280);
            dgvInstructors.TabIndex = 0;
            dgvInstructors.Click += dgvInstructors_Click;
            // 
            // lblInstFirst
            // 
            lblInstFirst.AutoSize = true;
            lblInstFirst.Location = new Point(10, 313);
            lblInstFirst.Name = "lblInstFirst";
            lblInstFirst.Size = new Size(67, 15);
            lblInstFirst.TabIndex = 1;
            lblInstFirst.Text = "First Name:";
            // 
            // txtInstFirst
            // 
            txtInstFirst.Location = new Point(74, 310);
            txtInstFirst.Name = "txtInstFirst";
            txtInstFirst.Size = new Size(180, 23);
            txtInstFirst.TabIndex = 2;
            // 
            // lblInstLast
            // 
            lblInstLast.AutoSize = true;
            lblInstLast.Location = new Point(300, 310);
            lblInstLast.Name = "lblInstLast";
            lblInstLast.Size = new Size(66, 15);
            lblInstLast.TabIndex = 3;
            lblInstLast.Text = "Last Name:";
            // 
            // txtInstLast
            // 
            txtInstLast.Location = new Point(372, 310);
            txtInstLast.Name = "txtInstLast";
            txtInstLast.Size = new Size(180, 23);
            txtInstLast.TabIndex = 4;
            // 
            // lblInstPhone
            // 
            lblInstPhone.AutoSize = true;
            lblInstPhone.Location = new Point(590, 310);
            lblInstPhone.Name = "lblInstPhone";
            lblInstPhone.Size = new Size(44, 15);
            lblInstPhone.TabIndex = 5;
            lblInstPhone.Text = "Phone:";
            // 
            // txtInstPhone
            // 
            txtInstPhone.Location = new Point(640, 310);
            txtInstPhone.Name = "txtInstPhone";
            txtInstPhone.Size = new Size(180, 23);
            txtInstPhone.TabIndex = 6;
            // 
            // lblInstDept
            // 
            lblInstDept.AutoSize = true;
            lblInstDept.Location = new Point(512, 367);
            lblInstDept.Name = "lblInstDept";
            lblInstDept.Size = new Size(73, 15);
            lblInstDept.TabIndex = 7;
            lblInstDept.Text = "Department:";
            // 
            // cmbInstDept
            // 
            cmbInstDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInstDept.Location = new Point(590, 364);
            cmbInstDept.Name = "cmbInstDept";
            cmbInstDept.Size = new Size(250, 23);
            cmbInstDept.TabIndex = 8;
            // 
            // btnInstAdd
            // 
            btnInstAdd.Location = new Point(10, 347);
            btnInstAdd.Name = "btnInstAdd";
            btnInstAdd.Size = new Size(100, 35);
            btnInstAdd.TabIndex = 9;
            btnInstAdd.Text = "Add";
            btnInstAdd.Click += btnInstAdd_Click;
            // 
            // btnInstUpdate
            // 
            btnInstUpdate.Location = new Point(128, 347);
            btnInstUpdate.Name = "btnInstUpdate";
            btnInstUpdate.Size = new Size(100, 35);
            btnInstUpdate.TabIndex = 10;
            btnInstUpdate.Text = "Update";
            btnInstUpdate.Click += btnInstUpdate_Click;
            // 
            // btnInstDelete
            // 
            btnInstDelete.Location = new Point(242, 347);
            btnInstDelete.Name = "btnInstDelete";
            btnInstDelete.Size = new Size(100, 35);
            btnInstDelete.TabIndex = 11;
            btnInstDelete.Text = "Delete";
            btnInstDelete.Click += btnInstDelete_Click;
            // 
            // btnInstClear
            // 
            btnInstClear.Location = new Point(361, 347);
            btnInstClear.Name = "btnInstClear";
            btnInstClear.Size = new Size(100, 35);
            btnInstClear.TabIndex = 12;
            btnInstClear.Text = "Clear";
            btnInstClear.Click += btnInstClear_Click;
            // 
            // DeptInstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 560);
            Controls.Add(tabControl);
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

        private TabControl tabControl;
        private TabPage tabDepartment;
        private TabPage tabInstructor;

        private DataGridView dgvDepartments;
        private Label lblDeptName;
        private TextBox txtDeptName;
        private Label lblDeptLocation;
        private TextBox txtDeptLocation;
        private Label lblDeptManager;
        private ComboBox cmbDeptManager;
        private Button btnDeptAdd;
        private Button btnDeptUpdate;
        private Button btnDeptDelete;
        private Button btnDeptClear;

        private DataGridView dgvInstructors;
        private Label lblInstFirst;
        private TextBox txtInstFirst;
        private Label lblInstLast;
        private TextBox txtInstLast;
        private Label lblInstPhone;
        private TextBox txtInstPhone;
        private Label lblInstDept;
        private ComboBox cmbInstDept;
        private Button btnInstAdd;
        private Button btnInstUpdate;
        private Button btnInstDelete;
        private Button btnInstClear;
    }
}
