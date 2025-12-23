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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStoredGoods).BeginInit();
            SuspendLayout();
            // 
            // dgvStoredGoods
            // 
            dgvStoredGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStoredGoods.Location = new Point(487, 60);
            dgvStoredGoods.Name = "dgvStoredGoods";
            dgvStoredGoods.Size = new Size(388, 454);
            dgvStoredGoods.TabIndex = 1;
            // 
            // txtOperatorName
            // 
            txtOperatorName.Location = new Point(302, 427);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(166, 23);
            txtOperatorName.TabIndex = 3;
            // 
            // cbContracts
            // 
            cbContracts.FormattingEnabled = true;
            cbContracts.Location = new Point(22, 51);
            cbContracts.Name = "cbContracts";
            cbContracts.Size = new Size(289, 23);
            cbContracts.TabIndex = 4;
            cbContracts.SelectedIndexChanged += cbContracts_SelectedIndexChanged;
            // 
            // lbStorageUnits
            // 
            lbStorageUnits.FormattingEnabled = true;
            lbStorageUnits.Location = new Point(12, 157);
            lbStorageUnits.Name = "lbStorageUnits";
            lbStorageUnits.SelectionMode = SelectionMode.MultiExtended;
            lbStorageUnits.Size = new Size(275, 364);
            lbStorageUnits.TabIndex = 7;
            // 
            // btnRelease
            // 
            btnRelease.Location = new Point(326, 466);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(125, 46);
            btnRelease.TabIndex = 8;
            btnRelease.Text = "Оформить расход";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 9;
            label1.Text = "Выберите договор для оформления ТТН";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 10;
            label2.Text = "Ячейки хранения на оформленном складе";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 399);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 11;
            label4.Text = "Фамилия оператора";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 32);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 12;
            label3.Text = "Товары, указанные в договоре";
            // 
            // OutgoingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 535);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}