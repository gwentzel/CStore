namespace C_Store.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using C_Store;

    internal sealed class Configuration : DbMigrationsConfiguration<C_Store.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(C_Store.StoreContext StoreContext)
        {
            //  This method will be called after migrating to the latest version.
                    
            //  Seed data.
            
            //    StoreContext.Products.AddOrUpdate(
            //      p => p.Name,
                //  new product { Name = "apple" },
                //  new Product { Name = "orange" }
         
            //   );
            //
        }
    }
}
