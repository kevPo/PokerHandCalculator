using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class PokerCardFactoryTests
    {
        private readonly PokerCardFactory _pokerCardFactory = new PokerCardFactory();

        [TestMethod]
        public void Test_5D_Returns_Five_Diamonds()
        {
            var card = _pokerCardFactory.BuildCard(new CardCode("5D"));
            Assert.AreEqual(Card.Face.Five, card.CardFace.Value);
            Assert.AreEqual(Card.Suit.Diamonds, card.CardSuit.Value);
        }

        [TestMethod]
        public void Test_10C_Returns_Ten_Clubs()
        {
            var card = _pokerCardFactory.BuildCard(new CardCode("10C"));
            Assert.AreEqual(Card.Face.Ten, card.CardFace.Value);
            Assert.AreEqual(Card.Suit.Clubs, card.CardSuit.Value);
        }

        [TestMethod]
        public void Test_AS_Returns_Ace_Spades()
        {
            var card = _pokerCardFactory.BuildCard(new CardCode("AS"));
            Assert.AreEqual(Card.Face.Ace, card.CardFace.Value);
            Assert.AreEqual(Card.Suit.Spades, card.CardSuit.Value);
        }
    }
}
