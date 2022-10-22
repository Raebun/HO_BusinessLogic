using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class OrderDetailsBLL
	{
		// Properties
		private int orderId; // object
		private int productId; // object
		private string productName;
		private int quantity;
		private float unitCost;
		private float subTotal;

		// Getters and setters
		public int ProductId { get { return productId; } set { productId = value; } }
		public string ProductName { get { return productName; } set { productName = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public float UnitCost { get { return unitCost; } set { unitCost = value; } }
		public float SubTotal { get { return subTotal; } set { subTotal = value; } }

		// Constructor
		public OrderDetailsBLL()
		{

		}

		// Logic
		public void calcPrice()
		{

		}
	}
}
