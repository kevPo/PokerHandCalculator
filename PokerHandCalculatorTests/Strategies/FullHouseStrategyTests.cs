using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class FullHouseStrategyTests
    {
        private readonly ScoreStrategy _fullHouseStrategy = new FullHouseStrategy();

        [TestMethod]
        public void Test_Full_House_Returns_True()
        {
            var fullHouse = PokerHandMother.BuildFullHouse();
            Assert.IsTrue(_fullHouseStrategy.IsValidScoreForHand(fullHouse));
        }

        [TestMethod]
        public void Test_Full_House_Returns_False_For_Four_of_A_Kind()
        {
            var fourOfAKind = PokerHandMother.BuildFourOfAKind();
            Assert.IsFalse(_fullHouseStrategy.IsValidScoreForHand(fourOfAKind));
        }

    }
}
