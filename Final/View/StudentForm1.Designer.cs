namespace Final.View
{
    partial class StudentForm1
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
            regularPoint = new DataGridViewTextBoxColumn();
            midtermPoint = new DataGridViewTextBoxColumn();
            finalPoint = new DataGridViewTextBoxColumn();
            totalScore = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            classRegister = new Button();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, className, subject, regularPoint, midtermPoint, finalPoint, totalScore, rate });
            dataGridView1.Location = new Point(39, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1175, 357);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // className
            // 
            className.HeaderText = "Tên Lớp Học";
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
            // regularPoint
            // 
            regularPoint.HeaderText = "Điểm thường xuyên";
            regularPoint.MinimumWidth = 8;
            regularPoint.Name = "regularPoint";
            regularPoint.ReadOnly = true;
            regularPoint.Width = 180;
            // 
            // midtermPoint
            // 
            midtermPoint.HeaderText = "Điểm giữa kỳ";
            midtermPoint.MinimumWidth = 8;
            midtermPoint.Name = "midtermPoint";
            midtermPoint.ReadOnly = true;
            midtermPoint.Width = 150;
            // 
            // finalPoint
            // 
            finalPoint.HeaderText = "Điểm cuối kỳ";
            finalPoint.MinimumWidth = 8;
            finalPoint.Name = "finalPoint";
            finalPoint.ReadOnly = true;
            finalPoint.Width = 150;
            // 
            // totalScore
            // 
            totalScore.HeaderText = "Tổng điểm môn học";
            totalScore.MinimumWidth = 8;
            totalScore.Name = "totalScore";
            totalScore.ReadOnly = true;
            totalScore.Width = 150;
            // 
            // rate
            // 
            rate.HeaderText = "Xếp Loại";
            rate.MinimumWidth = 8;
            rate.Name = "rate";
            rate.ReadOnly = true;
            rate.Width = 150;
            // 
            // classRegister
            // 
            classRegister.Location = new Point(103, 427);
            classRegister.Name = "classRegister";
            classRegister.Size = new Size(150, 34);
            classRegister.TabIndex = 1;
            classRegister.Text = "Đăng Ký Lớp";
            classRegister.UseVisualStyleBackColor = true;
            classRegister.Click += classRegister_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(1016, 427);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(112, 34);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Đăng Xuất";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // StudentForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 488);
            Controls.Add(logoutBtn);
            Controls.Add(classRegister);
            Controls.Add(dataGridView1);
            Name = "StudentForm1";
            Text = "StudentForm1";
            Load += StudentForm1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn regularPoint;
        private DataGridViewTextBoxColumn midtermPoint;
        private DataGridViewTextBoxColumn finalPoint;
        private DataGridViewTextBoxColumn totalScore;
        private DataGridViewTextBoxColumn rate;
        private Button classRegister;
        private Button logoutBtn;
    }
}