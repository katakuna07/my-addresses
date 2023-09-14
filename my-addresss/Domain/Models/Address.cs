using System;
namespace my_addresss.Domain.Models
{
	public class Address
	{
		public Address() {}

		public Guid id { get; set; }
        public string state { get; set; }
		public string cep { get; set; }
		public string city  { get; set; }
		public string neighborhood { get; set; }
		public string street { get; set; }
		public string service { get; set; }
    }
}