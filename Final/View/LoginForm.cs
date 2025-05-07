using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.BLL;
using Final.DLL;
using Final.DLL.Enum;
namespace Final.View
{
    public partial class LoginForm : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userNameText.Text;  
            var password = passwordText.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }
            try
            {
                
                UserService userService = new UserService(context);
                userService.Login(username, password);
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                if(Session.UserSession.UserRole == RoleEnum.Student)
                {
                    StudentForm1 studentForm = new StudentForm1();
                    studentForm.Show();
                }
                else
                if(Session.UserSession.UserRole == RoleEnum.Admin)
                {
                    CreateClassForm form = new CreateClassForm();
                    form.Show();
                }
                else
                if(Session.UserSession.UserRole == RoleEnum.Teacher)
                {
                    TeacherClassListForm form = new TeacherClassListForm();
                    form.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
