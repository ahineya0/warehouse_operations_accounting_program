using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IMainView
    {
        void ShowOperatorMenu();
        void OpenChild(Form form);
        public void ShowAsWingow(Form form);
    }
}
