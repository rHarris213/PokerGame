using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using cardGame.Test;

namespace CardGame
{
    //public enum Suit
    //{
    //    Spades,
    //    Hearts,
    //    Clubs,
    //    Diamonds
    //};

    public enum Value
    {
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }

    public class Card : ICard, IComparable<Card>
    {
        private readonly int _cardValue;

        private readonly int _cardSuit;

        public int GetCardValue()
        {
            return _cardValue;
        }

        //public Suit Suit { get; set; }
        //public Value Value { get; set; }

        public int GetCardSuit()
        {
            return _cardSuit;
        }

        public Card(int sentCardValue, int sentCardSuit)
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

