using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.View.Items
{
    public class GoodsViewItem
    {
        public IGoods Goods { get; }

        public string Name => Goods.Name;
        public int Quantity => Goods.Quantity;
        public WarehouseType RequiredStorageType => Goods.RequiredStorageType;
        public decimal Volume => Goods.TotalVolume;
        public decimal VolumePerUnit => Goods.VolumePerUnit;

        public GoodsViewItem(IGoods goods)
        {
            Goods = goods;
        }
    }
}
