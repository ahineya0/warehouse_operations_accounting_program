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
            cmbWarehouses = new ComboBox();
            txtGoodsName = new TextBox();
            numQuantity = new NumericUpDown();
            numArea = new NumericUpDown();
            numVolume = new NumericUpDown();
            cmbStorageType = new ComboBox();
            btnAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).BeginInit();
            SuspendLayout();
            // 
            // cmbWarehouses
            // 
            cmbWarehouses.FormattingEnabled = true;
            cmbWarehouses.Location = new Point(169, 111);
            cmbWarehouses.Name = "cmbWarehouses";
            cmbWarehouses.Size = new Size(121, 23);
            cmbWarehouses.TabIndex = 0;
            // 
            // txtGoodsName
            // 
            txtGoodsName.Location = new Point(173, 150);
            txtGoodsName.Name = "txtGoodsName";
            txtGoodsName.Size = new Size(100, 23);
            txtGoodsName.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(165, 191);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 2;
            // 
            // numArea
            // 
            numArea.Location = new Point(169, 220);
            numArea.Name = "numArea";
            numArea.Size = new Size(120, 23);
            numArea.TabIndex = 3;
            // 
            // numVolume
            // 
            numVolume.Location = new Point(167, 252);
            numVolume.Name = "numVolume";
            numVolume.Size = new Size(120, 23);
            numVolume.TabIndex = 4;
            // 
            // cmbStorageType
            // 
            cmbStorageType.FormattingEnabled = true;
            cmbStorageType.Location = new Point(166, 292);
            cmbStorageType.Name = "cmbStorageType";
            cmbStorageType.Size = new Size(121, 23);
            cmbStorageType.TabIndex = 5;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(160, 333);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(142, 23);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Оформить ТТН";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // IncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccept);
            Controls.Add(cmbStorageType);
            Controls.Add(numVolume);
            Controls.Add(numArea);
            Controls.Add(numQuantity);
            Controls.Add(txtGoodsName);
            Controls.Add(cmbWarehouses);
            Name = "IncomingInvoiceForm";
            Text = "IncomingInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbWarehouses;
        private TextBox txtGoodsName;
        private NumericUpDown numQuantity;
        private NumericUpDown numArea;
        private NumericUpDown numVolume;
        private ComboBox cmbStorageType;
        private Button btnAccept;
    }
}