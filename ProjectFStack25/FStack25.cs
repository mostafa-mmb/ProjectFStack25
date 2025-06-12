using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFStack25
{
    class FStack25 : DbContext
    {
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }
        public virtual DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }
        public virtual DbSet<ReleaseOrder> ReleaseOrders { get; set; }
        public virtual DbSet<ReleaseOrderItem> ReleaseOrderItems { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=.\\SqlExpress;initial catalog=FStack25_Mostafa;integrated security=true;TrustServerCertificate=True;");

            //optionsBuilder.UseSqlServer("data source = .;initial catalog = FStack25_Mostafa;integrated security = true;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Warehouse>().HasKey(w => w.Name);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.SourceWarehouse)
                .WithMany()
                .HasForeignKey("SourceWarehouseID")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(t => t.DestinationWarehouse)
                .WithMany()
                .HasForeignKey("DestinationWarehouseID")
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
