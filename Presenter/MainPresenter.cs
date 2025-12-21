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

        public MainPresenter(IMainView view, User user, IWarehouseService warehouseService)
        {
            this.view = view;
            this.user = user;
            this.warehouseService = warehouseService;
        }

        public void Initialize()
        {
            if (user.Role == UserRole.Operator)
                view.ShowOperatorMenu();
        }
        public void OpenWarehouseManagement()
        {
            view.ShowAsWingow(new WarehouseManagementForm(warehouseService));
        }

        public void OpenIncoming()
        {
            view.ShowAsWingow(new IncomingInvoiceForm(warehouseService));
        }

        public void OpenOutgoing()
        {
            view.ShowAsWingow(new OutgoingInvoiceForm(warehouseService));
        }
    }
}
