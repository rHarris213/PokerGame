using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class OnePair
    {
        [Test]
        public void Pair_Should_Include_Two_Cards_Of_The_Same_Value()
        {
            var pair = new List<Card>
            {
               
                new Card(2, 2),
                new Card(2, 3),
                new Card(3, 2),
                new Card(4, 1),
                new Card(5, 1)
            };

            var analyser = new OnePairAnalyser(pair);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Pair_Should_Not_Include_Multiple_Sets_Of_Two_Cards_Of_The_Same_Value()
        {
            var pair = new List<Card>
            {
               
                new Card(2, 2),
                new Card(2, 3),
                new Card(3, 2),
                new Card(3, 1),
                new Card(5, 1)
            };

            var analyser = new OnePairAnalyser(pair);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Pair_Should_Not_Include_Three_Of_A_Kind_As_Pair()
        {
            var onePair = new List<Card>
            {
               
                new Card(2, 2),
                new Card(3, 3),
                new Card(3, 2),
                new Card(3, 1),
                new Card(5, 1)
            };

            var analyser = new OnePairAnalyser(onePair);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }
    }
}
