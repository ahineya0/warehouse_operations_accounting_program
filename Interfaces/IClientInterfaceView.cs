using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IClientInterfaceView
    {
        string AuthClientName { get; }

        void ShowMyContracts(IEnumerable<object> contracts);
        void ShowMyGoods(IEnumerable<object> goodsInfo);

        void ShowError(string message);
        void ShowSuccess(string message);
    }
}
