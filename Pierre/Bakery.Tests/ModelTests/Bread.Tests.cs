using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using Bake.Loaves;
using System;

namespace Bake.Loaves.Tests
{
	[TestClass]
	public class BreadTests : IDisposable
	{
		public void Dispose()
		{
			Bread.ClearOrder();
		}

		[TestMethod]
		public void Bread_HoldsLoaf_True()
		{
			Bread newPump = new Bread("Pumpernickel", 2);
			Assert.AreEqual("Pumpernickel", newPump.BreadType);
		}		
		[TestMethod]
		public void Bread_HoldsPrice_True()
		{
			Bread newPump = new Bread("Pumpernickel", 5);
			Assert.AreEqual(5, newPump.BreadPrice);
		}
		[TestMethod]
		public void BreadTab_ReturnsBreadPrices_True()
		{
			Bread newPump = new Bread("Pumpernickel", 5);
			Bread newOlive = new Bread("Olive", 5);
			Assert.AreEqual(10, Bread.BreadTab());
		}
		[TestMethod]
		public void BreadTab_ReturnsDiscountPrice_True()
		{
			Bread newPump = new Bread("Pumpernickel", 5);
			Bread newOlive = new Bread("Olive", 5);
			Bread newPump2 = new Bread("Pumpernickel", 5);
			Bread newOlive2 = new Bread("Olive", 5);
			Bread newPump3 = new Bread("Pumpernickel", 5);
			Bread newOlive3 = new Bread("Olive", 5);
			Assert.AreEqual(20, Bread.BreadTab());
		}
	}
}