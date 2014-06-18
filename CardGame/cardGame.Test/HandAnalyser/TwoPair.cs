using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class TwoPair
    {
        [Test]
        public void Two_Pairs_Should_Have_Two_Sets_Of_Cards_With_Same_Value()
        {
            var twoPair = new List<Card>
            {
               
                new Card(1, 2),
                new Card(2, 3),
                new Card(2, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new TwoPairAnalyser(twoPair);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Two_Pairs_Should_Not_Include_Three_Of_A_Kind()
        {
            var twoPair = new List<Card>
            {
               
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new TwoPairAnalyser(twoPair);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }
    }
}
