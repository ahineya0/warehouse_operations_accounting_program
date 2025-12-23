using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IOutgoingInvoiceView
    {
        IContract SelectedContract { get; }
        IGoods SelectedGoods { get; }
        IEnumerable<IStorageUnit> SelectedStorageUnits { get; }
        string OperatorName { get; }

        void ShowActiveContracts(IEnumerable<IContract> contracts);
        void ShowStoredGoods(IEnumerable<IGoods> goods);
        void ShowStorageUnits(IEnumerable<IStorageUnit> units);
        void ShowSuccess(string message);
        void ShowError(string message);
    }
}
