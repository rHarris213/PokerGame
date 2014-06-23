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
    class StraightFlushTieTests
    {
        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Identify_Higher_Value_Straight_Flush()
        {
            //arrange

            var playerOne = HandBuilder.StraightFlushLow();
            var playerTwo = HandBuilder.StraightFlushHigh();
            //act 

            var bestHand = StraightFlushTieBreak(playerOne, playerTwo);

            //assert
            Assert.That(bestHand.Equals(playerTwo));

        }

        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Not_Consider_Ace_Low_Straight_As_High()
        {

        }

        private Hand StraightFlushTieBreak(Hand playerOne, Hand playerTwo)
        {
            Hand bestHand = null;
           

            var playerOneHighCard = playerOne.GetCards()[0].GetCardValue();
            var playerOneSecondHighCard = playerOne.GetCards()[0].GetCardValue();

            var playerTwoHighCard = playerTwo.GetCards()[0].GetCardValue();
            var playerTwoSecondHighCard = playerTwo.GetCards()[0].GetCardValue();

            if (playerOneHighCard == Value.Ace && playerOneSecondHighCard == Value.Five)
            {
                playerOneHighCard = Value.Five;
            }

            if (playerTwoHighCard == Value.Ace && playerTwoSecondHighCard == Value.Five)
            {
                playerTwoHighCard = Value.Five;
            }

            if (playerOneHighCard > playerTwoHighCard)
            {
                bestHand = playerOne;
            } else if (playerTwoHighCard > playerOneHighCard)
            {
                bestHand = playerTwo;
            }
            else
            {
                bestHand = null;
            }

            return bestHand;

            return bestHand;
        }

    }
}
