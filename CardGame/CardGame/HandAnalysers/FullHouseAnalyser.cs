using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class FullHouseAnalyser : IHandAnalyser 
    {
        public bool IsHand(Hand hand)
        {
            var threeOfAKind = false;
            var pair = false;

            for (var i = Value.Two; i < Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);

                if (cardsOfSameValue.Count() > 2 && !threeOfAKind)
                {
                    threeOfAKind = true;

                }
                else if (cardsOfSameValue.Count() > 1 && !pair)
                {
                    pair = true;

                }
                if (threeOfAKind && pair)
                {
                    return true;
                }
            }
            return false;
        }
    }
}