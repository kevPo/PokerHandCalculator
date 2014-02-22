using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class PokerCardTests
    {
        [TestMethod]
        public void Test_3D_Equals_3D()
        {
            var threeD = new PokerCard {CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Diamonds)};
            var threeOfDiamonds = new PokerCard { CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Diamonds) };
            Assert.IsTrue(threeD.Equals(threeOfDiamonds));
        }

        [TestMethod]
        public void Test_3D_Does_Not_Equal_4D()
        {
            var threeD = new PokerCard { CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Diamonds) };
            var fourD = new PokerCard { CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Diamonds) };
            Assert.IsFalse(threeD.Equals(fourD));
        }

        [TestMethod]
        public void Test_Ace_Spades_Returns_AD()
        {
            var aceD = new PokerCard { CardFace = new Face(Card.Face.Ace, "A"), CardSuit = new Suit(Card.Suit.Diamonds, "D") };
            Assert.AreEqual("AD", aceD.ToString());
        }
    }
}
