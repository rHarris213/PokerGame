using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void If_Both_Pairs_Same_Kicker_Should_Resolve_Draw()
        {
            var handOne = HandBuilder.TwoPairKingsOverNinesThreeKicker();
            var handTwo = HandBuilder.TwoPairKingsOverTensThreeKicker();

            var result = FindBestTwoPair(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        private Hand FindBestTwoPair(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            
            for (var i = Value.Ace; i >= Value.Two; i--)
            {
                IEnumerable<Card> handOneCardsOfValue = handOne.GetCards().Where(obj => obj.GetCardValue() == i);
                IEnumerable<Card> handTwoCardsOfValue = handTwo.GetCards().Where(obj => obj.GetCardValue() == i);

                if (handOneCardsOfValue.Count() == 2 && handTwoCardsOfValue.Count() != 2)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoCardsOfValue.Count() == 2 && handOneCardsOfValue.Count() != 2)
                {
                    bestHand = handTwo;
                    break;
                }


            }
            return bestHand;
        }
    }
}
