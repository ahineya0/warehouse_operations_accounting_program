using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly List<Document> _documents;

        public DocumentService(List<Document> loadedDocuments)
        {
            _documents = loadedDocuments ?? new List<Document>();
        }

        public IEnumerable<Document> GetAll()
        {
            return _documents;
        }

        public void RegisterDocument(Document document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document), "Документ не может быть пустым");

            _documents.Add(document);
        }

        public IEnumerable<IncomingInvoice> GetIncomingInvoices()
        {
            return _documents.OfType<IncomingInvoice>();
        }

        public IEnumerable<OutcomingInvoice> GetOutcomingInvoices()
        {
            return _documents.OfType<OutcomingInvoice>();
        }
    }
}
