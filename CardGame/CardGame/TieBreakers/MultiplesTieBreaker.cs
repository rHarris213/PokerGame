using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.TieBreakers
{
    public class MultiplesTieBreaker 
    {
        public static Hand DetermineStrongestHand(Hand handOne, Hand handTwo, int multipleRequired)
        {
            Hand bestHand = null;
            for (var cardValue = Value.Ace; cardValue >= Value.Two; cardValue--)
            {

                var handOneCountOfCard = handOne.GetCards().Count(obj => obj.GetCardValue() == cardValue);
                var handTwoCountOfCard = handTwo.GetCards().Count(obj => obj.GetCardValue() == cardValue);


                if (handOneCountOfCard == multipleRequired && handTwoCountOfCard != multipleRequired)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoCountOfCard == multipleRequired && handOneCountOfCard != multipleRequired)
                {
                    bestHand = handTwo;
                    break;
                }

            }

            return bestHand;
        }
    }
}
