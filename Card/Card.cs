using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Card
    {
        public Suits Suit { get; }
        public Values Value { get; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{Value.ToString()} of {Suit.ToString()}";
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            return cardToCheck.Suit == suit;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            return cardToCheck.Value == value;
        }
    }
}
