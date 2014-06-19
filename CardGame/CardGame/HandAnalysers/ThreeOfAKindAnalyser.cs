using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class ThreeOfAKindAnalyser : IHandAnalyser
    {


        public bool IsHand(Hand hand)
        {
           

            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    return true;

                }
               
            }
            return false;
        }
    }
}