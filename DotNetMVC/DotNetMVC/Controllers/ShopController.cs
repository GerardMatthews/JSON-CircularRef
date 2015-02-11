using DotNetMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace DotNetMVC.Controllers {
	public class ShopController : ApiController {
		// GET api/values
		public List<ShoppingCart> Get() {
			//you should not be doing this in a controller but this is for demo purposes
			var cartItems = new List<ShoppingCart>();
			using(var context = new ShopContext()) {
				cartItems = context.ShoppingCart.Include(s => s.Product).ToList();
			}
			return cartItems;
		}
	}
}
