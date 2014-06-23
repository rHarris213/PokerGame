using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class ThreeOfAKindAnalyser : IHandAnalyser
    {


        public bool IsHand(Hand hand)
        {
           

            for (var i = Value.Two; i < Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    hand.SetRank(Rank.ThreeOfAKind);
                    return true;

                }
               
            }
            return false;
        }
    }
}