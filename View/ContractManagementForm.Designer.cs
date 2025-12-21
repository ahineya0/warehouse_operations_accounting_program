namespace warehouse_operations_accounting_program.View
{
    partial class ContractManagementForm
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
            cmbClients = new ComboBox();
            cmbWarehouses = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            numRate = new NumericUpDown();
            numUnits = new NumericUpDown();
            dgvContracts = new DataGridView();
            panelRentInfo = new Panel();
            panelKeepingInfo = new Panel();
            rbRent = new RadioButton();
            rbKeeping = new RadioButton();
            lblGoodsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)numRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            panelRentInfo.SuspendLayout();
            panelKeepingInfo.SuspendLayout();
            SuspendLayout();
            // 
            // cmbClients
            // 
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new Point(572, 58);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(121, 23);
            cmbClients.TabIndex = 0;
            // 
            // cmbWarehouses
            // 
            cmbWarehouses.FormattingEnabled = true;
            cmbWarehouses.Location = new Point(571, 112);
            cmbWarehouses.Name = "cmbWarehouses";
            cmbWarehouses.Size = new Size(121, 23);
            cmbWarehouses.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(571, 184);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(571, 235);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 3;
            // 
            // numRate
            // 
            numRate.Location = new Point(573, 311);
            numRate.Name = "numRate";
            numRate.Size = new Size(120, 23);
            numRate.TabIndex = 4;
            // 
            // numUnits
            // 
            numUnits.Location = new Point(13, 18);
            numUnits.Name = "numUnits";
            numUnits.Size = new Size(120, 23);
            numUnits.TabIndex = 5;
            // 
            // dgvContracts
            // 
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(31, 33);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(289, 268);
            dgvContracts.TabIndex = 6;
            // 
            // panelRentInfo
            // 
            panelRentInfo.Controls.Add(numUnits);
            panelRentInfo.Location = new Point(352, 79);
            panelRentInfo.Name = "panelRentInfo";
            panelRentInfo.Size = new Size(200, 100);
            panelRentInfo.TabIndex = 7;
            panelRentInfo.Visible = false;
            // 
            // panelKeepingInfo
            // 
            panelKeepingInfo.Controls.Add(lblGoodsCount);
            panelKeepingInfo.Location = new Point(352, 211);
            panelKeepingInfo.Name = "panelKeepingInfo";
            panelKeepingInfo.Size = new Size(200, 100);
            panelKeepingInfo.TabIndex = 8;
            panelKeepingInfo.Visible = false;
            // 
            // rbRent
            // 
            rbRent.AutoSize = true;
            rbRent.Checked = true;
            rbRent.Location = new Point(378, 345);
            rbRent.Name = "rbRent";
            rbRent.Size = new Size(65, 19);
            rbRent.TabIndex = 9;
            rbRent.TabStop = true;
            rbRent.Text = "Аренда";
            rbRent.UseVisualStyleBackColor = true;
            // 
            // rbKeeping
            // 
            rbKeeping.AutoSize = true;
            rbKeeping.Location = new Point(378, 370);
            rbKeeping.Name = "rbKeeping";
            rbKeeping.Size = new Size(78, 19);
            rbKeeping.TabIndex = 10;
            rbKeeping.Text = "Хранение";
            rbKeeping.UseVisualStyleBackColor = true;
            // 
            // lblGoodsCount
            // 
            lblGoodsCount.AutoSize = true;
            lblGoodsCount.Location = new Point(13, 75);
            lblGoodsCount.Name = "lblGoodsCount";
            lblGoodsCount.Size = new Size(38, 15);
            lblGoodsCount.TabIndex = 0;
            lblGoodsCount.Text = "label1";
            // 
            // ContractManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbKeeping);
            Controls.Add(rbRent);
            Controls.Add(panelKeepingInfo);
            Controls.Add(panelRentInfo);
            Controls.Add(dgvContracts);
            Controls.Add(numRate);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbWarehouses);
            Controls.Add(cmbClients);
            Name = "ContractManagementForm";
            Text = "ContractManagementForm";
            ((System.ComponentModel.ISupportInitialize)numRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            panelRentInfo.ResumeLayout(false);
            panelKeepingInfo.ResumeLayout(false);
            panelKeepingInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClients;
        private ComboBox cmbWarehouses;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private NumericUpDown numRate;
        private NumericUpDown numUnits;
        private DataGridView dgvContracts;
        private Panel panelRentInfo;
        private Panel panelKeepingInfo;
        private RadioButton rbRent;
        private RadioButton rbKeeping;
        private Label lblGoodsCount;
    }
}