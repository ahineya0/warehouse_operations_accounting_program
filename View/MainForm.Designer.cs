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
            contentPanel = new Panel();
            btnWarehouses = new Button();
            btnOutgoingGoods = new Button();
            btnIncomingGoods = new Button();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // operatorPanel
            // 
            operatorPanel.Location = new Point(4, 3);
            operatorPanel.Name = "operatorPanel";
            operatorPanel.Size = new Size(1240, 649);
            operatorPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(btnWarehouses);
            contentPanel.Controls.Add(btnOutgoingGoods);
            contentPanel.Controls.Add(btnIncomingGoods);
            contentPanel.Location = new Point(4, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1240, 649);
            contentPanel.TabIndex = 1;
            // 
            // btnWarehouses
            // 
            btnWarehouses.Location = new Point(19, 546);
            btnWarehouses.Name = "btnWarehouses";
            btnWarehouses.Size = new Size(183, 23);
            btnWarehouses.TabIndex = 2;
            btnWarehouses.Text = "Управление складами";
            btnWarehouses.UseVisualStyleBackColor = true;
            btnWarehouses.Click += btnWarehouses_Click;
            // 
            // btnOutgoingGoods
            // 
            btnOutgoingGoods.Location = new Point(20, 604);
            btnOutgoingGoods.Name = "btnOutgoingGoods";
            btnOutgoingGoods.Size = new Size(136, 23);
            btnOutgoingGoods.TabIndex = 1;
            btnOutgoingGoods.Text = "Отпуск ТМЦ";
            btnOutgoingGoods.UseVisualStyleBackColor = true;
            btnOutgoingGoods.Click += btnOutgoing_Click;
            // 
            // btnIncomingGoods
            // 
            btnIncomingGoods.Location = new Point(20, 575);
            btnIncomingGoods.Name = "btnIncomingGoods";
            btnIncomingGoods.Size = new Size(136, 23);
            btnIncomingGoods.TabIndex = 0;
            btnIncomingGoods.Text = "Приём ТМЦ";
            btnIncomingGoods.UseVisualStyleBackColor = true;
            btnIncomingGoods.Click += btnIncoming_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 654);
            Controls.Add(contentPanel);
            Controls.Add(operatorPanel);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel operatorPanel;
        private Panel contentPanel;
        private Button btnOutgoingGoods;
        private Button btnIncomingGoods;
        private Button btnWarehouses;
    }
}