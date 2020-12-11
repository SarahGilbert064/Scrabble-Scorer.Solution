using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer
{
  class Program
  { 
  
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer!");
      Console.WriteLine("Type a word!");
      string input = Console.ReadLine();
      ScoreCounter newInput = new ScoreCounter();
      int score = newInput.ReturnValue(input);
      Console.WriteLine(score);
    }
  }
}