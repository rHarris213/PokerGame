using System;
using System.Net.NetworkInformation;
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

    //public enum Value
    //{
    //    Ace,
    //    King,
    //    Queen,
    //    Jack,
    //    Ten,
    //    Nine,
    //    Eight,
    //    Seven,
    //    Six,
    //    Five,
    //    Four,
    //    Three,
    //    Two
    //}

    public class Card : ICard
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

      

      
    }
}

