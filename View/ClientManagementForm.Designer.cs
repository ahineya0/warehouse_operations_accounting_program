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
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            panelInd.SuspendLayout();
            panelComp.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(468, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(468, 162);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(100, 23);
            txtContact.TabIndex = 1;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(3, 3);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(131, 23);
            txtPassport.TabIndex = 2;
            // 
            // txtINN
            // 
            txtINN.Location = new Point(9, 3);
            txtINN.Name = "txtINN";
            txtINN.Size = new Size(134, 23);
            txtINN.TabIndex = 3;
            // 
            // txtKPP
            // 
            txtKPP.Location = new Point(9, 32);
            txtKPP.Name = "txtKPP";
            txtKPP.Size = new Size(134, 23);
            txtKPP.TabIndex = 4;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(24, 24);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(412, 379);
            dgvClients.TabIndex = 5;
            // 
            // btnAddInd
            // 
            btnAddInd.Location = new Point(3, 82);
            btnAddInd.Name = "btnAddInd";
            btnAddInd.Size = new Size(117, 52);
            btnAddInd.TabIndex = 6;
            btnAddInd.Text = "Добавить физическое лицо";
            btnAddInd.UseVisualStyleBackColor = true;
            btnAddInd.Click += btnAddIndividual_Click;
            // 
            // btnAddComp
            // 
            btnAddComp.Location = new Point(13, 81);
            btnAddComp.Name = "btnAddComp";
            btnAddComp.Size = new Size(118, 55);
            btnAddComp.TabIndex = 7;
            btnAddComp.Text = "Добавить юридическое лицо";
            btnAddComp.UseVisualStyleBackColor = true;
            btnAddComp.Click += btnAddCompany_Click;
            // 
            // panelInd
            // 
            panelInd.Controls.Add(txtPassport);
            panelInd.Controls.Add(btnAddInd);
            panelInd.Location = new Point(628, 236);
            panelInd.Name = "panelInd";
            panelInd.Size = new Size(137, 149);
            panelInd.TabIndex = 8;
            panelInd.Visible = false;
            // 
            // panelComp
            // 
            panelComp.Controls.Add(txtINN);
            panelComp.Controls.Add(txtKPP);
            panelComp.Controls.Add(btnAddComp);
            panelComp.Location = new Point(455, 236);
            panelComp.Name = "panelComp";
            panelComp.Size = new Size(150, 149);
            panelComp.TabIndex = 9;
            panelComp.Visible = false;
            // 
            // radioButtonInd
            // 
            radioButtonInd.AutoSize = true;
            radioButtonInd.Location = new Point(654, 24);
            radioButtonInd.Name = "radioButtonInd";
            radioButtonInd.Size = new Size(122, 19);
            radioButtonInd.TabIndex = 12;
            radioButtonInd.Text = "Физическое лицо";
            radioButtonInd.UseVisualStyleBackColor = true;
            radioButtonInd.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonComp
            // 
            radioButtonComp.AutoSize = true;
            radioButtonComp.Location = new Point(654, 49);
            radioButtonComp.Name = "radioButtonComp";
            radioButtonComp.Size = new Size(133, 19);
            radioButtonComp.TabIndex = 13;
            radioButtonComp.Text = "Юридическое лицо";
            radioButtonComp.UseVisualStyleBackColor = true;
            radioButtonComp.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // ClientManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonComp);
            Controls.Add(radioButtonInd);
            Controls.Add(panelComp);
            Controls.Add(panelInd);
            Controls.Add(dgvClients);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Name = "ClientManagementForm";
            Text = "ClientManagementForm";
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
    }
}