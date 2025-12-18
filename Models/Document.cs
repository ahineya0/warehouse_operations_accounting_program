using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class Document : IDocument
    {
        public string OperatorName { get; }
        public IContract Contract { get; }
        protected readonly List<IGoodsInformation> goods = new();
        public DateTime Date { get; }

        public IReadOnlyList<IGoodsInformation> Goods => goods;

        protected Document(string operatorName, IContract contract, DateTime date)
        {
            if (!contract.IsActive())
                throw new InvalidOperationException("Нельзя проводить операции по истекшему договору.");
            OperatorName = operatorName;
            Contract = contract;
            Date = date;
        }
    }
}
