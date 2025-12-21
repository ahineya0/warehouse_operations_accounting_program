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
        IWarehouse Warehouse { get; set; }
        int RentedUnits { get; set; }
        decimal RatePerDay { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        bool IsActive();
        bool IsPaid();
        bool CanAcceptGoods(IGoods goods);
    }
}
