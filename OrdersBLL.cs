using DataAccess.DTO;
using DataAccess;
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
		private OrderDetailDTO orderDetail;
		private DateTime dateCreated;

		// Getters and setters
		public int OrderId { get { return orderId; } set { orderId = value; } }
		public OrderDetailDTO OrderDetail { get { return orderDetail; } set { orderDetail = value; } }
		public DateTime DateCreated { get { return dateCreated; } set { dateCreated = value; } }

		// Constructor
		public OrdersBLL()
		{

		}

		// Logic
		Order orderData = new Order();
		public List<OrderDTO> Read()
		{
			List<OrderDTO> result = orderData.Read();
			return result;
		}

		public int Update(OrderDTO order)
		{
			int result = orderData.Update(order);
			return result;
		}

		public int Create(OrderDTO order)
		{
			int result = orderData.Create(order);
			return result;
		}

		public int Delete(OrderDTO order)
		{
			int result = orderData.Delete(order);
			return result;
		}
	}
}
