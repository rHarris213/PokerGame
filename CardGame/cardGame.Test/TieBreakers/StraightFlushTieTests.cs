using cardGame.Test.Builders;
using NUnit.Framework;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class StraightFlushTieTests
    {
        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Identify_Higher_Value_Straight_Flush()
        {

            var tieBreaker = new StraightFlushTieBreaker();
            //arrange

            var playerOne = HandBuilder.StraightFlushLow();
            var playerTwo = HandBuilder.StraightFlushHigh();
            //act 

            var bestHand = tieBreaker.DetermineStrongestHand(playerOne, playerTwo);
            //assert
            Assert.That(bestHand.Equals(playerTwo));

        }

        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Not_Consider_Ace_Low_Straight_As_High()
        {
            var tieBreaker = new StraightFlushTieBreaker();

            var playerOne = HandBuilder.StraightFlushWithAceLow();
            var playerTwo = HandBuilder.StraightFlushHigh();
            //act 

            var bestHand = tieBreaker.DetermineStrongestHand(playerOne, playerTwo);

            //assert
            Assert.That(bestHand.Equals(playerTwo));

        }

        [Test]
        public void Straight_Flush_Tie_Breaker_Should_Identify_A_Exact_Draw()
        {
            var tieBreaker = new StraightFlushTieBreaker();

            var playerOne = HandBuilder.StraightFlushHigh();
            var playerTwo = HandBuilder.StraightFlushHigh();

            var bestHand = tieBreaker.DetermineStrongestHand(playerOne, playerTwo);
            
            Assert.IsNull(bestHand);
        }

       

       
    }
}
