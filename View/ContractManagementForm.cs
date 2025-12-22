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
    public partial class ContractManagementForm : Form, IContractManagerView
    {
        private ContractManagementPresenter presenter;
        private List<IGoods> _tempGoods = new();

        public ContractManagementForm(IContractService contractService, IClientService clientService, IWarehouseService warehouseService)
        {
            InitializeComponent();
            presenter = new ContractManagementPresenter(this, contractService, clientService, warehouseService);
            presenter.Initialize();
        }

        public IContractor SelectedClient => cmbClients.SelectedItem as IContractor;
        public IWarehouse SelectedWarehouse => cmbWarehouses.SelectedItem as IWarehouse;
        public DateTime StartDate => dtpStart.Value;
        public DateTime EndDate => dtpEnd.Value;
        public decimal Rate => numRate.Value;
        public bool IsCashless => chkIsCashless.Checked;
        public int RentedUnits => (int)numUnits.Value;
        public List<IGoods> SelectedGoods => _tempGoods;
        public void ShowClients(IEnumerable<Contractor> clients)
        {
            cmbClients.DataSource = clients.ToList();
            cmbClients.DisplayMember = "Name";
        }
        public void ShowWarehouses(IEnumerable<Warehouse> warehouses)
        {
            cmbWarehouses.DataSource = warehouses.ToList();
            cmbWarehouses.DisplayMember = "Name";
        }
        public void ShowContracts(IEnumerable<IContract> contracts)
        {
            dgvContracts.DataSource = null;
            dgvContracts.DataSource = contracts.Select(c => new
            {
                Client = c.Client.Name,
                Warehouse = c.Warehouse.Name,
                Type = c is RentContract ? "Аренда" : "Хранение",
                Cost = c.CalculateCost(),
                Status = c.IsActive() ? "Активен" : "Завершен",
                PaymentStatus = c.IsPaid() ? "Оплачено" : "Ожидает оплаты"
            }).ToList();
        }
        public void ShowError(string message) => MessageBox.Show(message, "Ошибка");
        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            panelRentInfo.Visible = rbRent.Checked;
            panelKeepingInfo.Visible = rbKeeping.Checked;
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            using (var goodsForm = new GoodsSelectionForm())
            {
                if (goodsForm.ShowDialog() == DialogResult.OK)
                {
                    _tempGoods = goodsForm.ResultGoods;
                    lblGoodsCount.Text = $"Товаров выбрано: {_tempGoods.Count}";
                }
            }
        }
        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (rbRent.Checked)
                presenter.CreateRent();
            else
                presenter.CreateKeeping();
        }
    }
}
