using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class ThreeOfAKindTests
    {
        [Test]
        public void Three_Of_A_Kind_Should_Have_Three_Cards_Of_The_Same_Value()
        {
            var threeOfAKind = new List<Card>
            {
               
                new Card(1, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Work_With_More_Than_Five_Cards()
        {
            var threeOfAKind = new List<Card>
            {
                new Card(1, 2),
                new Card(2, 3),
                new Card(4, 2),
                new Card(5, 1),
                new Card(7, 2),
                new Card(8, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Work_With_Less_Than_Five_Cards()
        {
            var threeOfAKind = new List<Card>
            {
              
                new Card(8, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Not_Trigger_Work_With_More_Than_Three_Cards_Alike()
        {
            var threeOfAKind = new List<Card>
            {
                new Card(8, 3),
                new Card(9, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }
    }
}
