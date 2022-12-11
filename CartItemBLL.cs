using DataAccess.DTO;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class CartItemBLL
	{
		// Properties
		private int cartItemId;
		private int quantity;
		private ProductBLL product;
		private ShoppingCartBLL shoppingCart;

		// Getters and setters
		public int CartItemId { get { return cartItemId; } set { cartItemId = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public ProductBLL Product { get { return product; } set { product = value; } }
		public ShoppingCartBLL ShoppingCart { get { return shoppingCart; } set { shoppingCart = value; } }

		// Constructor
		public CartItemBLL()
		{

		}

		// Logic
		CartItem cartItemData = new CartItem();
		public List<CartItemDTO> Read()
		{
			List<CartItemDTO> result = cartItemData.Read();
			return result;
		}

		public int Update(CartItemDTO cartItem)
		{
			int result = cartItemData.Update(cartItem);
			return result;
		}
		public int Create(CartItemDTO cartItem)
		{
			int result = cartItemData.Create(cartItem);
			return result;
		}

		public int Delete(CartItemDTO cartItem)
		{
			int result = cartItemData.Delete(cartItem);
			return result;
		}
	}
}
