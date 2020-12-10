using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScoreCounterTests
  {
    [TestMethod]
    public void ScoreCounterConstructor_CreatesInstanceOfScoreCounter_ScoreCounter()
    {
      ScoreCounter newScore = new ScoreCounter("A");
      Assert.AreEqual(typeof(ScoreCounter), newScore.GetType());
    }


  }
}