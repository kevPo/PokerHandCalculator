using System.Linq;

namespace PokerHandCalculator.Strategies
{
    public class FourOfAKindStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            foreach (var card in hand.Cards)
            {
                if (hand.Cards.Count(c => c.CardFace.Equals(card.CardFace)) == 4)
                    return true;
            }
            return false;
        }
    }
}
