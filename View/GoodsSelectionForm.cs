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

        public void btnAddBatch_Click(object sender, EventArgs e)
        {
            var item = new Goods(
            txtName.Text,
            (WarehouseType)cmbType.SelectedItem,
            (int)numCount.Value,
            numArea.Value,
            numVolume.Value
            );
            ResultGoods.Add(item);
            UpdateGrid();
        }
        public void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void UpdateGrid()
        {
            dgvBatches.DataSource = null;
            dgvBatches.DataSource = ResultGoods.Cast<Goods>().ToList();
        }
        public GoodsSelectionForm()
        {
            InitializeComponent();
            cmbType.DataSource = Enum.GetValues(typeof(WarehouseType));
        }
    }
}
