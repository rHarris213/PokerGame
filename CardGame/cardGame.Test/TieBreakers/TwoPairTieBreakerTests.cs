using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using CardGame.TieBreakers;



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
            

            var bestPairHand = MultiplesTieBreaker.DetermineStrongestHand(handOne, handTwo, 2);
            

            if (bestPairHand != null)
            {
                return bestPairHand;
            }

            return MultiplesTieBreaker.DetermineStrongestHand(handOne, handTwo, 1);
        }
    }
}
