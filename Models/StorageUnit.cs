using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;

namespace warehouse_operations_accounting_program.Models
{
    public class StorageUnit : IStorageUnit
    {
        protected readonly List<IGoodsCharacteristics> goods = new();
        public int Id { get; set; }
        public decimal AreaCapacity { get; set; }
        public decimal VolumeCapacity { get; set; }
        public decimal OccupiedArea { get; }
        public decimal OccupiedVolume { get; }
        protected StorageUnit() { }
        protected StorageUnit(int id, decimal areaCapacity, decimal volumeCapacity) 
        { 
            Id = id;
            AreaCapacity = areaCapacity;
            VolumeCapacity = volumeCapacity;
        }
        public decimal FreeAreaCapacity() => AreaCapacity - OccupiedArea;
        public decimal FreeVolumeCapacity() => VolumeCapacity - OccupiedVolume;
        public bool CanStore(IGoodsCharacteristics goods) => OccupiedArea + goods.TotalArea() <= AreaCapacity || OccupiedVolume + goods.TotalVolume() <= VolumeCapacity;
        public void AddGoods(IGoodsCharacteristics goods)
        {
            if (!CanStore(goods)) throw new InvalidOperationException("Недостаточно места");
            this.goods.Add(goods);
        }
        public void RemoveGoods(IGoodsCharacteristics goods)
        {
            this.goods.Remove(goods);
        }
    }
}
