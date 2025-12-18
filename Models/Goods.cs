using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class Goods : IGoods
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal AreaPerUnit { get; set; }
        public decimal VolumePerUnit { get; set; }


        public decimal TotalArea() => Quantity * AreaPerUnit;
        public decimal TotalVolume() => Quantity * VolumePerUnit;
    }
}
