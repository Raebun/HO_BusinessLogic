﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	internal class ProductBLL
	{
		// Properties
		private int productId;
		private string productName;
		private string description;
		private float price;
		private string image;

		// Getters & Setters
		public int ProductId { get { return productId; } set { this.productId = value; } }
		public string ProductName { get { return productName; } set { this.productName = value; } }
		public string Description { get { return description; } set { this.description = value; } }
		public float Price { get { return price; } set { this.price = value; } }
		public string Image { get { return image; } set { this.image = value; } }

		// Constructor
		public ProductBLL()
		{

		}

		// Logic
		public void displayProducts()
		{

		}

		public void getProductDetails()
		{

		}
	}
}