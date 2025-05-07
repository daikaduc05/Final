namespace Final.View
{
    partial class RegisterClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            className = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            teacherName = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            isRegisted = new DataGridViewCheckBoxColumn();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, className, subject, teacherName, year, isRegisted });
            dataGridView1.Location = new Point(83, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(884, 281);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 70;
            // 
            // className
            // 
            className.HeaderText = "Tên Lớp";
            className.MinimumWidth = 8;
            className.Name = "className";
            className.Width = 150;
            // 
            // subject
            // 
            subject.HeaderText = "Môn Học";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.Width = 150;
            // 
            // teacherName
            // 
            teacherName.HeaderText = "Giảng Viên";
            teacherName.MinimumWidth = 8;
            teacherName.Name = "teacherName";
            teacherName.Width = 150;
            // 
            // year
            // 
            year.HeaderText = "Năm Học";
            year.MinimumWidth = 8;
            year.Name = "year";
            year.Width = 150;
            // 
            // isRegisted
            // 
            isRegisted.HeaderText = "Đã Đăng Ký";
            isRegisted.MinimumWidth = 8;
            isRegisted.Name = "isRegisted";
            isRegisted.Resizable = DataGridViewTriState.True;
            isRegisted.SortMode = DataGridViewColumnSortMode.Automatic;
            isRegisted.Width = 150;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(776, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(136, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(237, 34);
            btnBack.TabIndex = 2;
            btnBack.Text = "Quay Lại Danh Sách Lớp";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // RegisterClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Name = "RegisterClassForm";
            Text = "RegisterClassForm";
            Load += RegisterClassForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnBack;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn teacherName;
        private DataGridViewTextBoxColumn year;
        private DataGridViewCheckBoxColumn isRegisted;
    }
}