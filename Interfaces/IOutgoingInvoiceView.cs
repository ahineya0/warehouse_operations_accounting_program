using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IOutgoingInvoiceView
    {
        Warehouse SelectedWarehouse { get; }
        IGoods SelectedGoods { get; }

        void ShowWarehouses(IEnumerable<Warehouse> warehouses);
        void ShowGoods(IEnumerable<IGoods> goods);
        void ShowError(string message);
        void ShowSuccess(string message);
    }
}
