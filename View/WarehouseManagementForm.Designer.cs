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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouses).BeginInit();
            SuspendLayout();
            // 
            // dgvWarehouses
            // 
            dgvWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvWarehouses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvWarehouses.BackgroundColor = SystemColors.Info;
            dgvWarehouses.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvWarehouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWarehouses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvWarehouses.Location = new Point(13, 38);
            dgvWarehouses.Name = "dgvWarehouses";
            dgvWarehouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWarehouses.Size = new Size(822, 535);
            dgvWarehouses.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(879, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(879, 195);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(208, 23);
            txtAddress.TabIndex = 2;
            // 
            // clbTypes
            // 
            clbTypes.FormattingEnabled = true;
            clbTypes.Location = new Point(879, 252);
            clbTypes.Name = "clbTypes";
            clbTypes.Size = new Size(208, 112);
            clbTypes.TabIndex = 3;
            // 
            // btnAddWarehouse
            // 
            btnAddWarehouse.Location = new Point(918, 390);
            btnAddWarehouse.Name = "btnAddWarehouse";
            btnAddWarehouse.Size = new Size(120, 36);
            btnAddWarehouse.TabIndex = 4;
            btnAddWarehouse.Text = "Добавить склад";
            btnAddWarehouse.UseVisualStyleBackColor = true;
            btnAddWarehouse.Click += btnAddWarehouse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 5;
            label1.Text = "Склады";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(879, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(879, 177);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(879, 234);
            label4.Name = "label4";
            label4.Size = new Size(209, 15);
            label4.TabIndex = 8;
            label4.Text = "Поддерживаемые условия хранения";
            // 
            // WarehouseManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 603);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddWarehouse);
            Controls.Add(clbTypes);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(dgvWarehouses);
            Name = "WarehouseManagementForm";
            Text = "Управление складами";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}