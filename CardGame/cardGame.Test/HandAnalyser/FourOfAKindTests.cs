using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FourOfAKindTests
    {
        [Test]
        public void Four_Of_A_Kind_Should_Contain_Same_Card_Values()
        {
            var fourOfAKind = new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(9, 1)
            };

            var analyser = new FourOfAKindAnalyser(fourOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Four_Of_A_Kind_Should_Not_Be_Counted_When_Five_Of_A_Kind()
        {
            var fourOfAKind = new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(2, 1)
            };

            var analyser = new FourOfAKindAnalyser(fourOfAKind);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }
    }
}
