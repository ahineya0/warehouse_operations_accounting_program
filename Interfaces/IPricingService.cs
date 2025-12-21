using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(PricingService), typeDiscriminator: "base")]
    public interface IPricingService
    {
        decimal CalculateTotalCost(IContract contract);
    }
}
