namespace PokerHandCalculator.Strategies
{
    public class OnePairStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return FindPairs(hand.Cards).Count == 1;
        }
    }
}
