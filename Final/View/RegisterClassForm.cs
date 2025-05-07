using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Final.DLL;
using Final.DLL.Entity;
using Final.DLL.Dto;
using Final.BLL;

namespace Final.View
{
    public partial class RegisterClassForm : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);

        private bool hasEditedCell = false;
        private DataGridViewCheckBoxCell? editedCell = null;
        private object? originalValue = null;

        public RegisterClassForm()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;


        }

        private void RegisterClassForm_Load(object sender, EventArgs e)
        {
            ClassService classService = new ClassService(context);
            List<RegisterClassDto> classes = classService.GetAllClass(Session.UserSession.UserId);
            foreach (RegisterClassDto c in classes)
            {
                int idx = dataGridView1.Rows.Add(
                    c.Id,
                    c.ClassName,
                    c.SubjectName,
                    c.TeacherName,
                    c.Year,
                    c.Registered
                );
                bool locked = classService.IsLocked(c.Id);
                dataGridView1.Rows[idx].Tag = locked;
                dataGridView1.Rows[idx].Cells[5].ReadOnly = locked;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!hasEditedCell || editedCell == null)
            {
                MessageBox.Show("Bạn chưa thay đổi trạng thái đăng ký!");
                return;
            }

            int classId = (int)editedCell.OwningRow.Cells[0].Value;
            bool isReg = (bool)editedCell.Value;

            ScoreboardService sbSvc = new ScoreboardService(context);
            ClassService cs = new ClassService(context);
            var scoreboard = sbSvc.GetScoreboardWithClassAndUser(Session.UserSession.UserId, classId);

            if (scoreboard == null && isReg)
                sbSvc.CreateScoreboard(Session.UserSession.UserId, classId);
            else if (scoreboard != null && !isReg)
                sbSvc.DeleteScoreboard(scoreboard.Id);

            MessageBox.Show("Lưu thành công!");

            hasEditedCell = false;
            editedCell = null;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                bool locked = r.Tag is bool b && b;
                r.Cells[5].ReadOnly = locked;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            StudentForm1 f = new StudentForm1();
            Hide();
            f.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 || e.RowIndex < 0) return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[5] as DataGridViewCheckBoxCell;
            if (cell == null) return;

            if (!hasEditedCell)
            {
                hasEditedCell = true;
                editedCell = cell;
                originalValue = !(bool)cell.Value;

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[5] != cell)
                        r.Cells[5].ReadOnly = true;
                }
            }
            else if (cell == editedCell)
            {
                if ((bool)cell.Value == (bool?)originalValue)
                {

                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        bool locked = r.Tag is bool b && b;
                        r.Cells[5].ReadOnly = locked;
                    }
                    hasEditedCell = false;
                    editedCell = null;
                    originalValue = null;
                }
            }
        }

       
    }
}
