using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class OutcomingInvoice : Document
    {
        public OutcomingInvoice(string operatorName, IContract contract, DateTime date) : base(operatorName, contract, date) { }

        public void ReleaseGoods(IGoods goods)
        {
            this.goods.Add(goods);
        }
    }
}
