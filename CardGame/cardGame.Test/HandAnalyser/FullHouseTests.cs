using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FullHouseTests
    {
        [Test]
        public void Full_House_Should_Be_Identified_In_larger_lists_than_5()
        {
            var fullHouse = new List<Card>
            {
                new Card(1, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new FullHouseAnalyser(fullHouse);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }
    }
}
