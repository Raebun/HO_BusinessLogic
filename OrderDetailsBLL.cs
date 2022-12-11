using DataAccess.DTO;
using DataAccess;
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
		private int orderDetailId;
		private int quantity;
		private ProductDTO product;

		// Getters and setters
		public int OrderDetailId { get { return orderDetailId; } set { orderDetailId = value; } }
		public int Quantity { get { return quantity; } set { quantity = value; } }
		public ProductDTO Product { get { return product; } set { product = value; } }

		// Constructor
		public OrderDetailsBLL()
		{

		}

		// Logic
		OrderDetail orderDetailData = new OrderDetail();
		public List<OrderDetailDTO> Read()
		{
			List<OrderDetailDTO> result = orderDetailData.Read();
			return result;
		}

		public int Update(OrderDetailDTO orderDetail)
		{
			int result = orderDetailData.Update(orderDetail);
			return result;
		}

		public int Create(OrderDetailDTO orderDetail)
		{
			int result = orderDetailData.Create(orderDetail);
			return result;
		}

		public int Delete(OrderDetailDTO orderDetail)
		{
			int result = orderDetailData.Delete(orderDetail);
			return result;
		}
	}
}
