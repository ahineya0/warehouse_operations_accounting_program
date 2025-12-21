using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IStorageUnitsSettingView
    {
        decimal UnitArea { get; }
        decimal UnitVolume { get; }
        int UnitCount { get; }
        void ShowBatches(List<StorageUnitBatch> batches);
        void CloseView();
    }
}
