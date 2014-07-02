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
            if (GetThreeOfAKindCardValue(handOne) > GetThreeOfAKindCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (GetThreeOfAKindCardValue(handTwo) > GetThreeOfAKindCardValue(handOne))
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
               
                IEnumerable<Card> handOneKicker = handOne.GetCards().Where(obj => obj.GetCardValue() == i);
                IEnumerable<Card> handTwoKicker = handTwo.GetCards().Where(obj => obj.GetCardValue() == i);


                if (handOneKicker.Count() == 1 && handTwoKicker.Count() != 1)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoKicker.Count() == 1 && handOneKicker.Count() != 1)
                {
                    bestHand = handTwo;
                    break;
                }
            }
            return bestHand;
        }


        private static Value GetThreeOfAKindCardValue(Hand hand)
        {
            var tripletCardValue = (Value)0;

            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    tripletCardValue = i;

                }
            }
            return tripletCardValue;
        }
    }
}
