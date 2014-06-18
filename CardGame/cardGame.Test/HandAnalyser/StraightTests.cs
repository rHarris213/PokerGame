using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class StraightTests
    {

        [Test]
        public void Straight_Should_Contain_Correct_Sequence_Of_Cards()
        {
            var straight = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightAnalyser(straight);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }
    }
}
