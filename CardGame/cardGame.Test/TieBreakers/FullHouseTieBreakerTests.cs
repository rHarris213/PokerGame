using System.Collections.Generic;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class FullHouseTieBreakerTests
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

        private static Hand GetFullHouseWinner(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            var handOneThreeOfAKindCardValue = GetThreeOfAKindCardValue(handOne);
            var handTwoThreeOfAKindCardValue = GetThreeOfAKindCardValue(handTwo);

            if (handOneThreeOfAKindCardValue > handTwoThreeOfAKindCardValue)
            {
                bestHand = handOne;
            }
            if (handTwoThreeOfAKindCardValue > handOneThreeOfAKindCardValue)
            {
                bestHand = handTwo;
            }

            if (bestHand != null) return bestHand;

            var handOnePairCardValue = GetPairCardValue(handOne);
            var handTwoPairCardValue = GetPairCardValue(handTwo);

            if (handOnePairCardValue > handTwoPairCardValue)
            {
                bestHand = handOne;
            }
            if (handTwoPairCardValue > handOnePairCardValue)
            {
                bestHand = handTwo;
            }

            return bestHand;

        }

        private static Value GetPairCardValue(Hand hand)
        {
            var pairCardValue = Value.Two;
            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = hand.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 2)
                {
                    pairCardValue = i;
                }
            }
            return pairCardValue;
        }

        private static Value GetThreeOfAKindCardValue(Hand handOne)
        {
            var handOneThreeOfAKindCardValue = Value.Two;

            for (var i = Value.Two; i <= Value.Ace; i++)
            {
                IEnumerable<Card> cardsOfSameValue = handOne.GetCards().Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    handOneThreeOfAKindCardValue = i;
                    
                }
            }
            return handOneThreeOfAKindCardValue;
        }
    }
}
