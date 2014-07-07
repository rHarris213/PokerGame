using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class HighCardTieBreaker
    {
        [Test]
        public void Highest_Card_Should_Determine_Winner()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardNine();

            var result = FindBestHighCardHand(handOne, handTwo);

            Assert.That(result.Equals(handOne));
        }

        [Test]
        public void Same_Hand_Should_Result_In_Draw()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardAce();

            var result = FindBestHighCardHand(handOne, handTwo);

            Assert.IsNull(result);
        }

        private Hand FindBestHighCardHand(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

           for (var i = Value.Ace; i >= Value.Two; i --)
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
    }
}
