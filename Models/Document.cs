using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class Document : IDocument
    {
        protected readonly List<Goods> goods = new();

        public DateTime Date { get; }
        public IContractor Owner { get; }

        public IReadOnlyList<Goods> Goods => goods;

        protected Document(DateTime date, IContractor owner)
        {
            Date = date;
            Owner = owner;
        }

        public int GetTotalQuantity() => goods.Sum(g => g.Quantity);
    }
}
