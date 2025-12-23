namespace warehouse_operations_accounting_program.View
{
    partial class IncomingInvoiceForm
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
            cbContracts = new ComboBox();
            lbStorageUnits = new ListBox();
            btnAccept = new Button();
            dgvGoodsToAccept = new DataGridView();
            txtOperatorName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGoodsToAccept).BeginInit();
            SuspendLayout();
            // 
            // cbContracts
            // 
            cbContracts.FormattingEnabled = true;
            cbContracts.Location = new Point(21, 22);
            cbContracts.Name = "cbContracts";
            cbContracts.Size = new Size(497, 23);
            cbContracts.TabIndex = 0;
            cbContracts.SelectedIndexChanged += cbContracts_SelectedIndexChanged;
            // 
            // lbStorageUnits
            // 
            lbStorageUnits.FormattingEnabled = true;
            lbStorageUnits.Location = new Point(12, 260);
            lbStorageUnits.Name = "lbStorageUnits";
            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
            lbStorageUnits.Size = new Size(437, 124);
            lbStorageUnits.TabIndex = 2;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(609, 390);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(137, 23);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Оформить приём";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvGoodsToAccept
            // 
            dgvGoodsToAccept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoodsToAccept.Location = new Point(538, 35);
            dgvGoodsToAccept.MultiSelect = false;
            dgvGoodsToAccept.Name = "dgvGoodsToAccept";
            dgvGoodsToAccept.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGoodsToAccept.Size = new Size(240, 349);
            dgvGoodsToAccept.TabIndex = 5;
            // 
            // txtOperatorName
            // 
            txtOperatorName.Location = new Point(21, 198);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(100, 23);
            txtOperatorName.TabIndex = 6;
            // 
            // IncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOperatorName);
            Controls.Add(dgvGoodsToAccept);
            Controls.Add(btnAccept);
            Controls.Add(lbStorageUnits);
            Controls.Add(cbContracts);
            Name = "IncomingInvoiceForm";
            Text = "IncomingInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvGoodsToAccept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbContracts;
        private ListBox lbStorageUnits;
        private Button btnAccept;
        private DataGridView dgvGoodsToAccept;
        private TextBox txtOperatorName;
    }
}