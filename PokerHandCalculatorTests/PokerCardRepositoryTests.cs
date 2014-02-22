using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class PokerCardRepositoryTests
    {
        private readonly PokerCardRepository _repo = new PokerCardRepository();

        [TestMethod]
        public void Test_D_Creates_Diamond_Suit()
        {
            var suit = _repo.GetSuitFor("D");
            Assert.AreEqual(Card.Suit.Diamonds, suit.Value);
        }

        [TestMethod]
        public void Test_C_Creates_Clubs_Suit()
        {
            var suit = _repo.GetSuitFor("C");
            Assert.AreEqual(Card.Suit.Clubs, suit.Value);
        }

        [TestMethod]
        public void Test_H_Creates_Hearts_Suit()
        {
            var suit = _repo.GetSuitFor("H");
            Assert.AreEqual(Card.Suit.Hearts, suit.Value);
        }

        [TestMethod]
        public void Test_S_Creates_Spades_Suit()
        {
            var suit = _repo.GetSuitFor("S");
            Assert.AreEqual(Card.Suit.Spades, suit.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException),
            "Error: 'P' is not a valid suit.")]
        public void Test_P_Is_Not_A_Valid_Suit_Exception()
        {
            var suit = _repo.GetSuitFor("P");
        }

        [TestMethod]
        public void Test_2_Creates_Two()
        {
            var face = _repo.GetFaceFor("2");
            Assert.AreEqual(Card.Face.Two, face.Value);
        }

        [TestMethod]
        public void Test_3_Creates_Three()
        {
            var face = _repo.GetFaceFor("3");
            Assert.AreEqual(Card.Face.Three, face.Value);
        }

        [TestMethod]
        public void Test_4_Creates_Four()
        {
            var face = _repo.GetFaceFor("4");
            Assert.AreEqual(Card.Face.Four, face.Value);
        }

        [TestMethod]
        public void Test_5_Creates_Five()
        {
            var face = _repo.GetFaceFor("5");
            Assert.AreEqual(Card.Face.Five, face.Value);
        }

        [TestMethod]
        public void Test_6_Creates_Six()
        {
            var face = _repo.GetFaceFor("6");
            Assert.AreEqual(Card.Face.Six, face.Value);
        }

        [TestMethod]
        public void Test_7_Creates_Seven()
        {
            var face = _repo.GetFaceFor("7");
            Assert.AreEqual(Card.Face.Seven, face.Value);
        }

        [TestMethod]
        public void Test_8_Creates_Eight()
        {
            var face = _repo.GetFaceFor("8");
            Assert.AreEqual(Card.Face.Eight, face.Value);
        }

        [TestMethod]
        public void Test_9_Creates_Nine()
        {
            var face = _repo.GetFaceFor("9");
            Assert.AreEqual(Card.Face.Nine, face.Value);
        }

        [TestMethod]
        public void Test_10_Creates_Ten()
        {
            var face = _repo.GetFaceFor("10");
            Assert.AreEqual(Card.Face.Ten, face.Value);
        }

        [TestMethod]
        public void Test_J_Creates_Jack()
        {
            var face = _repo.GetFaceFor("J");
            Assert.AreEqual(Card.Face.Jack, face.Value);
        }

        [TestMethod]
        public void Test_Q_Creates_Queen()
        {
            var face = _repo.GetFaceFor("Q");
            Assert.AreEqual(Card.Face.Queen, face.Value);
        }

        [TestMethod]
        public void Test_K_Creates_King()
        {
            var face = _repo.GetFaceFor("K");
            Assert.AreEqual(Card.Face.King, face.Value);
        }

        [TestMethod]
        public void Test_A_Creates_Ace()
        {
            var face = _repo.GetFaceFor("A");
            Assert.AreEqual(Card.Face.Ace, face.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException),
            "Error: 'P' is not a valid face value.")]
        public void Test_P_Throws_Exception()
        {
            var face = _repo.GetFaceFor("P");
        }
    }
}
