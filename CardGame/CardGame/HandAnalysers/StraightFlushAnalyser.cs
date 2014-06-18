using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightFlushAnalyser : IHandAnalyser 
    {
        private readonly List<Card> _hand;

        public StraightFlushAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            int? expectedCard = null;
            int cardsChecked = 0;

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
               
                if ((suit.HasValue && suit.Value != card.GetCardSuit())|| card.GetCardValue() != expectedCard)
                {
                   
                    return false;
                }
                suit = card.GetCardSuit();
                expectedCard ++;
                cardsChecked++;
            }
            return true;
        }
    }
}