using Helpdesk_Application.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_Application.Core
{
	class UserDB
	{
		public static ArrayList users = new ArrayList();

		public static void AddProduct(User user)
		{
			users.Add(user);
		}


	}
}
