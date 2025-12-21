using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class StorageUnitsSettingPresenter
    {
        private readonly IStorageUnitsSettingView _view;
        private readonly List<StorageUnitBatch> _batches = new();

        public event Action<List<IStorageUnit>> UnitsConfirmed;

        public StorageUnitsSettingPresenter(IStorageUnitsSettingView view)
        {
            _view = view;
        }

        public void AddBatch()
        {
            _batches.Add(new StorageUnitBatch
            {
                Area = _view.UnitArea,
                Volume = _view.UnitVolume,
                Count = _view.UnitCount
            });
            _view.ShowBatches(_batches);
        }

        public void RemoveBatch(StorageUnitBatch batch)
        {
            _batches.Remove(batch);
            _view.ShowBatches(_batches);
        }

        public void Confirm()
        {
            var result = new List<IStorageUnit>();
            foreach (var batch in _batches)
            {
                for (int i = 0; i < batch.Count; i++)
                {
                    result.Add(new StorageUnit(0, batch.Area, batch.Volume));
                }
            }
            UnitsConfirmed?.Invoke(result);
            _view.CloseView();
        }
    }
}
