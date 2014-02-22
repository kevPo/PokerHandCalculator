using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class StraightFlushStrategyTests
    {
        private readonly ScoreStrategy _straightFlushStrategy = new StraightFlushStrategy();

        [TestMethod]
        public void Test_Straight_Flush_Returns_True_For_Straight_Flush()
        {
            var straightFlush = PokerHandMother.BuildStraightFlush();
            Assert.IsTrue(_straightFlushStrategy.IsValidScoreForHand(straightFlush));
        }

        [TestMethod]
        public void Test_Straight_Flush_Returns_False_For_Straight_Non_Flush()
        {
            var straightNonFlush = PokerHandMother.BuildStraight();
            Assert.IsFalse(_straightFlushStrategy.IsValidScoreForHand(straightNonFlush));
        }
    }
}
