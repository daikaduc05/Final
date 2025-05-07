using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL;
using Final.DLL.Dto;
using Final.DLL.Entity;
using Microsoft.EntityFrameworkCore;
namespace Final.BLL
{
    public class ScoreboardService
    {
        private readonly AppDbContext _context;
        public ScoreboardService(AppDbContext context)
        {
            _context = context;
        }
        public List<Scoreboard> GetMyScoreboards(int userId)
        {
            List<Scoreboard> scoreboards = _context.Scoreboards
                .Include(s => s.Class)
                .Include(s => s.Student)
                .Include(s => s.Class!.Subject)
                .Where(s => s.StudentId == userId && s.isActive == true)
                .ToList();
            return scoreboards;
        }
        public List<ScoreboardDto> GetClassScoreboards(int classId)
        {
            List<Scoreboard> scoreboards = _context.Scoreboards
                .Include(s => s.Class)
                .Include(s => s.Student)
                .Where(s => s.Class!.Id == classId)
                .ToList();
            
            List<ScoreboardDto> list = new List<ScoreboardDto>();
            foreach (var scoreboard in scoreboards)
            {
                ScoreboardDto item = new ScoreboardDto
                {
                    Id = scoreboard.Id,
                    StudentName = scoreboard.Student!.Name,
                    AssignmentScore = scoreboard.AssignmentScore,
                    MidtermScore = scoreboard.MidtermScore,
                    FinalScore = scoreboard.FinalScore,
                    TotalScore = scoreboard.TotalScore,
                    Rate = scoreboard.Rate,
                    isActive = scoreboard.isActive
                };
                list.Add(item);
            }
            return list;
        }
        public Scoreboard? GetScoreboardWithClassAndUser(int userId, int classId)
        {
            Scoreboard? scoreboard = _context.Scoreboards
                .Include(s => s.Class)
                .Include(s => s.Student)
                .Where(s => s.StudentId == userId && s.Class!.Id == classId)
                .FirstOrDefault();
            return scoreboard;
        }
        public void CreateScoreboard(int userId, int classId)
        {
            Class? thisClass = _context.Classes
                .FirstOrDefault(c => c.Id == classId);
            if(thisClass != null)
            {
                Scoreboard newScoreboard = new Scoreboard
                {
                    StudentId = userId,
                    ClassId = classId,
                    AssignmentScore = null,
                    MidtermScore = null,
                    FinalScore = null,
                    TotalScore = null,
                    Rate = null,
                    isActive = false
                };
                _context.Scoreboards.Add(newScoreboard);
                _context.SaveChanges();
           
            }
           
        }
        
        public bool isLocked(int scoreboardId)
        {
            Scoreboard? scoreboard = _context.Scoreboards
                .Include(s => s.Class)
                .FirstOrDefault(s => s.Id == scoreboardId);
            if (scoreboard != null)
            {
                return scoreboard.Class!.Locked;
            }
            return false;
        }

        public void UpdateScoreboard(Scoreboard scoreboard, int scoreboardId)
        {
            Scoreboard? oldScoreboard = _context.Scoreboards.Find(scoreboardId);
            if (oldScoreboard != null)
            {
                oldScoreboard.AssignmentScore = scoreboard.AssignmentScore;
                oldScoreboard.MidtermScore = scoreboard.MidtermScore;
                oldScoreboard.FinalScore = scoreboard.FinalScore;
                oldScoreboard.isActive = scoreboard.isActive;

                if (oldScoreboard.AssignmentScore != null &&
                    oldScoreboard.MidtermScore != null &&
                    oldScoreboard.FinalScore != null)
                {
                    oldScoreboard.TotalScore =
                        oldScoreboard.AssignmentScore * 0.3 +
                        oldScoreboard.MidtermScore * 0.3 +
                        oldScoreboard.FinalScore * 0.6;

                    if (oldScoreboard.TotalScore >= 8.5)
                        oldScoreboard.Rate = DLL.Enum.RateEnum.A;
                    else if (oldScoreboard.TotalScore >= 7.0)
                        oldScoreboard.Rate = DLL.Enum.RateEnum.B;
                    else if (oldScoreboard.TotalScore >= 5.0)
                        oldScoreboard.Rate = DLL.Enum.RateEnum.C;
                    else if (oldScoreboard.TotalScore >= 4.0)
                        oldScoreboard.Rate = DLL.Enum.RateEnum.D;
                    else
                        oldScoreboard.Rate = DLL.Enum.RateEnum.F;
                }

                _context.SaveChanges();
            }
        }


        public void DeleteScoreboard(int scoreboardId)
        {
            Scoreboard? oldScoreboard = _context.Scoreboards.Find(scoreboardId);
            if (oldScoreboard != null)
            {
                _context.Scoreboards.Remove(oldScoreboard);
                _context.SaveChanges();
                return;
            }
        }
        

    }
}
