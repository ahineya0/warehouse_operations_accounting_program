namespace warehouse_operations_accounting_program.View
{
    partial class GoodsSelectionForm
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
            cmbType = new ComboBox();
            numCount = new NumericUpDown();
            numArea = new NumericUpDown();
            numVolume = new NumericUpDown();
            dgvBatches = new DataGridView();
            btnAddB = new Button();
            btnCon = new Button();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(527, 128);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(525, 188);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 1;
            // 
            // numCount
            // 
            numCount.Location = new Point(522, 246);
            numCount.Name = "numCount";
            numCount.Size = new Size(120, 23);
            numCount.TabIndex = 2;
            // 
            // numArea
            // 
            numArea.Location = new Point(522, 292);
            numArea.Name = "numArea";
            numArea.Size = new Size(120, 23);
            numArea.TabIndex = 3;
            // 
            // numVolume
            // 
            numVolume.Location = new Point(522, 339);
            numVolume.Name = "numVolume";
            numVolume.Size = new Size(120, 23);
            numVolume.TabIndex = 4;
            // 
            // dgvBatches
            // 
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(28, 34);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.Size = new Size(467, 376);
            dgvBatches.TabIndex = 5;
            // 
            // btnAddB
            // 
            btnAddB.Location = new Point(540, 368);
            btnAddB.Name = "btnAddB";
            btnAddB.Size = new Size(75, 43);
            btnAddB.TabIndex = 6;
            btnAddB.Text = "Добавить товары";
            btnAddB.UseVisualStyleBackColor = true;
            btnAddB.Click += btnAddBatch_Click;
            // 
            // btnCon
            // 
            btnCon.Location = new Point(671, 388);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(114, 50);
            btnCon.TabIndex = 7;
            btnCon.Text = "Подтвердить";
            btnCon.UseVisualStyleBackColor = true;
            btnCon.Click += btnConfirm_Click;
            // 
            // GoodsSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCon);
            Controls.Add(btnAddB);
            Controls.Add(dgvBatches);
            Controls.Add(numVolume);
            Controls.Add(numArea);
            Controls.Add(numCount);
            Controls.Add(cmbType);
            Controls.Add(txtName);
            Name = "GoodsSelectionForm";
            Text = "GoodsSelectionForm";
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ComboBox cmbType;
        private NumericUpDown numCount;
        private NumericUpDown numArea;
        private NumericUpDown numVolume;
        private DataGridView dgvBatches;
        private Button btnAddB;
        private Button btnCon;
    }
}