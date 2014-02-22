using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class StraightStrategyTests
    {
        readonly ScoreStrategy _straightStrategy = new StraightStrategy();
        [TestMethod]
        public void Test_Straight_Hand_Returns_True()
        {
            Assert.IsTrue(_straightStrategy.IsValidScoreForHand(PokerHandMother.BuildStraight()));
        }

        [TestMethod]
        public void Test_Non_Straight_Hand_Returns_False()
        {
            Assert.IsFalse(_straightStrategy.IsValidScoreForHand(PokerHandMother.BuildHighCard()));
        }

        [TestMethod]
        public void Test_Straight_With_Low_Ace_Returns_True()
        {
            Assert.IsTrue(_straightStrategy.IsValidScoreForHand(PokerHandMother.BuildAceLowStraight()));
        }

        [TestMethod]
        public void Test_Straight_With_High_Ace_Returns_True()
        {
            Assert.IsTrue(_straightStrategy.IsValidScoreForHand(PokerHandMother.BuildAceHighStraight()));
        }
    }
}
