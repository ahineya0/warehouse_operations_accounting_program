using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Models
{
    public enum UserRole
    {
        Operator,
        Manager,
        Accountant,
        Client,
        Administrator
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public bool IsBlocked { get; set; }
    }
}
