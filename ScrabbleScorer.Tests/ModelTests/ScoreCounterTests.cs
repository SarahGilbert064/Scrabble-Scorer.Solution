using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass] 
  public class ScrabbleScorerTest
  {

    [TestMethod]
    public void ScoreCounterConstructor_CreatesInstanceOfScoreCounter_ScoreCounter()
    {
      ScoreCounter newScore = new ScoreCounter();
      Assert.AreEqual(typeof(ScoreCounter), newScore.GetType());
    }

    [TestMethod]
    public void CalculateScore_ReturnValue_Int()
    {
      ScoreCounter newScore = new ScoreCounter();
      int score = newScore.ReturnValue("a");
      Assert.AreEqual(1, score);
    }
  }
}