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
using Final.DLL.Dto;
namespace Final.View
{
    public partial class TeacherClassListForm : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);
        public TeacherClassListForm()
        {
            InitializeComponent();
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            CreateClassForm createClassForm = new CreateClassForm();
            createClassForm.Show();
            this.Hide();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            ClassService classService = new ClassService(context);
            List<ClassListDto> classList = classService.GetMyClass(Session.UserSession.UserId);
            foreach (var item in classList)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    item.Id,
                    item.ClassName!,
                    item.SubjectName!,
                    item.Year,
                    item.Locked
                });
            }
        }

        private void btnDetailClass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value?.ToString()!);
                ClassDetailForm form = new ClassDetailForm(id);
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Chọn Lớp Để Xem Chi Tiết");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value?.ToString()!);
                ClassService classService = new ClassService(context);
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    classService.DeleteClass(id);
                    MessageBox.Show("Xóa lớp thành công!");
                    dataGridView1.Rows.Clear();
                    ClassList_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã hủy xóa lớp.");
                }

            }
            else
            {
                MessageBox.Show("Chọn Lớp Để Xóa");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Session.UserSession.clearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
