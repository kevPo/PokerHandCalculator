using System.Collections.Generic;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculator
{
    public class HandValidator
    {
        public static void ValidateForPokerHand(List<CardCode> cardCodes)
        {
            if (cardCodes.Count < 5)
                throw new InvalidPokerHandException("Error: Not enough cards to make a valid poker hand.");
            if (cardCodes.Count > 5)
                throw new InvalidPokerHandException("Error: Too many cards to make a valid poker hand.");
        }
    }
}
