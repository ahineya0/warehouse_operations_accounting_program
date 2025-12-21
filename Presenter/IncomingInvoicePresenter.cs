using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class IncomingInvoicePresenter
    {
        private readonly IIncomingInvoiceView view;
        private readonly IWarehouseService service;

        public IncomingInvoicePresenter(IIncomingInvoiceView view, IWarehouseService service)
        {
            this.view = view;
            this.service = service;
        }

        public void Initialize()
        {
            view.ShowWarehouses(service.GetAll());
        }

        public void AcceptGoods()
        {
            if (view.SelectedWarehouse == null)
            {
                view.ShowError("Выберите склад");
                return;
            }
            try
            {
                service.AcceptGoods(view.SelectedWarehouse, view.GoodsData);
                view.ShowSuccess("ТМЦ приняты");
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
