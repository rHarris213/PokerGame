using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightAnalyser : IHandAnalyser 
    {
        public bool IsHand(Hand hand)
        {
            if (IsFlush(hand))
                return false;

            if (IsStraight(hand))
                return true;

            return IsAceLowStraight(hand);

        }

        private bool IsStraight(Hand hand)
        {
            var sortedHand = hand.SortCards();
            var expectedNextCardValue = sortedHand[0].GetCardValue() + 1;

            for (var x = 1; x < sortedHand.Count; x++)
            {
                var currentCard = sortedHand[x];
                if (currentCard.GetCardValue() != expectedNextCardValue)
                {
                    return false;
                }
                expectedNextCardValue++;
            }
            return true;
        }

        private bool IsFlush(Hand hand)
        {
            var analyser = new FlushAnalyser();

            return analyser.IsHand(hand);
        }

        private static bool IsAceLowStraight(Hand hand)
        {
           
            var cards2 = hand.GetCards();
            cards2.Sort();

            return (cards2[0].GetCardValue() == 2
                  && cards2[1].GetCardValue() == 3
                  && cards2[2].GetCardValue() == 4
                  && cards2[3].GetCardValue() == 5
                  && cards2[4].GetCardValue() == 14);

           
            
        }
    }
}