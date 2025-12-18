using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IGoodsInformation
    {
        string Name { get; set; }
        int Quantity { get; set; }
        WarehouseType RequiredStorageType { get; set; }
    }
}
