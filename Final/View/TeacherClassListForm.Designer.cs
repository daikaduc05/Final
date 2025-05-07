namespace Final.View
{
    partial class TeacherClassListForm
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
            btnCreateClass = new Button();
            btnDetailClass = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            className = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            locked = new DataGridViewCheckBoxColumn();
            btnDelete = new Button();
            btnSignOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateClass
            // 
            btnCreateClass.Location = new Point(487, 341);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Size = new Size(120, 34);
            btnCreateClass.TabIndex = 0;
            btnCreateClass.Text = "Tạo Lớp Học";
            btnCreateClass.UseVisualStyleBackColor = true;
            btnCreateClass.Click += btnCreateClass_Click;
            // 
            // btnDetailClass
            // 
            btnDetailClass.Location = new Point(48, 341);
            btnDetailClass.Name = "btnDetailClass";
            btnDetailClass.Size = new Size(155, 34);
            btnDetailClass.TabIndex = 1;
            btnDetailClass.Text = "Xem Chi Tiết Lớp ";
            btnDetailClass.UseVisualStyleBackColor = true;
            btnDetailClass.Click += btnDetailClass_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, className, subject, year, locked });
            dataGridView1.Location = new Point(35, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(814, 291);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // className
            // 
            className.HeaderText = "Tên Lớp";
            className.MinimumWidth = 8;
            className.Name = "className";
            className.ReadOnly = true;
            className.Width = 150;
            // 
            // subject
            // 
            subject.HeaderText = "Môn Học";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 150;
            // 
            // year
            // 
            year.HeaderText = "Năm Học";
            year.MinimumWidth = 8;
            year.Name = "year";
            year.ReadOnly = true;
            year.Width = 150;
            // 
            // locked
            // 
            locked.HeaderText = "Khóa";
            locked.MinimumWidth = 8;
            locked.Name = "locked";
            locked.ReadOnly = true;
            locked.Width = 150;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(271, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa Lớp";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(699, 341);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(112, 36);
            btnSignOut.TabIndex = 4;
            btnSignOut.Text = "Đăng Xuất";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // ClassListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 387);
            Controls.Add(btnSignOut);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnDetailClass);
            Controls.Add(btnCreateClass);
            Name = "ClassListForm";
            Text = "ClassList";
            Load += ClassList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateClass;
        private Button btnDetailClass;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn year;
        private DataGridViewCheckBoxColumn locked;
        private Button btnDelete;
        private Button btnSignOut;
    }
}