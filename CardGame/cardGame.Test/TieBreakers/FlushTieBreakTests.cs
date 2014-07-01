using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

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

        [Test]
        public void Flush_With_Same_Hand_Should_Draw()
        {
            var handOne = HandBuilder.FlushSevenHigh();
            var handTwo = HandBuilder.FlushSevenHigh();

            var result = IdentifyBestFlush(handTwo, handOne);

            Assert.IsNull(result);
        }

        [Test]
        public void Flush_With_High_Fifth_Kicker_Will_Beat_Same_Flush_With_Lower_Kicker()
        {
            var handOne = HandBuilder.FlushAceHighTwoLow();
            var handTwo = HandBuilder.FlushAceHighThreeLow();

            var result = IdentifyBestFlush(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        private Hand IdentifyBestFlush(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;
            var handSize = handOne.GetCards().Count;

            handOne.GetCards().Sort();
            handTwo.GetCards().Sort();
        

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

       
    }
}
