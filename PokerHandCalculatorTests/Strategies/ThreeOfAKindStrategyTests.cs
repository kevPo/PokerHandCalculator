using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class ThreeOfAKindStrategyTests
    {
        readonly ThreeOfAKindStrategy _threeOfKindStrategy = new ThreeOfAKindStrategy();

        [TestMethod]
        public void Test_Three_Of_Kind_Returns_True()
        {
            Assert.IsTrue(_threeOfKindStrategy.IsValidScoreForHand(PokerHandMother.BuildThreeOfAKind()));
        }

        [TestMethod]
        public void Test_Non_Three_Of_Kind_Returns_False()
        {
            Assert.IsFalse(_threeOfKindStrategy.IsValidScoreForHand(PokerHandMother.BuildTwoPair()));
        }
    }
}
