using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FullHouseTests
    {
        [Test]
        public void Full_House_Should_Be_Identified_In_larger_lists_than_5()
        {
            

            var analyser = new FullHouseAnalyser();

            var result = analyser.IsHand(HandBuilder.FullHouse());

            Assert.IsTrue(result);


        }
    }
}
