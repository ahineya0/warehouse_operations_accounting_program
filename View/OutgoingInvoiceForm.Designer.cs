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
            cmbWarehouses = new ComboBox();
            dgvGoods = new DataGridView();
            btnRelease = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGoods).BeginInit();
            SuspendLayout();
            // 
            // cmbWarehouses
            // 
            cmbWarehouses.FormattingEnabled = true;
            cmbWarehouses.Location = new Point(408, 294);
            cmbWarehouses.Name = "cmbWarehouses";
            cmbWarehouses.Size = new Size(150, 23);
            cmbWarehouses.TabIndex = 0;
            // 
            // dgvGoods
            // 
            dgvGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoods.Location = new Point(66, 27);
            dgvGoods.Name = "dgvGoods";
            dgvGoods.Size = new Size(601, 236);
            dgvGoods.TabIndex = 1;
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(152, 284);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(185, 41);
            btnRelease.TabIndex = 2;
            btnRelease.Text = "Оформить расходную накладную";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // OutgoingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelease);
            Controls.Add(dgvGoods);
            Controls.Add(cmbWarehouses);
            Name = "OutgoingInvoiceForm";
            Text = "OutgoingInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dgvGoods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbWarehouses;
        private DataGridView dgvGoods;
        private Button btnRelease;
    }
}