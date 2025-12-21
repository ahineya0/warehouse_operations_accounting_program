using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IWarehouse
    {
        string Name { get; }
        List<WarehouseType> Type { get; set; }
        bool TryStoreGoods(IGoods goods);
    }
}
