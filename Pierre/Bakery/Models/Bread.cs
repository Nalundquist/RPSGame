using System;
using System.Collections.Generic;

namespace Bake.Loaves
{
	public class Bread
	{
		public string BreadType { get; set; }
		public int BreadPrice { get; set; }
		private static List<Bread> _breadOrder = new List<Bread> {};
		public Bread(string breadType, int breadPrice)
		{
			BreadType = breadType;
			BreadPrice = breadPrice;
			_breadOrder.Add(this);
		}
		public static int BreadTab()
		{
			int orderPrice = 0;
			foreach (Bread bread in _breadOrder)
			{
			orderPrice += bread.BreadPrice;
			Console.WriteLine("Bread Price = " + bread.BreadPrice);
			Console.WriteLine("Order Price = " + orderPrice);
			}
			return orderPrice;
		}
		public static void ClearOrder()
		{
			_breadOrder.Clear();
		}
	}
}