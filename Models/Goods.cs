using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class Goods : IGoods
    {
        public string Name { get; set; }
        public WarehouseType RequiredStorageType { get; set; }
        public int Quantity { get; set; }
        public decimal AreaPerUnit { get; set; }
        public decimal VolumePerUnit { get; set; }

        public Goods(string name, WarehouseType requiredStorageType, int quantity, decimal areaPerUnit, decimal volumePerUnit)
        {
            Name = name;
            RequiredStorageType = requiredStorageType;
            Quantity = quantity;
            AreaPerUnit = areaPerUnit;
            VolumePerUnit = volumePerUnit;
        }

        public decimal TotalArea
        {
            get => Quantity * AreaPerUnit;
            set;
        }
        public decimal TotalVolume
        {
            get => Quantity * VolumePerUnit;
            set;
        }
    }
}
