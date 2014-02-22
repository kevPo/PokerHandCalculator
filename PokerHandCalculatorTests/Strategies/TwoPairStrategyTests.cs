using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class TwoPairStrategyTests
    {
        readonly ScoreStrategy _twoPairStrategy = new TwoPairStrategy();
       
        [TestMethod]
        public void Test_Two_Pair_Hand_Returns_True()
        {
            Assert.IsTrue(_twoPairStrategy.IsValidScoreForHand(PokerHandMother.BuildTwoPair()));
        }


        [TestMethod]
        public void Test_Not_Two_Pair_Hand_Returns_False()
        {
            Assert.IsFalse(_twoPairStrategy.IsValidScoreForHand(PokerHandMother.BuildHighCard()));
        }

    }
}
