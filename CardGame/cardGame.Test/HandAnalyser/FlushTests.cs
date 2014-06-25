using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FlushTests
    {
        [Test]
        public void Flush_Should_Contain_A_Single_Suit()
        {
            
            var analyser = new FlushAnalyser();

            var result = analyser.IsHand(HandBuilder.FlushSevenHigh());

            Assert.IsTrue(result);


        }
    }
}
