using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;

        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this, new AuthService());
        }

        public string Username => txtLogin.Text;
        public string Password => txtPassword.Text;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        public void CloseView()
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            presenter.Login();
        }
    }
}
