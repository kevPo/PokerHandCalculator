using System.Collections.Generic;
using PokerHandCalculator;

namespace PokerHandCalculatorTests
{
    public class PokerHandMother
    {
        public static PokerHand BuildTwoPair()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Nine), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Nine), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Hearts)},
                };
            return new PokerHand{Cards = cards};
        }

        public static PokerHand BuildHighCard()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Two), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildOnePair()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Two), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Two), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Seven), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Six), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildThreeOfAKind()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Two), CardSuit = new Suit(Card.Suit.Spades)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildStraight()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Nine), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Eight), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Seven), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Six), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Five), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildAceLowStraight()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Two), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Five), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildAceHighStraight()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildFlush()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Six), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Three), CardSuit = new Suit(Card.Suit.Spades)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildFullHouse()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Five), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Five), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Five), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Eight), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Eight), CardSuit = new Suit(Card.Suit.Hearts)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildFourOfAKind()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Four), CardSuit = new Suit(Card.Suit.Spades)},
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildStraightFlush()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Nine), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Eight), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Seven), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildRoyalFlush()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildRoyalNoFlush()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Ace), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Diamonds)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Hearts)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }

        public static PokerHand BuildAceLessHand()
        {
            var cards = new List<PokerCard>
                {
                    new PokerCard{CardFace = new Face(Card.Face.Nine), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.King), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Queen), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Jack), CardSuit = new Suit(Card.Suit.Clubs)},
                    new PokerCard{CardFace = new Face(Card.Face.Ten), CardSuit = new Suit(Card.Suit.Clubs)},
                };
            return new PokerHand { Cards = cards };
        }
    }
}
