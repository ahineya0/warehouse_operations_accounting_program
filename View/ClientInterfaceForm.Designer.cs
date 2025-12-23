namespace warehouse_operations_accounting_program.View
{
    partial class ClientInterfaceForm
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
            txtLoginName = new TextBox();
            dgvContracts = new DataGridView();
            dgvGoods = new DataGridView();
            btnLogin = new Button();
            btnPay = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGoods).BeginInit();
            SuspendLayout();
            // 
            // txtLoginName
            // 
            txtLoginName.Location = new Point(12, 45);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(138, 23);
            txtLoginName.TabIndex = 0;
            // 
            // dgvContracts
            // 
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(156, 34);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(446, 413);
            dgvContracts.TabIndex = 1;
            // 
            // dgvGoods
            // 
            dgvGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoods.Location = new Point(634, 34);
            dgvGoods.Name = "dgvGoods";
            dgvGoods.Size = new Size(335, 413);
            dgvGoods.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(22, 74);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "*Залогиниться*";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(261, 456);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(202, 23);
            btnPay.TabIndex = 4;
            btnPay.Text = "Оплатить выбранный договор";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя контрагента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 10);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 6;
            label2.Text = "Найденные договоры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 10);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Найденные ТМЦ";
            // 
            // ClientInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 501);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPay);
            Controls.Add(btnLogin);
            Controls.Add(dgvGoods);
            Controls.Add(dgvContracts);
            Controls.Add(txtLoginName);
            Name = "ClientInterfaceForm";
            Text = "Данные клиента";
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginName;
        private DataGridView dgvContracts;
        private DataGridView dgvGoods;
        private Button btnLogin;
        private Button btnPay;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}