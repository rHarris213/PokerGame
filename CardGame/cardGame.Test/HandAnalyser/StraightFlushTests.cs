using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class StraightFlushTests
    {
        [Test]
        public void Straight_Flush_Should_Contain_Cards_Of_The_Same_Suit()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Flush_Should_Not_Contain_Cards_Of_The_Same_Suit()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 2),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Straight_Flush_Should_Contain_Correct_Sequence_Of_Cards()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Flush_Should_Not_Contain_Inorrect_Sequence_Of_Cards()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(9, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Straight_Flush_Should_Allow_Ace_To_Be_Low()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(14, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }
    }
}
