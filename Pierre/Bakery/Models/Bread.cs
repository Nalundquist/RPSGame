using System;

namespace Bake.Loaves
{
	public class Bread
	{
		public string BreadType { get; set; }
		public int BreadPrice { get; set; }
		public Bread(string breadType, int BreadPrice)
		{
			BreadType = breadType;
			BreadPrice = 0;
		}
	}
}