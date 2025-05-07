namespace Final.View
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnSignup = new Button();
            userNameText = new TextBox();
            passwordText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 81);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 146);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(146, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(361, 236);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(112, 34);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "Đăng Ký";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // userNameText
            // 
            userNameText.Location = new Point(236, 81);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(305, 31);
            userNameText.TabIndex = 4;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(236, 143);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(305, 31);
            passwordText.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 282);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnSignup;
        private TextBox userNameText;
        private TextBox passwordText;
    }
}