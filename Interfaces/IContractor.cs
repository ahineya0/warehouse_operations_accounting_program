using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IContractor
    {
        string Name { get; }
        string ContactInfo { get; }

        IReadOnlyList<IContract> Contracts { get; }
        public void AddContract(IContract contract);
    }
}
