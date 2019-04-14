using Helpdesk_Application.Core;
using Helpdesk_Application.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk_Application
{
	public partial class AddProduct : Form
	{
		public AddProduct()
		{
			InitializeComponent();
		}

		private void btn_Add_product_Click(object sender, EventArgs e)
		{
			this.productsTest.Text = " ";

			Product product = new Product();

			product.Product_name = txbx_productName.Text;
			product.Product_price =Convert.ToInt32( txbx_productPrice.Text ); 

			ProductDB.AddProduct(product);

			foreach (Product item in ProductDB.products)
			{
				this.productsTest.Text += item.Product_name + " " + item.Product_price + "\n"; 
			}

		}
	}
}
