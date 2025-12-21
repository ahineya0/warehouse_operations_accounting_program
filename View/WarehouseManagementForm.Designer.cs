namespace warehouse_operations_accounting_program.View
{
    partial class WarehouseManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvWarehouses = new DataGridView();
            txtName = new TextBox();
            txtAddress = new TextBox();
            clbTypes = new CheckedListBox();
            btnAddWarehouse = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouses).BeginInit();
            SuspendLayout();
            // 
            // dgvWarehouses
            // 
            dgvWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvWarehouses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvWarehouses.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvWarehouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWarehouses.Location = new Point(29, 38);
            dgvWarehouses.Name = "dgvWarehouses";
            dgvWarehouses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvWarehouses.Size = new Size(550, 384);
            dgvWarehouses.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(621, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(621, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 2;
            // 
            // clbTypes
            // 
            clbTypes.FormattingEnabled = true;
            clbTypes.Location = new Point(621, 192);
            clbTypes.Name = "clbTypes";
            clbTypes.Size = new Size(120, 94);
            clbTypes.TabIndex = 3;
            // 
            // btnAddWarehouse
            // 
            btnAddWarehouse.Location = new Point(621, 306);
            btnAddWarehouse.Name = "btnAddWarehouse";
            btnAddWarehouse.Size = new Size(120, 23);
            btnAddWarehouse.TabIndex = 4;
            btnAddWarehouse.Text = "Добавить склад";
            btnAddWarehouse.UseVisualStyleBackColor = true;
            btnAddWarehouse.Click += btnAddWarehouse_Click;
            // 
            // WarehouseManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 588);
            Controls.Add(btnAddWarehouse);
            Controls.Add(clbTypes);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(dgvWarehouses);
            Name = "WarehouseManagementForm";
            Text = "WarehouseManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvWarehouses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWarehouses;
        private TextBox txtName;
        private TextBox txtAddress;
        private CheckedListBox clbTypes;
        private Button btnAddWarehouse;
    }
}