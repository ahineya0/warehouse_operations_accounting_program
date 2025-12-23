using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(Warehouse), typeDiscriminator: "base")]
    public interface IWarehouse
    {
        string Name { get; }
        List<WarehouseType> Type { get; set; }
        public List<IStorageUnit> StorageUnits { get; set; }
        bool TryStoreGoods(IGoods goods);
    }
}
