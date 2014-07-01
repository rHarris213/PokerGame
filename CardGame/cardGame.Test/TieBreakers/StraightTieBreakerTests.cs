using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class StraightTieBreakerTests
    {
        [Test]
        public void Straight_With_Higher_Lead_Card_Should_Win()
        {
            var handOne = HandBuilder.StraightJackHigh();
            var handTwo = HandBuilder.AceHighStraightWithoutFlush();

            var result = FindStrongerStraight(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Straight_With_Low_Ace_Should_Not_Beat_Higher_Ranking_Straights()
        {
            var handOne = HandBuilder.StraightAceLow();
            var handTwo = HandBuilder.StraightSixHigh();

            var result = FindStrongerStraight(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Alike_Straights_Should_Result_In_Draw()
        {
            var handOne = HandBuilder.StraightJackHigh();
            var handTwo = HandBuilder.StraightJackHigh();

            var result = FindStrongerStraight(handTwo, handOne);

            Assert.IsNull(result);
        }


        private Hand FindStrongerStraight(Hand handOne, Hand handTwo)
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
