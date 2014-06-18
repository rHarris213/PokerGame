using System.Collections.Generic;

namespace CardGame.HandAnalysers
{
    public class FlushAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand; 
        public FlushAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            foreach (var card in _hand)
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