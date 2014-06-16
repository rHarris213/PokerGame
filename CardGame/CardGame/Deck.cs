using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Deck
    {
       public List<Card> Cards = new List<Card>();

        public Deck()
        {
            BuildDeck();
        }

        private void BuildDeck()
        {
            const int numberOfSuits = 4;

            for (var j = 0; j < numberOfSuits; j++)
            {
                for (var i = 0; i < 13; i++)
                {
                   
                            Cards.Add(new Card(i + 2, j));
                           
                       
                    
                }
            }
        }

        public void Deal(Hand handToDealTo)
        {
            if (Count() <= 0) return;

            for (var i = 0; i < 5; i++)
            {
                if (Count() - i < 0)
                {
                    break;
                }
                handToDealTo.TakeCards(Cards[0]);
                Cards.Remove(Cards[0]);

            }
        }

        public void TakeCard(Card sentCard)
        {
            Cards.Add(sentCard);
        }
        
        public int Count()
        {
            return Cards.Count;
        }

        public void Shuffle()
        {
            for (var i = Cards.Count; i > 1; i--)
            {
                var shuffleRand = Rand;
                // Pick random element to swap.
                var j = shuffleRand.Next(i); // 0 <= j <= i-1
                // Swap.
                var tmp = Cards[j];
                Cards[j] = Cards[i - 1];
                Cards[i - 1] = tmp;
            }
        }

        public void Show()
        {
            foreach (var aCard in Cards)
            {
                Console.WriteLine(aCard);
            }
            Console.ReadKey();
        }

        public List<Card> GetCards()
        {
            return Cards;
        }

        public static Random Rand = new Random();
    }
}
