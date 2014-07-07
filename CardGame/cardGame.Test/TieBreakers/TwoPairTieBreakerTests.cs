using System.Collections.Generic;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{   
    [TestFixture]
    class TwoPairTieBreakerTests
    {
        [Test]
        public void The_Highest_Pair_Should_Win()
        {
            var handOne = HandBuilder.TwoPairKingsOverTensThreeKicker();
            var handTwo = HandBuilder.TwoPairQueensOverJacksThreeKicker();

            var result = FindBestTwoPair(handOne, handTwo);

            Assert.That(result.Equals(handOne));
        }

        [Test]
        public void If_Highest_Pair_Same_Second_Pair_Should_Resolve_Draw()
        {
            var handOne = HandBuilder.TwoPairKingsOverNinesThreeKicker();
            var handTwo = HandBuilder.TwoPairKingsOverTensThreeKicker();

            var result = FindBestTwoPair(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void If_Both_Pairs_Draw_Kicker_Should_Resolve_Draw()
        {
            var handOne = HandBuilder.TwoPairSevensOverTwosFourKicker();
            var handTwo = HandBuilder.TwoPairSevensOverTwosThreeKicker();

            var result = FindBestTwoPair(handOne, handTwo);

            Assert.That(result.Equals(handOne));
        }

        [Test]
        public void If_Both_Hands_Draw_Null_Should_Be_Returned()
        {
            var handOne = HandBuilder.TwoPairSevensOverTwosFourKicker();
            var handTwo = HandBuilder.TwoPairSevensOverTwosFourKicker();

            var result = FindBestTwoPair(handOne, handTwo);

            Assert.IsNull(result);
        }

        private Hand FindBestTwoPair(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            
            for (var i = Value.Ace; i >= Value.Two; i--)
            {
                var handOnePair = handOne.GetCards().Count(obj => obj.GetCardValue() == i);
                var handTwoPair = handTwo.GetCards().Count(obj => obj.GetCardValue() == i);

                if (handOnePair == 2 && handTwoPair != 2)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoPair == 2 && handOnePair != 2)
                {
                    bestHand = handTwo;
                    break;
                }
            }

            if (bestHand != null)
            {
                return bestHand;
            }
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
