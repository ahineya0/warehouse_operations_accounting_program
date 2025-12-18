using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class Document : IDocument
    {
        public string OperatorName { get; }
        public IWarehouse Warehouse { get; }
        protected readonly List<IGoodsInformation> goods = new();
        public DateTime Date { get; }
        public IContractor Owner { get; }

        public IReadOnlyList<IGoodsInformation> Goods => goods;

        protected Document(string operatorName, IWarehouse warehouse, DateTime date, IContractor owner)
        {
            OperatorName = operatorName;
            Warehouse = warehouse;
            Date = date;
            Owner = owner;
        }
    }
}
