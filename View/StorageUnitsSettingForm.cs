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
    public partial class StorageUnitsSettingForm : Form, IStorageUnitsSettingView
    {
        private StorageUnitsSettingPresenter _presenter;
        public List<IStorageUnit> ResultUnits { get; private set; } = new();

        public StorageUnitsSettingForm()
        {
            InitializeComponent();
            _presenter = new StorageUnitsSettingPresenter(this);

            _presenter.UnitsConfirmed += (units) => { ResultUnits = units; };
        }

        public decimal UnitArea => numBatchArea.Value;
        public decimal UnitVolume => numBatchVolume.Value;
        public int UnitCount => (int)numBatchCount.Value;

        public void ShowBatches(List<StorageUnitBatch> batches)
        {
            dgvBatches.DataSource = null;
            dgvBatches.DataSource = batches;
        }

        public void CloseView() => this.DialogResult = DialogResult.OK;

        private void btnAddBatch_Click(object sender, EventArgs e) => _presenter.AddBatch();

        private void btnDeleteBatch_Click(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentRow?.DataBoundItem is StorageUnitBatch batch)
                _presenter.RemoveBatch(batch);
        }

        private void btnConfirm_Click(object sender, EventArgs e) => _presenter.Confirm();
    }
}
