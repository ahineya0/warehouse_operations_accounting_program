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
using warehouse_operations_accounting_program.View.Items;

namespace warehouse_operations_accounting_program.View
{
    public partial class OutgoingInvoiceForm : Form, IOutgoingInvoiceView
    {
        private readonly OutgoingInvoicePresenter _presenter;

        public OutgoingInvoiceForm(IContractService contractService, IWarehouseService warehouseService, IDocumentService documentService)
        {
            InitializeComponent();
            _presenter = new OutgoingInvoicePresenter(this, contractService, warehouseService, documentService);
            _presenter.Initialize();

            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
        }

        public string OperatorName => txtOperatorName.Text;

        public IContract SelectedContract => (cbContracts.SelectedItem as ContractListItem)?.Contract;

        public IGoods SelectedGoods => (dgvStoredGoods.CurrentRow?.DataBoundItem as GoodsViewItem)?.Goods;

        public IEnumerable<IStorageUnit> SelectedStorageUnits =>
            lbStorageUnits.SelectedItems.Cast<StorageUnitListItem>().Select(i => i.Unit);

        public void ShowActiveContracts(IEnumerable<IContract> contracts)
        {
            cbContracts.Items.Clear();
            foreach (var contract in contracts)
                cbContracts.Items.Add(new ContractListItem(contract));
            cbContracts.DisplayMember = "DisplayText";
        }

        public void ShowStoredGoods(IEnumerable<IGoods> goods)
        {
            dgvStoredGoods.DataSource = null;
            if (goods != null)
                dgvStoredGoods.DataSource = goods.Select(g => new GoodsViewItem(g)).ToList();
        }

        public void ShowStorageUnits(IEnumerable<IStorageUnit> units)
        {
            lbStorageUnits.Items.Clear();
            foreach (var unit in units)
                lbStorageUnits.Items.Add(new StorageUnitListItem(unit));
            lbStorageUnits.DisplayMember = "DisplayText";
        }

        private void cbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.OnContractChanged();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            _presenter.Release();
        }

        public void ShowSuccess(string message) => MessageBox.Show(message, "Успех");
        public void ShowError(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
