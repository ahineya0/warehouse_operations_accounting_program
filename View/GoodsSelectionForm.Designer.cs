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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(522, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(522, 126);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 1;
            // 
            // numCount
            // 
            numCount.Location = new Point(522, 180);
            numCount.Name = "numCount";
            numCount.Size = new Size(120, 23);
            numCount.TabIndex = 2;
            // 
            // numArea
            // 
            numArea.Location = new Point(522, 234);
            numArea.Name = "numArea";
            numArea.Size = new Size(120, 23);
            numArea.TabIndex = 3;
            // 
            // numVolume
            // 
            numVolume.Location = new Point(522, 289);
            numVolume.Name = "numVolume";
            numVolume.Size = new Size(120, 23);
            numVolume.TabIndex = 4;
            // 
            // dgvBatches
            // 
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(12, 26);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.Size = new Size(467, 355);
            dgvBatches.TabIndex = 5;
            // 
            // btnAddB
            // 
            btnAddB.Location = new Point(523, 338);
            btnAddB.Name = "btnAddB";
            btnAddB.Size = new Size(102, 43);
            btnAddB.TabIndex = 6;
            btnAddB.Text = "Добавить товары";
            btnAddB.UseVisualStyleBackColor = true;
            btnAddB.Click += btnAddBatch_Click;
            // 
            // btnCon
            // 
            btnCon.Location = new Point(671, 405);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(114, 33);
            btnCon.TabIndex = 7;
            btnCon.Text = "Подтвердить";
            btnCon.UseVisualStyleBackColor = true;
            btnCon.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 47);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 8;
            label1.Text = "Что будет храниться";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 108);
            label2.Name = "label2";
            label2.Size = new Size(216, 15);
            label2.TabIndex = 9;
            label2.Text = "Какие условия хранения необходимы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 162);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 10;
            label3.Text = "Количество ТМЦ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(523, 216);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 11;
            label4.Text = "Площадь ТМЦ (в сумме)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 271);
            label5.Name = "label5";
            label5.Size = new Size(204, 15);
            label5.TabIndex = 12;
            label5.Text = "Занимаемый объём ТМЦ (в сумме)";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(23, 393);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(121, 45);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Убрать из списка выбранное";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnDeleteBatch_Click;
            // 
            // GoodsSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCon);
            Controls.Add(btnAddB);
            Controls.Add(dgvBatches);
            Controls.Add(numVolume);
            Controls.Add(numArea);
            Controls.Add(numCount);
            Controls.Add(cmbType);
            Controls.Add(txtName);
            Name = "GoodsSelectionForm";
            Text = "Информация о товарах";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRemove;
    }
}