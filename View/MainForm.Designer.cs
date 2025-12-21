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
            btnOutgoingGoods = new Button();
            btnIncomingGoods = new Button();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // operatorPanel
            // 
            operatorPanel.Location = new Point(4, 3);
            operatorPanel.Name = "operatorPanel";
            operatorPanel.Size = new Size(595, 178);
            operatorPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(btnOutgoingGoods);
            contentPanel.Controls.Add(btnIncomingGoods);
            contentPanel.Location = new Point(4, 187);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(595, 251);
            contentPanel.TabIndex = 1;
            // 
            // btnOutgoingGoods
            // 
            btnOutgoingGoods.Location = new Point(19, 205);
            btnOutgoingGoods.Name = "btnOutgoingGoods";
            btnOutgoingGoods.Size = new Size(75, 23);
            btnOutgoingGoods.TabIndex = 1;
            btnOutgoingGoods.Text = "Расход";
            btnOutgoingGoods.UseVisualStyleBackColor = true;
            // 
            // btnIncomingGoods
            // 
            btnIncomingGoods.Location = new Point(19, 176);
            btnIncomingGoods.Name = "btnIncomingGoods";
            btnIncomingGoods.Size = new Size(75, 23);
            btnIncomingGoods.TabIndex = 0;
            btnIncomingGoods.Text = "Приход";
            btnIncomingGoods.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPanel);
            Controls.Add(operatorPanel);
            Name = "MainForm";
            Text = "MainForm";
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel operatorPanel;
        private Panel contentPanel;
        private Button btnOutgoingGoods;
        private Button btnIncomingGoods;
    }
}