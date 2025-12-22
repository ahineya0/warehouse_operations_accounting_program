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
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGoods).BeginInit();
            SuspendLayout();
            // 
            // txtLoginName
            // 
            txtLoginName.Location = new Point(26, 196);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(100, 23);
            txtLoginName.TabIndex = 0;
            // 
            // dgvContracts
            // 
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(191, 34);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(310, 374);
            dgvContracts.TabIndex = 1;
            // 
            // dgvGoods
            // 
            dgvGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoods.Location = new Point(533, 34);
            dgvGoods.Name = "dgvGoods";
            dgvGoods.Size = new Size(240, 374);
            dgvGoods.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "*Залогиниться*";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(246, 415);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(202, 23);
            btnPay.TabIndex = 4;
            btnPay.Text = "Оплатить выбранный договор";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // ClientInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPay);
            Controls.Add(btnLogin);
            Controls.Add(dgvGoods);
            Controls.Add(dgvContracts);
            Controls.Add(txtLoginName);
            Name = "ClientInterfaceForm";
            Text = "ClientInterfaceForm";
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
    }
}