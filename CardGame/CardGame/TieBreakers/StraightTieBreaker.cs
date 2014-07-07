namespace CardGame.TieBreakers
{
    public class StraightTieBreaker : ITieBreaker
    {
        public Hand DetermineStrongestHand(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;
            handOne.ArrangeCardsLowToHigh();
            handTwo.ArrangeCardsLowToHigh();



            if (handOne.GetCards()[0].GetCardValue() > handTwo.GetCards()[0].GetCardValue())
            {
                bestHand = handOne;
            }
            if (handTwo.GetCards()[0].GetCardValue() > handOne.GetCards()[0].GetCardValue())
            {
                bestHand = handTwo;
            }

            if (IsAceLowStraight(handOne) && !IsAceLowStraight(handTwo))
                bestHand = handTwo;
            if (IsAceLowStraight(handTwo) && !IsAceLowStraight(handOne))
                bestHand = handOne;

            return bestHand;

        }

        private static bool IsAceLowStraight(Hand hand)
        {


            return (hand.GetCards()[0].GetCardValue() == Value.Two
                  && hand.GetCards()[1].GetCardValue() == Value.Three
                  && hand.GetCards()[2].GetCardValue() == Value.Four
                  && hand.GetCards()[3].GetCardValue() == Value.Five
                  && hand.GetCards()[4].GetCardValue() == Value.Ace);



        }
    }
}
