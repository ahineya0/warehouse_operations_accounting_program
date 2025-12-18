using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IWarehouse
    {
        public List<WarehouseType> Type { get; set; }
        bool TryStoreGoods(IGoodsCharacteristics goods);
    }
}
