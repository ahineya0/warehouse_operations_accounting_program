namespace warehouse_operations_accounting_program.View
{
    partial class StorageUnitsSettingForm
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
            dgvBatches = new DataGridView();
            btnAddBatch = new Button();
            numBatchCount = new NumericUpDown();
            numBatchVolume = new NumericUpDown();
            numBatchArea = new NumericUpDown();
            btnDeleteBatch = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchArea).BeginInit();
            SuspendLayout();
            // 
            // dgvBatches
            // 
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(12, 23);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.Size = new Size(539, 292);
            dgvBatches.TabIndex = 0;
            // 
            // btnAddBatch
            // 
            btnAddBatch.Location = new Point(389, 336);
            btnAddBatch.Name = "btnAddBatch";
            btnAddBatch.Size = new Size(151, 42);
            btnAddBatch.TabIndex = 13;
            btnAddBatch.Text = "Добавить пачку ячеек";
            btnAddBatch.UseVisualStyleBackColor = true;
            btnAddBatch.Click += btnAddBatch_Click;
            // 
            // numBatchCount
            // 
            numBatchCount.Location = new Point(231, 348);
            numBatchCount.Name = "numBatchCount";
            numBatchCount.Size = new Size(120, 23);
            numBatchCount.TabIndex = 12;
            // 
            // numBatchVolume
            // 
            numBatchVolume.Location = new Point(76, 365);
            numBatchVolume.Name = "numBatchVolume";
            numBatchVolume.Size = new Size(120, 23);
            numBatchVolume.TabIndex = 11;
            // 
            // numBatchArea
            // 
            numBatchArea.Location = new Point(76, 324);
            numBatchArea.Name = "numBatchArea";
            numBatchArea.Size = new Size(120, 23);
            numBatchArea.TabIndex = 10;
            // 
            // btnDeleteBatch
            // 
            btnDeleteBatch.Location = new Point(389, 394);
            btnDeleteBatch.Name = "btnDeleteBatch";
            btnDeleteBatch.Size = new Size(146, 44);
            btnDeleteBatch.TabIndex = 14;
            btnDeleteBatch.Text = "Удалить пачку ячеек";
            btnDeleteBatch.UseVisualStyleBackColor = true;
            btnDeleteBatch.Click += btnDeleteBatch_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(657, 385);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(131, 39);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Подтвердить ячейки склада";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // StorageUnitsSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(btnDeleteBatch);
            Controls.Add(btnAddBatch);
            Controls.Add(numBatchCount);
            Controls.Add(numBatchVolume);
            Controls.Add(numBatchArea);
            Controls.Add(dgvBatches);
            Name = "StorageUnitsSettingForm";
            Text = "StorageUnitsSettingForm";
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchArea).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBatches;
        private Button btnAddBatch;
        private NumericUpDown numBatchCount;
        private NumericUpDown numBatchVolume;
        private NumericUpDown numBatchArea;
        private Button btnDeleteBatch;
        private Button btnConfirm;
    }
}