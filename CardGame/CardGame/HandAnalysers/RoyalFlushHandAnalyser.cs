using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class RoyalFlushHandAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand;

        public RoyalFlushHandAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            int expectedCard = 10;
            foreach (var card in _hand.OrderBy(c => c.GetCardValue()))
            {
                if ((suit.HasValue && suit.Value != card.GetCardSuit()) || (card.GetCardValue() != expectedCard))
                {
                    return false;
                }
                expectedCard++;
                suit = card.GetCardSuit();
            }
            return true;
        }
    }
}