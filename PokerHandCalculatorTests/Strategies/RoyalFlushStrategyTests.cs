using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class RoyalFlushStrategyTests
    {
        private readonly ScoreStrategy _royalFlushStrategy = new RoyalFlushStrategy();

        [TestMethod]
        public void Test_Royal_Flush_Returns_True_For_Royal_Flush()
        {
            var royalFlush = PokerHandMother.BuildRoyalFlush();
            Assert.IsTrue(_royalFlushStrategy.IsValidScoreForHand(royalFlush));
        }

        [TestMethod]
        public void Test_Royal_Flush_Returns_False_For_Straight_Flush()
        {
            var straightFlush = PokerHandMother.BuildStraightFlush();
            Assert.IsFalse(_royalFlushStrategy.IsValidScoreForHand(straightFlush));
        }

        [TestMethod]
        public void Test_Royal_Flush_Returns_False_For_Royal_Non_Flush()
        {
            var royalNonFlush = PokerHandMother.BuildRoyalNoFlush();
            Assert.IsFalse(_royalFlushStrategy.IsValidScoreForHand(royalNonFlush));
        }


    }
}
