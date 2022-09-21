//there's 2 users that each take a turn inputting a move
//they can do 1 of 3 moves
// after they've both submitted, we output a winner based on who picked what
// if there is a tie, we play again
// rock =1, paper=2, scis=3
// if inputa-inputb = 2
//then winner = lower
// inputa=inputb 
//then draw
// else winner = higher
//if(Math.Abs(inputa-inputb) == 2);
using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    public int findMove(string input)
    {
      if (input.ToLower() == "rock" || input.ToLower() == "r")
      {
        return 1;
      }
      else if(input.ToLower() == "scissors" || input.ToLower() == "s")
      {
        return 3;
      }
      else if (input.ToLower() == "paper" || input.ToLower() == "p")
      {
        return 2;
      }
      else
      {
        return 4;
      }
    }
		
    public string DeclareWinner(int inputa, int inputb)
    {
      if (Math.Abs(inputa-inputb) == 2)
      {
        if (inputa > inputb)
        {
          return "Player 2 Wins";
        }
        else
        {
          return "Player 1 Wins";
        }
      }
      else if (inputa == inputb)
      {
        return "Draw";
      }
      else
      {
        if(inputa > inputb)
        {
          return "Player 1 Wins";
        }
        else 
        {
          return "Player 2 Wins";
        }
      }
    }
  }
}