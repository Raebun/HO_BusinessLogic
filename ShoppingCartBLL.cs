using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class ShoppingCartBLL
	{
		// Properties
		private int cartId;
		private int productId;
		private int quantity;
		private DateTime dateAdded;
		
		// Getters and setters
		public int CartId { get { return cartId; } set { cartId = value; } }
		public int ProductId { get { return productId; } set { productId = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public DateTime DateAdded { get { return dateAdded; } set { dateAdded = value; } }

		// Constructor
		public ShoppingCartBLL()
		{

		}

		// Logic
		public void addCartItem()
		{

		}

		public int removeCartItem(int id)
		{
			return 0;
		}

		public int updateQuantity(int newQuantity)
		{
			quantity = newQuantity;
			return 0;
		}

		public void viewCartDetails()
		{

		}

		public void checkout()
		{

		}

		public void calcTotalPrice()
		{

		}
	}
}
