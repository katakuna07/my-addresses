using System;
namespace my_addresss.Domain.Models
{
	public class User
	{
		public User(string _name, string _login, string _password, string _email)
		{
			name = _name;
			login = _login;
            password = _password;
			email = _email;
		}

		public Guid ID { get; set; }
		public string name { get; set; }
		public string login { get; set; }
		public string password { get; set; }
		public string email { get; set; }
	}
}

