using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Models
{
    public class Warehouse
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public List<StorageUnit> StorageUnits { get; set; } = new();
        public Warehouse() { }
        public Warehouse(string name, string type, string address)
        {
            Name = name;
            Type = type;
            Address = address;
        }
        public decimal FreeCapacity() => StorageUnits.Sum(s => s.Capacity - s.Occupied);
    }
}
