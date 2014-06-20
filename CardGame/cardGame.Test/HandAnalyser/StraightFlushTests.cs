using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class StraightFlushTests
    {
        [Test]
        public void Straight_Flush_Should_Contain_Cards_Of_The_Same_Suit()
        {
            var analyser = new StraightFlushAnalyser();

            var result = analyser.IsHand(HandBuilder.StraightFlush());

            Assert.IsTrue(result);
        }

        [Test]
        public void Straight_Flush_Should_Not_Contain_Incorrect_Sequence_Of_Cards()
        {
            var analyser = new StraightFlushAnalyser();

            var result = analyser.IsHand(HandBuilder.HighCardHand());

            Assert.IsFalse(result);
        }

        [Test]
        public void Straight_Flush_Should_Contain_Correct_Sequence_Of_Cards()
        {
            

            var analyser = new StraightFlushAnalyser();

            var result = analyser.IsHand(HandBuilder.StraightFlush());

            Assert.IsTrue(result);


        }
        

        [Test]
        public void Straight_Flush_Should_Allow_Ace_To_Be_Low()
        {
            

            var analyser = new StraightFlushAnalyser();

            var result = analyser.IsHand(HandBuilder.StraightFlushWithAceLow());

            Assert.IsTrue(result);


        }
    }
}
