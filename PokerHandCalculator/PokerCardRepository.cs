using System;
using System.Collections.Generic;
using PokerHandCalculator.Exceptions;

namespace PokerHandCalculator
{
    public class PokerCardRepository
    {
        
        private readonly Dictionary<string, Card.Suit> _suits = new Dictionary<string, Card.Suit>
            {
                {"C", Card.Suit.Clubs},
                {"D", Card.Suit.Diamonds},
                {"H", Card.Suit.Hearts},
                {"S", Card.Suit.Spades}
            };

        private readonly Dictionary<string, Card.Face> _faces = new Dictionary<string, Card.Face>
            {
                {"2", Card.Face.Two},
                {"3", Card.Face.Three},
                {"4", Card.Face.Four},
                {"5", Card.Face.Five},
                {"6", Card.Face.Six},
                {"7", Card.Face.Seven},
                {"8", Card.Face.Eight},
                {"9", Card.Face.Nine},
                {"10", Card.Face.Ten},
                {"J", Card.Face.Jack},
                {"Q", Card.Face.Queen},
                {"K", Card.Face.King},
                {"A", Card.Face.Ace}
            }; 

        public Face GetFaceFor(string faceCode)
        {
            try
            {
                return new Face(_faces[faceCode], faceCode);
            }
            catch (KeyNotFoundException)
            {
                throw new InvalidValueException(String.Format("Error: '{0}' is not a valid face value.", faceCode));
            }
        }

        public Suit GetSuitFor(string suitCode)
        {
            try
            {
                return new Suit(_suits[suitCode], suitCode); 
            }
            catch (KeyNotFoundException)
            {
                throw new InvalidValueException(String.Format("Error: '{0}' is not a valid suit.", suitCode));
            }
        }
    }
}
