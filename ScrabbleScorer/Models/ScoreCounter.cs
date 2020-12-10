using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models
{
  public class ScoreCounter
  {
    public string LetterInput { get; set; }
    private static List<ScoreCounter> _instances = new List<ScoreCounter> {};

    public ScoreCounter(string kindOfLetter)
    {
      LetterInput = kindOfLetter;
      _instances.Add(this);
    }

  }
}