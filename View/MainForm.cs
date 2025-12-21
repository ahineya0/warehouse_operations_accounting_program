using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Presenter;

namespace warehouse_operations_accounting_program.View
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter;

        public MainForm(User user)
        {
            InitializeComponent();
            presenter = new MainPresenter(this, user);
            presenter.Initialize();
        }

        public void ShowOperatorMenu()
        {
            operatorPanel.Visible = true;
        }

        public void OpenChild(Form form)
        {
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(form);
            form.Show();
        }
    }
}
