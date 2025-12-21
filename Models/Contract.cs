using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    [JsonDerivedType(typeof(KeepingContract), "keeping")]
    [JsonDerivedType(typeof(RentContract), "rent")]
    public abstract class Contract : IContract
    {
        public IContractor Client { get; set; }
        public IWarehouse Warehouse { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Payment Payment { get; set; }
        public decimal RatePerPerDay { get; set; }

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
        protected Contract() { }
        public bool IsActive() => DateTime.Now >= StartDate && DateTime.Now <= EndDate;
        public bool IsPaid() => Payment.Status == PaymentStatus.Paid;

        public abstract decimal CalculateCost();
    }
}
