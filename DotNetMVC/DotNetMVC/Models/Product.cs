using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetMVC.Models {
	public class Product {

		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }

		public virtual List<ShoppingCart> ShoppingCart { get; set; }
	}
}