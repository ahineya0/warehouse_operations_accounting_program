using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IIncomingInvoiceView
    {
        IContract SelectedContract { get; }
        IEnumerable<IGoods> SelectedGoods { get; }
        IEnumerable<IStorageUnit> SelectedStorageUnits { get; }
        void ShowStorageUnits(IEnumerable<IStorageUnit> units);
        string OperatorName { get; }

        void ShowActiveContracts(IEnumerable<IContract> contracts);
        void ShowContractGoods(IEnumerable<IGoods> goods);

        void ShowSuccess(string message);
        void ShowError(string message);
    }
}
