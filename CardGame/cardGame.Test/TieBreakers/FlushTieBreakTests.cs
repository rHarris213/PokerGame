using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using System.Collections.Generic;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class FlushTieBreakTests
    {
        [Test]
        public void Flush_With_Highest_Card_Should_Win()
        {
            var handOne = HandBuilder.FlushSevenHigh();
            var handTwo = HandBuilder.FlushAceHighNineLow();

            var result = IdentifyBestFlush(handTwo, handOne);
            
            Assert.That(result.Equals(handTwo));
        }

        private Hand IdentifyBestFlush(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;
            var handSize = handOne.GetCards().Count;

            handOne.GetCards().Sort();
            handOne.GetCards().Reverse();

            handTwo.GetCards().Sort();
            handTwo.GetCards().Reverse();

            for (var i = 0; i < handSize; i ++)
            {
                if (handOne.GetCards()[i].GetCardValue() > handTwo.GetCards()[i].GetCardValue())
                {
                    bestHand = handOne;
                    break;
                }

                if (handTwo.GetCards()[i].GetCardValue() > handOne.GetCards()[i].GetCardValue())
                {
                    bestHand = handTwo;
                    break;
                }
            }
            return bestHand;
        }

        private Value DetermineHighCardValue(Hand hand)
        {
            var highCardValue = Value.Two;

            foreach (var card in hand.GetCards())
            {
                if (card.GetCardValue() > highCardValue)
                {
                    highCardValue = card.GetCardValue();
                }
            }

            return highCardValue;
        }
    }
}
