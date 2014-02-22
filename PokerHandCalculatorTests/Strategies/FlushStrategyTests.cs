using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class FlushStrategyTests
    {
        readonly ScoreStrategy _flushStrategy = new FlushStrategy();
       
        [TestMethod]
        public void Test_Flush_Returns_True()
        {
            Assert.IsTrue(_flushStrategy.IsValidScoreForHand(PokerHandMother.BuildFlush()));
        }


        [TestMethod]
        public void Test_Non_Flush_Returns_False()
        {
            Assert.IsFalse(_flushStrategy.IsValidScoreForHand(PokerHandMother.BuildHighCard()));
        }
    }
}
