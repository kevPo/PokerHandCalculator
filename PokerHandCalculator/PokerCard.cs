namespace PokerHandCalculator
{
    public class PokerCard
    {
        public Suit CardSuit { get; set; }
        private Face _cardFace;
        public Face CardFace
        {
            get { return _cardFace; }
            set
            {
                _cardFace = value;
                Value = (int)_cardFace.Value;
            }
        }
        public int Value { get; set; }

        public bool Equals(PokerCard card)
        {
            if (card == null)
                return false;
            return (card.CardFace.Equals(CardFace) && card.CardSuit.Equals(CardSuit));
        }

        public string ToString()
        {
            return CardFace.Description + CardSuit.Description;
        }
    }
}
