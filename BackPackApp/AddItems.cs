using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class AddItems
	{
		public void NewItems()
		{ 
		Pack pack = new();
		Arrow arrow = new();
		Bow bow = new();
		Food food = new();
		Rope rope = new();
		Sword sword = new();
		Water water = new();
		bool programRunning = true;

			while (programRunning)
			{
				Console.Clear();
				Console.WriteLine("1 to add sword\n" +
								  "2 to add bow\n" +
								  "3 to add arrow\n" +
								  "4 to add rope\n" +
								  "5 to add food\n" +
								  "6 to add water\n" +
								  "7 to exit");
				string? userInput = Console.ReadLine();
				switch (userInput)
				{
					case "1":
						pack.Add(sword);
						break;
					case "2":
						pack.Add(bow);
						break;
					case "3":
						pack.Add(arrow);
						break;
					case "4":
						pack.Add(rope);
						break;
					case "5":
						pack.Add(food);
						break;
					case "6":
						pack.Add(water);
						break;
					case "7":
						programRunning = false;
						break;

					default:
						Console.WriteLine("No such loot");
						break;
				}
			}
		}
	}
}
