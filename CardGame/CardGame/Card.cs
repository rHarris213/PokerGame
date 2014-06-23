using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace CardGame
{
    public enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    };

    public enum Value
    {
        
        Two = 2,
        Three = 3,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card : ICard, IComparable<Card>
    {
        private readonly Value _cardValue;

        private readonly Suit _cardSuit;

        public Value GetCardValue()
        {
            return _cardValue;
        }

        //public Suit Suit { get; set; }
        //public Value Value { get; set; }

        public Suit GetCardSuit()
        {
            return _cardSuit;
        }

        public Card(Value sentCardValue, Suit sentCardSuit)
        {

           _cardValue = sentCardValue;
           _cardSuit = sentCardSuit;
        }


        public int CompareTo(Card card)
        {
            if (this.GetCardValue() > card.GetCardValue())
            {
                return 1;
            }
            else if (this.GetCardValue() < card.GetCardValue())
            {
                return -1;
            }
            else return 0;
            ;
        }

       
    }
}

