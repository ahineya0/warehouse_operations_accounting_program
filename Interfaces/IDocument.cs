using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IDocument
    {
        IWarehouse Warehouse { get; }
        DateTime Date { get; }
        IContractor Owner { get; }
        IReadOnlyList<IGoodsInformation> Goods { get; }
    }
}
