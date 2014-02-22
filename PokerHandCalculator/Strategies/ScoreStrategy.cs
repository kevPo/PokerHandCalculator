using System.Collections.Generic;
using System.Linq;

namespace PokerHandCalculator.Strategies
{
    public abstract class ScoreStrategy
    {
        public virtual bool IsValidScoreForHand(PokerHand hand)
        {
            return false;
        }

        public List<Face> FindPairs(List<PokerCard> cards)
        {
            var pairs = new List<Face>();
            foreach (var card in cards)
            {
                var pairFound = cards.Count(c => c.CardFace.Equals(card.CardFace)) == 2;
                var firstCardInPair = !pairs.Any(f => f.Equals(card.CardFace));
                if (pairFound && firstCardInPair)
                {
                    pairs.Add(card.CardFace);
                }
            }
            return pairs;
        }

        public bool HasThreeOfKind(List<PokerCard> cards)
        {
            foreach (var card in cards)
            {
                if (cards.Count(c => c.CardFace.Equals(card.CardFace)) == 3)
                    return true;
            }
            return false;
        }

        public bool IsFlush(List<PokerCard> cards)
        {
            return cards.Distinct(new SuitCamparer()).Count() == 1;
        }

        public bool IsStraight(List<PokerCard> cards)
        {
            var aceCount = cards.Count(c => c.CardFace.Value == Card.Face.Ace);
            if (aceCount > 1)
            {
                return false;
            }
            if (aceCount == 1)
            {
                return CardsAreConsecutiveWithAce(cards);    
            }
            return CardsAreConsecutive(cards);
        }

        private bool CardsAreConsecutiveWithAce(List<PokerCard> cards)
        {
            var aceHasPartner = cards.Any(c => c.CardFace.Value == Card.Face.Two) ||
                                cards.Any(c => c.CardFace.Value == Card.Face.King);
            var cardsWithoutAce = cards.Where(c => c.CardFace.Value != Card.Face.Ace).ToList();
            return aceHasPartner && CardsAreConsecutive(cardsWithoutAce);
        }

        private bool CardsAreConsecutive(List<PokerCard> cards)
        {
            var orderedCards = cards.OrderBy(c => c.Value).ToArray();
            var root = orderedCards[0];
            for (var i = 1; i < orderedCards.Length; i++)
            {
                if (orderedCards[i].Value != root.Value + i)
                    return false;
            }
            return true;
        }

        
    }
}
