using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public abstract class StorageUnit : IStorageUnit
    {
        protected readonly List<Goods> goods = new();
        public int Id { get; set; }
        public abstract decimal Capacity { get; }
        public abstract decimal Occupied { get; }
        protected StorageUnit() { }
        protected StorageUnit(int id) { Id = id; }
        public abstract bool CanStore(Goods goods);
        public void AddGoods(Goods goods)
        {
            if (!CanStore(goods)) throw new InvalidOperationException("Недостаточно места");
            this.goods.Add(goods);
        }
        public void RemoveGoods(Goods goods)
        {
            this.goods.Remove(goods);
        }
    }
}
