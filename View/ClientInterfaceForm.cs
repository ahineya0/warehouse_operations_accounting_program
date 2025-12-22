using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class ClientInterfaceForm : Form, IClientInterfaceView
    {
        private ClientInterfacePresenter _presenter;
        public ClientInterfaceForm(IContractService contractService, IClientService clientService, IWarehouseService warehouseService)
        {
            InitializeComponent();
            _presenter = new ClientInterfacePresenter(this, contractService, warehouseService);
        }
        public string AuthClientName => txtLoginName.Text;

        public void ShowMyContracts(IEnumerable<object> contracts) => dgvContracts.DataSource = contracts.ToList();
        public void ShowMyGoods(IEnumerable<object> goodsInfo) => dgvGoods.DataSource = goodsInfo.ToList();

        private void btnLogin_Click(object sender, EventArgs e) => _presenter.LoginAndLoadData();

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvContracts.CurrentRow != null)
            {
                dynamic selected = dgvContracts.CurrentRow.DataBoundItem;
                _presenter.PayContract(selected.Id);
            }
        }

        public void ShowError(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public void ShowSuccess(string message) => MessageBox.Show(message, "Успех");
    }
}
