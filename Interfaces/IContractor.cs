using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(Contractor), typeDiscriminator: "base")]
    public interface IContractor
    {
        string Name { get; }
        string ContactInfo { get; }
        IReadOnlyList<IContract> Contracts { get; }
        decimal CalculateTotalDebt();
    }
}
