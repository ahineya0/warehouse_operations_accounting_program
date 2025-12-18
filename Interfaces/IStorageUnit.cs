using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IStorageUnit
    {
        int Id { get; }
        decimal Capacity { get; }
        decimal Occupied { get; }

        bool CanStore(Goods goods);
        void AddGoods(Goods goods);
        void RemoveGoods(Goods goods);
    }

}
