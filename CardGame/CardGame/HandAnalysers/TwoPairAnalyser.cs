using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class TwoPairAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            
            var numberOfPairs = 0;
            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 2)
                {
                    numberOfPairs++;
                    if (numberOfPairs == 2)
                    {
                        hand.SetRank(Rank.TwoPair);
                        return true;
                    }
                }

            }
            return false;
        }
    }
}