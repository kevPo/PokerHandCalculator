using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class SuiteTests
    {
        [TestMethod]
        public void Test_Spades_Equals_Spades()
        {
            var s = new Suit(Card.Suit.Spades);
            var spade = new Suit(Card.Suit.Spades);
            Assert.IsTrue(s.Equals(spade));
        }

        [TestMethod]
        public void Test_Spades_Does_Not_Equal_Hearts()
        {
            var spade = new Suit(Card.Suit.Spades);
            var heart = new Suit(Card.Suit.Hearts);
            Assert.IsFalse(heart.Equals(spade));
        }
    }
}
