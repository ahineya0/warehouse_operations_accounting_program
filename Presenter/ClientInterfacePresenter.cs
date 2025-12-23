using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class ClientInterfacePresenter
    {
        private readonly IClientInterfaceView _view;
        private readonly IContractService _contractService;
        private readonly IWarehouseService _warehouseService;

        public ClientInterfacePresenter(IClientInterfaceView view, IContractService contractService, IWarehouseService warehouseService)
        {
            _view = view;
            _contractService = contractService;
            _warehouseService = warehouseService;
        }

        // Имитация входа и загрузка данных
        public void LoginAndLoadData()
        {
            var clientName = _view.AuthClientName;
            if (string.IsNullOrWhiteSpace(clientName)) return;

            var myContracts = _contractService.GetAll()
                .Where(c => c.Client.Name.Equals(clientName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            _view.ShowMyContracts(myContracts.Select(c => new {
                Id = c.GetHashCode(),
                Type = c is RentContract ? "Аренда" : "Хранение",
                Warehouse = c.Warehouse.Name,
                Period = $"{c.StartDate.ToShortDateString()} - {c.EndDate.ToShortDateString()}",
                Cost = c.CalculateCost(),
                IsPaid = c.IsPaid() ? "Оплачено" : "Ожидает"
            }));

            LoadGoodsInfo(myContracts);
        }

        private void LoadGoodsInfo(List<Contract> contracts)
        {
            var goodsInfo = new List<object>();
            var allWarehouses = _warehouseService.GetAll();
            var groupedGoods = new Dictionary<string, (string GoodName, string Status, int Quantity)>();

            foreach (var contract in contracts.OfType<KeepingContract>())
            {
                foreach (var item in contract.Goods)
                {
                    var location = "В процессе приема";
                    var warehouse = allWarehouses.FirstOrDefault(w => w.Name == contract.Warehouse.Name);

                    if (warehouse != null)
                    {
                        var foundInUnit = warehouse.StorageUnits.Any(u => u.GetGoods().Any(g => g.Name == item.Name));

                        if (foundInUnit)
                            location = $"На складе: {warehouse.Name} ({warehouse.Address})";
                    }

                    var key = $"{item.Name}|{location}";
                    if (groupedGoods.ContainsKey(key))
                    {
                        var existing = groupedGoods[key];
                        groupedGoods[key] = (existing.GoodName, existing.Status, existing.Quantity + item.Quantity);
                    }
                    else
                        groupedGoods[key] = (item.Name, location, item.Quantity);
                }
            }

            foreach (var goods in groupedGoods.Values)
            {
                goodsInfo.Add(new
                {
                    GoodName = goods.GoodName,
                    Status = goods.Status,
                    Quantity = goods.Quantity
                });
            }

            _view.ShowMyGoods(goodsInfo);
        }

        public void PayContract(int contractHash)
        {
            var contract = _contractService.GetAll().FirstOrDefault(c => c.GetHashCode() == contractHash);
            if (contract != null)
            {
                contract.Payment.Status = PaymentStatus.Paid;
                _view.ShowSuccess("Оплата успешно произведена");
                LoginAndLoadData();
            }
        }
    }
}
