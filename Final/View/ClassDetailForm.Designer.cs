namespace Final.View
{
    partial class ClassDetailForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            assignmentScore = new DataGridViewTextBoxColumn();
            midtermScore = new DataGridViewTextBoxColumn();
            finalScore = new DataGridViewTextBoxColumn();
            totalScore = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            isActive = new DataGridViewCheckBoxColumn();
            btnSave = new Button();
            labelSubject = new Label();
            labelClassName = new Label();
            labelYear = new Label();
            label4 = new Label();
            checkBoxLocked = new CheckBox();
            btnListClass = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 53);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Môn Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 124);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 192);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Năm Học";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, studentName, assignmentScore, midtermScore, finalScore, totalScore, rate, isActive });
            dataGridView1.Location = new Point(328, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(710, 415);
            dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 80;
            // 
            // studentName
            // 
            studentName.HeaderText = "Tên Học Sinh";
            studentName.MinimumWidth = 8;
            studentName.Name = "studentName";
            studentName.Width = 150;
            // 
            // assignmentScore
            // 
            assignmentScore.HeaderText = "Điểm Bài Tập";
            assignmentScore.MinimumWidth = 8;
            assignmentScore.Name = "assignmentScore";
            assignmentScore.Width = 150;
            // 
            // midtermScore
            // 
            midtermScore.HeaderText = "Điểm Giữa Kỳ";
            midtermScore.MinimumWidth = 8;
            midtermScore.Name = "midtermScore";
            midtermScore.Width = 150;
            // 
            // finalScore
            // 
            finalScore.HeaderText = "Điểm Cuối Kỳ";
            finalScore.MinimumWidth = 8;
            finalScore.Name = "finalScore";
            finalScore.Width = 150;
            // 
            // totalScore
            // 
            totalScore.HeaderText = "Tổng Điểm";
            totalScore.MinimumWidth = 8;
            totalScore.Name = "totalScore";
            totalScore.Width = 150;
            // 
            // rate
            // 
            rate.HeaderText = "Xếp Loại";
            rate.MinimumWidth = 8;
            rate.Name = "rate";
            rate.Width = 150;
            // 
            // isActive
            // 
            isActive.HeaderText = "Được Chấp Nhận";
            isActive.MinimumWidth = 8;
            isActive.Name = "isActive";
            isActive.Resizable = DataGridViewTriState.True;
            isActive.SortMode = DataGridViewColumnSortMode.Automatic;
            isActive.Width = 150;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(178, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(125, 53);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(59, 25);
            labelSubject.TabIndex = 8;
            labelSubject.Text = "label4";
            // 
            // labelClassName
            // 
            labelClassName.AutoSize = true;
            labelClassName.Location = new Point(125, 124);
            labelClassName.Name = "labelClassName";
            labelClassName.Size = new Size(59, 25);
            labelClassName.TabIndex = 9;
            labelClassName.Text = "label5";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(125, 192);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(59, 25);
            labelYear.TabIndex = 10;
            labelYear.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 262);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 11;
            label4.Text = "Khóa Lớp Học";
            // 
            // checkBoxLocked
            // 
            checkBoxLocked.AutoSize = true;
            checkBoxLocked.Location = new Point(41, 265);
            checkBoxLocked.Name = "checkBoxLocked";
            checkBoxLocked.Size = new Size(22, 21);
            checkBoxLocked.TabIndex = 12;
            checkBoxLocked.UseVisualStyleBackColor = true;
            // 
            // btnListClass
            // 
            btnListClass.Location = new Point(12, 393);
            btnListClass.Name = "btnListClass";
            btnListClass.Size = new Size(149, 34);
            btnListClass.TabIndex = 13;
            btnListClass.Text = "Danh Sách Lớp";
            btnListClass.UseVisualStyleBackColor = true;
            btnListClass.Click += btnListClass_Click;
            // 
            // ClassDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(btnListClass);
            Controls.Add(checkBoxLocked);
            Controls.Add(label4);
            Controls.Add(labelYear);
            Controls.Add(labelClassName);
            Controls.Add(labelSubject);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClassDetailForm";
            Text = "ClassDetailForm";
            Load += ClassDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn assignmentScore;
        private DataGridViewTextBoxColumn midtermScore;
        private DataGridViewTextBoxColumn finalScore;
        private DataGridViewTextBoxColumn totalScore;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewCheckBoxColumn isActive;
        private Button btnSave;
        private TextBox subjectTxt;
        private TextBox txtClassName;
        private TextBox txtYear;
        private TextBox txtSubject;
        private Label labelSubject;
        private Label labelClassName;
        private Label labelYear;
        private Label label4;
        private CheckBox checkBoxLocked;
        private Button btnListClass;
    }
}