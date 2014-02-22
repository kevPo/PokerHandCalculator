using System;

namespace PokerHandCalculator.Strategies
{
    public class StraightFlushStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return IsFlush(hand.Cards) && IsStraight(hand.Cards);
        }
    }
}
