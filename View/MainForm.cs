using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter presenter;
        private readonly IStateStorage storage;
        private readonly WarehouseSystemState state;
        private readonly IWarehouseService warehouseService;
        private readonly IClientService clientService;
        private readonly IContractService contractService;

        public MainForm(User user)
        {
            InitializeComponent();

            storage = new JsonStateStorage();
            state = storage.Load();

            warehouseService = new WarehouseService(state.Warehouses);
            clientService = new ClientService(state.Contractors);
            contractService = new ContractService(state.Contracts);
            presenter = new MainPresenter(this, user, warehouseService, clientService, contractService);

            presenter.Initialize();
        }

        public void ShowOperatorMenu()
        {
            operatorPanel.Visible = true;
        }

        public void ShowManagerMenu()
        {
           managerPanel.Visible = true;
        }

        public void ShowClientMenu()
        {
            clientPanel.Visible = true;
        }

        public void ShowAdministratorMenu()
        {
            adminPanel.Visible = true;
        }

        public void ShowAsWingow(Form form)
        {
            form.Show();
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            presenter.OpenWarehouseManagement();
        }

        private void btnIncoming_Click(object sender, EventArgs e)
        {
            presenter.OpenIncoming();
        }

        private void btnOutgoing_Click(object sender, EventArgs e)
        {
            presenter.OpenOutgoing();
        }
        private void btnClients_Click(object sender, EventArgs e)
        {
            presenter.OpenClientManagement();
        }
        private void btnContracts_Click(object sender, EventArgs e)
        {
            presenter.OpenContractManagement();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            storage.Save(state);
            Application.Exit();
        }
    }
}
