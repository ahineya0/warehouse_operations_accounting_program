using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Services;

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
        }

        public void CreateRent()
        {
            try
            {
                service.CreateRentContract(view.SelectedContractor, view.SelectedWarehouse, view.StartDate, view.EndDate, view.Payment, view.Rate, view.RentedUnits);
                view.ShowContracts(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
        public void CreateKeeping()
        {
            try
            {
                service.CreateKeepingContract(view.SelectedContractor, view.SelectedWarehouse, view.StartDate, view.EndDate, view.Payment, view.Rate, view.SelectedGoods);
                view.ShowContracts(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
