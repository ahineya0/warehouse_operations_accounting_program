using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IMainView
    {
        void ShowOperatorMenu();
        void ShowManagerMenu();
        void ShowClientMenu();
        void ShowAdministratorMenu();
        public void ShowAsWingow(Form form);
    }
}
