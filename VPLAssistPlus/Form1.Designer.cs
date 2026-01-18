namespace VPLAssistPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtID = new TextBox();
            txtGrade = new TextBox();
            cmbCourse = new ComboBox();
            btnAdd = new Button();
            btnSave = new Button();
            dgvStudents = new DataGridView();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 7);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(205, 9);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 1;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(390, 7);
            txtGrade.Name = "txtGrade";
            txtGrade.PlaceholderText = "Grade";
            txtGrade.Size = new Size(150, 31);
            txtGrade.TabIndex = 2;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Computer ", "IT ", "AI" });
            cmbCourse.Location = new Point(11, 69);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(182, 33);
            cmbCourse.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Student ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(148, 138);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(31, 211);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(360, 225);
            dgvStudents.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(446, 367);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(dgvStudents);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(cmbCourse);
            Controls.Add(txtGrade);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtGrade;
        private ComboBox cmbCourse;
        private Button btnAdd;
        private Button btnSave;
        private DataGridView dgvStudents;
        private Label lblStatus;
    }
}
