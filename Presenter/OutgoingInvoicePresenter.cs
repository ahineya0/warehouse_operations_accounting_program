using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Services;

namespace warehouse_operations_accounting_program.Presenter
{
    public class OutgoingInvoicePresenter
    {
        private readonly IOutgoingInvoiceView view;
        private readonly IWarehouseService service;

        public OutgoingInvoicePresenter(IOutgoingInvoiceView view, IWarehouseService service)
        {
            this.view = view;
            this.service = service;
        }

        public void Initialize()
        {
            view.ShowWarehouses(service.GetAll());
        }

        public void WarehouseChanged()
        {
            var goods = view.SelectedWarehouse.StorageUnits.SelectMany(u => u.GetGoods());

            view.ShowGoods(goods);
        }

        public void ReleaseGoods()
        {
            if (view.SelectedWarehouse == null)
            {
                view.ShowError("Склад не выбран");
                return;
            }
            try
            {
                service.ReleaseGoods(view.SelectedWarehouse, view.SelectedGoods);

                WarehouseChanged();
                view.ShowSuccess("ТМЦ отпущены");
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
