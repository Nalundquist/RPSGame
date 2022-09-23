using System;
using System.Collections.Generic;
using Bake.Loaves;
using Bake.Cakes;

namespace Bake
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("---------------------------");
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Console.WriteLine("---------------------------");
			bool stillOrdering = false;
			while (stillOrdering == true);
			{
				stillOrdering = true;
				Console.WriteLine("Deals:");
				Console.WriteLine("- Buy Two Loaves of Bread, Get One Free!");
				Console.WriteLine("- Buy Two Pastries, get one half off!");
				Console.WriteLine("Browse our (B)read or (P)astry selections (or (E)xit");
				string userinput1 = Console.ReadLine().ToLower();
				if (userinput1 == "bread" || userinput1 == "b")
				{
					Console.WriteLine("This Week's Breads");
					Console.WriteLine("- (P)umpernickel");
					Console.WriteLine("- (O)live");
					Console.WriteLine("- (W)heat");
					Console.WriteLine("- (C)hallah");
					string userinput2 = Console.ReadLine().ToLower();
					if (userinput2 == "pumpernickel" || userinput2 == "p")
					{
						Console.WriteLine("Input the amount of loaves you would like:");
						int userinput3 = Int32.Parse(Console.ReadLine());
						for (int i=0; i < userinput3; i++)
						{
							Bread loaf = new Bread("Pumpernickel", 5);
						}
						Console.WriteLine("Your current total is $" + Bread.BreadTab() + ".");
						Console.WriteLine("Would you like to (O)rder more or (C)heckout?");
						string userInput4 = Console.ReadLine().ToLower();
						if (userInput4 == "checkout" || userInput4 == "c")
						{
							stillOrdering = false;
						}
						else if (userInput4 == "order" || userInput4 == "o")
						{
							stillOrdering = true;
						}
					}
				}
			}
			Console.WriteLine("Your final total is $" + Bread.BreadTab() + ".");
			Console.WriteLine("Pick up your order at:");
			Console.WriteLine("Pierre's Bakery");
			Console.WriteLine("123 Fake St NE");
			Console.WriteLine("Newark, NJ 12345");
		}
	}
}