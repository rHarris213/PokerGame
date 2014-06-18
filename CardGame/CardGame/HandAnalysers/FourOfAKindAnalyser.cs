using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class FourOfAKindAnalyser : IHandAnalyser
    {
        private readonly List<Card> _hand ;
        public FourOfAKindAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {

            for (var i = 0; i < 15; i ++)
            {
                IEnumerable<Card> fourMatchCheck = _hand.Where(obj => obj.GetCardValue() == i);


                if (fourMatchCheck.Count() == 4)
                {
                    return true;

                }
            }
            return false;
        }
    }
}