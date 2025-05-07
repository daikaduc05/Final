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
using Final.DLL.Entity;
namespace Final.View
{
    public partial class CreateClassForm : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);
        public CreateClassForm()
        {
            InitializeComponent();
        }

        private void CreateClassForm_Load(object sender, EventArgs e)
        {
            SubjectService subjectService = new SubjectService(context);
            List<Subject> subjects = subjectService.GetAllSubjects();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "Name";
            cmbSubject.ValueMember = "Id";
            for (int i = 2023; i <= 2030; i++)
            {
                cmbYear.Items.Add(i);
            }


        }
        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassService classService = new ClassService(context);
            string className = textClassName.Text;
            if (cmbSubject.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn môn học.");
                return;
            }
            int subjectId = (int)cmbSubject.SelectedValue;
            if (cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm học.");
                return;
            }
            int year = (int)cmbYear.SelectedItem;
            bool ok = classService.CreateClass(className, Session.UserSession.UserId, subjectId, year);
            if (ok)
                MessageBox.Show("Tạo lớp học thành công!");
            else
                MessageBox.Show("Thông Tin Trùng Lặp");
        }

        private void textClassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackListClass_Click(object sender, EventArgs e)
        {
            TeacherClassListForm form = new TeacherClassListForm();
            form.Show();
            this.Hide();
        }
    }
}
