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
    internal class AddViewDocumentPresenter : IPresenter
    {
        private readonly AddViewDocumentForm addViewDocumentForm;
        private readonly IDocumentFacade<Document> documentFacade;
        private readonly IProductFacade<Product> productFacade;

        public AddViewDocumentPresenter(AddViewDocumentForm addViewDocumentForm, IDocumentFacade<Document> documentFacade, IProductFacade<Product> productFacade) 
        {
            this.addViewDocumentForm = addViewDocumentForm;
            this.documentFacade = documentFacade;
            this.productFacade = productFacade;
        }

        public void Run()
        {
            addViewDocumentForm.DisplayDocument += OutputDocumentData;
            addViewDocumentForm.SaveDocument += SaveDocument;
            addViewDocumentForm.AddProduct += AddProduct;

            addViewDocumentForm.ShowDialog();
        }

        private void OutputDocumentData()
        {
            Document viewedDocument = documentFacade.GetById(addViewDocumentForm.ViewDocumentId);

            foreach (ProductDocuments productInDocument in viewedDocument.ProductDocuments)
            {
                Product currentProduct = productInDocument.Product;

                int productCount = productInDocument.Count > 0 ? productInDocument.Count : productInDocument.Count * -1;

                addViewDocumentForm.ProductTable.Add(new object[] { currentProduct.Id, currentProduct.Name, currentProduct.Unit, productCount });
            }

            addViewDocumentForm.DisplayDocumentData(viewedDocument.Type, viewedDocument.DateTime.ToString(), viewedDocument.Counterparty);
        }

        private void AddProduct()
        {
            AddProductToDocumentPresenter addProductToDocumentPresenter = new AddProductToDocumentPresenter(new AddProductToDocumentForm(), productFacade, AddProductToTable);

            addProductToDocumentPresenter.Run();
        }

        private void SaveDocument()
        {
            if (addViewDocumentForm.ProductTable.Count == 0)
            {
                addViewDocumentForm.ShowError("Невозможно сохранить документ без товаров");
                return;
            }

            if (addViewDocumentForm.DocumentCounterparty.Trim() == "")
            {
                addViewDocumentForm.ShowError("Невозможно сохранить документ без контрагента");
                return;
            }

            Document newDocument = new Document();

            newDocument.Type = addViewDocumentForm.DocumentType;
            newDocument.DateTime = DateTime.Now;
            newDocument.Counterparty = addViewDocumentForm.DocumentCounterparty;

            foreach (DataGridViewRow currentRow in addViewDocumentForm.ProductTable)
            {
                int productCount = 0;
                int productId = int.Parse(currentRow.Cells["ProductId"].Value.ToString());

                if (currentRow.Cells["ProductCount"].Value == null)
                {
                    addViewDocumentForm.ShowError("В документе есть товары без количества");
                    return;
                }

                if (int.TryParse(currentRow.Cells["ProductCount"].Value.ToString(), out productCount) == false)
                {
                    addViewDocumentForm.ShowError("Некорректное значение в поле количества");
                    return;
                }

                productCount = addViewDocumentForm.DocumentType == "Приход" ? productCount : productCount * -1;

                int productCountInDb = productFacade.GetById(productId).ProductDocuments.Sum(x => x.Count);

                if (productCountInDb + productCount < 0)
                {
                    addViewDocumentForm.ShowError("У товара \"" + currentRow.Cells["ProductName"].Value.ToString().Trim() + "\" будет отрицательный остаток!");
                    return;
                }

                newDocument.ProductDocuments.Add(new ProductDocuments { ProductId = productId, Count = productCount });
            }

            documentFacade.Insert(newDocument);

            addViewDocumentForm.DialogResult = DialogResult.OK;
        }

        private void AddProductToTable(object[] product)
        {
            foreach (DataGridViewRow currentProduct in addViewDocumentForm.ProductTable)
            {
                if (currentProduct.Cells["ProductId"].Value == product[0])
                    return;
            }

            addViewDocumentForm.ProductTable.Add(product);
        }
    }
}
