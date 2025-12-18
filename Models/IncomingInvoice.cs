using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class IncomingInvoice : Document
    {
        public IncomingInvoice(string operatorName, IContract contract, DateTime date) : base (operatorName, contract, date) { }

        public void AcceptGoods(IGoods goods)
        {
            if (!Contract.Warehouse.TryStoreGoods(goods))
                throw new InvalidOperationException("Склад переполнен");

            this.goods.Add(goods);
        }
    }
}
