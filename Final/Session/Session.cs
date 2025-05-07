using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final.DLL.Enum;

namespace Final.Session
{
    public static class UserSession
    {
        public static int UserId;
        public static string? UserName;
        public static RoleEnum? UserRole;
        public static void clearSession()
        {
            UserId = 0;
            UserName = null;
            UserRole = null;
        }
    }
}
