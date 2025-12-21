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
    public partial class OutgoingInvoiceForm : Form, IOutgoingInvoiceView
    {
        private OutgoingInvoicePresenter presenter;

        public OutgoingInvoiceForm(IWarehouseService service)
        {
            InitializeComponent();
            presenter = new OutgoingInvoicePresenter(this, service);
            presenter.Initialize();
        }

        public Warehouse SelectedWarehouse =>
            cmbWarehouses.SelectedItem as Warehouse;

        public IGoods SelectedGoods =>
            dgvGoods.CurrentRow?.DataBoundItem as IGoods;

        public void ShowWarehouses(IEnumerable<Warehouse> warehouses)
        {
            cmbWarehouses.DataSource = warehouses.ToList();
            cmbWarehouses.DisplayMember = "Name";
        }

        public void ShowGoods(IEnumerable<IGoods> goods)
        {
            dgvGoods.DataSource = goods.ToList();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message);
        }

        private void cmbWarehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.WarehouseChanged();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            presenter.ReleaseGoods();
        }
    }
}
