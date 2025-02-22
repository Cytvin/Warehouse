using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Models;

namespace Warehouse.Fasades
{
    internal class ProductFacade : IProductFacade<Product>
    {
        private WarehouseContext dbContext;

        public ProductFacade()
        {
            dbContext = WarehouseContext.Instance();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public List<Product> SelectAll()
        {
            return dbContext.Products.ToList();
        }

        public void Insert(Product insertableProduct)
        {
            dbContext.Products.Add(insertableProduct);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Product updateableProduct) 
        {
            Product productToEdit = dbContext.Products.Find(updateableProduct.Id);
            productToEdit.Name = updateableProduct.Name;
            productToEdit.Unit = updateableProduct.Unit;

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int deletableProductId)
        {
            Product removableProduct = dbContext.Products.Find(deletableProductId);
            dbContext.Products.Remove(removableProduct);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
