using System;
using System.Collections.Generic;

namespace Bake.Loaves
{
	public class Bread
	{
		public string BreadType { get; set; }
		public int BreadPrice { get; set; }
		public Bread(string breadType, int breadPrice)
		{
			BreadType = breadType;
			BreadPrice = breadPrice;
		}
		public static int BreadTab()
		{
			return 0;
		}
	}
}