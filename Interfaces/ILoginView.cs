using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }

        void ShowError(string message);
        void CloseView();
    }
}
