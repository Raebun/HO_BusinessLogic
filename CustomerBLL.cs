using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace BusinessLogic
{
	public class CustomerBLL
	{
		// Properties
		private int customerId;
		private string firstName;
		private string lastName;
		private string address;
		private string city;
		private string postalCode;
		private string phone;
		private OrderDTO order;
		private ShoppingCartDTO shoppingCart;

		// Getters and setters
		public int CustomerId { get { return customerId; } set { customerId = value; } }
		public string FirstName { get { return firstName; } set { firstName = value; } }
		public string LastName { get { return lastName; } set { lastName = value; } }
		public string Address { get { return address; } set { address = value; } }
		public string City { get { return city; } set { city = value; } }
		public string PostalCode { get { return postalCode; } set { postalCode = value; } }
		public string Phone { get { return phone; } set { phone = value; } }
		public OrderDTO Order { get { return order; } set { order = value; } }
		public ShoppingCartDTO ShoppingCart { get { return shoppingCart; } set { shoppingCart = value; } }

		// Constructor
		public CustomerBLL()
		{

		}

		// Logic
		CustomerDAL customerDAL = new CustomerDAL();

		public List<CustomerDTO> Read()
		{
			List <CustomerDTO> result = customerDAL.Read();
			return result;
		}

		public int Update(CustomerDTO customer)
		{
			int result = customerDAL.Update(customer);
			return result;
		}

		public int Create(CustomerDTO customer)
		{
			int result = customerDAL.Create(customer);
			return result;
		}

		public int Delete(CustomerDTO customer)
		{
			int result = customerDAL.Delete(customer);
			return result;
		}


/*		public List<CustomerDTO> GetAllCustomers()
		{
			//List<CustomerDTO> customersList = customerBLL.Read();
			return customers;
		}*/
	}
}
