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
    public partial class InvoicesListForm : Form, IInvoicesListView
    {
        private readonly InvoicesListPresenter _presenter;

        public InvoicesListForm(IDocumentService documentService)
        {
            InitializeComponent();
            _presenter = new InvoicesListPresenter(this, documentService);

            ConfigureGrid();
            this.Load += (s, e) => _presenter.RefreshData();
        }

        private void ConfigureGrid()
        {
            dgvInvoices.ReadOnly = true;
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.BackgroundColor = Color.White;
        }

        public void ShowInvoices(IEnumerable<object> invoices)
        {
            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = invoices;

            if (dgvInvoices.Columns["Содержимое"] != null)
                dgvInvoices.Columns["Содержимое"].FillWeight = 200;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.RefreshData();
        }
    }
}
