namespace PokerHandCalculator.Strategies
{
    public class FullHouseStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            if (HasThreeOfKind(hand.Cards))
            {
                return FindPairs(hand.Cards).Count == 1;
            }
            return false;
        }
    }
}
