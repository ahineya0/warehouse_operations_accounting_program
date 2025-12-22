using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class ContractService : IContractService
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

        public void CreateRentContract(IContractor contractor, IWarehouse warehouse, DateTime startDate, DateTime endDate, Payment payment, decimal ratePerDay, int rentedUnits)
        {
            if (contractor == null || warehouse == null || payment == null || startDate >= endDate || ratePerDay <= 0 || rentedUnits <= 0)
                throw new ArgumentException("Неполные данные");

            var contract = new RentContract(contractor, warehouse, startDate, endDate, payment, ratePerDay, rentedUnits);
            contracts.Add(contract);
            contractor.AddContract(contract);
        }

        public void CreateKeepingContract(IContractor contractor, IWarehouse warehouse, DateTime startDate, DateTime endDate, Payment payment, decimal ratePerDay, List<IGoods> goods)
        {
            if (contractor == null || warehouse == null || payment == null || startDate >= endDate || ratePerDay <= 0 || goods == null || goods.Count == 0)
                throw new ArgumentException("Неполные данные");

            var contract = new KeepingContract(contractor, warehouse, startDate, endDate, payment, ratePerDay, goods);
            contracts.Add(contract);
            contractor.AddContract(contract);
        }
    }
}
