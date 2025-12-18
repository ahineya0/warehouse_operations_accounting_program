using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IStorageUnit
    {
        decimal FreeAreaCapacity();
        decimal FreeVolumeCapacity();
        bool CanStore(IGoods goods);
        void AddGoods(IGoods goods);
        void RemoveGoods(IGoods goods);
    }
}
