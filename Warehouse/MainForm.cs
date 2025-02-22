using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        public DataGridViewRowCollection ProductsTable { get { return dataGridProducts.Rows; } }
        public DataGridViewRowCollection DocumentsTable { get { return dataGridDocuments.Rows; } }
        public DataGridViewRow CurrentProduct { get { return dataGridProducts.CurrentRow; } }
        public DataGridViewRow CurrentDocument { get { return dataGridDocuments.CurrentRow; } }
        public bool SelectedProductTab { get { return tabControlMenu.SelectedTab == tabPageProducts; } }

        public event Action AddProduct;
        public event Action RemoveProduct;
        public event Action EditProduct;
        public event Action AddDocument;
        public event Action RemoveDocument;
        public event Action ViewDocument;
        public event Action ProductTabSelected;

        public MainForm()
        {
            InitializeComponent();

            buttonAddProduct.Click += (sender, args) => Invoke(AddProduct);
            buttonDeleteProduct.Click += (sender, args) => Invoke(RemoveProduct);
            buttonEditProduct.Click += (sender, args) => Invoke(EditProduct);
            buttonAddDocument.Click += (sender, args) => Invoke(AddDocument);
            buttonDeleteDocument.Click += (sender, args) => Invoke(RemoveDocument);
            dataGridDocuments.MouseDoubleClick += (sender, args) => Invoke(ViewDocument);
            tabControlMenu.Selected += (sender, args) => Invoke(ProductTabSelected);
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public void ShowError(string errorText)
        {
            MessageBox.Show(errorText, "Ошибка");
        }

        public DialogResult ShowUserDialog(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
        }

        private void Invoke(Action action)
        {
            if (action != null)
                action();
        }
    }
}
