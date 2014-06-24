using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using cardGame.Test.HandAnalyser;
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
            var playerOne = HandBuilder.StraightFlushWithAceLow();
            var playerTwo = HandBuilder.StraightFlushHigh();
            //act 

            var bestHand = StraightFlushTieBreak(playerOne, playerTwo);

            //assert
            Assert.That(bestHand.Equals(playerTwo));

        }

        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Identify_A_Exact_Draw()
        {

            var playerOne = HandBuilder.StraightFlushHigh();
            var playerTwo = HandBuilder.StraightFlushHigh();

            var bestHand = StraightFlushTieBreak(playerOne, playerTwo);
            
            Assert.IsNull(bestHand);
        }

        private Hand StraightFlushTieBreak(Hand playerOne, Hand playerTwo)
        {
            Hand bestHand = null;
           

            var playerOneHighCard = FindHighestCard(playerOne);
            var playerTwoHighCard = FindHighestCard(playerTwo);
       
            if (playerOneHighCard > playerTwoHighCard)
            {
                bestHand = playerOne;
            } else if (playerTwoHighCard > playerOneHighCard)
            {
                bestHand = playerTwo;
            }
          


            return bestHand;

           
        }

        private Value FindHighestCard(Hand hand)
        {

            var sortedHand = hand.GetCards().OrderByDescending(c => c.GetCardValue()).ToList();

            var highCardValue = sortedHand[0].GetCardValue();
            var secondHighestCardValue = sortedHand[1].GetCardValue();

            if (highCardValue == Value.Ace && secondHighestCardValue == Value.Five)
            {
                return Value.Five;
            }

            return highCardValue;
        }

       
    }
}
