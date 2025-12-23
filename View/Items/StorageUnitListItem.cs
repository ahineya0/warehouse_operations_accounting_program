using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.View.Items
{
    public class StorageUnitListItem
    {
        public IStorageUnit Unit { get; }
        public StorageUnitListItem(IStorageUnit unit) => Unit = unit;

        public string DisplayText =>
            $"Ячейка #{Unit.Id} (Свободно: {Unit.FreeAreaCapacity()}м², {Unit.FreeVolumeCapacity()}м³)";
    }
}
