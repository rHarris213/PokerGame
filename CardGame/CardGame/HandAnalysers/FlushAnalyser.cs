using System.Collections.Generic;

namespace CardGame.HandAnalysers
{
    public class FlushAnalyser : IHandAnalyser
    {
        public bool IsHand(IHand hand)
        {
            Suit? suit = null;
            foreach (var card in hand.GetCards())
            {
                if (suit.HasValue && suit != card.GetCardSuit())
                {
                    return false;
                }
                suit = card.GetCardSuit();
            }
            hand.SetRank(Rank.Flush);
            return true;
        }
    }
}