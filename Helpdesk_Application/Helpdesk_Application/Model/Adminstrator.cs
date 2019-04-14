using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_Application.Model
{
	class Adminstrator
	{
		public string  Name { get; set; }
		public string  Password { get; set; }

		public Adminstrator(string Name = "admin" , string Password = "admin123")
		{
			this.Name = Name;
			this.Password = Password;
		}

	}
}
