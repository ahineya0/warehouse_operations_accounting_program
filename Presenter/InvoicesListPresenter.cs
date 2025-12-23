using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class InvoicesListPresenter
    {
        private readonly IInvoicesListView _view;
        private readonly IDocumentService _documentService;

        public InvoicesListPresenter(IInvoicesListView view, IDocumentService documentService)
        {
            _view = view;
            _documentService = documentService;
        }

        public void RefreshData()
        {
            var invoices = _documentService.GetAll()
                .OrderByDescending(d => d.Date)
                .Select(d => new
                {
                    Тип = d is IncomingInvoice ? "Приход" : "Расход",
                    Дата = d.Date.ToString("g"),
                    Оператор = d.OperatorName,
                    Контракт = $"ID: {d.Contract.Warehouse} ({d.Contract.Client.Name})",
                    Содержимое = string.Join(", ", d.Goods.Select(g => $"{g.Name} ({g.Quantity} шт.)"))
                })
                .ToList();

            _view.ShowInvoices(invoices);
        }
    }
}
