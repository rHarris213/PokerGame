using cardGame.Test.Builders;
using NUnit.Framework;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class StraightTieBreakerTests
    {
        [Test]
        public void Straight_With_Higher_Lead_Card_Should_Win()
        {
            var tieBreaker = new StraightTieBreaker();

            var handOne = HandBuilder.StraightJackHigh();
            var handTwo = HandBuilder.AceHighStraightWithoutFlush();

            var result = tieBreaker.DetermineStrongestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Straight_With_Low_Ace_Should_Not_Beat_Higher_Ranking_Straights()
        {
            var tieBreaker = new StraightTieBreaker();

            var handOne = HandBuilder.StraightAceLow();
            var handTwo = HandBuilder.StraightSixHigh();

            var result = tieBreaker.DetermineStrongestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Alike_Straights_Should_Result_In_Draw()
        {
            var tieBreaker = new StraightTieBreaker();

            var handOne = HandBuilder.StraightJackHigh();
            var handTwo = HandBuilder.StraightJackHigh();

            var result = tieBreaker.DetermineStrongestHand(handTwo, handOne);

            Assert.IsNull(result);
        }


       
    }
}
