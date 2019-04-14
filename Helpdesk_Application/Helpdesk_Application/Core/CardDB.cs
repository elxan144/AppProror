using Helpdesk_Application.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_Application.Core
{
	static class CardDB
	{

		public static ArrayList Cards = new ArrayList();

		public static void GenerateCard(Card _card)
		{
			Random rnd = new Random();
			int number = rnd.Next(100000000, 999999999);
		

			for (int i = 0; i < 150; i++)
			{
				int Price = rnd.Next(10, 70);
				if (Price == 10 || Price == 15 || Price == 25 || Price == 50)
				{
					_card.Price = Price;
					_card.CardNumber =number;
					break;
				}
				else
				{
					continue;
				}

			}

			
				
		}

		public static void AddCard(Card Card)
		{
			Cards.Add(Card);		
		}

	}
}
