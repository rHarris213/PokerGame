using System;

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

    public class Card
    {
        private readonly int CardValue;

        private readonly int CardSuit;

        public int GetCardValue()
        {
            return CardValue;
        }

        //public Suit Suit { get; set; }
        //public Value Value { get; set; }

        public int GetCardSuit()
        {
            return CardSuit;
        }

        public Card(int sentCardValue, int sentCardSuit)
        {

           CardValue = sentCardValue;
           CardSuit = sentCardSuit;
        }

        //public string Description
        //{
        //    get { return String.Format("{0} of {1}", Value, Suit); }
        //}

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
    }
}

