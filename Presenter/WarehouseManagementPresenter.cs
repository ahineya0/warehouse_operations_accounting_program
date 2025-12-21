using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;
using warehouse_operations_accounting_program.Services;
using warehouse_operations_accounting_program.View;

namespace warehouse_operations_accounting_program.Presenter
{
    public class WarehouseManagementPresenter
    {
        private readonly IWarehouseManagementView view;
        private readonly IWarehouseService service;

        public WarehouseManagementPresenter(IWarehouseManagementView view, IWarehouseService service)
        {
            this.view = view;
            this.service = service;
        }

        public void Initialize()
        {
            view.ShowWarehouses(service.GetAll());
        }

        public void CreateWarehouse()
        {
            try
            {
                using (var settingsForm = new StorageUnitsSettingForm())
                {
                    if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var confirmedUnits = settingsForm.ResultUnits;

                        if (confirmedUnits == null || confirmedUnits.Count == 0)
                        {
                            view.ShowError("Нельзя создать склад без ячеек хранения.");
                            return;
                        }

                        service.CreateWarehouse(view.WarehouseName, view.SelectedTypes, view.Address, confirmedUnits);

                        view.ShowWarehouses(service.GetAll());
                    }
                }
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
    }
}
