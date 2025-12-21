using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Services;
using warehouse_operations_accounting_program.View;

namespace warehouse_operations_accounting_program.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly IAuthService authService;

        public LoginPresenter(ILoginView view, IAuthService authService)
        {
            this.view = view;
            this.authService = authService;
        }

        public void Login()
        {
            var user = authService.Authenticate(view.Username, view.Password);

            if (user == null)
            {
                view.ShowError("Неверный логин или пароль");
                return;
            }

            var mainForm = new MainForm(user);
            mainForm.Show();

            view.CloseView();
        }
    }
}
