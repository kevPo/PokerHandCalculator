namespace PokerHandCalculator.Strategies
{
    public class StraightStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return IsStraight(hand.Cards);
        }
    }
}
