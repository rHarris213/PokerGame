using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Hand
    {
        List<Card> Cards = new List<Card>();

        public void TakeCards(Card sentCard)
        {
            Cards.Add(sentCard);
        }

        public void Show()
        {
            foreach (var aCard in Cards)
            {
                Console.WriteLine(aCard);
            }
        }

        public int GetLength()
        {
            return Cards.Count;
        }

        public void ChangeCards(Deck deckToReturnTo, List<int> returnedCards )
        {

            for (var i = 0; i < returnedCards.Count; i++)
            {
                deckToReturnTo.TakeCard(Cards[i]);
                
            }
            



        }

       public List<Card> GetCards()
        {
            return Cards;
        }





       public int CheckHighCard()
       {
           var highCard = 0;
           foreach (var aCard in Cards)
           {
               if (aCard.GetCardValue() > highCard)
               {
                   highCard = aCard.GetCardValue();
               }
           }
           return highCard;
       }

        public bool CheckFlush()
        {
            
            int suitValue = Cards[0].GetCardSuit();
            foreach (var aCard in Cards)
            {
                if (aCard.GetCardSuit() != suitValue)
                {

                    return false;
                }
            }
            return true ;
        }
        
        public bool CheckStraight()
        {

            var sorted = new List<Card>(Cards.OrderBy(o => o.GetCardValue()));
            var numberOfCards = sorted.Count();
            var initialCardValue = sorted[0].GetCardValue();
        
            for(int i = 0; i < numberOfCards; i++)
            {
                if (sorted[i].GetCardValue() != i + initialCardValue)
                {
                    if (!(initialCardValue == 2 && sorted[i].GetCardValue() == 14))
                    {
                        return false;
                    }
                }
                
            }
            return true;

        }

        public int CheckStraightFlush()
        {
            int handValue = 0;
            var initialCardValue = SortCards()[0].GetCardValue();

            if (CheckStraight() && CheckFlush())
            {

                if (CheckRoyalFlush())
                {
                    handValue = 9;
                    
                }
                else
                {
                    handValue = 8;
                }
            }
            else
            {
                handValue = 5;

            }
            return handValue;
        }

        public bool CheckRoyalFlush()
        {
            var initialCardValue = SortCards()[0].GetCardValue();

            if (initialCardValue == 10)
            {
                return true;
            }
            return false;
        }

        public int CheckMultiples()
        {
            int highestMult = 0;
            int numOfPairs = 0;
            int handValue = 0;

            for (int i = 0; i < 15; i++)
            {
                
                
                IEnumerable<Card> multiples = Cards.Where(obj => obj.GetCardValue() == i);

                
                if (multiples.Count() > 3)
                {
                    handValue = 7;

                }
                if (multiples.Count() > 2)
                {
                    handValue = 3;
                }
                if (multiples.Count() > 1)
                {
                    handValue = 1;
                    numOfPairs += 1;

                }
                
            }

            if (numOfPairs > 1)
            {
                handValue = 2;
            }
            return handValue;
        }

        public List<Card> SortCards()
        {
            return new List<Card>(Cards.OrderBy(o => o.GetCardValue()));
            

        }

    }
}
