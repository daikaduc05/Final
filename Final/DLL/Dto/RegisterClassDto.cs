using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DLL.Dto
{
    public class RegisterClassDto
    {
        public int Id { get; set; }
        public string? ClassName { get; set; }
        public string? SubjectName { get; set; }
        public string? TeacherName { get; set; }
        public int Year { get; set; }
        public bool Registered { get; set; }
    }
}
