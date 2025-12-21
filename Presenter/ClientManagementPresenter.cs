using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Services;
using warehouse_operations_accounting_program.View;

namespace warehouse_operations_accounting_program.Presenter
{
    public class ClientManagementPresenter
    {
        private readonly IClientManagementView view;
        private readonly IClientService service;

        public ClientManagementPresenter(IClientManagementView view, IClientService service)
        {
            this.view = view;
            this.service = service;
        }

        public void Initialize()
        {
            view.ShowClients(service.GetAll());
        }

        public void CreateIndividual()
        {
            try
            {
                service.CreateIndividual(view.ClientName, view.Contact, view.Passport);
                view.ShowClients(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        public void CreateCompany()
        {
            try
            {
                service.CreateCompany(view.ClientName, view.Contact, view.INN, view.KPP);
                view.ShowClients(service.GetAll());
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
