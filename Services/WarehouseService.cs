using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly List<Warehouse> warehouses = new();
        public WarehouseService(List<Warehouse> loadedWarehouses)
        {
            warehouses = loadedWarehouses ?? new List<Warehouse>();
        }

        public IEnumerable<Warehouse> GetAll()
        {
            return warehouses;
        }

        public void CreateWarehouse(string name, List<WarehouseType> types, string address, IEnumerable<IStorageUnit> storageUnits)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название склада не задано");

            var warehouse = new Warehouse(name, types, address);
            int currentId = 1;
            foreach (var unit in storageUnits)
            {
                unit.Id = currentId++;
                warehouse.StorageUnits.Add(unit);
            }
            warehouses.Add(warehouse);
        }

        public void AcceptGoods(Warehouse warehouse, IGoods goods)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            if (goods == null)
                throw new ArgumentNullException(nameof(goods));

            if (!warehouse.TryStoreGoods(goods))
                throw new InvalidOperationException("Недостаточно места на складе");
        }

        public void ReleaseGoods(Warehouse warehouse, IGoods goods)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            var unit = warehouse.StorageUnits.FirstOrDefault(u => u.GetGoods().Contains(goods));

            if (unit == null)
                throw new InvalidOperationException("Товар не найден на складе");

            unit.RemoveGoods(goods);
        }
    }
}
