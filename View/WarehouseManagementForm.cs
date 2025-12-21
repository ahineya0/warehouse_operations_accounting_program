using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.View
{
    public partial class WarehouseManagementForm : Form, IWarehouseManagementView
    {
        private WarehouseManagementPresenter presenter;

        public WarehouseManagementForm(IWarehouseService service)
        {
            InitializeComponent();
            presenter = new WarehouseManagementPresenter(this, service);
            presenter.Initialize();

            clbTypes.DataSource = Enum.GetValues(typeof(WarehouseType));
        }

        public string WarehouseName => txtName.Text;
        public string Address => txtAddress.Text;
        public List<WarehouseType> SelectedTypes => clbTypes.CheckedItems.Cast<WarehouseType>().ToList();

        public void ShowWarehouses(IEnumerable<Warehouse> warehouses)
        {
            dgvWarehouses.DataSource = warehouses.Select(w => new 
            { w.Name, w.Address, Types = string.Join(", ", w.Type), UnitCount = w.StorageUnits.Count, TotalArea = w.StorageUnits.Sum(u => u.AreaCapacity) }
            ).ToList();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка");
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            presenter.CreateWarehouse();
        }
    }
}
