using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class KeepingContract : Contract
    {
        public List<IGoods> Goods { get; }

        public decimal RatePerVolumePerDay { get; }

        public KeepingContract(
            IContractor client,
            IWarehouse warehouse,
            DateTime startDate,
            DateTime endDate,
            Payment payment,
            decimal ratePerVolumePerDay,
            List<IGoods> goods) : base(client, warehouse, startDate, endDate, payment, ratePerVolumePerDay)
        {
            RatePerVolumePerDay = ratePerVolumePerDay;
            Goods = goods;
        }

        public bool CanAcceptGoods(IGoods goodsItem)
        {
            return Warehouse.Type.Contains(goodsItem.RequiredStorageType);
        }

        public override decimal CalculateCost()
        {
            var totalVolume = Goods.Sum(g => g.TotalVolume());
            var days = (EndDate - StartDate).Days;

            return totalVolume * RatePerVolumePerDay * days;
        }
    }
}
