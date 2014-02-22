namespace PokerHandCalculator
{
    public class PokerCardFactory
    {
        private readonly PokerCardRepository _cardRepo;

        public PokerCardFactory()
        {
            _cardRepo = new PokerCardRepository();
        }

        public PokerCard BuildCard(CardCode cardCode)
        {
            return new PokerCard
                {
                    CardFace = _cardRepo.GetFaceFor(cardCode.FaceCode), 
                    CardSuit = _cardRepo.GetSuitFor(cardCode.SuitCode)
                };
        }
    }
}
