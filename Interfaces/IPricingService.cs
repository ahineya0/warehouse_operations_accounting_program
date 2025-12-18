using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IPricingService
    {
        decimal CalculateTotalCost(IContract contract);
    }
}
