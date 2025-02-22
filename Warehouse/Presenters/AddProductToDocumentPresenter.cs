using System;
using System.Windows.Forms;
using Warehouse.Fasades;
using Warehouse.Models;

namespace Warehouse.Presenters
{
    internal class AddProductToDocumentPresenter : IPresenter
    {
        private readonly AddProductToDocumentForm addProductToDocumentForm;
        private readonly IProductFacade<Product> productFacade;
        private readonly Action<object[]> addProductToDocument;

        public AddProductToDocumentPresenter(AddProductToDocumentForm addProductToDocumentForm, IProductFacade<Product> productFacade, Action<object[]> addProductCallback) 
        {
            this.addProductToDocumentForm = addProductToDocumentForm;
            this.productFacade = productFacade;
            this.addProductToDocument = addProductCallback;
        }

        public void Run()
        {
            addProductToDocumentForm.DisplayProduct += OutputProductList;
            addProductToDocumentForm.AddProduct += AddProduct;

            addProductToDocumentForm.ShowDialog();
        }

        private void OutputProductList()
        {
            addProductToDocumentForm.ProductTable.Clear();

            foreach (Product product in productFacade.SelectAll())
            {
                addProductToDocumentForm.ProductTable.Add(new object[] { product.Id, product.Name, product.Unit });
            }
        }

        private void AddProduct()
        {
            DataGridViewCellCollection currentProduct = addProductToDocumentForm.CurrentProduct.Cells;
            addProductToDocument(new object[] { currentProduct["ProductId"].Value, currentProduct["ProductName"].Value, currentProduct["ProductUnit"].Value });
        }
    }
}
