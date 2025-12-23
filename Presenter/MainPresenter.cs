using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;
using warehouse_operations_accounting_program.View;

namespace warehouse_operations_accounting_program.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly User user;
        private readonly IWarehouseService warehouseService;
        private readonly IClientService clientService;
        private readonly IContractService contractService;

        public MainPresenter(IMainView view, User user, IWarehouseService warehouseService, IClientService clientService, IContractService contractService)
        {
            this.view = view;
            this.user = user;
            this.warehouseService = warehouseService;
            this.clientService = clientService;
            this.contractService = contractService;
        }

        public void Initialize()
        {
            if (user.Role == UserRole.Operator)
                view.ShowOperatorMenu();
            if (user.Role == UserRole.Manager)
                view.ShowManagerMenu();
            if (user.Role == UserRole.Client)
                view.ShowClientMenu();
        }
        public void OpenWarehouseManagement()
        {
            view.ShowAsWingow(new WarehouseManagementForm(warehouseService));
        }

        public void OpenIncoming()
        {
            view.ShowAsWingow(new IncomingInvoiceForm(contractService, warehouseService));
        }

        public void OpenOutgoing()
        {
            view.ShowAsWingow(new OutgoingInvoiceForm(contractService, warehouseService));
        }
        public void OpenClientManagement()
        {
            view.ShowAsWingow(new ClientManagementForm(clientService));
        }
        public void OpenContractManagement()
        {
            view.ShowAsWingow(new ContractManagementForm(contractService, clientService, warehouseService));
        }
        public void OpenClientInterface()
        {
            view.ShowAsWingow(new ClientInterfaceForm(contractService, clientService, warehouseService));
        }
    }
}
