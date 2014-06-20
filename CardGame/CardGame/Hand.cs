using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Hand
    {
        readonly List<Card> _cards = new List<Card>();

        public void AddCards(IList<Card> cards)
        {
            // probably should check for duplicates
            _cards.AddRange(cards);
        }

        public void AddCard(Value value, Suit suit)
        {
            _cards.Add(new Card(value,suit));
        }

        public void TakeCards(Card sentCard)
        {
            _cards.Add(sentCard);
        }

        public void Show()
        {
            foreach (var aCard in _cards)
            {
                Console.WriteLine(aCard);
            }
        }

        public int GetLength()
        {
            return _cards.Count;
        }

        public void ChangeCards(Deck deckToReturnTo, List<int> returnedCards )
        {
            for (var i = 0; i < returnedCards.Count; i++)
            {
                deckToReturnTo.TakeCard(_cards[i]);
                
            }
        }

       public List<Card> GetCards()
        {
            return _cards;
        }

        public List<Card> SortCards()
        {
            return new List<Card>(_cards.OrderBy(o => o.GetCardValue()));
        }

        
    }
}
