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
    public partial class IncomingInvoiceForm : Form, IIncomingInvoiceView
    {
        private readonly IncomingInvoicePresenter _presenter;

        public IncomingInvoiceForm(IContractService contractService, IWarehouseService warehouseService, IDocumentService documentService)
        {
            InitializeComponent();
            _presenter = new IncomingInvoicePresenter(this, contractService, warehouseService, documentService);
            _presenter.Initialize();
            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
        }

        public string OperatorName => txtOperatorName.Text;

        public IContract SelectedContract => (cbContracts.SelectedItem as ContractListItem)?.Contract;

        public IEnumerable<IGoods> SelectedGoods =>
            dgvGoodsToAccept.SelectedRows.Cast<DataGridViewRow>().Select(r => (r.DataBoundItem as GoodsViewItem)?.Goods).Where(g => g != null);

        public IEnumerable<IStorageUnit> SelectedStorageUnits => lbStorageUnits.SelectedItems.Cast<StorageUnitListItem>().Select(i => i.Unit);

        public void ShowActiveContracts(IEnumerable<IContract> contracts)
        {
            cbContracts.Items.Clear();
            foreach (var contract in contracts)
                cbContracts.Items.Add(new ContractListItem(contract));

            cbContracts.DisplayMember = "DisplayText";
        }

        public void ShowContractGoods(IEnumerable<IGoods> goods)
        {
            dgvGoodsToAccept.DataSource = null;
            if (goods != null)
                dgvGoodsToAccept.DataSource = goods.Select(g => new GoodsViewItem(g)).ToList();
        }

        public void ShowSuccess(string message) => MessageBox.Show(message, "Успех");

        public void ShowError(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void cbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contract = SelectedContract;
            if (contract != null)
                _presenter.RefreshUI(contract);
        }

        public void ShowStorageUnits(IEnumerable<IStorageUnit> units)
        {
            var selectedIds = lbStorageUnits.SelectedItems.Cast<StorageUnitListItem>().Select(i => i.Unit.Id).ToList();

            lbStorageUnits.Items.Clear();
            foreach (var unit in units)
            {
                lbStorageUnits.Items.Add(new StorageUnitListItem(unit));
            }
            lbStorageUnits.DisplayMember = "DisplayText";

            for (int i = 0; i < lbStorageUnits.Items.Count; i++)
            {
                if (selectedIds.Contains(((StorageUnitListItem)lbStorageUnits.Items[i]).Unit.Id))
                    lbStorageUnits.SetSelected(i, true);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _presenter.Accept();
        }
    }
}
