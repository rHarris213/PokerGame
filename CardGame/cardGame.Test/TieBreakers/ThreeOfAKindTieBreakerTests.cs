using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class ThreeOfAKindTieBreakerTests
    {
        [Test]
        public void Three_Of_A_Kind_With_Higher_Triplet_Should_Win()
        {
            var handOne = HandBuilder.ThreeOfAKindThreesHighKickers();
            var handTwo = HandBuilder.ThreeOfAKindKingsHighKickers();

            var result = FindBestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Three_Of_A_Kind_With_Higher_Kicker_Should_Win_If_Triplet_Are_Same()
        {
            var handOne = HandBuilder.ThreeOfAKindKingsLowKickers();
            var handTwo = HandBuilder.ThreeOfAKindKingsHighKickers();

            var result = FindBestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }
        





        private Hand FindBestHand(Hand handTwo, Hand handOne)
        {
            Hand bestHand = null;
            if (ThreeOfAKindCardValue(handOne) > ThreeOfAKindCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (ThreeOfAKindCardValue(handTwo) > ThreeOfAKindCardValue(handOne))
            {
                bestHand = handTwo;
            }
            if (bestHand != null)
            {
                return bestHand;
            }
           

            return CompareKickers(handTwo, handOne);
        }

        private static Hand CompareKickers(Hand handTwo, Hand handOne)
        {
            Hand bestHand = null;
            for (var i = Value.Ace; i >= Value.Two; i--)
            {
               
                var handOneKicker = handOne.GetCards().Count(obj => obj.GetCardValue() == i);
                var handTwoKicker = handTwo.GetCards().Count(obj => obj.GetCardValue() == i);


                if (handOneKicker == 1 && handTwoKicker != 1)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoKicker == 1 && handOneKicker != 1)
                {
                    bestHand = handTwo;
                    break;
                }
            }
            return bestHand;
        }


        private static Value ThreeOfAKindCardValue(Hand hand)
        {
            var tripletCardValue = (Value)0;

            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                
                if (hand.GetCards().Count(obj => obj.GetCardValue() == i) != 3) continue;
                
                tripletCardValue = i;
                break;
            }
            return tripletCardValue;
        }
    }
}
