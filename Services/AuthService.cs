using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class AuthService : IAuthService
    {
        private List<User> users = new()
        {
            new User { Username = "operator", Password = "123", Role = UserRole.Operator },
            new User { Username = "admin", Password = "123", Role = UserRole.Administrator }
        };

        public User Authenticate(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password && !u.IsBlocked);
        }
    }
}
