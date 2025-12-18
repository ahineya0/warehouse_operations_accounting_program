using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class Contractor : IContractor
    {
        protected readonly List<IContract> contracts = new();

        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public IReadOnlyList<IContract> Contracts => contracts;


        protected Contractor() { }
        protected Contractor(string name, string contact)
        {
            Name = name;
            ContactInfo = contact;
        }

        public void AddContract(Contract contract) => contracts.Add(contract);

        IPricingService service { get; set; }
        public decimal CalculateTotalDebt() => contracts.Where(c => c.IsActive() && !c.IsPaid()).Sum(c => service.CalculateTotalCost(c));
    }
}
