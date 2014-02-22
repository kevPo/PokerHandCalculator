using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class OnePairStrategyTests
    {
        readonly ScoreStrategy _onePairStrategy = new OnePairStrategy();

        [TestMethod]
        public void Test_One_Pair_Hand_Returns_True()
        {
            Assert.IsTrue(_onePairStrategy.IsValidScoreForHand(PokerHandMother.BuildOnePair()));
        }


        [TestMethod]
        public void Test_Non_One_Pair_Hand_Returns_False()
        {
            Assert.IsFalse(_onePairStrategy.IsValidScoreForHand(PokerHandMother.BuildHighCard()));
        }
    }
}
