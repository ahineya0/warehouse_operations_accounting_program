using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class ContractService
    {
        private readonly List<Contract> contracts = new();
        public ContractService(List<Contract> loadedContracts)
        {
            contracts = loadedContracts ?? new List<Contract>();
        }

        public IEnumerable<Contract> GetAll()
        {
            return contracts;
        }

        public void CreateContract(IContractor contractor, IWarehouse warehouse, int rentedUnits, decimal ratePerDay, DateTime startDate, DateTime endDate, Payment payment)
        {
            if ()
                throw new ArgumentException("Неполные данные");

            var сontract = new Contract(contractor, warehouse, rentedUnits, ratePerDay, startDate, endDate, payment);
            contracts.Add(сontract);
        }
    }
}
