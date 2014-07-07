using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.TieBreakers;

namespace CardGame.TieBreakers
{
    class FourOfAKindTieBreaker : ITieBreaker
    {
    public Hand DetermineStrongestHand(Hand handOne, Hand handTwo)
        {
            
        
            //var highestFourOfAKindHand = MultiplesTieBreaker.FindHigherValueMultiples(handOne, handTwo, 4);

            //if (highestFourOfAKindHand != null)
            //{
            //    return highestFourOfAKindHand;
            //}
            //var highestKickerHand = MultiplesTieBreaker.FindHigherValueMultiples(handOne, handTwo, 1);

            //return highestKickerHand;
        return null;

        }

        
    }
}
