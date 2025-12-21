using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IClientManagementView
    {
        string ClientName { get; }
        string Contact { get; }
        string Passport { get; }
        string INN { get; }
        string KPP { get; }

        void ShowClients(IEnumerable<Contractor> contractors);
        void ShowError(string message);
    }
}
