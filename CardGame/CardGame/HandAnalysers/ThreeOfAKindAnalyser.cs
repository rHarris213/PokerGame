using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class ThreeOfAKindAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand; 
        public ThreeOfAKindAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    return true;

                }
               
            }
            return false;
        }
    }
}