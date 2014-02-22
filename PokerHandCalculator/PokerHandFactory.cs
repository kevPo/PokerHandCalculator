using System.Collections.Generic;
using System.Linq;

namespace PokerHandCalculator
{
    public class PokerHandFactory
    {
        private readonly PokerCardFactory _cardFactory;

        public PokerHandFactory()
        {
            _cardFactory = new PokerCardFactory();
        }

        public PokerHand BuildHand(string rawCardCodes)
        {
            var cardCodes = ConvertCardCodes(rawCardCodes);
            HandValidator.ValidateForPokerHand(cardCodes);
            var hand = new PokerHand();
            foreach (var cardCode in cardCodes)
            {
                var card = _cardFactory.BuildCard(cardCode);
                hand.AddCard(card);
            }
            return hand;
        }

        private List<CardCode> ConvertCardCodes(string rawCardCodes)
        {
            var trimmedRawCards = rawCardCodes.Trim();
            var rawCards = trimmedRawCards.Split(' ').ToList();
            rawCards.RemoveAll(c => c.Length == 0);
            return rawCards.Select(rawCard => new CardCode(rawCard)).ToList();
        }
    }
}
