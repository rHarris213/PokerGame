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

        public void AddCards(IList<Card> cards)
        {
            // probably should check for duplicates
            Cards.AddRange(cards);
        }

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

        public List<Card> SortCards()
        {
            return new List<Card>(Cards.OrderBy(o => o.GetCardValue()));
            

        }

    }
}
