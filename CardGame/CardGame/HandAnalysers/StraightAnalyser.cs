using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class StraightAnalyser : IHandAnalyser
    {
        private IHandAnalyser _analyser;

        public StraightAnalyser(FlushAnalyser analyser)
        {
            _analyser = analyser;
        }

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
            return _analyser.IsHand(hand);
        }

        private static bool IsAceLowStraight(Hand hand)
        {
            hand.GetCards().Sort();

            return (hand.GetCards()[0].GetCardValue() == Value.Two
                  && hand.GetCards()[1].GetCardValue() == Value.Three
                  && hand.GetCards()[2].GetCardValue() == Value.Four
                  && hand.GetCards()[3].GetCardValue() == Value.Five
                  && hand.GetCards()[4].GetCardValue() == Value.Ace);

           
            
        }
    }
}