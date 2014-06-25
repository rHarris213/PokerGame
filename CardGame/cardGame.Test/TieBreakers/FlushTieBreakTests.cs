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

            var result = IdentifyBestFlush(handOne, handTwo);
            
            Assert.That(result.Equals(handTwo));
        }

        private Hand IdentifyBestFlush(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            var handOneHighCard = DetermineHighCardValue(handOne);
            var handTwoHighCard = DetermineHighCardValue(handTwo);

            if (handOneHighCard > handTwoHighCard)
            {
                bestHand = handOne;
            }
            if (handTwoHighCard > handOneHighCard)
            {
                bestHand = handTwo;
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
