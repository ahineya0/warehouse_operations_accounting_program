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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBatchArea).BeginInit();
            SuspendLayout();
            // 
            // dgvBatches
            // 
            dgvBatches.BackgroundColor = SystemColors.ActiveBorder;
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(12, 12);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.Size = new Size(539, 364);
            dgvBatches.TabIndex = 0;
            // 
            // btnAddBatch
            // 
            btnAddBatch.Location = new Point(606, 262);
            btnAddBatch.Name = "btnAddBatch";
            btnAddBatch.Size = new Size(151, 42);
            btnAddBatch.TabIndex = 13;
            btnAddBatch.Text = "Добавить указанные ячейки";
            btnAddBatch.UseVisualStyleBackColor = true;
            btnAddBatch.Click += btnAddBatch_Click;
            // 
            // numBatchCount
            // 
            numBatchCount.Location = new Point(575, 193);
            numBatchCount.Name = "numBatchCount";
            numBatchCount.Size = new Size(120, 23);
            numBatchCount.TabIndex = 12;
            // 
            // numBatchVolume
            // 
            numBatchVolume.Location = new Point(575, 123);
            numBatchVolume.Name = "numBatchVolume";
            numBatchVolume.Size = new Size(120, 23);
            numBatchVolume.TabIndex = 11;
            // 
            // numBatchArea
            // 
            numBatchArea.Location = new Point(575, 56);
            numBatchArea.Name = "numBatchArea";
            numBatchArea.Size = new Size(120, 23);
            numBatchArea.TabIndex = 10;
            // 
            // btnDeleteBatch
            // 
            btnDeleteBatch.Location = new Point(12, 399);
            btnDeleteBatch.Name = "btnDeleteBatch";
            btnDeleteBatch.Size = new Size(179, 29);
            btnDeleteBatch.TabIndex = 14;
            btnDeleteBatch.Text = "Удалить выбранные ячейки";
            btnDeleteBatch.UseVisualStyleBackColor = true;
            btnDeleteBatch.Click += btnDeleteBatch_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(644, 399);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(131, 39);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Подтвердить";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 166);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 16;
            label1.Text = "Количество подобных ячеек";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(565, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 17;
            label2.Text = "Объём 1 ячейки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 23);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 18;
            label3.Text = "Площадь 1 ячейки";
            // 
            // StorageUnitsSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(btnDeleteBatch);
            Controls.Add(btnAddBatch);
            Controls.Add(numBatchCount);
            Controls.Add(numBatchVolume);
            Controls.Add(numBatchArea);
            Controls.Add(dgvBatches);
            Name = "StorageUnitsSettingForm";
            Text = "Добавление склада";
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBatchArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBatches;
        private Button btnAddBatch;
        private NumericUpDown numBatchCount;
        private NumericUpDown numBatchVolume;
        private NumericUpDown numBatchArea;
        private Button btnDeleteBatch;
        private Button btnConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}