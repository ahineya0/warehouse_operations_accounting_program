using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class PricingService
    {
        public decimal CalculateTotalCost(IContract contract) => (contract.EndDate - contract.StartDate).Days * contract.RentedUnits * contract.RatePerDay;
    }
}
