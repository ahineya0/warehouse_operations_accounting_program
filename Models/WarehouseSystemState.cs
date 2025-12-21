using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Models
{
    public class WarehouseSystemState
    {
        public List<Warehouse> Warehouses { get; set; } = new();
        public List<Contractor> Contractors { get; set; } = new();
        public List<Contract> Contracts { get; set; } = new();
    }
}
