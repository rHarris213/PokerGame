using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightAnalyser : IHandAnalyser 
    {
        private readonly List<Card> _hand; 
        public StraightAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int cardsChecked = 0;
            int? expectedCard = null;
            foreach (var card in _hand.OrderBy(c => c.GetCardValue()))
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