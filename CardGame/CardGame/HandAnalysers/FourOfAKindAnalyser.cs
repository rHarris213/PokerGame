using System.Linq;

namespace CardGame.HandAnalysers
{
    public class FourOfAKindAnalyser : IHandAnalyser
    {
        public bool IsHand(Hand hand)
        {
            for (var i = Value.Two; i <= Value.Ace; i ++)
            {
                var fourMatchCheck = hand.GetCards().Where(obj => obj.GetCardValue() == i);

                if (fourMatchCheck.Count() == 4)
                {
                    hand.SetRank(Rank.FourOfAKind);
                    return true;
                }
            }
            return false;
        }

        
    }
}