using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bake.Loaves;
using System;

namespace Bake.Loaves.Tests
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void Bread_HoldsLoaf_True()
		{
			Bread newPump = new Bread("Pumpernickel", 2);
			Assert.AreEqual("Pumpernickel", newPump.BreadType);
		}		
		[TestMethod]
		public void Bread_HoldsPrice_True()
		{
			Bread newPump = new Bread("Pumpernickel", 2);
			Assert.AreEqual(2, newPump.BreadPrice);
		}
	}
}