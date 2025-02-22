namespace Warehouse
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
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dataGridDocuments = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCounterparty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteDocument = new System.Windows.Forms.Button();
            this.buttonAddDocument = new System.Windows.Forms.Button();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.tabControlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dataGridDocuments);
            this.tabPageDocuments.Controls.Add(this.buttonDeleteDocument);
            this.tabPageDocuments.Controls.Add(this.buttonAddDocument);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(843, 685);
            this.tabPageDocuments.TabIndex = 1;
            this.tabPageDocuments.Text = "Документы";
            this.tabPageDocuments.UseVisualStyleBackColor = true;
            // 
            // dataGridDocuments
            // 
            this.dataGridDocuments.AllowUserToAddRows = false;
            this.dataGridDocuments.AllowUserToDeleteRows = false;
            this.dataGridDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.DocumentDate,
            this.DocumentType,
            this.DocumentCounterparty});
            this.dataGridDocuments.Location = new System.Drawing.Point(6, 35);
            this.dataGridDocuments.Name = "dataGridDocuments";
            this.dataGridDocuments.ReadOnly = true;
            this.dataGridDocuments.Size = new System.Drawing.Size(831, 644);
            this.dataGridDocuments.TabIndex = 2;
            // 
            // DocumentId
            // 
            this.DocumentId.HeaderText = "Код";
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.ReadOnly = true;
            // 
            // DocumentDate
            // 
            this.DocumentDate.HeaderText = "Дата документа";
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.ReadOnly = true;
            // 
            // DocumentType
            // 
            this.DocumentType.HeaderText = "Тип";
            this.DocumentType.Name = "DocumentType";
            this.DocumentType.ReadOnly = true;
            // 
            // DocumentCounterparty
            // 
            this.DocumentCounterparty.HeaderText = "Контрагент";
            this.DocumentCounterparty.Name = "DocumentCounterparty";
            this.DocumentCounterparty.ReadOnly = true;
            // 
            // buttonDeleteDocument
            // 
            this.buttonDeleteDocument.Location = new System.Drawing.Point(87, 6);
            this.buttonDeleteDocument.Name = "buttonDeleteDocument";
            this.buttonDeleteDocument.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDocument.TabIndex = 1;
            this.buttonDeleteDocument.Text = "Удалить";
            this.buttonDeleteDocument.UseVisualStyleBackColor = true;
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.Location = new System.Drawing.Point(6, 6);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDocument.TabIndex = 0;
            this.buttonAddDocument.Text = "Добавить";
            this.buttonAddDocument.UseVisualStyleBackColor = true;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.dataGridProducts);
            this.tabPageProducts.Controls.Add(this.buttonDeleteProduct);
            this.tabPageProducts.Controls.Add(this.buttonEditProduct);
            this.tabPageProducts.Controls.Add(this.buttonAddProduct);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(843, 685);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Номенклатура";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductUnit,
            this.ProductCount});
            this.dataGridProducts.Location = new System.Drawing.Point(6, 35);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.Size = new System.Drawing.Size(831, 644);
            this.dataGridProducts.TabIndex = 3;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Номенклатура";
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
            this.ProductCount.ReadOnly = true;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(186, 6);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 2;
            this.buttonDeleteProduct.Text = "Удалить";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(87, 6);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(93, 23);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.Text = "Редактировать";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(6, 6);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageProducts);
            this.tabControlMenu.Controls.Add(this.tabPageDocuments);
            this.tabControlMenu.Location = new System.Drawing.Point(13, 13);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(851, 711);
            this.tabControlMenu.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 736);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Склад";
            this.tabPageDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.tabControlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDocuments;
        private System.Windows.Forms.DataGridView dataGridDocuments;
        private System.Windows.Forms.Button buttonDeleteDocument;
        private System.Windows.Forms.Button buttonAddDocument;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCounterparty;
    }
}