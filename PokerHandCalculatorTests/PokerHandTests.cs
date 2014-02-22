using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class PokerHandTests
    {
        [TestMethod]
        public void Test_Add_Card_Increments_Number_Of_Cards()
        {
            var hand = new PokerHand();
            Assert.IsTrue(hand.Cards.Count == 0);
            hand.AddCard(new PokerCard {CardFace = new Face(Card.Face.Ace), 
                CardSuit = new Suit(Card.Suit.Hearts) });
            Assert.IsTrue(hand.Cards.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPokerHandException),
           "Error: Poker hand does not allow duplicate cards.")]
        public void Test_Add_Card_Duplicate_Throws_Exception()
        {
            var hand = new PokerHand();
            hand.AddCard(new PokerCard
            {
                CardFace = new Face(Card.Face.Ace),
                CardSuit = new Suit(Card.Suit.Hearts)
            });
            Assert.IsTrue(hand.Cards.Count == 1);
            hand.AddCard(new PokerCard
            {
                CardFace = new Face(Card.Face.Ace),
                CardSuit = new Suit(Card.Suit.Hearts)
            });
        }

        [TestMethod]
        public void Test_Get_High_Card_Returns_Ace_With_Royal_Flush()
        {
            var royalFlush = PokerHandMother.BuildRoyalFlush();
            Assert.IsTrue(royalFlush.GetHighCard().CardFace.Value == Card.Face.Ace);
        }

        
    }
}
