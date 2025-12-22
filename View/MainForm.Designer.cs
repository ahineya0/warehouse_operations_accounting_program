namespace warehouse_operations_accounting_program.View
{
    partial class MainForm
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
            operatorPanel = new Panel();
            btnWarehouses = new Button();
            btnOutgoingGoods = new Button();
            btnIncomingGoods = new Button();
            managerPanel = new Panel();
            btnContracts = new Button();
            btnClients = new Button();
            clientPanel = new Panel();
            btnClient = new Button();
            adminPanel = new Panel();
            operatorPanel.SuspendLayout();
            managerPanel.SuspendLayout();
            clientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // operatorPanel
            // 
            operatorPanel.Controls.Add(btnWarehouses);
            operatorPanel.Controls.Add(btnOutgoingGoods);
            operatorPanel.Controls.Add(btnIncomingGoods);
            operatorPanel.Location = new Point(446, 28);
            operatorPanel.Name = "operatorPanel";
            operatorPanel.Size = new Size(352, 212);
            operatorPanel.TabIndex = 0;
            operatorPanel.Visible = false;
            // 
            // btnWarehouses
            // 
            btnWarehouses.Location = new Point(23, 20);
            btnWarehouses.Name = "btnWarehouses";
            btnWarehouses.Size = new Size(183, 43);
            btnWarehouses.TabIndex = 2;
            btnWarehouses.Text = "Управление складами";
            btnWarehouses.UseVisualStyleBackColor = true;
            btnWarehouses.Click += btnWarehouses_Click;
            // 
            // btnOutgoingGoods
            // 
            btnOutgoingGoods.Location = new Point(22, 146);
            btnOutgoingGoods.Name = "btnOutgoingGoods";
            btnOutgoingGoods.Size = new Size(92, 39);
            btnOutgoingGoods.TabIndex = 1;
            btnOutgoingGoods.Text = "Отпуск ТМЦ";
            btnOutgoingGoods.UseVisualStyleBackColor = true;
            btnOutgoingGoods.Click += btnOutgoing_Click;
            // 
            // btnIncomingGoods
            // 
            btnIncomingGoods.Location = new Point(23, 86);
            btnIncomingGoods.Name = "btnIncomingGoods";
            btnIncomingGoods.Size = new Size(93, 38);
            btnIncomingGoods.TabIndex = 0;
            btnIncomingGoods.Text = "Приём ТМЦ";
            btnIncomingGoods.UseVisualStyleBackColor = true;
            btnIncomingGoods.Click += btnIncoming_Click;
            // 
            // managerPanel
            // 
            managerPanel.Controls.Add(btnContracts);
            managerPanel.Controls.Add(btnClients);
            managerPanel.Location = new Point(12, 28);
            managerPanel.Name = "managerPanel";
            managerPanel.Size = new Size(405, 212);
            managerPanel.TabIndex = 1;
            managerPanel.Visible = false;
            // 
            // btnContracts
            // 
            btnContracts.Location = new Point(17, 86);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(107, 50);
            btnContracts.TabIndex = 1;
            btnContracts.Text = "Работа с договорами";
            btnContracts.UseVisualStyleBackColor = true;
            btnContracts.Click += btnContracts_Click;
            // 
            // btnClients
            // 
            btnClients.Location = new Point(17, 20);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(107, 49);
            btnClients.TabIndex = 0;
            btnClients.Text = "Работа с клиентами";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // clientPanel
            // 
            clientPanel.Controls.Add(btnClient);
            clientPanel.Location = new Point(12, 271);
            clientPanel.Name = "clientPanel";
            clientPanel.Size = new Size(405, 193);
            clientPanel.TabIndex = 2;
            clientPanel.Visible = false;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(122, 71);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(133, 43);
            btnClient.TabIndex = 0;
            btnClient.Text = "Просмотреть мои данные";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // adminPanel
            // 
            adminPanel.Location = new Point(757, 355);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(200, 100);
            adminPanel.TabIndex = 4;
            adminPanel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 517);
            Controls.Add(adminPanel);
            Controls.Add(clientPanel);
            Controls.Add(operatorPanel);
            Controls.Add(managerPanel);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            operatorPanel.ResumeLayout(false);
            managerPanel.ResumeLayout(false);
            clientPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel operatorPanel;
        private Panel managerPanel;
        private Button btnOutgoingGoods;
        private Button btnIncomingGoods;
        private Button btnWarehouses;
        private Button btnClients;
        private Button btnContracts;
        private Panel clientPanel;
        private Panel adminPanel;
        private Button btnClient;
    }
}