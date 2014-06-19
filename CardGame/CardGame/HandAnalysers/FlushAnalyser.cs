using System.Collections.Generic;

namespace CardGame.HandAnalysers
{
    public class FlushAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            int? suit = null;
            foreach (var card in hand.GetCards())
            {
                if (suit.HasValue && suit != card.GetCardSuit())
                {
                    return false;
                }
                suit = card.GetCardSuit();
            }
            return true;
        }
    }
}