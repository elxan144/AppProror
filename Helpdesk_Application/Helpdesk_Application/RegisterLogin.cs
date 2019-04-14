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
	public partial class btn_registerCard : Form
	{
		public btn_registerCard()
		{
			InitializeComponent();
		}

		private void lbl_reg_name_Click(object sender, EventArgs e)
		{

		}

		private void grpBox_reg_User_Enter(object sender, EventArgs e)
		{

		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if(txbx_login_Email_cardNumber.Text == "admin" || txbx_login_Password.Text == "admin123")
			{
				AdminForm adminForm = new AdminForm();

				adminForm.Show();
			}
		}

		private void btn_registerUser_Click(object sender, EventArgs e)
		{
			this.label1.Text = "";

			User user = new User(txbx_Name.Text , txbx_Surname.Text , txbx_Email.Text , txbx_Password.Text);

			Validator valid = new Validator();

			if (valid.IsValidUser(user))
			{
				UserDB.users.Add(user);
				foreach (User item in UserDB.users)
				{
					this.label1.Text += item.Name + " " + item.Surname + "\n";
				}
			}
			else
			{
				this.label1.Text += valid.GetError() + "\n";
			}
		}
	}
}
