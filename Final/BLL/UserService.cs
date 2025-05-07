using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL;
using Final.DLL.Entity;
using Final.DLL.Enum;
using Final.Session;
using Microsoft.Extensions.Logging;
namespace Final.BLL
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public void CreateUser(string username, string password, string email, RoleEnum role)
        {
            User newUser = new User
            {
                Name = username,
                Password = password,
                Role = role
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
        public void Login(string username, string password)
        {
            User? user = _context.Users.FirstOrDefault(u => u.Name == username && u.Password == password);
            if (user != null)
            {
                Session.UserSession.UserId = user.Id;
                Session.UserSession.UserName = user.Name;
                Session.UserSession.UserRole = user.Role;
            }
            else
            {
                throw new Exception("Invalid username or password");
            }
        }
    }
}
