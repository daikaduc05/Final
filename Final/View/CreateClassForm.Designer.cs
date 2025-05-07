namespace Final.View
{
    partial class CreateClassForm
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
            btnSave = new Button();
            cmbYear = new ComboBox();
            textClassName = new TextBox();
            btnBackListClass = new Button();
            label4 = new Label();
            cmbSubject = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 117);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Môn Học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 183);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 254);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Năm Học";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(484, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(288, 246);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(233, 33);
            cmbYear.TabIndex = 5;
            // 
            // textClassName
            // 
            textClassName.Location = new Point(287, 177);
            textClassName.Name = "textClassName";
            textClassName.Size = new Size(234, 31);
            textClassName.TabIndex = 6;
            textClassName.TextChanged += textClassName_TextChanged;
            // 
            // btnBackListClass
            // 
            btnBackListClass.Location = new Point(60, 316);
            btnBackListClass.Name = "btnBackListClass";
            btnBackListClass.Size = new Size(154, 34);
            btnBackListClass.TabIndex = 8;
            btnBackListClass.Text = "Danh Sách Lớp";
            btnBackListClass.UseVisualStyleBackColor = true;
            btnBackListClass.Click += btnBackListClass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 38);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 9;
            label4.Text = "Thông Tin Lớp Học";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(287, 109);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(234, 33);
            cmbSubject.TabIndex = 10;
            // 
            // CreateClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 374);
            Controls.Add(cmbSubject);
            Controls.Add(label4);
            Controls.Add(btnBackListClass);
            Controls.Add(textClassName);
            Controls.Add(cmbYear);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateClassForm";
            Text = "CreateClassForm";
            Load += CreateClassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private ComboBox cmbYear;
        private TextBox textClassName;
        private Button btnBackListClass;
        private Label label4;
        private ComboBox cmbSubject;
    }
}