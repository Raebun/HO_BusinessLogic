using DataAccess.DTO;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class ProductBLL
	{
		// Properties
		private int productId;
		private string productName;
		private string productDescription;
		private double unitCost;
		private DiscountDTO discount;

		// Getters & Setters
		public int ProductId { get { return productId; } set { productId = value; } }
		public string ProductName { get { return productName; } set { productName = value; } }
		public string ProductDescription { get { return productDescription; } set { productDescription = value; } }
		public double UnitCost { get { return unitCost; } set { unitCost = value; } }
		public DiscountDTO Discount { get { return discount; } set { discount = value; } }

		// Constructor
		public ProductBLL()
		{

		}

		// Logic
		Product productData = new Product();

		public List<ProductDTO> Read()
		{
			List<ProductDTO> result = productData.Read();
			return result;
		}

		public int Update(ProductDTO product)
		{
			int result = productData.Update(product);
			return result;
		}

		public int Create(ProductDTO product)
		{
			int result = productData.Create(product);
			return result;
		}

		public int Delete(ProductDTO product)
		{
			int result = productData.Delete(product);
			return result;
		}
		public void displayProducts()
		{

		}

		public void getProductDetails()
		{

		}
	}
}
