using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(StorageUnit), typeDiscriminator: "base")]
    public interface IStorageUnit
    {
        IReadOnlyCollection<IGoods> Goods { get; }
        int Id { get; set; }
        decimal AreaCapacity { get; set; }
        decimal VolumeCapacity { get; set; }
        decimal FreeAreaCapacity();
        decimal FreeVolumeCapacity();
        bool CanStore(IGoods goods);
        void AddGoods(IGoods goods);
        void RemoveGoods(IGoods goods);
    }
}
