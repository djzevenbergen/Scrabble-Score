using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]

  public class ScrabbleScoreTests
  {
    [TestMethod]

    public void ScrabbleScore_ObjectIsCreated_ScrabbleScore()
    {
      ScrabbleGame newScore = new ScrabbleGame("hello");

      Assert.AreEqual(typeof(ScrabbleGame), newScore.GetType());

    }

    [TestMethod]
    public void ScrabbleScore_PropertyIsSet_ScrabbleScore(){
      string inputWord = "hello";
      ScrabbleGame newScore = new ScrabbleGame("hello");
      Assert.AreEqual(8, newScore.Score);
      Assert.AreEqual(inputWord, newScore.Word);

    }

  }
}