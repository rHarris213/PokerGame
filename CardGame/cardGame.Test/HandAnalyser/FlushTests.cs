using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FlushTests
    {
        [Test]
        public void Flush_Should_Contain_A_Single_Suit()
        {
            var flush = new List<Card>
            {
                new Card(2, 1),
                new Card(4, 1),
                new Card(6, 1),
                new Card(8, 1),
                new Card(10, 1)
            };

            var analyser = new FlushAnalyser(flush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }
    }
}
