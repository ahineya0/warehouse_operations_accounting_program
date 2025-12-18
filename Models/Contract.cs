using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class Contract : IContract
    {
        public IContractor Client { get; set; }
        public IWarehouse Warehouse { get; set; }
        public int RentedUnits { get; set; }
        public decimal RatePerDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Payment Payment { get; set; }
        public bool IsActive() => DateTime.Now <= EndDate;
        public bool IsPaid() => Payment.Status == PaymentStatus.Paid;
        public decimal CalculateTotalCost() => (EndDate - StartDate).Days * RentedUnits * RatePerDay;
    }
}
