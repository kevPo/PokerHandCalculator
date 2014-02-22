namespace PokerHandCalculator.Strategies
{
    public class TwoPairStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            var pairValues = FindPairs(hand.Cards);
            return pairValues.Count == 2;
        }
    }
}
