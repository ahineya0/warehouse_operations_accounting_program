using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class GoodsBatch
    {
        public string Name { get; set; }
        public WarehouseType Type { get; set; }
        public int Count { get; set; }
        public decimal Area { get; set; }
        public decimal Volume { get; set; }

        public decimal TotalArea => Count * Area;
        public decimal TotalVolume => Count * Volume;
    }
}
