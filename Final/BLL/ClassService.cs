using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL;
using Final.DLL.Entity;
using Final.DLL.Dto;
using Microsoft.EntityFrameworkCore;
namespace Final.BLL
{
    public class ClassService
    {
        private readonly AppDbContext _context;
        public ClassService(AppDbContext context)
        {
            _context = context;
        }
        public bool IsLocked(int classId)
        {
            Class? classToFind = _context.Classes
                .Include(c => c.Subject)
                .Include(c => c.Teacher)
                .FirstOrDefault(c => c.Id == classId);
            return classToFind!.Locked;
        }
        public List<RegisterClassDto> GetAllClass(int userId)
        {
            List<Scoreboard> scoreboards = _context.Scoreboards
                .Include(c => c.Class)
                .Include(c => c.Class!.Subject)
                .Include(c => c.Class!.Teacher)
                .Where(c => c.StudentId ==  userId)
                .ToList();
            
            List<RegisterClassDto> list = new List<RegisterClassDto>();
            HashSet<int> set = new HashSet<int>();
            foreach (var scoreboard in scoreboards)
            {
                RegisterClassDto item = new RegisterClassDto{
                    Id = scoreboard.ClassId,
                    ClassName = scoreboard.Class!.Name,
                    SubjectName = scoreboard.Class!.Subject!.Name,
                    TeacherName = scoreboard.Class!.Teacher!.Name,
                    Registered = true,
                    Year = scoreboard.Class!.Year
                };
                set.Add(scoreboard.ClassId);
                list.Add(item);
            }
            List<Class> classList = _context.Classes
                .Include(c => c.Subject)
                .Include(c => c.Teacher)
                .ToList();
            foreach(var classes in classList)
            {
                if (!set.Contains(classes.Id))
                {
                    RegisterClassDto item = new RegisterClassDto
                    {
                        Id = classes.Id,
                        ClassName = classes.Name,
                        SubjectName = classes.Subject!.Name,
                        TeacherName = classes.Teacher!.Name,
                        Registered = false,
                        Year = classes.Year
                    };
                    list.Add(item);
                }
            }
            return list;
        }
        public List<ClassListDto> GetMyClass(int userId)
        {
            List<Class> classes = _context.Classes
                .Include(c => c.Subject)
                .Where(c => c.TeacherId == userId)
                .ToList();
            List<ClassListDto> classList = new List<ClassListDto>();
            foreach (var classesItem in classes)
            {
                ClassListDto item = new ClassListDto
                {
                    Id = classesItem.Id,
                    ClassName = classesItem.Name,
                    SubjectName = classesItem.Subject!.Name,
                    Year = classesItem.Year,
                    Locked = classesItem.Locked
                };
                classList.Add(item);
            }
            return classList;
        }
        public bool CreateClass(string className, int userId, int subjectId, int year)
        {
            
            Class newClass = new Class
            {
                Name = className,
                TeacherId = userId,
                SubjectId = subjectId,
                Year = year,
                Locked = false
            };
            bool ok = _context.Classes
                .Include(c => c.Subject)
                .Any(c => c.Name == className && c.Subject!.Id == subjectId);
            if (ok)
            {
                return false;
            }
            _context.Classes.Add(newClass);
            _context.SaveChanges();
            return true;
        }
        public void DeleteClass(int classId)
        {
            Class? classToDelete = _context.Classes.Find(classId);
            if (classToDelete != null)
            {
                _context.Classes.Remove(classToDelete);
                _context.SaveChanges();
            }
        }
        
        public void LockClass(int classId)
        {
            Class? classToLock = _context.Classes.Find(classId);
            if (classToLock != null)
            {
                classToLock.Locked = true;
                _context.SaveChanges();
            }
        }

        public void UnLockClass(int classId)
        {
            Class? classToLock = _context.Classes.Find(classId);
            if (classToLock != null)
            {
                classToLock.Locked = false;
                _context.SaveChanges();
            }
        }

        public void ActiveStudent(int studentId, int classId)
        {
            Class? classToActive = _context.Classes.Find(classId);
            if (classToActive != null)
            {
                Scoreboard? scoreboard = _context.Scoreboards.FirstOrDefault(s => s.StudentId == studentId && s.ClassId == classId);
                if (scoreboard != null)
                {
                    scoreboard.isActive = true;
                    _context.SaveChanges();
                }
            }
        }

        public void UnActiveStudent(int studentId, int classId)
        {
            Class? classToKick = _context.Classes.Find(classId);
            if (classToKick != null)
            {
                Scoreboard? scoreboard = _context.Scoreboards.FirstOrDefault(s => s.StudentId == studentId && s.ClassId == classId);
                if (scoreboard != null)
                {
                   scoreboard.isActive = false; 
                    _context.SaveChanges();
                }
            }
        }

        public void RequestJoinClass(int studentId, int classId)
        {
            Class? classToJoin = _context.Classes
                .Include(classToJoin => classToJoin.Subject)
                .FirstOrDefault(classToJoin => classToJoin.Id == classId);
            if (classToJoin != null)
            {
                bool existSubject = _context.Scoreboards
                    .Include(s => s.Class!.Subject!)
                    .Any(s => s.StudentId == studentId && s.Class!.Subject!.Name == classToJoin.Name);
                if (existSubject)
                {
                    throw new Exception("You have already register this subject");
                }
                Scoreboard newScoreboard = new Scoreboard
                {
                    StudentId = studentId,
                    ClassId = classId,
                    AssignmentScore = null,
                    MidtermScore = null,
                    FinalScore = null,
                    TotalScore = null,
                    isActive = false,
                    Rate = null
                };
                _context.Scoreboards.Add(newScoreboard);
                _context.SaveChanges();

            }
        }
    }
}
