using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Tests
{
  [TestClass]
  public class WordsTests
  {
    [TestMethod]
    public void LetterScore_Return1forA_1()
    {
      Assert.AreEqual(1, Words.LetterScore('a'));
    }
    [TestMethod]
    public void WordScore_Return3forOil_3()
    {
      Assert.AreEqual(3, Words.WordScore("OIL"));
    }
  }
}