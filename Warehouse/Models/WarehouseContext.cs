using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Warehouse.Models
{
    public partial class WarehouseContext : DbContext
    {
        private static WarehouseContext instance;

        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ProductDocuments> ProductDocuments { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        private WarehouseContext()
            : base("name=WarehouseContext")
        {
        }

        public static WarehouseContext Instance()
        {
            if (instance == null)
            {
                instance = new WarehouseContext();
            }

            return instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Document>()
                .Property(e => e.Counterparty)
                .IsFixedLength();

            modelBuilder.Entity<Document>()
                .HasMany(e => e.ProductDocuments)
                .WithRequired(e => e.Document)
                .HasForeignKey(e => e.DocumentId);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Unit)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDocuments)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);
        }
    }
}
