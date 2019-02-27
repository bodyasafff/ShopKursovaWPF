namespace ShopKursovaWPF
{
    using ShopKursovaWPF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopKurs : DbContext
    {
        public ShopKurs()
            : base("name=ShopKurs")
        {
        }
        //public virtual DbSet<Delivery> Deliveries { get; set; }
        //public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<Sale> Sales { get; set; }
        //public virtual DbSet<Storege> Storeges { get; set;}
        //public virtual DbSet<Supplier> Suppliers { get; set; }
    }

}