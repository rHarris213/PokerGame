using System.Linq;

namespace CardGame.HandAnalysers
{
    public class FourOfAKindAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            for (var i = 0; i < 15; i ++)
            {
                var fourMatchCheck = hand.GetCards().Where(obj => obj.GetCardValue() == i);

                if (fourMatchCheck.Count() == 4)
                {
                    return true;
                }
            }
            return false;
        }
    }
}