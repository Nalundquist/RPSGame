using System;
using System.Collections.Generic;
using RPS.Models;

namespace RPS
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to the Competition Zone");
      bool buul = true;
      while (buul)
      {
        buul = false;
        Console.WriteLine("Player one, input '(R)ock', '(P)aper', or '(S)cissors'.");
        Game gameVar = new Game();
        string userInput1 = Console.ReadLine();
        int inputA = gameVar.findMove(userInput1);
        while (inputA == 4)
        {
          Console.WriteLine("Error: Player one, input '(R)ock', '(P)aper', or '(S)cissors'.");
          userInput1 = Console.ReadLine();
          inputA = gameVar.findMove(userInput1);
        }
        Console.WriteLine("Player two, input '(R)ock', '(P)aper', or '(S)cissors'.");
        string userInput2 = Console.ReadLine();
        int inputB = gameVar.findMove(userInput2);
        while (inputB == 4)
        {
          Console.WriteLine("Error: Player two, input '(R)ock', '(P)aper', or '(S)cissors'.");
          userInput2 = Console.ReadLine();
          inputB = gameVar.findMove(userInput2);
        }
        string result = gameVar.DeclareWinner(inputA, inputB);
        Console.WriteLine(result);
        if (result == "Draw")
        {
          buul = true;
        }
      }
		}
	}
}