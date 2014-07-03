﻿using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    internal class FourOfAKindTieBreakTests
    {
        [Test]
        public void Four_Of_A_Kind_Tie_Breaker_Should_Identify_Higher_Value_Multiple()
        {
            var handOne = HandBuilder.FourOfAKindSevens();
            var handTwo = HandBuilder.FourOfAKindKings();

            var result = IdentifyHighestMultiples(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Four_Of_A_Kind_Tie_Breaker_Does_Not_Assign_Winner_When_There_Is_Draw()
        {
            var handOne = HandBuilder.FourOfAKindSevens();
            var handTwo = HandBuilder.FourOfAKindSevens();

            var result = IdentifyHighestMultiples(handOne, handTwo);

            Assert.IsNull(result);
        }

        [Test]
        public void Four_Of_A_Kind_Tie_Breaker_Can_Be_Won_With_High_Kicker()
        {
            var handOne = HandBuilder.FourOfAKindKingsLowKicker();
            var handTwo = HandBuilder.FourOfAKindKingsHighKicker();

            var result = IdentifyHighestMultiples(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        private Hand IdentifyHighestMultiples(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;


            if (GetFourOfAKindCardValue(handOne) > GetFourOfAKindCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (GetFourOfAKindCardValue(handTwo) > GetFourOfAKindCardValue(handOne))
            {
                bestHand = handTwo;
            }

            if (bestHand != null) return bestHand;



            if (GetKickerCardValue(handOne) > GetKickerCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (GetKickerCardValue(handTwo) > GetKickerCardValue(handOne))
            {
                bestHand = handTwo;
            }

            return bestHand;
        }

        private static Value GetKickerCardValue(Hand handOne)
        {
            var handOneKickerValue = Value.Two;
            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                var cardValue = handOne.GetCards().Where(obj => obj.GetCardValue() == i);

                if (cardValue.Count() == 1)
                {
                    handOneKickerValue = i;
                    break;
                }
            }
            return handOneKickerValue;
        }

        private static Value GetFourOfAKindCardValue(Hand hand)
        {
            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                var cardValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);

                if (cardValue.Count() == 4)
                {
                    var fourOfAKindValue = i;
                    return fourOfAKindValue;
                }
            }
            return Value.Two;

        }
    }
}


