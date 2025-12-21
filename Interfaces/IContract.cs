using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(Contract), typeDiscriminator: "base")]
    public interface IContract
    {
        IContractor Client { get; }
        IWarehouse Warehouse { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        bool IsActive();
        bool IsPaid();
        decimal CalculateCost();
    }
}
