using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightAnalyser : IHandAnalyser 
    {
        public bool IsHand(Hand hand)
        {
            
            int cardsChecked = 0;
            int? expectedCard = null;
            foreach (var card in hand.GetCards().OrderBy(c => c.GetCardValue()))
            {
                if (!expectedCard.HasValue)
                {
                    expectedCard = card.GetCardValue();
                }
                if (cardsChecked == 4 && expectedCard == 6 && card.GetCardValue() == 14)
                {
                    return true;
                }
                if ( card.GetCardValue() != expectedCard)
                {

                    return false;
                }

                cardsChecked ++;
                expectedCard ++;

            }
            return true;
        }
    }
}