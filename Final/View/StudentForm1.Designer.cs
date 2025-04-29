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
            subject = new DataGridViewTextBoxColumn();
            regularPoint = new DataGridViewTextBoxColumn();
            midtermPoint = new DataGridViewTextBoxColumn();
            finalPoint = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, subject, regularPoint, midtermPoint, finalPoint, rate });
            dataGridView1.Location = new Point(79, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(875, 357);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 30;
            // 
            // subject
            // 
            subject.HeaderText = "Môn Học";
            subject.MinimumWidth = 8;
            subject.Name = "subject";
            subject.Width = 150;
            // 
            // regularPoint
            // 
            regularPoint.HeaderText = "Điểm thường xuyên";
            regularPoint.MinimumWidth = 8;
            regularPoint.Name = "regularPoint";
            regularPoint.Width = 180;
            // 
            // midtermPoint
            // 
            midtermPoint.HeaderText = "Điểm giữa kỳ";
            midtermPoint.MinimumWidth = 8;
            midtermPoint.Name = "midtermPoint";
            midtermPoint.Width = 150;
            // 
            // finalPoint
            // 
            finalPoint.HeaderText = "Điểm cuối kỳ";
            finalPoint.MinimumWidth = 8;
            finalPoint.Name = "finalPoint";
            finalPoint.Width = 150;
            // 
            // rate
            // 
            rate.HeaderText = "Xếp Loại";
            rate.MinimumWidth = 8;
            rate.Name = "rate";
            rate.Width = 150;
            // 
            // StudentForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 488);
            Controls.Add(dataGridView1);
            Name = "StudentForm1";
            Text = "StudentForm1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn regularPoint;
        private DataGridViewTextBoxColumn midtermPoint;
        private DataGridViewTextBoxColumn finalPoint;
        private DataGridViewTextBoxColumn rate;
    }
}