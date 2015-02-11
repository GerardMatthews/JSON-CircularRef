namespace DotNetMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using DotNetMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DotNetMVC.Models.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DotNetMVC.Models.ShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

			//seed a user with a shopping cart and products
			context.User.AddOrUpdate(
				new User { FirstName = "George", LastName = "Lopez", ShoppingCart = new System.Collections.Generic.List<ShoppingCart> {
						new ShoppingCart { Quantity = 1, Product = new Product { Name = "Samsung Galaxy S5", Description = "One very cool phone, perhaps a little large."}},
						new ShoppingCart {Quantity = 2, Product = new Product { Name = "Sony Xperia Z3 compact", Description = "One even better smart phone with looking like it is compensating for something."}}
					}
				}
			);
        }
    }
}
