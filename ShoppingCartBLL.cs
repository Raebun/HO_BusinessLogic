using DataAccess.DTO;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BusinessLogic
{
	public class ShoppingCartBLL
	{
		// Properties
		private int cartId;
		private DateTime dateCreated;

		// Getters and setters
		public int CartId { get { return cartId; } set { cartId = value; } }
		public DateTime DateCreated { get { return dateCreated; } set { dateCreated = value; } }

		// Constructor
		public ShoppingCartBLL()
		{

		}

		// Logic
		ShoppingCart shoppingCartData = new ShoppingCart();
		CustomerDAL customerData = new CustomerDAL();
		ShoppingCartDTO shoppingCartDTO = new ShoppingCartDTO();
		CartItem cartItemData = new CartItem();
		private List<ShoppingCartDTO> carts = new List<ShoppingCartDTO>();
		
		public List<ShoppingCartDTO> Read()
		{
			List<ShoppingCartDTO> result = shoppingCartData.Read();
			return result;
		}

		public int Update(ShoppingCartDTO cart)
		{
			int result = shoppingCartData.Update(cart);
			return result;
		}

		public int Create(ShoppingCartDTO cart)
		{
			int result = shoppingCartData.Create(cart);
			return result;
		}

		public int Delete(ShoppingCartDTO cart)
		{
			int result = shoppingCartData.Delete(cart);
			return result;
		}

		public ShoppingCartDTO getShoppingCartId(int cartId)
		{
			ShoppingCartDTO result = shoppingCartData.ReadSingleRecord(cartId);
			return result;
		}

		public int AddShoppingCartToCustomer(CustomerDTO cart)
		{
			int result = shoppingCartData.AddShoppingCartToCustomer(cart);
			return result;
		}

		public int removeCartItem(int id)
		{
			return 0;
		}

		public void updateQuantity()
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
