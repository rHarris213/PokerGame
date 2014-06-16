using System;

namespace CardGame
{
    public class Card
    {
        private readonly int CardValue;

        private readonly int CardSuit;

        public int GetCardValue()
        {
            return CardValue;
        }
        public int GetCardSuit()
        {
            return CardSuit;
        }

        public Card(int sentCardValue, int sentCardSuit)
        {

           CardValue = sentCardValue;
           CardSuit = sentCardSuit;
        }



    }

       

}

