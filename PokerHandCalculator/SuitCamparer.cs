using System.Collections.Generic;

namespace PokerHandCalculator
{
    public class SuitCamparer : IEqualityComparer<PokerCard>
    {
        public bool Equals(PokerCard x, PokerCard y)
        {
            var same = x.CardSuit.Value.Equals(y.CardSuit.Value);
            return same;
        }

        public int GetHashCode(PokerCard obj)
        {
            return obj.CardSuit.Value.GetHashCode();
        }
    }
}
