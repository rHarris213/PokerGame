using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class RoyalFlushHandAnalyser : IHandAnalyser
    {
        public bool IsHand(IHand hand)
        {
            Suit? suit = null;
            var expectedCard = Value.Ten;
            foreach (var card in hand.GetCards().OrderBy(c => c.GetCardValue()))
            {
                if ((suit.HasValue && suit.Value != card.GetCardSuit()) || (card.GetCardValue() != expectedCard))
                {
                    return false;
                }
                expectedCard++;
                suit = card.GetCardSuit();
            }
            hand.SetRank(Rank.RoyalFlush);

            return true;
        }
    }
}