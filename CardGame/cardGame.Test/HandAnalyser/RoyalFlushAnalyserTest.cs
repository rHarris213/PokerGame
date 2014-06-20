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
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
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
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 2),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.HighCardHand());
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
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(8, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser();
            // act
            var result = analyser.IsHand(HandBuilder.HighCardHand());
            // assert
            Assert.IsFalse(result);
        }
    }
}
