using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public interface IClientService
    {
        IEnumerable<Contractor> GetAll();
        void CreateIndividual(string name, string contact, string passport);
        void CreateCompany(string name, string contact, string inn, string kpp);
    }
}
