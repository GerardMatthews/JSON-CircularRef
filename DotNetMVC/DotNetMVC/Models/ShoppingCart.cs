using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetMVC.Models {
	public class ShoppingCart {
		[Key]
		[Column(Order=1)]
		public int UserID { get; set; }
		[Key]
		[Column(Order = 2)]
		public int ProductID { get; set; }
		public int Quantity { get; set; }

		public virtual Product Product { get; set; }
		public virtual User User { get; set; }
	}
}