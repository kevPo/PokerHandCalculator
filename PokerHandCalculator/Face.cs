namespace PokerHandCalculator
{
    public class Face
    {
        public Card.Face Value { get; private set; }
        public string Description { get; private set; }

        public Face(Card.Face value, string description)
        {
            Value = value;
            Description = description;
        }

        public Face(Card.Face value)
        {
            Value = value;
            Description = "";
        }

        public bool Equals(Face other)
        {
            if (other == null)
                return false;
            return other.Value == Value;
        }
    }
}
