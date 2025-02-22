namespace Warehouse
{
    partial class AddViewDocumentForm
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
            this.labelDocumentType = new System.Windows.Forms.Label();
            this.comboBoxDocumentType = new System.Windows.Forms.ComboBox();
            this.labelConterparty = new System.Windows.Forms.Label();
            this.textBoxConterparty = new System.Windows.Forms.TextBox();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDocumentType
            // 
            this.labelDocumentType.AutoSize = true;
            this.labelDocumentType.Location = new System.Drawing.Point(575, 15);
            this.labelDocumentType.Name = "labelDocumentType";
            this.labelDocumentType.Size = new System.Drawing.Size(86, 13);
            this.labelDocumentType.TabIndex = 0;
            this.labelDocumentType.Text = "Тип документа:";
            // 
            // comboBoxDocumentType
            // 
            this.comboBoxDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocumentType.FormattingEnabled = true;
            this.comboBoxDocumentType.Items.AddRange(new object[] {
            "Приход",
            "Расход"});
            this.comboBoxDocumentType.Location = new System.Drawing.Point(667, 12);
            this.comboBoxDocumentType.Name = "comboBoxDocumentType";
            this.comboBoxDocumentType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDocumentType.TabIndex = 1;
            // 
            // labelConterparty
            // 
            this.labelConterparty.AutoSize = true;
            this.labelConterparty.Location = new System.Drawing.Point(15, 15);
            this.labelConterparty.Name = "labelConterparty";
            this.labelConterparty.Size = new System.Drawing.Size(68, 13);
            this.labelConterparty.TabIndex = 2;
            this.labelConterparty.Text = "Контрагент:";
            // 
            // textBoxConterparty
            // 
            this.textBoxConterparty.Location = new System.Drawing.Point(89, 12);
            this.textBoxConterparty.Name = "textBoxConterparty";
            this.textBoxConterparty.Size = new System.Drawing.Size(238, 20);
            this.textBoxConterparty.TabIndex = 3;
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.dataGridProduct);
            this.groupBoxProducts.Location = new System.Drawing.Point(12, 93);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(776, 533);
            this.groupBoxProducts.TabIndex = 4;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Список номенклатуры:";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductUnit,
            this.ProductCount});
            this.dataGridProduct.Location = new System.Drawing.Point(6, 19);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.Size = new System.Drawing.Size(764, 508);
            this.dataGridProduct.TabIndex = 0;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductUnit
            // 
            this.ProductUnit.HeaderText = "Единица измерения";
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            // 
            // ProductCount
            // 
            this.ProductCount.HeaderText = "Количество";
            this.ProductCount.Name = "ProductCount";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(713, 626);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(632, 626);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 64);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(139, 23);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Добавить номенклатуру";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Enabled = false;
            this.labelDateTime.Location = new System.Drawing.Point(15, 41);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(93, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Дата документа:";
            this.labelDateTime.Visible = false;
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Enabled = false;
            this.textBoxDateTime.Location = new System.Drawing.Point(114, 38);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.Size = new System.Drawing.Size(213, 20);
            this.textBoxDateTime.TabIndex = 9;
            this.textBoxDateTime.Visible = false;
            // 
            // AddViewDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.textBoxConterparty);
            this.Controls.Add(this.labelConterparty);
            this.Controls.Add(this.comboBoxDocumentType);
            this.Controls.Add(this.labelDocumentType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddViewDocumentForm";
            this.Text = "Документ";
            this.groupBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDocumentType;
        private System.Windows.Forms.ComboBox comboBoxDocumentType;
        private System.Windows.Forms.Label labelConterparty;
        private System.Windows.Forms.TextBox textBoxConterparty;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.TextBox textBoxDateTime;
    }
}