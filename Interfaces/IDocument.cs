using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    [JsonDerivedType(typeof(Document), typeDiscriminator: "base")]
    public interface IDocument
    {
        string OperatorName { get; }
        IReadOnlyList<IGoods> Goods { get; }
        IContract Contract { get; }
        DateTime Date { get; }
    }
}
