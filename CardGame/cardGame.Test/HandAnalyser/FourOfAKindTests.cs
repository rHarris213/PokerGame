using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FourOfAKindTests
    {
        [Test]
        public void Four_Of_A_Kind_Should_Contain_Same_Card_Values()
        {
           
            var analyser = new FourOfAKindAnalyser();

            var result = analyser.IsHand(HandBuilder.FourOfAKindSevens());

            Assert.IsTrue(result);


        }

        [Test]
        public void Four_Of_A_Kind_Should_Not_Be_Counted_When_Five_Of_A_Kind()
        {
           
            var analyser = new FourOfAKindAnalyser();

            var result = analyser.IsHand(HandBuilder.FiveOfAKind());

            Assert.IsFalse(result);


        }
    }
}
