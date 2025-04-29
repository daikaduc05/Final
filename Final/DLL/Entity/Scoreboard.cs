using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL.Enum;

namespace Final.DLL.Entity
{
    public class Scoreboard
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public Class? Class {  get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public double AssignmentScore { get; set; }
        public double MidtermScore { get; set; }
        public double FinalScore { get; set; }
        public double TotalScore { get; set; }
        public bool isActive { get; set; } = true;
        public RateEnum Rate { get; set; }
    }
}
