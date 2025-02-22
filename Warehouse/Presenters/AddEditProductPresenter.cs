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
    internal class AddEditProductPresenter : IPresenter
    {
        private readonly AddEditProductForm addEditProductForm;
        private readonly IProductFacade<Product> productFacade;

        public AddEditProductPresenter(AddEditProductForm addEditProductForm, IProductFacade<Product> productFacade)
        {
            this.addEditProductForm = addEditProductForm;
            this.productFacade = productFacade;

            addEditProductForm.SaveProduct += InsertProduct;
            addEditProductForm.UpdateProduct += UpdateProduct;
        }

        public void Run()
        {
            addEditProductForm.ShowDialog();
        }

        public void InsertProduct()
        {
            if (addEditProductForm.CurrentProductName.Trim() == "" || addEditProductForm.CurrentProductUnit.Trim() == "")
            {
                addEditProductForm.ShowError("Введены не все данные. Сохранение невозможно.");
                return;
            }

            Product newProduct = new Product
            {
                Name = addEditProductForm.CurrentProductName,
                Unit = addEditProductForm.CurrentProductUnit
            };

            try
            {
                productFacade.Insert(newProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addEditProductForm.DialogResult = DialogResult.OK;
        }

        public void UpdateProduct()
        {
            if (addEditProductForm.CurrentProductName.Trim() == "" || addEditProductForm.CurrentProductUnit.Trim() == "")
            {
                addEditProductForm.ShowError("Введены не все данные. Сохранение невозможно.");
                return;
            }

            Product newProduct = new Product
            {
                Id = addEditProductForm.CurrentProductId,
                Name = addEditProductForm.CurrentProductName,
                Unit = addEditProductForm.CurrentProductUnit
            };

            try
            {
                productFacade.Update(newProduct);
            }
            catch (Exception ex)
            {
                addEditProductForm.ShowError(ex.Message);
                return;
            }

            addEditProductForm.DialogResult = DialogResult.OK;
        }
    }
}
