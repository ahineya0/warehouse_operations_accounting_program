using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Models
{
    public class Company : Contractor
    {
        public string INN { get; set; }
        public string KPP { get; set; }
        public Company() { }
        public Company(string name, string contact, string inn, string kpp) : base(name, contact)
        {
            INN = inn;
            KPP = kpp;
        }
    }
}
