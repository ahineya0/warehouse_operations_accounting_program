using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class IncomingInvoice : Document
    {
        public IncomingInvoice(string operatorName, IWarehouse warehouse, DateTime date, IContractor owner) : base (operatorName, warehouse, date, owner) { }

        public void AcceptGoods(Goods goods)
        {
            if (!Warehouse.TryStoreGoods(goods))
                throw new InvalidOperationException("Склад переполнен");

            this.goods.Add(goods);
        }
    }
}
