using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPS.Models;
using System;

namespace RPS.Models.TestTools
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void DeclareWinner_determineWinner_True()
    {
      int userInput1 = 1;
      int userInput2 = 2;
      Game gameVar = new Game();
      Assert.AreEqual("Player 2 Wins", gameVar.DeclareWinner(userInput1, userInput2));
    }
  }
}