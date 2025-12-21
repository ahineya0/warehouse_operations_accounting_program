using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public interface IContractService
    {
        IEnumerable<Contract> GetAll();
        void CreateRentContract(IContractor contractor, IWarehouse warehouse, DateTime startDate, DateTime endDate, Payment payment, decimal ratePerDay, int rentedUnits);
        void CreateKeepingContract(IContractor contractor, IWarehouse warehouse, DateTime startDate, DateTime endDate, Payment payment, decimal ratePerDay, List<IGoods> goods);
    }
}
