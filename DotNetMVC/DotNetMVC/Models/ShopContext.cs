namespace DotNetMVC.Models {
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class ShopContext : DbContext {
		// Your context has been configured to use a 'ShopEntities' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'DotNetMVC.ShopEntities' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'ShopEntities' 
		// connection string in the application configuration file.

		public ShopContext()
			: base("name=ShopEntities") {
			//this is important because it throws an error during serialisation if not disabled
			this.Configuration.ProxyCreationEnabled = false;
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }

	}
}