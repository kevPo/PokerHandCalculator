using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class FourOfAKindStrategyTests
    {
        readonly ScoreStrategy _fourOfAKindStrategy = new FourOfAKindStrategy();
        [TestMethod]
        public void Test_Four_Of_A_Kind_Returns_True()
        {
            Assert.IsTrue(_fourOfAKindStrategy.IsValidScoreForHand(PokerHandMother.BuildFourOfAKind()));
        }


        [TestMethod]
        public void Test_Non_Four_Of_A_Kind_Returns_False()
        {
            Assert.IsFalse(_fourOfAKindStrategy.IsValidScoreForHand(PokerHandMother.BuildThreeOfAKind()));
        }
    }
}
