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
	public partial class CardGenerateForm : Form
	{
		public CardGenerateForm()
		{
			InitializeComponent();
		}

		private Card crd;

		private void btn_cardGenerate_Click(object sender, EventArgs e)
		{
			crd = new Card();

			CardDB.GenerateCard(crd);

			lbl_generatedCard.Text = crd.CardNumber.ToString();
			lbl_generatedCardPrice.Text = crd.Price.ToString();
		}

		private void btn_AddCard_Click(object sender, EventArgs e)
		{
			this.label1.Text = "";

			CardDB.AddCard(crd);

			foreach (Card item in CardDB.Cards)
			{
				this.label1.Text += item.CardNumber.ToString() + " " + item.Price.ToString() + "\n";
			}

			this.AutoScroll = true;

		}
	}
}
