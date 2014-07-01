using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class StraightTests
    {
        private StraightAnalyser _analyser;

        [Test]
        public void Straight_Should_Contain_Correct_Sequence_Of_Cards()
        {
            

            _analyser = new StraightAnalyser(new FlushAnalyser());

            var result = _analyser.IsHand(HandBuilder.StraightJackHigh());

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Should_Not_Contain_Incorrect_Sequence_Of_Cards()
        {
            var analyser = new StraightAnalyser(new FlushAnalyser());

            var result = analyser.IsHand(HandBuilder.HighCardHand());

            Assert.IsFalse(result);
        }

        [Test]
        public void Straight_Should_Not_Be_A_Straight_Flush()
        {
            var analyser = new StraightAnalyser(new FlushAnalyser());

            var result = analyser.IsHand(HandBuilder.StraightFlushLow());

            Assert.IsFalse(result);
        }
    }
}
