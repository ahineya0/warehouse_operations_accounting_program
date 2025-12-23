using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class OutgoingInvoicePresenter
    {
        private readonly IOutgoingInvoiceView _view;
        private readonly IContractService _contractService;
        private readonly IWarehouseService _warehouseService;

        public OutgoingInvoicePresenter(IOutgoingInvoiceView view, IContractService contractService, IWarehouseService warehouseService)
        {
            _view = view;
            _contractService = contractService;
            _warehouseService = warehouseService;
        }

        public void Initialize()
        {
            var active = _contractService.GetAll().Where(c => c.IsActive()).ToList();
            _view.ShowActiveContracts(active);
        }

        public void OnContractChanged()
        {
            var contract = _view.SelectedContract;
            RefreshUI(contract);
        }

        public void Release()
        {
            try
            {
                var contract = _view.SelectedContract ?? throw new Exception("Договор не выбран");
                var invoice = new OutcomingInvoice(_view.OperatorName, contract, DateTime.Now);

                if (contract is KeepingContract keeping)
                    ReleaseKeeping(keeping, invoice);
                else if (contract is RentContract rent)
                    ReleaseRent(rent, invoice);

                RefreshUI(contract);
                _view.ShowSuccess("Отпуск оформлен");
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void ReleaseKeeping(KeepingContract contract, OutcomingInvoice invoice)
        {
            var goods = _view.SelectedGoods ?? throw new Exception("Товар не выбран в таблице");

            var unit = contract.Warehouse.StorageUnits.FirstOrDefault(u => u.GetGoods().Contains(goods)) 
                ?? throw new Exception("Товар не найден в ячейках склада");

            unit.RemoveGoods(goods);

            contract.Goods.Remove(goods);

            invoice.ReleaseGoods(goods);
        }

        private void ReleaseRent(RentContract contract, OutcomingInvoice invoice)
        {
            var selectedUnits = _view.SelectedStorageUnits.ToList();
            if (!selectedUnits.Any()) throw new Exception("Выберите арендованные ячейки для освобождения");

            foreach (var unit in selectedUnits)
            {
                if (unit.IsFree) throw new Exception($"Ячейка {unit.Id} уже свободна");
                unit.IsFree = true;
            }
        }

        private void RefreshUI(IContract contract)
        {
            if (contract == null) return;

            _view.ShowStorageUnits(contract.Warehouse.StorageUnits);

            if (contract is KeepingContract)
            {
                var storedGoods = contract.Warehouse.StorageUnits
                    .SelectMany(u => u.GetGoods())
                    .ToList();
                _view.ShowStoredGoods(storedGoods);
            }
        }
    }
}
