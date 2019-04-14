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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void linkLabel_CardGenearte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CardGenerateForm cardGenerate = new CardGenerateForm();
			cardGenerate.Show();
		}

		private void link_lbl_xidmetForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AddProduct addProduct = new AddProduct();
			addProduct.Show();
		}
	}
}
