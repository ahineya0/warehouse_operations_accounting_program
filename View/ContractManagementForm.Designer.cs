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
            label2 = new Label();
            panelKeepingInfo = new Panel();
            btnAddG = new Button();
            lblGoodsCount = new Label();
            rbRent = new RadioButton();
            rbKeeping = new RadioButton();
            chkIsCashless = new CheckBox();
            btnCreate = new Button();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
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
            cmbClients.Location = new Point(913, 63);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(171, 23);
            cmbClients.TabIndex = 0;
            // 
            // cmbWarehouses
            // 
            cmbWarehouses.FormattingEnabled = true;
            cmbWarehouses.Location = new Point(913, 115);
            cmbWarehouses.Name = "cmbWarehouses";
            cmbWarehouses.Size = new Size(171, 23);
            cmbWarehouses.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(959, 265);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(138, 23);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(959, 346);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(138, 23);
            dtpEnd.TabIndex = 3;
            // 
            // numRate
            // 
            numRate.Location = new Point(753, 470);
            numRate.Name = "numRate";
            numRate.Size = new Size(120, 23);
            numRate.TabIndex = 4;
            // 
            // numUnits
            // 
            numUnits.Location = new Point(13, 32);
            numUnits.Name = "numUnits";
            numUnits.Size = new Size(120, 23);
            numUnits.TabIndex = 5;
            // 
            // dgvContracts
            // 
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(12, 31);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(691, 506);
            dgvContracts.TabIndex = 6;
            // 
            // panelRentInfo
            // 
            panelRentInfo.Controls.Add(label2);
            panelRentInfo.Controls.Add(numUnits);
            panelRentInfo.Location = new Point(726, 206);
            panelRentInfo.Name = "panelRentInfo";
            panelRentInfo.Size = new Size(200, 68);
            panelRentInfo.TabIndex = 7;
            panelRentInfo.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 15;
            label2.Text = "Количество арендуемых ячеек";
            // 
            // panelKeepingInfo
            // 
            panelKeepingInfo.Controls.Add(btnAddG);
            panelKeepingInfo.Controls.Add(lblGoodsCount);
            panelKeepingInfo.Location = new Point(726, 301);
            panelKeepingInfo.Name = "panelKeepingInfo";
            panelKeepingInfo.Size = new Size(200, 105);
            panelKeepingInfo.TabIndex = 8;
            panelKeepingInfo.Visible = false;
            // 
            // btnAddG
            // 
            btnAddG.Location = new Point(8, 65);
            btnAddG.Name = "btnAddG";
            btnAddG.Size = new Size(186, 23);
            btnAddG.TabIndex = 13;
            btnAddG.Text = "Добавить товары на хранение";
            btnAddG.UseVisualStyleBackColor = true;
            btnAddG.Click += btnAddGoods_Click;
            // 
            // lblGoodsCount
            // 
            lblGoodsCount.AutoSize = true;
            lblGoodsCount.Location = new Point(13, 15);
            lblGoodsCount.Name = "lblGoodsCount";
            lblGoodsCount.Size = new Size(152, 30);
            lblGoodsCount.TabIndex = 0;
            lblGoodsCount.Text = "Информация о товарах, \r\nдобавленных на хранение";
            // 
            // rbRent
            // 
            rbRent.AutoSize = true;
            rbRent.Location = new Point(726, 138);
            rbRent.Name = "rbRent";
            rbRent.Size = new Size(65, 19);
            rbRent.TabIndex = 9;
            rbRent.Text = "Аренда";
            rbRent.UseVisualStyleBackColor = true;
            rbRent.CheckedChanged += rbRent_CheckedChanged;
            // 
            // rbKeeping
            // 
            rbKeeping.AutoSize = true;
            rbKeeping.Location = new Point(726, 163);
            rbKeeping.Name = "rbKeeping";
            rbKeeping.Size = new Size(78, 19);
            rbKeeping.TabIndex = 10;
            rbKeeping.Text = "Хранение";
            rbKeeping.UseVisualStyleBackColor = true;
            rbKeeping.CheckedChanged += rbRent_CheckedChanged;
            // 
            // chkIsCashless
            // 
            chkIsCashless.AutoSize = true;
            chkIsCashless.Location = new Point(753, 499);
            chkIsCashless.Name = "chkIsCashless";
            chkIsCashless.Size = new Size(138, 19);
            chkIsCashless.TabIndex = 11;
            chkIsCashless.Text = "Безналичная оплата";
            chkIsCashless.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(959, 499);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 36);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Оформить договор";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreateContract_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 111);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 14;
            label1.Text = "Вид услуги";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(959, 231);
            label5.Name = "label5";
            label5.Size = new Size(110, 30);
            label5.TabIndex = 18;
            label5.Text = "Дата начала \r\nдействия договора";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(959, 311);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 19;
            label3.Text = "Дата конца \r\nдействия договора";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(913, 37);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 16;
            label4.Text = "Контрагент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(913, 93);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 20;
            label6.Text = "Склад";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(752, 449);
            label7.Name = "label7";
            label7.Size = new Size(139, 15);
            label7.TabIndex = 21;
            label7.Text = "Размер суточной платы";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(22, 7);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 22;
            label8.Text = "Договоры";
            // 
            // ContractManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 564);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(chkIsCashless);
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
            Text = "Управление договорами";
            ((System.ComponentModel.ISupportInitialize)numRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            panelRentInfo.ResumeLayout(false);
            panelRentInfo.PerformLayout();
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
        private CheckBox chkIsCashless;
        private Button btnCreate;
        private Button btnAddG;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}