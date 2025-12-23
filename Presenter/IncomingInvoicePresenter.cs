using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class IncomingInvoicePresenter
    {
        private readonly IIncomingInvoiceView _view;
        private readonly IContractService _contractService;
        private readonly IWarehouseService _warehouseService;

        public IncomingInvoicePresenter(IIncomingInvoiceView view, IContractService contractService, IWarehouseService warehouseService)
        {
            _view = view;
            _contractService = contractService;
            _warehouseService = warehouseService;
        }

        public void Initialize()
        {
            var active = _contractService
                .GetAll()
                .Where(c => c.IsActive())
                .ToList();

            _view.ShowActiveContracts(active);
        }

        public void Accept()
        {
            try
            {
                var contract = _view.SelectedContract
                    ?? throw new Exception("Договор не выбран");

                var invoice = new IncomingInvoice(
                    _view.OperatorName,
                    contract,
                    DateTime.Now);

                if (contract is KeepingContract keeping)
                {
                    AcceptKeeping(keeping, invoice);
                    _view.ShowSuccess("Приёмка оформлена");
                }
                else if (contract is RentContract rent)
                {
                    AcceptRent(rent, invoice);
                    _view.ShowSuccess("Приёмка оформлена");
                }
                RefreshUI(contract);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        private void AcceptKeeping(KeepingContract contract, IncomingInvoice invoice)
        {
            // 1. Сразу фиксируем список ВЫДЕЛЕННЫХ ячеек в локальную переменную
            var selectedUnits = _view.SelectedStorageUnits.ToList();
            var selectedGoods = _view.SelectedGoods.ToList();

            if (!selectedGoods.Any()) throw new Exception("Выберите товары.");
            if (!selectedUnits.Any()) throw new Exception("Выберите ячейки.");

            foreach (var goodsItem in selectedGoods)
            {
                // Сверяем по имени, так как при десериализации/обновлении ссылки на объекты меняются
                bool alreadyStored = contract.Warehouse.StorageUnits
                    .Any(u => u.GetGoods().Any(g => g.Name == goodsItem.Name));

                if (alreadyStored)
                {
                    _view.ShowError($"Товар '{goodsItem.Name}' уже принят!");
                    continue;
                }

                int remaining = goodsItem.Quantity;

                // 2. Распределяем товар. Если ячеек несколько, делим поровну или сколько влезет
                foreach (var unit in selectedUnits)
                {
                    if (remaining <= 0) break;

                    int canFit = CalculateHowManyCanFit(unit, goodsItem);
                    if (canFit <= 0) continue;

                    // Распределяем пропорционально, чтобы не забивать только первую
                    int limit = (selectedUnits.Count > 1)
                        ? (int)Math.Ceiling((double)goodsItem.Quantity / selectedUnits.Count)
                        : remaining;

                    int countToPut = Math.Min(Math.Min(limit, canFit), remaining);

                    if (countToPut > 0)
                    {
                        var subBatch = new Goods(
                            goodsItem.Name,
                            goodsItem.RequiredStorageType,
                            countToPut,
                            goodsItem.AreaPerUnit,
                            goodsItem.VolumePerUnit);

                        unit.AddGoods(subBatch);
                        invoice.AcceptGoods(subBatch);
                        remaining -= countToPut;
                    }
                }

                if (remaining > 0)
                    throw new Exception($"Не удалось разместить {remaining} шт. товара '{goodsItem.Name}'.");

                // 3. Убираем "плановый" товар и заменяем его реально размещенным, чтобы не было дубля объема
                contract.Goods.Remove(goodsItem);
            }
        }

        public void RefreshUI(IContract contract)
        {
            if (contract == null) return;

            // Обновляем ячейки
            _view.ShowStorageUnits(contract.Warehouse.StorageUnits.ToList());

            // ВАЖНО: Показываем в таблице только то, чего НЕТ на складе
            if (contract is KeepingContract kc)
            {
                var remainingGoods = kc.Goods.Where(g =>
                    !kc.Warehouse.StorageUnits.Any(u => u.GetGoods().Any(st => st.Name == g.Name))
                ).ToList();
                _view.ShowContractGoods(remainingGoods);
            }
        }

        private int CalculateHowManyCanFit(IStorageUnit unit, IGoods goods)
        {
            decimal freeArea = unit.FreeAreaCapacity();
            decimal freeVolume = unit.FreeVolumeCapacity();

            int byArea = (int)(freeArea / goods.AreaPerUnit);
            int byVolume = (int)(freeVolume / goods.VolumePerUnit);

            return Math.Min(byArea, byVolume);
        }

        private void AcceptRent(RentContract contract, IncomingInvoice invoice)
        {
            foreach (var unit in _view.SelectedStorageUnits)
            {
                if (!unit.IsFree)
                    throw new Exception($"Ячейка {unit.Id} уже занята");

                unit.IsFree = false;
            }
            var selectedContract = _view.SelectedContract;
            if (selectedContract != null)
            {
                var units = selectedContract.Warehouse.StorageUnits.ToList();
                _view.ShowStorageUnits(units);
            }
        }
    }
}
