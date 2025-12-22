using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Presenter;
using warehouse_operations_accounting_program.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace warehouse_operations_accounting_program.View
{
    public partial class ClientManagementForm : Form, IClientManagementView
    {
        public string ClientName => txtName.Text;
        public string Contact => txtContact.Text;
        public string Passport => txtPassport.Text;
        public string INN => txtINN.Text;
        public string KPP => txtKPP.Text;
        public void ShowClients(IEnumerable<Contractor> contractors)
        {
            dgvClients.DataSource = contractors.Select(w => new
            {
                w.Name,
                w.ContactInfo,
                Contracts = w.Contracts != null && w.Contracts.Any()
            ? string.Join("; ", w.Contracts.Select(c => $"{c.Warehouse?.Name ?? "No Name"} ({c.StartDate:dd.MM.yyyy})"))
            : "No contracts"
            }).ToList();
        }
        private ClientManagementPresenter presenter;
        public ClientManagementForm(IClientService service)
        {
            InitializeComponent();
            presenter = new ClientManagementPresenter(this, service);
            presenter.Initialize();
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка");
        }
        private void btnAddIndividual_Click(object sender, EventArgs e)
        {
            presenter.CreateIndividual();
        }
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            presenter.CreateCompany();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            panelInd.Visible = radioButtonInd.Checked;
            panelComp.Visible = radioButtonComp.Checked;
        }
    }
}
