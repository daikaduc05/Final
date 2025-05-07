using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL.Enum;

namespace Final.DLL.Dto
{
    public class ScoreboardDto
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public double? AssignmentScore { get; set; }
        public double? MidtermScore { get; set; }
        public double? FinalScore { get; set; }
        public double? TotalScore { get; set; }
        public bool isActive { get; set; } = true;
        public RateEnum? Rate { get; set; }
    }
}
