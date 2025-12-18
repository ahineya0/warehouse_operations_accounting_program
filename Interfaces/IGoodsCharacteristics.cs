using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Interfaces
{
    public interface IGoods
    {
        decimal TotalArea();
        decimal TotalVolume();
    }
}
