using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IDocument
    {
        DateTime Date { get; }
        IContractor Owner { get; }
        IReadOnlyList<Goods> Goods { get; }

        int GetTotalQuantity();
    }
}
