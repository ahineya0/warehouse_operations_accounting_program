using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.View.Items
{
    public class ContractListItem
    {
        public string DisplayText { get; }
        public IContract Contract { get; }

        public ContractListItem(IContract contract)
        {
            Contract = contract;
            DisplayText =
                $"{(contract is RentContract ? "Аренда" : "Хранение")} " +
                $"{contract.Client.Name} - {contract.Warehouse.Name} " +
                $"({contract.StartDate:dd.MM.yyyy})";
        }
    }
}
