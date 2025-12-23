using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public interface IDocumentService
    {
        IEnumerable<Document> GetAll();
        void RegisterDocument(Document document);
        IEnumerable<IncomingInvoice> GetIncomingInvoices();
        IEnumerable<OutcomingInvoice> GetOutcomingInvoices();
    }
}
