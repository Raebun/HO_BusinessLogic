using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class DiscountBLL
	{
		// Properties
		private int discountId;
		private DateTime dueTime;
		private float discountPercentage;

		// Getters and setters
		public int DiscountId { get { return discountId; } set { discountId = value; } }
		public DateTime DueTime { get { return dueTime; } set { dueTime = value; } }
		public float DiscountPercentage { get { return discountPercentage; } set { discountPercentage = value; } }

		// Constructor
		public DiscountBLL()
		{

		}

		// Logic
		public void appliedOnProducts()
		{

		}
		
		public void getListOfDiscounts()
		{

		}
	}
}
