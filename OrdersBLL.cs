using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class OrdersBLL
	{
		// Properties
		private int orderId;
		private DateTime dateCreated;
		private DateTime dateShipped;
		private int customerId;
		private string customerName;

		// Getters and setters
		public int OrderId { get { return orderId; } set { orderId = value; } }
		public DateTime DateCreated { get { return dateCreated; } set { dateCreated = value; } }
		public DateTime DateShipped { get { return dateShipped; } set { dateShipped = value; } }
		public int CustomerId { get { return customerId; } set { customerId = value; } }
		public string CustomerName { get { return customerName; } set { customerName = value; } }

		// Constructor
		public OrdersBLL()
		{

		}

		// Logic
		public void PlaceOrder()
		{

		}
	}
}
