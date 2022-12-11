using DataAccess;
using DataAccess.DTO;

namespace BusinessLogic
{
	public class DiscountBLL
	{
		// Properties
		private int discountId;
		private string discountName;
		private DateTime dueTime;
		private double discountPercentage;

		// Getters and setters
		public int DiscountId { get { return discountId; } set { discountId = value; } }
		public string DiscountName { get { return discountName; } set { discountName = value; } }
		public DateTime DueTime { get { return dueTime; } set { dueTime = value; } }
		public double DiscountPercentage { get { return discountPercentage; } set { discountPercentage = value; } }

		// Constructor
		public DiscountBLL()
		{

		}

		// Logic
		Discount discountData = new Discount();
		public List<DiscountDTO> Read()
		{
			List<DiscountDTO> result = discountData.Read();
			return result;
		}

		public int Update(DiscountDTO discount)
		{
			int result = discountData.Update(discount);
			return result;
		}

		public int Create(DiscountDTO discount)
		{
			int result = discountData.Create(discount);
			return result;
		}

		public int Delete(DiscountDTO discount)
		{
			int result = discountData.Delete(discount);
			return result;
		}

		public void appliedOnProducts()
		{

		}
		
		public void getListOfDiscounts()
		{

		}
	}
}
