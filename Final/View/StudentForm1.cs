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

    public partial class StudentForm1 : Form
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public AppDbContext context = factory.CreateDbContext(null);
        public StudentForm1()
        {
            InitializeComponent();
        }

        private void StudentForm1_Load(object sender, EventArgs e)
        {
            ScoreboardService scoreboardService = new ScoreboardService(context);
            List<Scoreboard> scoreboards = scoreboardService.GetMyScoreboards(Session.UserSession.UserId);
            foreach (Scoreboard scoreboard in scoreboards)
            {
                dataGridView1.Rows.Add(
                    scoreboard.Id,
                    scoreboard.Class?.Name,
                    scoreboard.Class?.Subject?.Name,
                    scoreboard.AssignmentScore,
                    scoreboard.MidtermScore,
                    scoreboard.FinalScore,
                    scoreboard.TotalScore,
                    scoreboard.Rate
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void classRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterClassForm form = new RegisterClassForm();
            form.Show();
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.UserSession.clearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
