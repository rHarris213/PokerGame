using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightFlushAnalyser : IHandAnalyser 
    {


        public bool IsHand(Hand hand)
        {
            
            Suit? suit = null;
            Value? expectedCard = null;
            int cardsChecked = 0;

            foreach (var card in hand.GetCards().OrderBy(c => c.GetCardValue()))
            {
                if (!expectedCard.HasValue)
                {
                    expectedCard = card.GetCardValue();
                }
                if (cardsChecked == 4 && expectedCard == Value.Six && card.GetCardValue() == Value.Ace)
                {
                    hand.SetRank(Rank.StraightFlush);
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
            hand.SetRank(Rank.StraightFlush);
            return true;
        }
    }
}