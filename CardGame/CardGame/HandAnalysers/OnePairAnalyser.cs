using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class OnePairAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand; 
        public OnePairAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            var numberOfPairs = 0;
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 2)
                {
                    numberOfPairs++;
                }

            }
            if (numberOfPairs == 1)
            {
                return true;   
            }
            return false;
        }
    }
}