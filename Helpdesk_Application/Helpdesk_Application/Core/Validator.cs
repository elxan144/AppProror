using Helpdesk_Application.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_Application.Core
{
	class Validator
	{
		ArrayList errors = new ArrayList();


		public bool IsValidUser(User user)
		{
			bool isValid = true;

			if (String.IsNullOrEmpty(user.Email))
			{
				errors.Add("Email is empty!");
				isValid = false;
			}
			if (String.IsNullOrEmpty(user.Surname))
			{
				errors.Add("surname is empty!");
				isValid = false;
			}
			if (String.IsNullOrEmpty(user.Name))
			{
				errors.Add("Name is empty!");
				isValid = false;
			}
			if (String.IsNullOrEmpty(user.Password))
			{
				errors.Add("password is empty!");
				isValid = false;
			}
			
			//if (String.IsNullOrEmpty(user.ConfirmPassword))
			//{
			//	errors.Add("ConfirmPassword is empty!");
			//	isValid = false;
			//}
			//if (User.password != user.ConfirmPassword)
			//{
			//	errors.Add("Password is not same with ConfirmPassword!");
			//	isValid = false;
			//}
			return isValid;
		}

		//public bool IsValidCard(CardUser card)
		//{
		//	bool isValid = true;

		//	if (String.IsNullOrEmpty(card.Card_Number))
		//	{
		//		errors.Add("Card Nmber is empty!");
		//		isValid = false;
		//	}
		//	if (String.IsNullOrEmpty(card.Email))
		//	{
		//		errors.Add("Email is empty!");
		//		isValid = false;
		//	}
		//	if (String.IsNullOrEmpty(card.Password))
		//	{
		//		errors.Add("password is empty!");
		//		isValid = false;
		//	}
		//	return isValid;
		//}

		public string GetError()
		{
			string result = "";
			foreach (String item in errors)
			{
				result += item + "\n";
			}
			return result;
		}
	}
}
