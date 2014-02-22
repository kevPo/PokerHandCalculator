using System;

namespace PokerHandCalculator.Exceptions
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base(message)
        {
        }
    }
}
