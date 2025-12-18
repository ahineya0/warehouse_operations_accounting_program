using System;
using System.Collections.Generic;
using System.Text;

namespace warehouse_operations_accounting_program.Models
{
    public class Individual : Contractor
    {
        public string PassportData { get; set; }
        public Individual() { }
        public Individual(string name, string contact, string passport) : base(name, contact)
        {
            PassportData = passport;
        }
    }
}
