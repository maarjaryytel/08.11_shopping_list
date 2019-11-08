using System;
using System.Collections.Generic;

namespace kodune_ylesanne_shopping_list
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your list of items you would like to buy from the supermarket separated by a comma and space: ");
			string userList = Console.ReadLine();
			Console.Clear();

			string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

			var currentDate = DateTime.Now;
			Console.WriteLine($"{currentDate}");

			List<string> ShoppingList = new List<string>(shoppingList);

			for (int i = 0; i < shoppingList.Length; i++)
			{
				Console.WriteLine($"Item {i + 1}: {shoppingList[i]}");
			}

		Start:
			Console.WriteLine("Would you like to add or remove an item or quit the app?");
			string userAnswer = Console.ReadLine();

			if (userAnswer.ToLower() == "add")
			{
				AddItems(ShoppingList);
				goto Start;
			}

			else if (userAnswer.ToLower() == "remove")
			{
				RemoveItems(ShoppingList);
				goto Start;
			}
			else
			{
				Goodbye();
			}
			Console.ReadLine();
		}
		public static void AddItems(List<string> ShoppingList)
		{
			Console.WriteLine($"Add your new item:  ");
			string newItemToAdd = Console.ReadLine();
			ShoppingList.Add(newItemToAdd);
			Console.Clear();
			var currentDate = DateTime.Now;
			Console.WriteLine($"{currentDate}");

			foreach (string item in ShoppingList)
			{
				Console.WriteLine(item);
			}
		}
		public static void RemoveItems(List<string> ShoppingList)
		{
			Console.WriteLine("Remove the following item: ");
			string itemToRemove = Console.ReadLine();
			ShoppingList.Remove(itemToRemove);
			Console.Clear();
			var currentDate = DateTime.Now;
			Console.WriteLine($"{currentDate}");

			foreach (string item in ShoppingList)
			{
				Console.WriteLine(item);
			}
		}
		public static void Goodbye()
		{
			Console.WriteLine("Goodbye and shop wisely in the future!");
		}
	}
}
