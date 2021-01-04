namespace Lr1.Migrations
{
    using Lr1.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lr1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lr1.Models.ApplicationDbContext context)
        {
         //   context.Dtps.Add(new DTP { Name = "Важке ДТП", Type = "Аварія", Price = 7000 });
         //   context.Dtps.Add(new DTP { Name = "Наїзд на нерухомий транспортний засіб", Type = "Аварія", Price = 4000 });
          //  context.Dtps.Add(new DTP { Name = "Наїзд на пішохода", Type = "Зіткнення", Price = 11000 });
          //  context.Dtps.Add(new DTP { Name = "Наїзд на велосипедиста", Type = "Аварія", Price = 2000 });

            //  to avoid creating duplicate seed data.
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            roleManager.Create(role1);
            roleManager.Create(role2);


            var admin = new ApplicationUser { Email = "DimaIamborko@mail.ru", UserName = "DimaIamborko@mail.ru" };
            string password = "Dima_1234";
            var result = userManager.Create(admin, password);


            if (result.Succeeded)
            {

                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }

            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
