using System.Collections.Generic;
using System.Linq;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculator
{
    public class PokerHand
    {
        public List<PokerCard> Cards { get; set; }

        public PokerHand()
        {
            Cards = new List<PokerCard>();
        }

        public void AddCard(PokerCard card)
        {
            if (!AlreadyInHand(card))
            {
                Cards.Add(card);
            }
            else
            {
                throw new InvalidPokerHandException("Error: Poker hand does not allow duplicate cards.");
            }
        }

        private bool AlreadyInHand(PokerCard pokerCard)
        {
            return Cards.Any(card => card.Equals(pokerCard));
        }

        public PokerCard GetHighCard()
        {
            var highValue = Cards.Max(c => c.Value);
            return Cards.FirstOrDefault(c => c.Value == highValue);
        }

    }
}
