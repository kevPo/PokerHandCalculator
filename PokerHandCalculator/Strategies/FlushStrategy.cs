namespace PokerHandCalculator.Strategies
{
    public class FlushStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return IsFlush(hand.Cards);
        }
    }
}
