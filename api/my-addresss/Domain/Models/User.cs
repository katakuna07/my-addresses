using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_addresss.Domain.Models
{
	public class User
	{
		public User()
		{ }

		public Guid ID { get; set; }
		public string name { get; set; }
		public string login { get; set; }
		public string password { get; set; }
		public string email { get; set; }

		// Addresses
		[NotMapped]
		public List<Address> addresses;
	}
}

