namespace warehouse_operations_accounting_program.View
{
    partial class ClientManagementForm
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
            txtName = new TextBox();
            txtContact = new TextBox();
            txtPassport = new TextBox();
            txtINN = new TextBox();
            txtKPP = new TextBox();
            dgvClients = new DataGridView();
            btnAddInd = new Button();
            btnAddComp = new Button();
            panelInd = new Panel();
            panelComp = new Panel();
            radioButtonInd = new RadioButton();
            radioButtonComp = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            panelInd.SuspendLayout();
            panelComp.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(468, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(468, 163);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(100, 23);
            txtContact.TabIndex = 1;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(3, 52);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(131, 23);
            txtPassport.TabIndex = 2;
            // 
            // txtINN
            // 
            txtINN.Location = new Point(9, 32);
            txtINN.Name = "txtINN";
            txtINN.Size = new Size(134, 23);
            txtINN.TabIndex = 3;
            // 
            // txtKPP
            // 
            txtKPP.Location = new Point(9, 78);
            txtKPP.Name = "txtKPP";
            txtKPP.Size = new Size(134, 23);
            txtKPP.TabIndex = 4;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 40);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(424, 383);
            dgvClients.TabIndex = 5;
            // 
            // btnAddInd
            // 
            btnAddInd.Location = new Point(9, 116);
            btnAddInd.Name = "btnAddInd";
            btnAddInd.Size = new Size(117, 52);
            btnAddInd.TabIndex = 6;
            btnAddInd.Text = "Добавить физическое лицо";
            btnAddInd.UseVisualStyleBackColor = true;
            btnAddInd.Click += btnAddIndividual_Click;
            // 
            // btnAddComp
            // 
            btnAddComp.Location = new Point(15, 115);
            btnAddComp.Name = "btnAddComp";
            btnAddComp.Size = new Size(118, 55);
            btnAddComp.TabIndex = 7;
            btnAddComp.Text = "Добавить юридическое лицо";
            btnAddComp.UseVisualStyleBackColor = true;
            btnAddComp.Click += btnAddCompany_Click;
            // 
            // panelInd
            // 
            panelInd.Controls.Add(label6);
            panelInd.Controls.Add(txtPassport);
            panelInd.Controls.Add(btnAddInd);
            panelInd.Location = new Point(632, 213);
            panelInd.Name = "panelInd";
            panelInd.Size = new Size(137, 190);
            panelInd.TabIndex = 8;
            panelInd.Visible = false;
            // 
            // panelComp
            // 
            panelComp.Controls.Add(label5);
            panelComp.Controls.Add(label4);
            panelComp.Controls.Add(txtINN);
            panelComp.Controls.Add(txtKPP);
            panelComp.Controls.Add(btnAddComp);
            panelComp.Location = new Point(455, 213);
            panelComp.Name = "panelComp";
            panelComp.Size = new Size(150, 189);
            panelComp.TabIndex = 9;
            panelComp.Visible = false;
            // 
            // radioButtonInd
            // 
            radioButtonInd.AutoSize = true;
            radioButtonInd.Location = new Point(654, 40);
            radioButtonInd.Name = "radioButtonInd";
            radioButtonInd.Size = new Size(122, 19);
            radioButtonInd.TabIndex = 12;
            radioButtonInd.Text = "Физическое лицо";
            radioButtonInd.UseVisualStyleBackColor = true;
            radioButtonInd.CheckedChanged += rb_CheckedChanged;
            // 
            // radioButtonComp
            // 
            radioButtonComp.AutoSize = true;
            radioButtonComp.Location = new Point(654, 65);
            radioButtonComp.Name = "radioButtonComp";
            radioButtonComp.Size = new Size(133, 19);
            radioButtonComp.TabIndex = 13;
            radioButtonComp.Text = "Юридическое лицо";
            radioButtonComp.UseVisualStyleBackColor = true;
            radioButtonComp.CheckedChanged += rb_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 18);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 14;
            label1.Text = "Вид контрагента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 87);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 15;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 144);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 16;
            label3.Text = "Контактная информация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 17;
            label4.Text = "ИНН";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 60);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 18;
            label5.Text = "КПП";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 15);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 17;
            label6.Text = "Паспортные данные";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 17);
            label7.Name = "label7";
            label7.Size = new Size(168, 15);
            label7.TabIndex = 17;
            label7.Text = "Существующие контрагенты";
            // 
            // ClientManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButtonComp);
            Controls.Add(radioButtonInd);
            Controls.Add(panelComp);
            Controls.Add(panelInd);
            Controls.Add(dgvClients);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Name = "ClientManagementForm";
            Text = "Контрагенты";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            panelInd.ResumeLayout(false);
            panelInd.PerformLayout();
            panelComp.ResumeLayout(false);
            panelComp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtPassport;
        private TextBox txtINN;
        private TextBox txtKPP;
        private DataGridView dgvClients;
        private Button btnAddInd;
        private Button btnAddComp;
        private Panel panelInd;
        private Panel panelComp;
        private RadioButton radioButtonInd;
        private RadioButton radioButtonComp;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label7;
    }
}