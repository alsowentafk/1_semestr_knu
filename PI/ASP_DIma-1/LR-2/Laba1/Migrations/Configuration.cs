namespace Laba1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Laba1.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Laba1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Laba1.Models.ApplicationDbContext context)
        {
            context.Phones.Add(new Phone { Mark = "Samsung", Model = "A15", Ozu = "32Gb", Price = 7000 });
            context.Phones.Add(new Phone { Mark = "Nokia", Model = "M29", Ozu = "16Gb", Price = 4000 });
            context.Phones.Add(new Phone { Mark = "LG", Model = "Ase", Ozu = "128Gb", Price = 11000 });
            context.Phones.Add(new Phone { Mark = "Simens", Model = "Ale", Ozu = "64Gb", Price = 8000 });
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
