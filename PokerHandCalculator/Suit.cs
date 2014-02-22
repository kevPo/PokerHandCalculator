namespace PokerHandCalculator
{
    public class Suit
    {
        public Card.Suit Value { get; private set; }
        public string Description { get; private set; }

        public Suit(Card.Suit suit, string description)
        {
            Value = suit;
            Description = description;
        }

        public Suit(Card.Suit suit)
        {
            Value = suit;
            Description = "";
        }

        public bool Equals(Suit other)
        {
            if (other == null)
                return false;
            return other.Value == Value;
        }
    }
}
