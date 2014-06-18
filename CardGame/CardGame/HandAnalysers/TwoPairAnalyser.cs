using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class TwoPairAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand; 
        public TwoPairAnalyser(List<Card> hand)
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
                    if (numberOfPairs == 2)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}