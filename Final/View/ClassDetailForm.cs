using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Final.BLL;
using Final.DLL;
using Final.DLL.Dto;
using Final.DLL.Entity;
using Final.DLL.Enum;
using Microsoft.EntityFrameworkCore;

namespace Final.View
{
    public partial class ClassDetailForm : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);
        private readonly int _classId;

        public ClassDetailForm(int classId)
        {
            InitializeComponent();
            _classId = classId;
        }

        private void ClassDetailForm_Load(object sender, EventArgs e)
        {
            LoadScoreboards();
        }

        private void LoadScoreboards()
        {
            dataGridView1.Rows.Clear();

            
            Class this_class = context.Classes.Include(c => c.Subject).Where(c => c.Id == _classId).FirstOrDefault()!;
            checkBoxLocked.Checked = this_class.Locked;
            labelClassName.Text = this_class.Name!;
            labelSubject.Text = this_class.Subject!.Name!;
            labelYear.Text = this_class.Year.ToString();
            ScoreboardService scoreboardService = new ScoreboardService(context);
            List<ScoreboardDto> scoreboards = scoreboardService.GetClassScoreboards(_classId);
            foreach (var item in scoreboards)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    item.Id,
                    item.StudentName!,
                    item.AssignmentScore!,
                    item.MidtermScore!,
                    item.FinalScore!,
                    item.TotalScore!,
                    item.Rate!,
                    item.isActive
                });
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class this_class = context.Classes.Include(c => c.Subject).Where(c => c.Id == _classId).FirstOrDefault()!;
            ClassService classService = new ClassService(context);
            if (checkBoxLocked.Checked == true)
            {
                classService.LockClass(_classId);
            }
            else
            {
                classService.UnLockClass(_classId);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int id = (int)row.Cells[0].Value;
                    double? assignmentScore, midtermScore, finalScore;
                    if (row.Cells[2].Value != null)
                    {
                        assignmentScore = double.Parse(row.Cells[2].Value.ToString()!);
                    }
                    else
                    {
                        assignmentScore = null;
                    }
                    if (row.Cells[3].Value != null)
                    {
                        midtermScore = double.Parse(row.Cells[3].Value.ToString()!);
                    }
                    else
                    {
                        midtermScore = null;
                    }
                    if (row.Cells[4].Value != null)
                    {
                        finalScore = double.Parse(row.Cells[4].Value.ToString()!);
                    }
                    else
                    {
                        finalScore = null;
                    }
                    bool isActive = (bool)row.Cells[7].Value!;
                    Scoreboard new_scoreboard = new Scoreboard()
                    {
                        AssignmentScore = assignmentScore,
                        MidtermScore = midtermScore,
                        FinalScore = finalScore,
                        isActive = isActive
                    };
                    ScoreboardService scoreboardService = new ScoreboardService(context);
                    scoreboardService.UpdateScoreboard(new_scoreboard, id);
                }
            }
            LoadScoreboards();

        }

        private void btnListClass_Click(object sender, EventArgs e)
        {
            TeacherClassListForm form = new TeacherClassListForm();
            form.Show();
            this.Hide();
        }
    }
}
