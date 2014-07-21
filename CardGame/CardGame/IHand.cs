using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace CardGame
{
    public interface IHand
    {
        void AddCard(Value value, Suit suit);
        void AddCards(IList<Card> cards);
        List<Card> GetCards();
        void SetRank(Rank newRank);
        List<Card> SortCards();
    }
}
