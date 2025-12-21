using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IWarehouseManagementView
    {
        string WarehouseName { get; }
        string Address { get; }
        List<WarehouseType> SelectedTypes { get; }

        void ShowWarehouses(IEnumerable<Warehouse> warehouses);
        void ShowError(string message);
    }
}
