using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly User user;

        public MainPresenter(IMainView view, User user)
        {
            this.view = view;
            this.user = user;
        }

        public void Initialize()
        {
            if (user.Role == UserRole.Operator)
                view.ShowOperatorMenu();
        }
    }
}
