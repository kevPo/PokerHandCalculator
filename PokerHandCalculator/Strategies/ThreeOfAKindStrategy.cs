namespace PokerHandCalculator.Strategies
{
    public class ThreeOfAKindStrategy : ScoreStrategy
    {
        public override bool IsValidScoreForHand(PokerHand hand)
        {
            return HasThreeOfKind(hand.Cards);
        }
    }
}
