using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IContractManagerView
    {
        IContractor SelectedClient { get; }
        IWarehouse SelectedWarehouse { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        decimal Rate { get; }

        int RentedUnits { get; }
        List<IGoods> SelectedGoods { get; }

        void ShowClients(IEnumerable<Contractor> clients);
        void ShowWarehouses(IEnumerable<Warehouse> warehouses);
        void ShowContracts(IEnumerable<IContract> contracts);
        void ShowError(string message);
    }
}
