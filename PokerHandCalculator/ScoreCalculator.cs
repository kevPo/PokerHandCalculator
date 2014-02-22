using PokerHandCalculator.Strategies;

namespace PokerHandCalculator
{
    public class ScoreCalculator
    {
        private readonly PokerHand _hand;

        public ScoreCalculator(PokerHand hand)
        {
            _hand = hand;
        }

        public bool CalculateScore(ScoreStrategy strategy)
        {
            return strategy.IsValidScoreForHand(_hand);
        }
    }
}
