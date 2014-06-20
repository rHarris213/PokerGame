using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class RoyalFlushAnalyserTest
    {

        [Test]
        public void Royal_Flush_Should_Only_Contain_Cards_From_The_Same_Suit()
        {
            // arrange

            
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.RoyalFlush());
            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Royal_Flush_Should_not_Contain_Cards_From_other_suits()
        {
            // arrange

            
            
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.AceHighStraightWithoutFlush());
            // assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Royal_Flush_Should_Contain_correct_sequence_of_cards()
        {
           
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.RoyalFlush());
            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Royal_Flush_Should_not_Contain_incorrect_sequence_of_cards()
        {
            // arrange
           
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.HighCardHand());
            // assert
            Assert.IsFalse(result);
        }
    }
}
