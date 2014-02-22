using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class PokerHandFactoryTests
    {
        private readonly PokerHandFactory _pokerHandFactory = new PokerHandFactory();
        private readonly string _validCardCodes;
        private readonly string _notEnoughCardCodes;
        private readonly string _tooManyCardCodes;
        private readonly string _duplicateCardCodes;
        private readonly string _invalidCardCodes;
        private readonly string _extraSpacesCardCodes;

        public PokerHandFactoryTests()
        {
            _validCardCodes = "2D 3C AS KH JC";
            _notEnoughCardCodes = "QD JC";
            _tooManyCardCodes = "2D 3C AS KH JC QD";
            _duplicateCardCodes = "2D 3C 3C KH JC";
            _invalidCardCodes = "2D 1S 3C KH JC";
            _extraSpacesCardCodes = "    10C   9C  8C 7C   6C ";
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidPokerHandException),
            "Error: Not enough cards to make a valid poker hand.")]
        public void Test_Build_Hand_With_Two_Cards_Throws_Error()
        {
            var hand = _pokerHandFactory.BuildHand(_notEnoughCardCodes);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPokerHandException),
            "Error: Too many cards to make a valid poker hand.")]
        public void Test_Build_Hand_With_Too_Many_Cards_Throws_Error()
        {
            var hand = _pokerHandFactory.BuildHand(_tooManyCardCodes);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPokerHandException),
            "Error: Poker hand does not allow duplicate cards.")]
        public void Test_Build_Hand_With_Duplicates_Throws_Error()
        {
            var hand = _pokerHandFactory.BuildHand(_duplicateCardCodes);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException),
            "Error: '1' is not a valid face value.")]
        public void Test_Build_Hand_With_Invalids_Throws_Error()
        {
            var hand = _pokerHandFactory.BuildHand(_invalidCardCodes);
        }

        [TestMethod]
        public void Test_Build_Hand_With_Valid_Cards()
        {
            var hand = _pokerHandFactory.BuildHand(_validCardCodes);
            Assert.IsTrue(hand.Cards.Count == 5);
        }

        [TestMethod]
        public void Test_Build_Hand_With_Extra_Spaces()
        {
            var hand = _pokerHandFactory.BuildHand(_extraSpacesCardCodes);
            Assert.IsTrue(hand.Cards.Count == 5);
        }
    }
}
