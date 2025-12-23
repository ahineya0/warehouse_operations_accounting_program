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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGoodsToAccept).BeginInit();
            SuspendLayout();
            // 
            // cbContracts
            // 
            cbContracts.FormattingEnabled = true;
            cbContracts.Location = new Point(12, 39);
            cbContracts.Name = "cbContracts";
            cbContracts.Size = new Size(335, 23);
            cbContracts.TabIndex = 0;
            cbContracts.SelectedIndexChanged += cbContracts_SelectedIndexChanged;
            // 
            // lbStorageUnits
            // 
            lbStorageUnits.FormattingEnabled = true;
            lbStorageUnits.Location = new Point(12, 123);
            lbStorageUnits.Name = "lbStorageUnits";
            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
            lbStorageUnits.Size = new Size(281, 424);
            lbStorageUnits.TabIndex = 2;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(323, 499);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(137, 48);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Оформить приём";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvGoodsToAccept
            // 
            dgvGoodsToAccept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoodsToAccept.Location = new Point(500, 61);
            dgvGoodsToAccept.MultiSelect = false;
            dgvGoodsToAccept.Name = "dgvGoodsToAccept";
            dgvGoodsToAccept.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGoodsToAccept.Size = new Size(415, 493);
            dgvGoodsToAccept.TabIndex = 5;
            // 
            // txtOperatorName
            // 
            txtOperatorName.Location = new Point(311, 465);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(176, 23);
            txtOperatorName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 7;
            label1.Text = "Выберите договор для оформления ТТН";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 101);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 8;
            label2.Text = "Ячейки хранения на оформленном складе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 37);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 9;
            label3.Text = "Товары, указанные в договоре";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 441);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 10;
            label4.Text = "Фамилия оператора";
            // 
            // IncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 564);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOperatorName);
            Controls.Add(dgvGoodsToAccept);
            Controls.Add(btnAccept);
            Controls.Add(lbStorageUnits);
            Controls.Add(cbContracts);
            Name = "IncomingInvoiceForm";
            Text = "Оформление ТТН";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}