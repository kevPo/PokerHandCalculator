using PokerHandCalculator.Strategies;

namespace PokerHandCalculator
{
    public class PokerTable
    {
        private readonly ScoreCalculator _calculator;
        private readonly PokerHandFactory _pokerHandFactory;
        private readonly PokerHand _pokerHand;

        public PokerTable(string cardData)
        {
            _pokerHandFactory = new PokerHandFactory();
            _pokerHand = _pokerHandFactory.BuildHand(cardData);
            _calculator = new ScoreCalculator(_pokerHand);
        }

        public string CalculateScore()
        {
            if (_calculator.CalculateScore(new RoyalFlushStrategy()))
                return "Royal Flush";
            if (_calculator.CalculateScore(new StraightFlushStrategy()))
                return "Straight Flush";
            if (_calculator.CalculateScore(new FourOfAKindStrategy()))
                return "Four of a Kind";
            if (_calculator.CalculateScore(new FullHouseStrategy()))
                return "Full House";
            if (_calculator.CalculateScore(new FlushStrategy()))
                return "Flush";
            if (_calculator.CalculateScore(new StraightStrategy()))
                return "Straight";
            if (_calculator.CalculateScore(new ThreeOfAKindStrategy()))
                return "Three of a Kind";
            if (_calculator.CalculateScore(new TwoPairStrategy()))
                return "Two Pair";
            if (_calculator.CalculateScore(new OnePairStrategy()))
                return "One Pair";
            return "High Card: " + _pokerHand.GetHighCard().ToString();
        }
    }
}
