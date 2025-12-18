using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class OutcomingInvoice : Document
    {
        public OutcomingInvoice(string operatorName, IWarehouse warehouse, DateTime date, IContractor owner) : base(operatorName, warehouse, date, owner) { }

        public void ReleaseGoods(Goods goods)
        {
            this.goods.Add(goods);
        }
    }
}
