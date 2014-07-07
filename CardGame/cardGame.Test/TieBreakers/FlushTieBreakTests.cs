using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class FlushTieBreakTests
    {
        [Test]
        public void Flush_With_Highest_Card_Should_Win()
        {
            var tieBreaker = new FlushTieBreaker();

            var handOne = HandBuilder.FlushSevenHigh();
            var handTwo = HandBuilder.FlushAceHighNineLow();

            var result = tieBreaker.DetermineStrongestHand(handTwo, handOne);
            
            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Flush_With_Same_Hand_Should_Draw()
        {
            var tieBreaker = new FlushTieBreaker();

            var handOne = HandBuilder.FlushSevenHigh();
            var handTwo = HandBuilder.FlushSevenHigh();

            var result = tieBreaker.DetermineStrongestHand(handTwo, handOne);

            Assert.IsNull(result);
        }

        [Test]
        public void Flush_With_High_Fifth_Kicker_Will_Beat_Same_Flush_With_Lower_Kicker()
        {
            var tieBreaker = new FlushTieBreaker();

            var handOne = HandBuilder.FlushAceHighTwoLow();
            var handTwo = HandBuilder.FlushAceHighThreeLow();

            var result = tieBreaker.DetermineStrongestHand(handOne, handTwo);

            Assert.That(result.Equals(handTwo));
        }



        

       
    }
}
