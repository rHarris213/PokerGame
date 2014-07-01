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

        [Test] public void Full_Houses_With_Same_Cards_Should_Tie()
        {
            var handOne = HandBuilder.FullHouseThreeEightsPairOfFours();
            var handTwo = HandBuilder.FullHouseThreeEightsPairOfFours();

            var result = GetFullHouseWinner(handOne, handTwo);

            Assert.IsNull(result);
        }

        private static Hand GetFullHouseWinner(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;
            
            if (GetThreeOfAKindCardValue(handOne) > GetThreeOfAKindCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (GetThreeOfAKindCardValue(handTwo) > GetThreeOfAKindCardValue(handOne))
            {
                bestHand = handTwo;
            }

            if (bestHand != null) return bestHand;

            
            if ( GetPairCardValue(handOne) > GetPairCardValue(handTwo))
            {
                bestHand = handOne;
            }
            if (GetPairCardValue(handTwo) >  GetPairCardValue(handOne))
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
