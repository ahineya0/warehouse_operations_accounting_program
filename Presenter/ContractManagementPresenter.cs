using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warehouse_operations_accounting_program.Presenter
{
    public class ContractManagementPresenter
    {
        private readonly IContractManagerView view;
        private readonly IContractService service;
        private readonly IClientService clientService;
        private readonly IWarehouseService warehouseService;

        public ContractManagementPresenter(IContractManagerView view, IContractService service, IClientService clientService, IWarehouseService warehouseService)
        {
            this.view = view;
            this.service = service;
            this.clientService = clientService;
            this.warehouseService = warehouseService;
        }

        public void Initialize()
        {
            view.ShowContracts(service.GetAll());
            view.ShowClients(clientService.GetAll());
            view.ShowWarehouses(warehouseService.GetAll());
        }

        public void CreateRent()
        {
            var days = (view.EndDate - view.StartDate).Days;
            var totalAmount = view.RentedUnits * view.Rate * days;
            var payment = new Payment
            {
                Amount = totalAmount,
                Status = PaymentStatus.Pending,
                IsCashless = view.IsCashless
            };
            try
            {
                service.CreateRentContract(view.SelectedClient, view.SelectedWarehouse, view.StartDate, view.EndDate, payment, view.Rate, view.RentedUnits);
                view.ShowContracts(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
        public void CreateKeeping()
        {
            var days = (view.EndDate - view.StartDate).Days;
            var totalAmount = view.RentedUnits * view.Rate * days;
            var payment = new Payment
            {
                Amount = totalAmount,
                Status = PaymentStatus.Pending,
                IsCashless = view.IsCashless
            };
            try
            {
                service.CreateKeepingContract(view.SelectedClient, view.SelectedWarehouse, view.StartDate, view.EndDate, payment, view.Rate, view.SelectedGoods);
                view.ShowContracts(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
