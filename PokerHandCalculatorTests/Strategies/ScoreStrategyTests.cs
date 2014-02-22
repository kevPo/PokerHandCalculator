using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator.Strategies;

namespace PokerHandCalculatorTests.Strategies
{
    [TestClass]
    public class ScoreStrategyTests
    {
        readonly ScoreStrategy _mockScoreStrategy = new MockScoreStrategy();
        
        [TestMethod]
        public void Test_Find_Pairs_Finds_One_Pair()
        {
            var onePairHand = PokerHandMother.BuildOnePair();
            var pairs = _mockScoreStrategy.FindPairs(onePairHand.Cards);
            Assert.IsTrue(pairs.Count == 1);
        }

        [TestMethod]
        public void Test_Find_Pairs_Finds_Two_Pair()
        {
            var twoPair = PokerHandMother.BuildTwoPair();
            var pairs = _mockScoreStrategy.FindPairs(twoPair.Cards);
            Assert.IsTrue(pairs.Count == 2);
        }

        [TestMethod]
        public void Test_Find_Pairs_Finds_No_Pair()
        {
            var noPairs = PokerHandMother.BuildHighCard();
            var pairs = _mockScoreStrategy.FindPairs(noPairs.Cards);
            Assert.IsTrue(pairs.Count == 0);
        }

        [TestMethod]
        public void Test_Is_Flush_Returns_True_For_Flush()
        {
            var flush = PokerHandMother.BuildFlush();
            Assert.IsTrue(_mockScoreStrategy.IsFlush(flush.Cards));
        }

        [TestMethod]
        public void Test_Is_Flush_Returns_False_For_Non_Flush()
        {
            var nonFlush = PokerHandMother.BuildHighCard();
            Assert.IsFalse(_mockScoreStrategy.IsFlush(nonFlush.Cards));
        }

        [TestMethod]
        public void Test_Is_Straight_Returns_True_For_Straight()
        {
            var straight = PokerHandMother.BuildStraight();
            Assert.IsTrue(_mockScoreStrategy.IsStraight(straight.Cards));
        }

        [TestMethod]
        public void Test_Is_Straight_Returns_False_For_Non_Straight()
        {
            var highCard = PokerHandMother.BuildHighCard();
            Assert.IsFalse(_mockScoreStrategy.IsStraight(highCard.Cards));
        }

        [TestMethod]
        public void Test_Is_Straight_Returns_True_For_Ace_High_Straight()
        {
            var aceHighStraight = PokerHandMother.BuildAceHighStraight();
            Assert.IsTrue(_mockScoreStrategy.IsStraight(aceHighStraight.Cards));
        }

        [TestMethod]
        public void Test_Is_Straight_Returns_True_For_Ace_Low_Straight()
        {
            var aceLowStraight = PokerHandMother.BuildAceLowStraight();
            Assert.IsTrue(_mockScoreStrategy.IsStraight(aceLowStraight.Cards));
        }

    }
}
