using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class StraightTests
    {

        [Test]
        public void Straight_Should_Contain_Correct_Sequence_Of_Cards()
        {
            

            var analyser = new StraightAnalyser();

            var result = analyser.IsHand(HandBuilder.Straight());

            Assert.IsTrue(result);


        }
    }
}
