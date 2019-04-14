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
	public partial class UserProfile : Form
	{
		public UserProfile()
		{
			InitializeComponent();
		}

		private void comboBox_Products_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (Product item in ProductDB.products)
			{
				this.comboBox_Products.Text += item.Product_name + " " + item.Product_price;
			}
		}
	}
}
