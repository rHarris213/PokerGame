using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.TieBreakers
{
    public class FlushTieBreaker : ITieBreaker
    {
        public Hand DetermineStrongestHand(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;
            var handSize = handOne.GetCards().Count;

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();


            for (var i = 0; i < handSize; i++)
            {
                if (handOne.GetCards()[i].GetCardValue() > handTwo.GetCards()[i].GetCardValue())
                {
                    bestHand = handOne;
                    break;
                }

                if (handTwo.GetCards()[i].GetCardValue() > handOne.GetCards()[i].GetCardValue())
                {
                    bestHand = handTwo;
                    break;
                }
            }
            return bestHand;
        }
    }
}
