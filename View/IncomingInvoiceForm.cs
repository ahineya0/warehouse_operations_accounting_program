using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class IncomingInvoiceForm : Form, IIncomingInvoiceView
    {
        private IncomingInvoicePresenter presenter;

        public IncomingInvoiceForm(IWarehouseService service)
        {
            InitializeComponent();
            presenter = new IncomingInvoicePresenter(this, service);
            presenter.Initialize();

            cmbStorageType.DataSource = Enum.GetValues(typeof(WarehouseType));
        }

        public Warehouse SelectedWarehouse => cmbWarehouses.SelectedItem as Warehouse;

        public Goods GoodsData =>
            new Goods(txtGoodsName.Text, (WarehouseType)cmbStorageType.SelectedItem, (int)numQuantity.Value, numArea.Value, numVolume.Value);

        public void ShowWarehouses(IEnumerable<Warehouse> warehouses)
        {
            cmbWarehouses.DataSource = warehouses.ToList();
            cmbWarehouses.DisplayMember = "Name";
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            presenter.AcceptGoods();
        }
    }
}
