using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Fasades;
using Warehouse.Models;

namespace Warehouse.Presenters
{
    internal class MainPresenter : IPresenter
    {
        private readonly MainForm mainForm;
        private readonly IProductFacade<Product> productFacade;
        private readonly IDocumentFacade<Document> documentFacade;

        public MainPresenter(MainForm mainForm, IProductFacade<Product> productFacade, IDocumentFacade<Document> documentFacade) 
        {
            this.mainForm = mainForm;
            this.productFacade = productFacade;
            this.documentFacade = documentFacade;
        }

        public void Run()
        {
            DisplayAllProductsToDataGrid();
            DisplayAllDocumentsToDataGrid();

            mainForm.AddProduct += AddProduct;
            mainForm.RemoveProduct += RemoveProduct;
            mainForm.EditProduct += EditProduct;
            mainForm.AddDocument += AddDocument;
            mainForm.RemoveDocument += RemoveDocument;
            mainForm.ProductTabSelected += SelectProductsTab;
            mainForm.ViewDocument += ViewDocument;

            mainForm.Show();
        }

        private void DisplayAllProductsToDataGrid()
        {
            mainForm.ProductsTable.Clear();

            foreach (Product product in productFacade.SelectAll())
            {
                mainForm.ProductsTable.Add(new object[] { product.Id, product.Name, product.Unit, product.ProductDocuments.Sum(x => x.Count) });
            }
        }

        private void DisplayAllDocumentsToDataGrid()
        {
            mainForm.DocumentsTable.Clear();

            foreach (Document document in documentFacade.SelectAll())
            {
                mainForm.DocumentsTable.Add(new object[] { document.Id, document.DateTime, document.Type, document.Counterparty });
            }
        }

        private void AddProduct()
        {
            AddEditProductPresenter addEditProductPresenter = new AddEditProductPresenter(new AddEditProductForm(), productFacade);

            addEditProductPresenter.Run();

            DisplayAllProductsToDataGrid();
        }

        private void RemoveProduct()
        {
            int removableProductId = (int)mainForm.CurrentProduct.Cells["ProductId"].Value;

            if (productFacade.GetById(removableProductId).ProductDocuments.Count != 0)
            {
                mainForm.ShowError("Невозможно удалить товар. Есть документы с товаром.");
                return;
            }

            try
            {
                productFacade.Delete(removableProductId);
            }
            catch (Exception ex)
            {
                mainForm.ShowError(ex.Message);
                return;
            }

            mainForm.ProductsTable.Remove(mainForm.CurrentProduct);
        }

        private void EditProduct()
        {
            DataGridViewCellCollection currentProductData = mainForm.CurrentProduct.Cells;

            int currentProductId = (int)currentProductData["ProductId"].Value;
            string currentProductName = currentProductData["ProductName"].Value.ToString().Trim();
            string currentProductUnit = currentProductData["ProductUnit"].Value.ToString().Trim();

            AddEditProductPresenter addEditProductPresenter = new AddEditProductPresenter(
                new AddEditProductForm(currentProductId, currentProductName, currentProductUnit), productFacade);

            addEditProductPresenter.Run();

            DisplayAllProductsToDataGrid();
        }

        private void AddDocument()
        {
            AddViewDocumentPresenter addEditProductPresenter = new AddViewDocumentPresenter(new AddViewDocumentForm(), documentFacade, productFacade);

            addEditProductPresenter.Run();

            DisplayAllDocumentsToDataGrid();
        }

        private void RemoveDocument() 
        {
            if (mainForm.ShowUserDialog("Удалить документ?", "Внимание!") == DialogResult.No)
            {
                return;
            }

            int removableDocumentId = (int)mainForm.CurrentDocument.Cells["DocumentId"].Value;

            documentFacade.Delete(removableDocumentId);

            mainForm.DocumentsTable.Remove(mainForm.CurrentDocument);
        }

        private void SelectProductsTab()
        {
            if (mainForm.SelectedProductTab == false)
            {
                return;
            }

            DisplayAllProductsToDataGrid();
        }

        private void ViewDocument()
        {
            int selectedDocumentId = (int)mainForm.CurrentDocument.Cells["DocumentId"].Value;

            AddViewDocumentPresenter addViewDocumentPresenter = new AddViewDocumentPresenter(new AddViewDocumentForm(selectedDocumentId), documentFacade, productFacade);
            addViewDocumentPresenter.Run();
        }
    }
}
