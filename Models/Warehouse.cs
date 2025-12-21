using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public enum WarehouseType { Construction, Refrigeration, Heating }

    public class Warehouse : IWarehouse
    {
        public string Name { get; set; }
        public List<WarehouseType> Type { get; set; }
        public string Address { get; set; }
        public List<IStorageUnit> StorageUnits { get; set; } = new();
        public Warehouse() { }
        public Warehouse(string name, List<WarehouseType> type, string address)
        {
            Name = name;
            Type = type;
            Address = address;
        }
        public decimal FreeAreaCapacity() => StorageUnits.Sum(s => s.FreeAreaCapacity());
        public decimal FreeVolumeCapacity() => StorageUnits.Sum(s => s.FreeVolumeCapacity());
        public bool TryStoreGoods(IGoods goods)
        {
            var unit = StorageUnits.FirstOrDefault(u => u.CanStore(goods));
            if (unit == null) return false;

            unit.AddGoods(goods);
            return true;
        }
    }
}
