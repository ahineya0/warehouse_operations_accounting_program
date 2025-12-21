using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IIncomingInvoiceView
    {
        Warehouse SelectedWarehouse { get; }
        Goods GoodsData { get; }

        void ShowWarehouses(IEnumerable<Warehouse> warehouses);
        void ShowSuccess(string message);
        void ShowError(string message);
    }
}
