﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLinq
{
    enum Values 
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    enum Suits
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades,
    }
    internal class Card : IComparable<Card>
    {
        public Values Value { get; private set; }
        public Suits Suit { get;private set; }

        public Card(Values value, Suits suit)
        {
            Value= value;
            Suit= suit;
        }
        public string Name {
            get { return $"{Value} of {Suit}"; } 
        }

        public override string ToString()
        {
            return Name;
        }
        public int CompareTo(Card other)
        {
            return new CardComparerByValue().Compare(this, other);
        }
        
    }
}
