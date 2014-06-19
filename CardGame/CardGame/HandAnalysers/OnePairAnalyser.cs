using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class OnePairAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            var numberOfPairs = 0;
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


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