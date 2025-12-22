using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class RentContract : Contract
    {
        public int RentedUnits { get; set; }

        public decimal RatePerUnitPerDay { get; set; }

        public RentContract(
            IContractor client,
            IWarehouse warehouse,
            DateTime startDate,
            DateTime endDate,
            Payment payment,
            decimal ratePerUnitPerDay,
            int rentedUnits)
            : base(client, warehouse, startDate, endDate, payment, ratePerUnitPerDay)
        {
            RentedUnits = rentedUnits;
            RatePerUnitPerDay = ratePerUnitPerDay;
        }
        public RentContract() : base() { }
        public override decimal CalculateCost()
        {
            var days = (EndDate - StartDate).Days;
            return RentedUnits * RatePerUnitPerDay * days;
        }
    }
}
