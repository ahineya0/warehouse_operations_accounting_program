using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IDocument
    {
        string OperatorName { get; }
        IReadOnlyList<IGoodsInformation> Goods { get; }
        IContract Contract { get; }
        DateTime Date { get; }
    }
}
