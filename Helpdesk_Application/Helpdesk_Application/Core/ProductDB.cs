using Helpdesk_Application.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_Application.Core
{
	static class ProductDB
	{

		public static ArrayList products = new ArrayList();

		public static void AddProduct(Product _product)
		{
			products.Add(_product);
		}



	}
}