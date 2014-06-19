﻿using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class RoyalFlushHandAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            int? suit = null;
            int expectedCard = 10;
            foreach (var card in hand.GetCards().OrderBy(c => c.GetCardValue()))
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