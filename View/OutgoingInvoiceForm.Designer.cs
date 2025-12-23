namespace warehouse_operations_accounting_program.View
{
    partial class OutgoingInvoiceForm
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
            dgvStoredGoods = new DataGridView();
            txtOperatorName = new TextBox();
            cbContracts = new ComboBox();
            lbStorageUnits = new ListBox();
            btnRelease = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStoredGoods).BeginInit();
            SuspendLayout();
            // 
            // dgvStoredGoods
            // 
            dgvStoredGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStoredGoods.Location = new Point(66, 27);
            dgvStoredGoods.Name = "dgvStoredGoods";
            dgvStoredGoods.Size = new Size(675, 236);
            dgvStoredGoods.TabIndex = 1;
            // 
            // txtOperatorName
            // 
            txtOperatorName.Location = new Point(410, 350);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(100, 23);
            txtOperatorName.TabIndex = 3;
            // 
            // cbContracts
            // 
            cbContracts.FormattingEnabled = true;
            cbContracts.Location = new Point(537, 350);
            cbContracts.Name = "cbContracts";
            cbContracts.Size = new Size(121, 23);
            cbContracts.TabIndex = 4;
            cbContracts.SelectedIndexChanged += cbContracts_SelectedIndexChanged;
            // 
            // lbStorageUnits
            // 
            lbStorageUnits.FormattingEnabled = true;
            lbStorageUnits.Location = new Point(98, 302);
            lbStorageUnits.Name = "lbStorageUnits";
            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
            lbStorageUnits.Size = new Size(120, 94);
            lbStorageUnits.TabIndex = 7;
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(637, 391);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(125, 23);
            btnRelease.TabIndex = 8;
            btnRelease.Text = "Оформить отпуск";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // OutgoingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelease);
            Controls.Add(lbStorageUnits);
            Controls.Add(cbContracts);
            Controls.Add(txtOperatorName);
            Controls.Add(dgvStoredGoods);
            Name = "OutgoingInvoiceForm";
            Text = "OutgoingInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvStoredGoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStoredGoods;
        private TextBox txtOperatorName;
        private ComboBox cbContracts;
        private ListBox lbStorageUnits;
        private Button btnRelease;
    }
}