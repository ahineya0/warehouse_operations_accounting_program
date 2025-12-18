using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IContractor
    {
        string Name { get; }
        string ContactInfo { get; }
        IReadOnlyList<IContract> Contracts { get; }
        decimal CalculateTotalDebt();
    }
}
