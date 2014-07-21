using System.Collections.Generic;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using cardGame.Test.TieBreakers;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    internal class FullHouseTieBreakerTests
    {
        [Test]
        public void Full_House_With_Higher_Three_Of_A_Kind_Should_Win()
        {
            var handOne = HandBuilder.FullHouseThreeFours();
            var handTwo = HandBuilder.FullHouseThreeAces();

            var result = GetFullHouseWinner(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Full_House_With_Same_Three_Of_A_Kind_Higher_Pair_Should_Win()
        {
            var handOne = HandBuilder.FullHouseThreeEightsPairOfFours();
            var handTwo = HandBuilder.FullHouseThreeEightsPairOfKings();

            var result = GetFullHouseWinner(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Full_Houses_With_Same_Cards_Should_Tie()
        {
            var handOne = HandBuilder.FullHouseThreeEightsPairOfFours();
            var handTwo = HandBuilder.FullHouseThreeEightsPairOfFours();

            var result = GetFullHouseWinner(handOne, handTwo);

            Assert.IsNull(result);
        }

        private static Hand GetFullHouseWinner(Hand handOne, Hand handTwo)
        {

            var strongerRepeatingCards = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);

            var highestThreeOfAKindHand = strongerRepeatingCards.DetermineStrongestHand(3);

            if (highestThreeOfAKindHand != null)
                return highestThreeOfAKindHand;

            var highestPairHand = strongerRepeatingCards.DetermineStrongestHand(2);
            return highestPairHand;


        }

    }
}
