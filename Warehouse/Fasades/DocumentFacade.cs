using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Models;

namespace Warehouse.Fasades
{
    internal class DocumentFacade : IDocumentFacade<Document>
    {
        WarehouseContext dbContext;

        public DocumentFacade() 
        {
            dbContext = WarehouseContext.Instance();
        }

        public List<Document> SelectAll()
        {
            return dbContext.Documents.ToList();
        }

        public Document GetById(int documentId)
        {
            return dbContext.Documents.Find(documentId);
        }

        public void Insert(Document insertableDocument)
        {
            dbContext.Documents.Add(insertableDocument);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int deletableDocumentId)
        {
            Document removableProduct = dbContext.Documents.Find(deletableDocumentId);
            dbContext.Documents.Remove(removableProduct);

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
