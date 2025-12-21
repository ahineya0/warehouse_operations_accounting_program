using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public interface IWarehouseService
    {
        IEnumerable<Warehouse> GetAll();

        void CreateWarehouse(string name, List<WarehouseType> types, string address, IEnumerable<IStorageUnit> storageUnits);

        void AcceptGoods(Warehouse warehouse, IGoods goods);

        void ReleaseGoods(Warehouse warehouse, IGoods goods);
    }
}
