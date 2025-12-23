namespace warehouse_operations_accounting_program.View
{
    partial class InvoicesListForm
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
            dgvInvoices = new DataGridView();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoices
            // 
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(31, 12);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.Size = new Size(592, 411);
            dgvInvoices.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(656, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // InvoicesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(dgvInvoices);
            Name = "InvoicesListForm";
            Text = "InvoicesListForm";
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInvoices;
        private Button btnUpdate;
    }
}