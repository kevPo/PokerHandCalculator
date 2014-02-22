using System;

namespace PokerHandCalculator.Exceptions
{
    public class InvalidPokerHandException : Exception
    {
        public InvalidPokerHandException(string message) : base(message)
        {
        }
    }
}
