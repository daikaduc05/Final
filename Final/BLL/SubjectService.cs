using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL;
using Final.DLL.Entity;
namespace Final.BLL
{
    public class SubjectService
    {
        private readonly AppDbContext _context;
        public SubjectService(AppDbContext context)
        {
            _context = context;
        }
        public void CreateSubject(string name)
        {
            Subject newSubject = new Subject
            {
                Name = name
            };
            _context.Subjects.Add(newSubject);
            _context.SaveChanges();
        }
        public List<Subject> GetAllSubjects()
        {
            return _context.Subjects.ToList();
        }
    }
}
