using System.Linq;
using System.Collections.Generic;

namespace PokerHandCalculator.Strategies
{
    public class RoyalFlushStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return IsRoyalty(hand.Cards) && IsFlush(hand.Cards);
        }

        private bool IsRoyalty(List<PokerCard> cards)
        {
            return cards.Any(c => c.CardFace.Value.Equals(Card.Face.Ace)) &&
                cards.Any(c => c.CardFace.Value.Equals(Card.Face.King)) &&
                cards.Any(c => c.CardFace.Value.Equals(Card.Face.Queen)) &&
                cards.Any(c => c.CardFace.Value.Equals(Card.Face.Jack)) &&
                cards.Any(c => c.CardFace.Value.Equals(Card.Face.Ten));
        }
    }
}
