using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
    }
}
