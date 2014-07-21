using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using CardGame.TieBreakers;
using NUnit.Framework;
using cardGame.Test.TieBreakers;

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
            var repeatingCardsComparer = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = IdentifyHighestMultiples(repeatingCardsComparer);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Four_Of_A_Kind_Tie_Breaker_Does_Not_Assign_Winner_When_There_Is_Draw()
        {
            var handOne = HandBuilder.FourOfAKindSevens();
            var handTwo = HandBuilder.FourOfAKindSevens();
            var repeatingCardsComparer = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = IdentifyHighestMultiples(repeatingCardsComparer);

            Assert.IsNull(result);
        }

        [Test]
        public void Four_Of_A_Kind_Tie_Breaker_Can_Be_Won_With_High_Kicker()
        {
            var handOne = HandBuilder.FourOfAKindKingsLowKicker();
            var handTwo = HandBuilder.FourOfAKindKingsHighKicker();
            var repeatingCardsComparer = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = IdentifyHighestMultiples(repeatingCardsComparer);

            Assert.That(result.Equals(handTwo));
        }


        public Hand IdentifyHighestMultiples(GroupsOfCardsOfSameValueTieBreaker repeatingCardsComparer)
        {
            Hand bestHand = null;
            
            bestHand = repeatingCardsComparer.DetermineStrongestHand(4);
            if (bestHand != null)
            {
                return bestHand;
            }

            

            return repeatingCardsComparer.DetermineStrongestHand(1);
        }


    }
}


