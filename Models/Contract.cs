using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class Contract : IContract
    {
        public IContractor Client { get; }
        public IWarehouse Warehouse { get; }

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public Payment Payment { get; }
        public decimal RatePerPerDay { get; }

        protected Contract(
            IContractor client,
            IWarehouse warehouse,
            DateTime startDate,
            DateTime endDate,
            Payment payment,
            decimal ratePerDay)
        {
            Client = client;
            Warehouse = warehouse;
            StartDate = startDate;
            EndDate = endDate;
            Payment = payment;
            RatePerPerDay = ratePerDay;
        }

        public bool IsActive() => DateTime.Now >= StartDate && DateTime.Now <= EndDate;
        public bool IsPaid() => Payment.Status == PaymentStatus.Paid;

        public abstract decimal CalculateCost();
    }
}
