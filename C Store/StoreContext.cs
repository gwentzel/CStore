namespace C_Store
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreContext : DbContext
    {
        public StoreContext() : base("name=Store")
        {
        }
        
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}