namespace Warehouse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductDocuments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public virtual Document Document { get; set; }

        public virtual Product Product { get; set; }

        public ProductDocuments() { }

        public ProductDocuments(int productId, int count) 
        {
            ProductId = productId;
            Count = count;
        }
    }
}
