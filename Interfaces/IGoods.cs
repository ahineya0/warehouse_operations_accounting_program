using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(Goods), typeDiscriminator: "base")]
    public interface IGoods
    {
        string Name { get; set; }
        int Quantity { get; set; }
        WarehouseType RequiredStorageType { get; set; }
        decimal AreaPerUnit { get; set; }
        decimal VolumePerUnit { get; set; }
        decimal TotalArea { get; set; }
        decimal TotalVolume { get; set; }
    }
}
