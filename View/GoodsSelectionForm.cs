using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class GoodsSelectionForm : Form
    {
        public List<IGoods> ResultGoods { get; private set; } = new();
        private List<GoodsBatch> _batches = new();

        public void btnAddBatch_Click(object sender, EventArgs e)
        {
            var batch = new GoodsBatch
            {
                Name = txtName.Text,
                Type = (WarehouseType)cmbType.SelectedItem,
                Count = (int)numCount.Value,
                Area = numArea.Value,
                Volume = numVolume.Value
            };
            _batches.Add(batch);
            UpdateGrid();
        }
        public void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (var b in _batches)
            {
                for (int i = 0; i < b.Count; i++)
                    ResultGoods.Add(new Goods(b.Name, b.Type, 1, b.Area, b.Volume));
            }
            this.DialogResult = DialogResult.OK;
        }
        private void UpdateGrid()
        {
            dgvBatches.DataSource = null;
            dgvBatches.DataSource = _batches.ToList();
        }
        public GoodsSelectionForm()
        {
            InitializeComponent();
            cmbType.DataSource = Enum.GetValues(typeof(WarehouseType));
        }
    }
}
